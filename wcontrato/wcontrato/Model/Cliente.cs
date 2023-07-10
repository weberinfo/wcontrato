using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wcontrato.Model
{
    public class Cliente
    {

        
        public int ID_CLIENTE { get; set; } = 0;
        public string NOME_RAZAO { get; set; } = string.Empty;
        public string CNPJ_CPF { get; set; } = string.Empty;
        public string ENDERECO { get; set; } = string.Empty;
        public string ENDER_NUM { get; set; } = string.Empty;
        public string BAIRRO { get; set; } = string.Empty;
        public string CIDADE { get; set; } = string.Empty;
        public string UF { get; set; } = string.Empty;
        public string CONTRATO_DIA_VCTO { get; set; } = string.Empty;

        public string SOCIO_CPF1 { get; set; } = string.Empty;
        public string SOCIO_NOME1 { get; set; } = string.Empty;
        public string SOCIO_RG1 { get; set; } = string.Empty;
        public string SOCIO_ADM1 { get; set; } = string.Empty;

        public string SOCIO_CPF2 { get; set; } = string.Empty;
        public string SOCIO_NOME2 { get; set; } = string.Empty;
        public string SOCIO_RG2 { get; set; } = string.Empty;
        public string SOCIO_ADM2 { get; set; } = string.Empty;

        public string SOCIO_CPF3 { get; set; } = string.Empty;
        public string SOCIO_NOME3 { get; set; } = string.Empty;
        public string SOCIO_RG3 { get; set; } = string.Empty;
        public string SOCIO_ADM3 { get; set; } = string.Empty;

        public int CONTRATO_QTD_TEF { get; set; } = 0;
        public int CONTRATO_QTD_PDV { get; set; } = 0;
        public int CONTRATO_QTD_TERM { get; set; } = 0;

    }

}
