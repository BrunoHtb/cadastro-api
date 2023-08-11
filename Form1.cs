using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using TesteAPI.Controller;
using TesteAPI.Models;
using static System.Net.WebRequestMethods;

namespace TesteAPI
{
    public partial class Form1 : Form
    {
        string[] jsonFiles;
        int cont = 1;
        bool pessoaGET = false;
        bool bairroGET = false;
        bool pessoaPOST = false;
        bool pessoaPOSTMulti = false;
        bool imoveisPOSTMultiNOVO = false;
        bool imoveisPOSTMultiUPDATE = false;
        bool pessoaGetTripa = false;

        // Token de acesso
        public string bearerToken = "de9ab3c8-ca63-4307-aaf5-81227f29463b";
        // User-Access
        public string userAccess = "QGNC5TIDmNDdFDlWfrfl20TcngLevEmE1z53k9Gom-k=";

        public Form1()
        {
            InitializeComponent();
        }



        public void DiretorioJSON()
        {
            string directoryPath = "D:\\_Projetos_Importantes\\_API_CADASTRO_JUIZ_DE_FORA\\_Teste\\__TESTE_MANUAL_DAVI\\update\\";

            jsonFiles = Directory.GetFiles(directoryPath, "*.json");
        }


        //GET PESSOAS TRIPA

        private void btn_getPessoasTripaCPF_Click(object sender, EventArgs e)
        {
            DiretorioJSON();
            PessoasGetGrupo pessoasGetGrupo = new PessoasGetGrupo(jsonFiles);
            //pessoasGetGrupo.LerArquivoJSON();
            //PercorrerMultiLineJSON();
        }


        #region GET INDIVIDUAL
        private void btn_getBairros_Click(object sender, EventArgs e)
        {
            DiretorioJSON();
            BairrosGetIndividual bairrosGetIndividual = new BairrosGetIndividual(jsonFiles);
            bairrosGetIndividual.PercorrerJSON();
        }

        private void btn_getPessoas_Click_1(object sender, EventArgs e)
        {
            DiretorioJSON();
            PessoaGetIndividual getPessoaIndividual = new PessoaGetIndividual(jsonFiles);
            getPessoaIndividual.PercorrerJSON();
        }
        #endregion

        #region POST INDIVIDUAL
        private void btn_postPessoas_Click(object sender, EventArgs e)
        {
            DiretorioJSON();
            PessoasPostIndividual pessoaPost = new PessoasPostIndividual(jsonFiles);
            pessoaPost.PercorrerJSON();
        }
        #endregion

        #region POST GRUPO
        private void btn_postPessoasMultiElemento_Click(object sender, EventArgs e)
        {
            DiretorioJSON();
            PessoasPostGrupo pessoasPostGrupo = new PessoasPostGrupo(jsonFiles);
            pessoasPostGrupo.PercorrerMultiLineJSON();
        }

        private void btn_postImoveisMultiElemento_Click(object sender, EventArgs e)
        {
            DiretorioJSON();
            ImoveisPostGrupoNOVO imoveisPostGrupoNovo = new ImoveisPostGrupoNOVO(jsonFiles);
            imoveisPostGrupoNovo.PercorrerMultiLineJSON();
        }

        private void btn_postImoveisMultiElementoUPDATE_Click(object sender, EventArgs e)
        {
            DiretorioJSON();
            ImoveisPostGrupoUPDATE imoveisPostGrupoUpdate = new ImoveisPostGrupoUPDATE(jsonFiles);
            imoveisPostGrupoUpdate.PercorrerMultiLineJSON();
        }
        #endregion

        private void btn_getImoveisIndividual_Click(object sender, EventArgs e)
        {
            ImoveisGetIndividual imoveisGetIndividual = new ImoveisGetIndividual();
            imoveisGetIndividual.GetPessoa();
        }
    }
}