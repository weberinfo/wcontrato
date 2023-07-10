using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace wcontrato.Controller
{
    public class AplicacaoController
    {

        public static string ObtemChaveMaquina()
        {
            //Realiza condição de objeto nullo, pois caso usuario esteja logado com dominio, não é possível obter ID unico de conta local
            string numLicenca = System.Security.Principal.WindowsIdentity.GetCurrent().User.AccountDomainSid != null ? System.Security.Principal.WindowsIdentity.GetCurrent().User.AccountDomainSid.ToString() : Utilitarios.Util.removeAcentos(Environment.UserName + "_" + Environment.MachineName);
            return numLicenca;

        }

        public static DateTime ObtemCompilacaoApp()
        {

            DateTime buildDate = new FileInfo(Assembly.GetExecutingAssembly().Location).LastWriteTime;
            DateTime compilDate = buildDate;
            return compilDate;
        }


        public static string ObtemNomeAplicacao()
        {
            return "wcontrato";
        }

    }
}
