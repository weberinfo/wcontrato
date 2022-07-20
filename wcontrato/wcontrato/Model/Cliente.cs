using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wcontrato.Model
{
    public class Cliente
    {


        public int idCliente { get; set; }
        public string nomeRazao { get; set; }
        public string cnpjCpf { get; set; }
        public string enderRua { get; set; }
        public int enderNum { get; set; }
        public string enderBairro { get; set; }
        public string enderCidade { get; set; }
        public string enderUF { get; set; }
        public int dataVctoFatura { get; set; }

        public string socioCpf1 { get; set; }
        public string socioNome1 { get; set; }
        public string socioRg1 { get; set; }
        public string socioAdm1 { get; set; }

        public string socioCpf2 { get; set; }
        public string socioNome2 { get; set; }
        public string socioRg2 { get; set; }
        public string socioAdm2 { get; set; }

        public string socioCpf3 { get; set; }
        public string socioNome3 { get; set; }
        public string socioRg3 { get; set; }
        public string socioAdm3 { get; set; }

    }

}
