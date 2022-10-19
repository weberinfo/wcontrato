using Spire.Doc;
using Spire.Doc.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wcontrato
{
    public partial class Form1 : Form
    {

        public string localizacaoContrato = null;
        public string trechoSocioPadrao = @"Sr.(a) #NOME_SOCIO#, brasileiro(a),   solteiro(a),   empresário(a), " + 
            "titular   do   documento   de   identidade   RG   nº #RG_SOCIO#, inscrito(a) no CPF sob o nº #CPF_SOCIO#";

        public Form1()
        {
            InitializeComponent();

        }


        public string obtemDataExtensaComCidade()
        {
            return "São Leopoldo, " + DateTime.Now.ToString("dd") + " de " + DateTime.Now.ToString("MMMM") + " de " + DateTime.Now.ToString("yyyy");
        }

        public string FormatCPF(string sender)
        {
            sender = Utilitarios.Util.apenasNumeros(sender);
            string response = sender.Trim();
            if (response.Length == 11)
            {
                response = response.Insert(9, "-");
                response = response.Insert(6, ".");
                response = response.Insert(3, ".");
            }
            return response;
        }

        // O método EscreverExtenso recebe um valor do tipo decimal
        public static string EscreverExtenso(decimal valor)
        {
            if (valor <= 0 | valor >= 1000000000000000)
                return "Valor não suportado pelo sistema.";
            else
            {
                string strValor = valor.ToString("000000000000000.00");
                string valor_por_extenso = string.Empty;
                for (int i = 0; i <= 15; i += 3)
                {
                    valor_por_extenso += Escrever_Valor_Extenso(Convert.ToDecimal(strValor.Substring(i, 3)));
                    if (i == 0 & valor_por_extenso != string.Empty)
                    {
                        if (Convert.ToInt32(strValor.Substring(0, 3)) == 1)
                            valor_por_extenso += " TRILHÃO" + ((Convert.ToDecimal(strValor.Substring(3, 12)) > 0) ? " E " : string.Empty);
                        else if (Convert.ToInt32(strValor.Substring(0, 3)) > 1)
                            valor_por_extenso += " TRILHÕES" + ((Convert.ToDecimal(strValor.Substring(3, 12)) > 0) ? " E " : string.Empty);
                    }
                    else if (i == 3 & valor_por_extenso != string.Empty)
                    {
                        if (Convert.ToInt32(strValor.Substring(3, 3)) == 1)
                            valor_por_extenso += " BILHÃO" + ((Convert.ToDecimal(strValor.Substring(6, 9)) > 0) ? " E " : string.Empty);
                        else if (Convert.ToInt32(strValor.Substring(3, 3)) > 1)
                            valor_por_extenso += " BILHÕES" + ((Convert.ToDecimal(strValor.Substring(6, 9)) > 0) ? " E " : string.Empty);
                    }
                    else if (i == 6 & valor_por_extenso != string.Empty)
                    {
                        if (Convert.ToInt32(strValor.Substring(6, 3)) == 1)
                            valor_por_extenso += " MILHÃO" + ((Convert.ToDecimal(strValor.Substring(9, 6)) > 0) ? " E " : string.Empty);
                        else if (Convert.ToInt32(strValor.Substring(6, 3)) > 1)
                            valor_por_extenso += " MILHÕES" + ((Convert.ToDecimal(strValor.Substring(9, 6)) > 0) ? " E " : string.Empty);
                    }
                    else if (i == 9 & valor_por_extenso != string.Empty)
                        if (Convert.ToInt32(strValor.Substring(9, 3)) > 0)
                            valor_por_extenso += " MIL" + ((Convert.ToDecimal(strValor.Substring(12, 3)) > 0) ? " E " : string.Empty);
                    if (i == 12)
                    {
                        if (valor_por_extenso.Length > 8)
                            if (valor_por_extenso.Substring(valor_por_extenso.Length - 6, 6) == "BILHÃO" | valor_por_extenso.Substring(valor_por_extenso.Length - 6, 6) == "MILHÃO")
                                valor_por_extenso += " DE";
                            else
                                if (valor_por_extenso.Substring(valor_por_extenso.Length - 7, 7) == "BILHÕES" | valor_por_extenso.Substring(valor_por_extenso.Length - 7, 7) == "MILHÕES"
| valor_por_extenso.Substring(valor_por_extenso.Length - 8, 7) == "TRILHÕES")
                                valor_por_extenso += " DE";
                            else
                                    if (valor_por_extenso.Substring(valor_por_extenso.Length - 8, 8) == "TRILHÕES")
                                valor_por_extenso += " DE";
                        if (Convert.ToInt64(strValor.Substring(0, 15)) == 1)
                            valor_por_extenso += " REAL";
                        else if (Convert.ToInt64(strValor.Substring(0, 15)) > 1)
                            valor_por_extenso += " REAIS";
                        if (Convert.ToInt32(strValor.Substring(16, 2)) > 0 && valor_por_extenso != string.Empty)
                            valor_por_extenso += " E ";
                    }
                    if (i == 15)
                        if (Convert.ToInt32(strValor.Substring(16, 2)) == 1)
                            valor_por_extenso += " CENTAVO";
                        else if (Convert.ToInt32(strValor.Substring(16, 2)) > 1)
                            valor_por_extenso += " CENTAVOS";
                }
                return valor_por_extenso;
            }
        }
        static string Escrever_Valor_Extenso(decimal valor)
        {
            if (valor <= 0)
                return string.Empty;
            else
            {
                string montagem = string.Empty;
                if (valor > 0 & valor < 1)
                {
                    valor *= 100;
                }
                string strValor = valor.ToString("000");
                int a = Convert.ToInt32(strValor.Substring(0, 1));
                int b = Convert.ToInt32(strValor.Substring(1, 1));
                int c = Convert.ToInt32(strValor.Substring(2, 1));
                if (a == 1) montagem += (b + c == 0) ? "CEM" : "CENTO";
                else if (a == 2) montagem += "DUZENTOS";
                else if (a == 3) montagem += "TREZENTOS";
                else if (a == 4) montagem += "QUATROCENTOS";
                else if (a == 5) montagem += "QUINHENTOS";
                else if (a == 6) montagem += "SEISCENTOS";
                else if (a == 7) montagem += "SETECENTOS";
                else if (a == 8) montagem += "OITOCENTOS";
                else if (a == 9) montagem += "NOVECENTOS";
                if (b == 1)
                {
                    if (c == 0) montagem += ((a > 0) ? " E " : string.Empty) + "DEZ";
                    else if (c == 1) montagem += ((a > 0) ? " E " : string.Empty) + "ONZE";
                    else if (c == 2) montagem += ((a > 0) ? " E " : string.Empty) + "DOZE";
                    else if (c == 3) montagem += ((a > 0) ? " E " : string.Empty) + "TREZE";
                    else if (c == 4) montagem += ((a > 0) ? " E " : string.Empty) + "QUATORZE";
                    else if (c == 5) montagem += ((a > 0) ? " E " : string.Empty) + "QUINZE";
                    else if (c == 6) montagem += ((a > 0) ? " E " : string.Empty) + "DEZESSEIS";
                    else if (c == 7) montagem += ((a > 0) ? " E " : string.Empty) + "DEZESSETE";
                    else if (c == 8) montagem += ((a > 0) ? " E " : string.Empty) + "DEZOITO";
                    else if (c == 9) montagem += ((a > 0) ? " E " : string.Empty) + "DEZENOVE";
                }
                else if (b == 2) montagem += ((a > 0) ? " E " : string.Empty) + "VINTE";
                else if (b == 3) montagem += ((a > 0) ? " E " : string.Empty) + "TRINTA";
                else if (b == 4) montagem += ((a > 0) ? " E " : string.Empty) + "QUARENTA";
                else if (b == 5) montagem += ((a > 0) ? " E " : string.Empty) + "CINQUENTA";
                else if (b == 6) montagem += ((a > 0) ? " E " : string.Empty) + "SESSENTA";
                else if (b == 7) montagem += ((a > 0) ? " E " : string.Empty) + "SETENTA";
                else if (b == 8) montagem += ((a > 0) ? " E " : string.Empty) + "OITENTA";
                else if (b == 9) montagem += ((a > 0) ? " E " : string.Empty) + "NOVENTA";
                if (strValor.Substring(1, 1) != "1" & c != 0 & montagem != string.Empty) montagem += " E ";
                if (strValor.Substring(1, 1) != "1")
                    if (c == 1) montagem += "UM";
                    else if (c == 2) montagem += "DOIS";
                    else if (c == 3) montagem += "TRÊS";
                    else if (c == 4) montagem += "QUATRO";
                    else if (c == 5) montagem += "CINCO";
                    else if (c == 6) montagem += "SEIS";
                    else if (c == 7) montagem += "SETE";
                    else if (c == 8) montagem += "OITO";
                    else if (c == 9) montagem += "NOVE";
                return montagem;
            }
        }

        int[] GetIntArray(int num)
        {
            List<int> listOfInts = new List<int>();
            while (num > 0)
            {
                listOfInts.Add(num % 10);
                num = num / 10;
            }
            listOfInts.Reverse();
            return listOfInts.ToArray();
        }

        private string OrdinalExtensoVCTO(int numero)
        {
            int conta;
            string Texto = "";
            string[] VctosExtenso = new string[30];
            VctosExtenso[5] = "quinto";
            VctosExtenso[10] = "décimo";
            VctosExtenso[20] = "vigésimo";

            return VctosExtenso[numero];


        }


        public class KeyValue
        {
            public string Key { get; set; }
            public string Value { get; set; }
        }

        public string FirstLetterToUpper(string str)
        {
            if (str == null)
                return null;

            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);

            return str.ToUpper();
        }

        private string CapitalizarNome(string nome)
        {
            string[] excecoes = new string[] { "e", "de", "da", "das", "do", "dos" };
            var palavras = new Queue<string>();
            foreach (var palavra in nome.Split(' '))
            {
                if (!string.IsNullOrEmpty(palavra))
                {
                    var emMinusculo = palavra.ToLower();
                    var letras = emMinusculo.ToCharArray();
                    if (!excecoes.Contains(emMinusculo)) letras[0] = char.ToUpper(letras[0]);
                    palavras.Enqueue(new string(letras));
                }
            }
            return string.Join(" ", palavras);
        }
        private void btnGeraDocContrato_Click(object sender, EventArgs e)
        {

            try
            {
                this.Enabled = false;

                string strCodClinente = txtCodCliente.Text;
                int codCliente;
                

                if (int.TryParse(strCodClinente, out codCliente))
                {
                    if (Convert.ToInt32(strCodClinente) > 0)
                    {

                        string uuid = Utilitarios.Util.gerarUUIDVersion4(false);
                        string validacoesErros = null;
                        string pathSalvar = AppDomain.CurrentDomain.BaseDirectory +  codCliente + "_" + DateTime.Now.ToString("yyyyyMMddhhmmss") + "\\";
                        codCliente = Convert.ToInt32(strCodClinente);
                        List<string> listaTrechosSocios = new List<string>();
                        string trechosSocios = null;
                        decimal valorMensal = this.nudValorMensal.Value;
                       

                        //Obtendo dados do cliente
                        Model.Cliente cliente = Model.BD.ObtemDadosCliente(codCliente);

                        if(cliente is null) { validacoesErros += "Não foi possível obter os dados do cliente.\n"; }
                        if(valorMensal < 1) { validacoesErros += "Você deve informar o valor mensal.\n"; }
                        if(this.cboPacote.SelectedIndex < 1) { validacoesErros += "Você deve selecionar o pacote.\n"; }
                        if(this.cboTipoContrato.SelectedIndex < 1) { validacoesErros += "Você deve selecionar o tipo de contrato.\n"; }


                        if (string.IsNullOrEmpty(validacoesErros))
                        {

                            if (cliente.socioAdm1.Equals("S"))
                            {
                                string socio1 = trechoSocioPadrao;
                                socio1 = socio1.Replace("#NOME_SOCIO#", cliente.socioNome1.ToUpper());
                                socio1 = socio1.Replace("#CPF_SOCIO#", FormatCPF(cliente.socioCpf1));
                                socio1 = socio1.Replace("#RG_SOCIO#", Utilitarios.Util.apenasNumeros(cliente.socioRg1));
                                listaTrechosSocios.Add(socio1);
                            }



                            if (cliente.socioAdm2.Equals("S"))
                            {
                                string socio2 = trechoSocioPadrao;
                                socio2 = socio2.Replace("#NOME_SOCIO#", cliente.socioNome2.ToUpper());
                                socio2 = socio2.Replace("#CPF_SOCIO#", FormatCPF(cliente.socioCpf2));
                                socio2 = socio2.Replace("#RG_SOCIO#", Utilitarios.Util.apenasNumeros(cliente.socioRg2));
                                listaTrechosSocios.Add(socio2);
                            }

                            if (cliente.socioAdm3.Equals("S"))
                            {
                                string socio3 = trechoSocioPadrao;
                                socio3 = socio3.Replace("#NOME_SOCIO#", CapitalizarNome(cliente.socioNome3));
                                socio3 = socio3.Replace("#CPF_SOCIO#", FormatCPF(cliente.socioCpf3));
                                socio3 = socio3.Replace("#RG_SOCIO#", Utilitarios.Util.apenasNumeros(cliente.socioRg3));
                                listaTrechosSocios.Add(socio3);
                            }


                            trechosSocios = String.Join(", ", listaTrechosSocios.ToArray());



                            IDocument replaceDocument = new Document(this.localizacaoContrato + this.cboTipoContrato.SelectedValue);
                            replaceDocument.Replace("#NOME_RAZAO#", cliente.nomeRazao.Trim(), false, true);
                            replaceDocument.Replace("#CNPJ_CPF#", cliente.cnpjCpf, false, true);
                            replaceDocument.Replace("#ENDER_RUA#", CapitalizarNome(cliente.enderRua.Trim()), false, true);
                            replaceDocument.Replace("#ENDER_NUM#", cliente.enderNum.ToString(), false, true);
                            replaceDocument.Replace("#ENDER_BAIRRO#", CapitalizarNome(cliente.enderBairro.Trim()), false, true);
                            replaceDocument.Replace("#ENDER_CIDADE#", CapitalizarNome(cliente.enderCidade.Trim()), false, true);
                            replaceDocument.Replace("#ENDER_UF#", cliente.enderUF.Trim().ToUpper(), false, true);
                            replaceDocument.Replace("#SOCIOS_TRECHO_01#", trechosSocios, false, true);
                            replaceDocument.Replace("#DIA_VCTO_FATURA#", OrdinalExtensoVCTO(cliente.dataVctoFatura), false, true);
                            replaceDocument.Replace("#DATA_EXTENSA_COM_CIDADE#", obtemDataExtensaComCidade(), false, true);
                            replaceDocument.Replace("#VALOR_MENSAL_EXTENSO#", valorMensal.ToString("C") + " (" + FirstLetterToUpper(EscreverExtenso(valorMensal).ToLower()) + ")", false, true);
                            replaceDocument.Replace("#QTD_PDV#", Math.Abs(this.nudQtdPDV.Value).ToString().PadLeft(2, '0'), false, true);
                            replaceDocument.Replace("#QTD_TEF#", Math.Abs(this.nudQtdTEF.Value).ToString().PadLeft(2, '0'), false, true);
                            replaceDocument.Replace("#QTD_RETAGUARDA#", Math.Abs(this.nudQtdRetaguarda.Value).ToString().PadLeft(2, '0'), false, true);
                            replaceDocument.Replace("#PACOTE_NOME#", this.cboPacote.SelectedValue.ToString().ToUpper(), false, true);



                            //Save the file
                            replaceDocument.SaveToFile(pathSalvar + uuid + ".docx", FileFormat.Docx2013);

                            MessageBox.Show("Arquivo salvo com sucesso.");

                            //opens the folder in explorer
                            Process.Start("explorer.exe", pathSalvar);

                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Ops..\n\n" + validacoesErros);
                        }

                    } else
                    {
                        MessageBox.Show("ERRO L1X910X10: Você deve informar um código de cliente valido.");
                    }

                } else
                {
                    MessageBox.Show("ERRO L0XPQXXFG: Você deve informar um código de cliente valido.");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO LPXQ9XQ8: " + ex.ToString());
            }
            finally
            {
                this.Enabled = true;
            }

         
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            

            List<KeyValue>  listaPacote = new List<KeyValue>();

            listaPacote.Add(new KeyValue() { Key = "Selecione", Value = "Selecione..." });
            listaPacote.Add(new KeyValue() { Key = " Silver", Value = "Silver" });
            listaPacote.Add(new KeyValue() { Key = " Gold", Value = "Gold" });
            listaPacote.Add(new KeyValue() { Key = " Platinum", Value = "Platinum" });
            listaPacote.Add(new KeyValue() { Key = "", Value = "Nenhum(Em branco)" });

            this.cboPacote.DataSource = listaPacote;
            this.cboPacote.DisplayMember = "Value";
            this.cboPacote.ValueMember = "Key";
            this.cboPacote.SelectedIndex = 0;

            List<KeyValue> listaTipoContrato = new List<KeyValue>();

            listaTipoContrato.Add(new KeyValue() { Key = "", Value = "Selecione..." });
            listaTipoContrato.Add(new KeyValue() { Key = "contratoWeber.docx", Value = "Novo" });
            listaTipoContrato.Add(new KeyValue() { Key = "adendoContratual.docx", Value = "Adendo" });

            this.cboTipoContrato.DataSource = listaTipoContrato;
            this.cboTipoContrato.DisplayMember = "Value";
            this.cboTipoContrato.ValueMember = "Key";
            this.cboTipoContrato.SelectedIndex = 0;



            this.localizacaoContrato = AppDomain.CurrentDomain.BaseDirectory;
            this.lblLocalizacaoContrato.Text = "Os contratos devem estar localizados na pasta do executável com os nomes:";
            string nomesContratos = "";
            foreach(var keyContrato in listaTipoContrato)
            {
                if(keyContrato.Key != "")
                    nomesContratos += keyContrato.Key + ", ";
            }
            this.txtLocalizacaoContrato.Text = nomesContratos;

        }
    }
}
