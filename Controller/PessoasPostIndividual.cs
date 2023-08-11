using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TesteAPI.Global;

namespace TesteAPI.Controller
{
    public class PessoasPostIndividual
    {
        string[] jsonFiles;
        int cont = 0;

        public PessoasPostIndividual(string[] jsonFiles)
        {
            this.jsonFiles = jsonFiles;
        }

        public async void PercorrerJSON()
        {
            foreach (string filePath in jsonFiles)
            {
                Console.WriteLine("Lendo arquivo: " + filePath);

                string jsonContent = System.IO.File.ReadAllText(filePath);

                JObject jsonObj = JObject.Parse(jsonContent);
                PessoasPOST(filePath);               
            }
        }

        async Task PessoasPOST(string filePath)
        {
            string apiUrl = "https://tributos.suite.betha.cloud/geoprocessamento/v1/pessoas"; // Substitua pela URL da sua API

            using (HttpClient client = new HttpClient())
            {
                // Configurar o cabeçalho de autenticação
                // Configura o cabeçalho da autorização (Bearer Token)
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalStatic.bearerToken);
                client.DefaultRequestHeaders.Add("User-Access", GlobalStatic.userAccess);

                // Ler o conteúdo do arquivo JSON
                string jsonContent = System.IO.File.ReadAllText(filePath);

                // Configurar o conteúdo da solicitação
                StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                // Enviar a solicitação POST
                HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                // Verificar a resposta da API
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("POST bem-sucedido!");
                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine("Resposta da API: " + responseBody);
                }
                else
                {
                    Console.WriteLine("Erro no POST. Status code: " + response.StatusCode);
                }
            }
        }
    }
}
