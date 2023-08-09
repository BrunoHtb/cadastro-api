using Newtonsoft.Json.Linq;
using System.Drawing;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace TesteAPI
{
    public partial class Form1 : Form
    {
        string[] jsonFiles;
        int cont = 1;
        bool pessoa = false;
        bool bairro = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_getPessoas_Click(object sender, EventArgs e)
        {
            pessoa = true;
            
            DiretorioJSON();
            PercorrerJSON();
        }
        public void DiretorioJSON()
        {
            // Diret�rio onde os arquivos JSON est�o localizados
            string directoryPath = "D:\\_TESTE\\";

            // Lista todos os arquivos JSON no diret�rio
            jsonFiles = Directory.GetFiles(directoryPath, "*.json");
        }

        public async void PercorrerJSON()
        {
            foreach (string filePath in jsonFiles)
            {
                Console.WriteLine("Lendo arquivo: " + filePath);

                // L� o conte�do do arquivo JSON
                string jsonContent = System.IO.File.ReadAllText(filePath);

                // Faz o parse do JSON
                JObject jsonObj = JObject.Parse(jsonContent);

                if (pessoa)
                {
                    string cpfCnpj = jsonObj["cpfCnpj"].ToString();
                    await PessoasGet(cpfCnpj);
                }
                if(bairro)
                {
                    string bairro = jsonObj["enderecos"]["bairro"]["nome"].ToString();
                    await BairrosGet(bairro);
                }      
            }
            bairro = false;
            pessoa = false;
        }

        public string LerPessoasCPFJSON(JObject jsonObj)
        {
            return jsonObj["cpfCnpj"].ToString();
        }
        public string LerBairrosNomesJSON(JObject jsonObj)
        {
            return jsonObj["bairro"]["nome"].ToString();
        }

        async Task PessoasGet(string cpfCNPJ)
        {
            // URL da API
            string apiUrl = "https://tributos.suite.betha.cloud/dados/v1/contribuintes";

            // Token de acesso
            string bearerToken = "de9ab3c8-ca63-4307-aaf5-81227f29463b";
            // User-Access
            string userAccess = "QGNC5TIDmNDdFDlWfrfl20TcngLevEmE1z53k9Gom-k=";

            string filterPessoasAPI = $"?filter=cpfCnpj='{cpfCNPJ}'";

            string apiUrlFilter = apiUrl + filterPessoasAPI;

            // Cria��o do cliente HTTP
            using (HttpClient client = new HttpClient())
            {
                // Configura o cabe�alho da autoriza��o (Bearer Token)
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
                client.DefaultRequestHeaders.Add("User-Access", userAccess);

                // Realiza a solicita��o GET
                HttpResponseMessage response = await client.GetAsync(apiUrlFilter);

                // Verifica se a solicita��o foi bem-sucedida (c�digo de status 200)
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Caminho do arquivo onde voc� deseja salvar os dados JSON
                    string filePath = $"D:\\_TESTE\\OK_Pessoas\\dados{cont.ToString()}.json";

                    // Divide o conte�do do responseBody em linhas
                    string[] lines = responseBody.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                    // Salva cada linha em um arquivo (uma linha para cada elemento do JSON)
                    System.IO.File.WriteAllLines(filePath, lines);
                    cont++;
                    Console.WriteLine("Dados salvos em " + filePath);
                }
                else
                {
                    Console.WriteLine("Erro ao fazer a solicita��o GET. C�digo de status: " + response.StatusCode);
                }
            }
        }

        private void btn_getBairros_Click(object sender, EventArgs e)
        {
            bairro = true;
            DiretorioJSON();
            PercorrerJSON();
        }

        async Task BairrosGet(string nomeBairro)
        {
            // URL da API
            string apiUrl = "https://tributos.suite.betha.cloud/dados/v1/bairros";

            // Token de acesso
            string bearerToken = "de9ab3c8-ca63-4307-aaf5-81227f29463b";
            // User-Access
            string userAccess = "QGNC5TIDmNDdFDlWfrfl20TcngLevEmE1z53k9Gom-k=";

            string filterPessoasAPI = $"?filter=nome=\"{nomeBairro}\"";

            string apiUrlFilter = apiUrl + filterPessoasAPI;

            // Cria��o do cliente HTTP
            using (HttpClient client = new HttpClient())
            {
                // Configura o cabe�alho da autoriza��o (Bearer Token)
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
                client.DefaultRequestHeaders.Add("User-Access", userAccess);

                // Realiza a solicita��o GET
                HttpResponseMessage response = await client.GetAsync(apiUrlFilter);

                // Verifica se a solicita��o foi bem-sucedida (c�digo de status 200)
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Caminho do arquivo onde voc� deseja salvar os dados JSON
                    string filePath = $"D:\\_TESTE\\OK_Bairros\\dados{cont.ToString()}.json";

                    // Divide o conte�do do responseBody em linhas
                    string[] lines = responseBody.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                    // Salva cada linha em um arquivo (uma linha para cada elemento do JSON)
                    System.IO.File.WriteAllLines(filePath, lines);
                    cont++;
                    Console.WriteLine("Dados salvos em " + filePath);
                }
                else
                {
                    Console.WriteLine("Erro ao fazer a solicita��o GET. C�digo de status: " + response.StatusCode);
                }
            }
        }
    }
}