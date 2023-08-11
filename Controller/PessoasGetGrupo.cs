using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using TesteAPI.Global;
using TesteAPI.Models;

namespace TesteAPI.Controller
{
    public class PessoasGetGrupo
    {
        string[] jsonFiles;

        public PessoasGetGrupo(string[] jsonFiles)
        {
            this.jsonFiles = jsonFiles;
        }
        /*
        public void LerArquivoJSON()
        {
            foreach (string filePath in jsonFiles)
            {
                string jsonContent = File.ReadAllText(filePath);


                DeserializarPessoasJSON(jsonContent);
            }

        }
        public void DeserializarPessoasJSON(string jsonContent)
        {
            List<PessoasJSON> registros = JsonConvert.DeserializeObject<List<PessoasJSON>>(jsonContent);
            PessoasGet(registros);
        }

        
        async Task PessoasGet(List<PessoasJSON> registros)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Configura o cabeçalho da autorização (Bearer Token)
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GlobalStatic.bearerToken);
                    client.DefaultRequestHeaders.Add("User-Access", GlobalStatic.userAccess);

                    foreach (var registro in registros)
                    {
                        string cpf = registro.proprietario.cpfCnpj; // Pega o valor do cpfCnpj do registro

                        string filterPessoasAPI = $"?filter=cpfCnpj=\"{cpf}\"";
                        string apiUrl = "https://tributos.suite.betha.cloud/dados/v1/contribuintes" + filterPessoasAPI; // Substitua pela URL da sua API de consulta

                        HttpResponseMessage response = await client.GetAsync(apiUrl);

                        if (response.IsSuccessStatusCode)
                        {
                            var resultadoAPI = JsonConvert.DeserializeObject<PessoaGet>(responseBody);

                            if (resultadoAPI != null)
                            {
                                // Pega o ID retornado pela API
                                int idRetornado = resultadoAPI.id;

                                // Substitui o valor de idVinculado pelo ID retornado
                                //registro.idVinculado = idRetornado;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Erro na consulta à API para cpfCnpj: {cpf}. Status code: {response.StatusCode}");
                        }
                    }

                    // Após o loop, você pode serializar novamente a lista de registros para um novo JSON
                    string novoJson = JsonConvert.SerializeObject(registros, Formatting.Indented);
                    File.WriteAllText("novo_arquivo.json", novoJson); // Substitua pelo caminho onde deseja salvar o novo JSON
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao ler o arquivo JSON: " + ex.Message);
            }
        }
        */
    }
}
