using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wcontrato
{

    public partial class Principal : Form
    {
    

        public string _DEFAULT_IDENTIFICACAO = @"[{""PATH_BD"":""177.101.148.24:C:\\WEBER_SERVER\\DADOS\\DADO1.MDW"",""PATH_BIN"":""C:\\Weber\\Estacao\\"",""PATH_TMP"":""C:\\Weber\\Estacao\\TEMP\\TmpAno_Mes\\2021_05\\Dia_26\\Francisco\\menu\\10110739\\"",""PATH_TMPCONF"":""C:\\Weber\\Estacao\\TEMP\\TmpConf\\Usuario_1\\Francisco\\"",""DATA_ABERTA"":""11/05/2021"",""COD_LOJA"":""1"",""CNPJ"":""07.691.741/0001-05"",""CNPJ_COD"":""237"",""USUA_COD"":""1"",""USUA_NOME"":""***SUPORTE***"",""HAB_FECHA_MES"":""N"",""HAB_MULTI_PRECO"":""S"",""COD_URA"":""290237"",""VPN_HOST"":""localhost"",""VPN_PORT"":""3381"",""VPN_HTTP"":""8081""}]";

        public Principal(string identificacao)
        {

            InitializeComponent();


            if (identificacao == null)
            {
                Globals.IDENTIF = _DEFAULT_IDENTIFICACAO;
            }
            else
            {
                Globals.IDENTIF = identificacao;
            }



        }

        private void trataJSON(string ident)
        {
            try
            {
                var objects = JArray.Parse(ident); // parse as array
                foreach (JObject root in objects)
                {

                    Globals.dbPath = root["PATH_BD"].ToString();
                    Globals.IdUsuario = Int32.Parse(root["USUA_COD"].ToString());
                    Globals.Usuario = root["USUA_NOME"].ToString();
                    Globals.CodClie = Convert.ToInt32(root["CNPJ_COD"].ToString());
                    Globals.Loja = Convert.ToInt32(root["COD_LOJA"].ToString());
                    Globals.MultiPreco = root["HAB_MULTI_PRECO"].ToString();
                    Globals.binPath = root["PATH_BIN"].ToString();
                    Globals.cnpjCpf = root["CNPJ"].ToString();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar autenticação: \n\n" + ex.Message);
                return;



            }
        }

        //Lista com as dlls necessárias
        public List<string> listDlls = new List<string>()
        {
            "FirebirdSql.Data.FirebirdClient.dll",
            "Newtonsoft.Json.dll",
            "Spire.Doc.dll",
            "Spire.Pdf.dll",
            "Microsoft.mshtml.dll"
        };

        private void Principal_Load(object sender, EventArgs e)
        {

            trataJSON(Globals.IDENTIF);

            //Validando se na pasta da aplicação encontram-se todas as dlls necessárias
            /*string errorsDlls = null;
            try
            {
                foreach (var dll in listDlls)
                {
                    if (!File.Exists(dll))
                    {
                        errorsDlls += dll + "\n";
                    }
                }

                if (errorsDlls != null)
                {
                    MessageBox.Show("Faltam os seguintes componentes: \n\n" + errorsDlls);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.Close();
            }*/

            Form1 newForm = new Form1();
            newForm.FormClosing += (obj, args) => { this.Dispose(); };
            newForm.Load += (obj, args) => { this.Hide(); };
            newForm.ShowDialog();

        }
    }
}
