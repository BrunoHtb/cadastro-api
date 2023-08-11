using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAPI.Models
{
    public class ImoveisUpdate
    {
        public string inscricaoImobiliaria { get; set; }
        public string tipoImovel { get; set; }
        public string enderecoCorrespondencia { get; set; }
        public string complemento { get; set; }
        public string numero { get; set; }
        public string situacao { get; set; }
        public Agrupamento agrupamento { get; set; }
        public string usarEnderecoCondominio { get; set; }
        public Proprietario proprietario { get; set; }
        public BairrosImoveis bairro { get; set; }
        public string anoCamposAdicionais { get; set; }
        public List<CampoAdicional> camposAdicionais { get; set; }

    }




}
