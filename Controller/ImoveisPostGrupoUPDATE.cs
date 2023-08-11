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
    public class ImoveisPostGrupoUPDATE
    {
        string[] jsonFiles;

        public ImoveisPostGrupoUPDATE(string[] jsonFiles)
        {
            this.jsonFiles = jsonFiles;
        }
        public void PercorrerMultiLineJSON()
        {
            foreach (string filePath in jsonFiles)
            {
                Console.WriteLine("Lendo arquivo: " + filePath);
 
                DeserializarImoveisUpdatesJSON(filePath);
            }
        }
        public void DeserializarImoveisUpdatesJSON(string filePath)
        {
            try
            {
                string jsonContent = System.IO.File.ReadAllText(filePath);

                // Desserializar o JSON em uma lista de objetos
                List<ImoveisUpdate> objetos = JsonConvert.DeserializeObject<List<ImoveisUpdate>>(jsonContent);
                ImoveisMultiUpdatePOST(objetos);
                Console.WriteLine("Funcionou!!!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao ler o arquivo JSON: " + ex.Message);
            }
        }
        async Task ImoveisMultiUpdatePOST(List<ImoveisUpdate> objetos)
        {
            string apiUrl = "https://tributos.suite.betha.cloud/geoprocessamento/v1/imoveis"; // Substitua pela URL da sua API

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
                        Console.WriteLine("POST bem-sucedido para NOME: " + objeto.inscricaoImobiliaria);
                        string responseBody = await response.Content.ReadAsStringAsync();
                        Console.WriteLine("Resposta da API: " + responseBody);
                    }
                    else
                    {
                        //Console.WriteLine("Erro no POST para ID: " + objeto.Id + ". Status code: " + response.StatusCode);
                    }
                }
            }
        }
    }
}
