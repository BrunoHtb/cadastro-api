using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TesteAPI.Global;

namespace TesteAPI.Controller
{
    public class PessoaGetIndividual
    {
        string[] jsonFiles;
        int cont = 0;
        public PessoaGetIndividual(string[] jsonFiles)
        {
            this.jsonFiles = jsonFiles;
        }

        public string LerPessoasCPFJSON(JObject jsonObj)
        {
            return jsonObj["cpfCnpj"].ToString();
        }

        public async void PercorrerJSON()
        {
            foreach (string filePath in jsonFiles)
            {
                Console.WriteLine("Lendo arquivo: " + filePath);

                string jsonContent = System.IO.File.ReadAllText(filePath);

                JObject jsonObj = JObject.Parse(jsonContent);


                string cpfCnpj = LerPessoasCPFJSON(jsonObj);
                await PessoasGet(cpfCnpj);

            }

            async Task PessoasGet(string cpfCNPJ)
            {
                // URL da API
                string apiUrl = "https://tributos.suite.betha.cloud/dados/v1/contribuintes";


                string filterPessoasAPI = $"?filter=cpfCnpj='{cpfCNPJ}'";

                string apiUrlFilter = apiUrl + filterPessoasAPI;

                // Criação do cliente HTTP
                using (HttpClient client = new HttpClient())
                {
                    // Configura o cabeçalho da autorização (Bearer Token)
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalStatic.bearerToken) ;
                    client.DefaultRequestHeaders.Add("User-Access", GlobalStatic.userAccess);

                    // Realiza a solicitação GET
                    HttpResponseMessage response = await client.GetAsync(apiUrlFilter);

                    // Verifica se a solicitação foi bem-sucedida (código de status 200)
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        // Caminho do arquivo onde você deseja salvar os dados JSON
                        string filePath = $"D:\\_Projetos_Importantes\\_API_CADASTRO_JUIZ_DE_FORA\\_Teste\\__TESTE_MANUAL_DAVI\\update\\IP\\dados{cont.ToString()}.json";
                        cont++;
                        // Divide o conteúdo do responseBody em linhas
                        string[] lines = responseBody.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                        // Salva cada linha em um arquivo (uma linha para cada elemento do JSON)
                        System.IO.File.WriteAllLines(filePath, lines);

                        Console.WriteLine("Dados salvos em " + filePath);
                    }
                    else
                    {
                        Console.WriteLine("Erro ao fazer a solicitação GET. Código de status: " + response.StatusCode);
                    }
                }
            }
        }
    }
}
