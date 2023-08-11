using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAPI.Models
{
    public class PessoasPost
    {
        public string tipoPessoa { get; set; }
        public string nome { get; set; }
        public string cpfCnpj { get; set; }
        public string situacao { get; set; }
        public Endereco enderecos { get; set; }
    }

    public class Endereco
    {
        public string principal { get; set; }
        public string descricao { get; set; }
        public string complemento { get; set; }
        public string numero { get; set; }
        public string cep { get; set; }
        public Logradouro logradouro { get; set; }
        public Bairro bairro { get; set; }
        public Municipio municipio { get; set; }
    }

    public class Logradouro
    {
        public int idVinculado { get; set; }
        public string tipoLogradouro { get; set; }
        public string nome { get; set; }
        public Municipio municipio { get; set; }
    }

    public class Municipio
    {
        public int idVinculado { get; set; }
        public string nome { get; set; }
        public string uf { get; set; }
    }

    public class Bairro
    {
        public int idVinculado { get; set; }
        public string nome { get; set; }
    }

}
