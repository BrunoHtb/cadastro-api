using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TesteAPI.Models;
using TesteAPI.Global;

namespace TesteAPI.Controller
{
    public class PessoasPostGrupo
    {
        string[] jsonFiles;

        public PessoasPostGrupo(string[] jsonFiles)
        {
            this.jsonFiles = jsonFiles;
        }

        public void PercorrerMultiLineJSON()
        {
            foreach (string filePath in jsonFiles)
            {
                Console.WriteLine("Lendo arquivo: " + filePath);

                DeserializarPessoasJSON(filePath);  
            }
        }

        public void DeserializarPessoasJSON(string filePath)
        {
            try
            {
                string jsonContent = System.IO.File.ReadAllText(filePath);

                // Desserializar o JSON em uma lista de objetos
                List<PessoasPost> objetos = JsonConvert.DeserializeObject<List<PessoasPost>>(jsonContent);
                PessoasMultiPOST(objetos);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao ler o arquivo JSON: " + ex.Message);
            }
        }

        async Task PessoasMultiPOST(List<PessoasPost> objetos)
        {
            string apiUrl = "https://tributos.suite.betha.cloud/geoprocessamento/v1/pessoas"; // Substitua pela URL da sua API

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalStatic.bearerToken);
                client.DefaultRequestHeaders.Add("User-Access", GlobalStatic.userAccess);

                foreach (var objeto in objetos)
                {
                    string objetoJson = JsonConvert.SerializeObject(objeto);
                    StringContent content = new StringContent(objetoJson, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                    }
                }
            }
        }
    }
}
