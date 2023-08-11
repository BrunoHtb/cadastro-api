using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TesteAPI.Models
{
    public class Imoveis
    {
        public int unidade { get; set; }
        public string inscricaoImobiliaria { get; set; }
        public string tipoImovel { get; set; }
        public string enderecoCorrespondencia { get; set; }
        public string apartamento { get; set; }
        public string bloco { get; set; }
        public string cep { get; set; }
        public string complemento { get; set; }
        public string lote { get; set; }
        public string matricula { get; set; }
        public string numero { get; set; }
        public string quadra { get; set; }
        public string setor { get; set; }
        public string situacao { get; set; }
        public string usarEnderecoCondominio { get; set; }
        public Agrupamento agrupamento { get; set; }
        public Face face { get; set; }
        public Proprietario proprietario { get; set; }
        public List<Responsaveis> responsaveis { get; set; }
        public BairrosImoveis bairro { get; set; }
        public Logradouro logradouro { get; set; }
        public string anoCamposAdicionais { get; set; }
        public List<CampoAdicional> camposAdicionais { get; set; }
    }

    public class Agrupamento
    {
        public string descricao { get; set; }
    }

    public class Face
    {
        public string abreviatura { get; set; }
        public string descricao { get; set; }
    }

    public class Proprietario
    {
        public int idVinculado { get; set; }
        public string nome { get; set; }
        public string cpfCnpj { get; set; }
    }

    public class Responsaveis
    {
        public Pessoa pessoa { get; set; }
        public int percentual { get; set; }
    }
    public class Pessoa
    {
        public int idVinculado { get; set; }
        public string nome { get; set; }
        public string cpfCnpj { get; set; }
    }
    public class BairrosImoveis
    {
        public string nome { get; set; }
    }

    public class CampoAdicional
    {
        public CampoAdicionalInfo campoAdicional { get; set; }
        public double? vlCampo { get; set; }
        public List<Opcao> opcoes { get; set; }
    }

    public class CampoAdicionalInfo
    {
        public string titulo { get; set; }
        public string tipo { get; set; }
    }

    public class Opcao
    {
        public string titulo { get; set; }
        public string tipo { get; set; }
    }

}
