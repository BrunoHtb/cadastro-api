using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TesteAPI.Global;
using TesteAPI.Models;

namespace TesteAPI.Controller
{
    public class ImoveisGetIndividual
    {
        public ImoveisGetIndividual()
        {
        }
        public void GetPessoa()
        {
            PessoasGet();
        }

        async Task PessoasGet()
        {
            string apiUrl = "https://tributos.suite.betha.cloud/dados/v1/imoveis?filter=inscricaoImobiliaria='9999.063064000.000.0'";
            // Configura o cabeçalho da autorização (Bearer Token)

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalStatic.bearerToken);
                client.DefaultRequestHeaders.Add("User-Access", GlobalStatic.userAccess);
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        JObject responseObject = JObject.Parse(responseBody);

                        JArray imoveis = (JArray)responseObject["content"];

                        foreach (var imovel in imoveis)
                        {
                            JObject faceObject = (JObject)imovel["face"];
                            if (faceObject != null)
                            {
                                int id = (int)faceObject["id"];
                                string abreviatura = (string)faceObject["abreviatura"];
                                string descricao = (string)faceObject["descricao"];

                                Console.WriteLine("ID: " + id);
                                Console.WriteLine("Abreviatura: " + abreviatura);
                                Console.WriteLine("Descrição: " + descricao);

                                Console.WriteLine();
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Erro na requisição. Status code: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro na requisição: " + ex.Message);
                }
            }
        
        }
    }
}
