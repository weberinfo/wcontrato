using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wcontrato
{
    public static class Globals
    {
        //Váriaveis globais que retornarão para o APP que esta chamando a DLL após esta aplicação ser fechada
        public static string DLL_RETORNO1 = null;
        public static string DLL_RETORNO2 = null;
        private static string _ident = "";
        public static int IdUsuario = 1;
        public static string Usuario = "";
        public static int Loja = 0;
        public static string MultiPreco = null;
        public static string dbPath { get; set; }
        public static int CodClie { get; set; }
        public static string binPath { get; set; }
        public static string cnpjCpf { get; set; }

        public static string IDENTIF
        {
            get { return _ident; }
            set { _ident = value; }
        }


    }
}
