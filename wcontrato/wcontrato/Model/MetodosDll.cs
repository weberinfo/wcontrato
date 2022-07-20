using RGiesecke.DllExport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wcontrato
{
    public class MetodosDll
    {
        [DllExport(CallingConvention = CallingConvention.Cdecl)]
        public static void ExibeFormWContrato(string identificacao, string message2, string message3, string message4, out string ret, out string ret2)
        {
            Application.EnableVisualStyles();

            Principal principal = new Principal(identificacao);
            principal.ShowDialog();

            //Variaveis de retorno
            //Retorna variaveis globais pois podem ser setadas em outros forms da aplicação
            ret = Globals.DLL_RETORNO1;
            ret2 = Globals.DLL_RETORNO2;



        }
    }

}
