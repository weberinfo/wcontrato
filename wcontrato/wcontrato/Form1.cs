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
using Utilitarios;
using wcontrato.Model;

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

        public string obtemTrecho01ValorImplantacao(int qtdParcelas, double valorTotalImplantacao)
        {
            return "Valor do Serviço de IMPLANTAÇÃO: " + ( valorTotalImplantacao.ToString("C") + " (" + Model.Util.FirstLetterToUpper(Model.Util.EscreverExtenso((decimal)valorTotalImplantacao).ToLower()) + ")") + " a serem pagos após implantação no boleto, em " + qtdParcelas + " vez(es), na(s) próxima(s) fatura(s) da mensalidade.";
        }

        public double obtemValorParcelaImplantacao(int qtdParcelas, double valorTotalImplantacao)
        {
            
            if (valorTotalImplantacao <= 0)
                return 0;

            double valorParcela = Math.Round(valorTotalImplantacao / qtdParcelas, 2);
            return valorParcela;

        }



        public void populaDadosTeste()
        {
            //Populando dados teste para facilitar a compilação
            this.cboTipoContrato.SelectedIndex = 3;
            this.cboConsultor.SelectedIndex = 1;           
            this.txtCNPJ.Text = "07691741000105";
            this.txtContatoAC.Text = "Francisco";
            this.txtRazaoSocial.Text = "Supermercado do Francisco";
            //this.nudValorMensal.Value = 1;
           // this.nudValorImplantacao.Value = 5000;
           // this.nudQtdParcelaImplantacao.Value = 2;
            this.nudDiaVctoFatura.Value = 5;
          
        }


 
        Model.Cliente cliente = null;
        private async void btnGeraDocContrato_Click(object sender, EventArgs e)
        {


            try
            {
                this.Enabled = false;

                string strCodClinente = txtCodCliente.Text;
                int codCliente = 0;
                int.TryParse(strCodClinente, out codCliente);

                
                    //Caso seja proposta comercial não precisa ter um código de cliente
                    if (codCliente > 0 || this.cboTipoContrato.SelectedIndex == 4)
                    {

 

                        string uuid = Utilitarios.Util.gerarUUIDVersion4(false);
                        string validacoesErros = null;
                        string pathSalvar = AppDomain.CurrentDomain.BaseDirectory +  codCliente + "_" + DateTime.Now.ToString("yyyyyMMddhhmmss") + "\\";
                        List<string> listaTrechosSocios = new List<string>();
                        string trechosSocios = null;
                        decimal valorMensalidade = this.nudValorMensal.Value;
                        double valorImplantacao = (double)this.nudValorImplantacao.Value;
                        int qtdParcelasImplantacao = (int) this.nudQtdParcelaImplantacao.Value;
                        double valorParcelaImplantacao = obtemValorParcelaImplantacao(qtdParcelasImplantacao, valorImplantacao);
                        string nomeClienteAC = null;
                        string nomeConsultor = null;

                        int qtdUsuariosSimultanos = 0;

                        //Inicializando a classe cliente para obter os defaults
                        if (cliente is null)
                            cliente = new Cliente();

                        //Atualizando os dados a partir dos campos
                        cliente.NOME_RAZAO = this.txtRazaoSocial.Text.Trim();
                        cliente.CNPJ_CPF = !String.IsNullOrEmpty(this.txtCNPJ.Text) ? Convert.ToUInt64(Utilitarios.Util.apenasNumeros(this.txtCNPJ.Text.Trim())).ToString(@"00\.000\.000\/0000\-00") : null;
                        cliente.CONTRATO_DIA_VCTO = this.nudDiaVctoFatura.Value.ToString();

                        //Validações gerais
                        if(cliente is null) { validacoesErros += "Não foi possível obter os dados do cliente.\n"; }
                        if(valorMensalidade < 1) { validacoesErros += "Você deve informar o valor mensal.\n"; }
                        if(this.cboPacote.SelectedIndex < 1) { validacoesErros += "Você deve selecionar o pacote.\n"; }
                        if(this.cboTipoContrato.SelectedIndex < 1) { validacoesErros += "Você deve selecionar o tipo de contrato.\n"; }
                        if(String.IsNullOrEmpty(cliente.CNPJ_CPF) || !Utilitarios.Util.validaCNPJ(cliente.CNPJ_CPF)) { validacoesErros += "Você deve informar o CNPJ.\n"; }
                        if(cliente.NOME_RAZAO == null || cliente.NOME_RAZAO.Equals("")) { validacoesErros += "Você deve informar a razão social.\n"; }
                        if((qtdParcelasImplantacao > 0 && valorImplantacao <= 0) || (qtdParcelasImplantacao <= 0 && valorImplantacao > 0)) { validacoesErros += "Você deve informar Quantidade e Valor de implantação, ou deixar ambos campos em branco.\n"; }
                       
                        //Validações ref. ao tipo Proposta comercial
                        if (this.cboTipoContrato.SelectedIndex == 4)
                        {
                            nomeConsultor = Model.Util.CapitalizarNome(this.cboConsultor.SelectedValue.ToString().Trim());
                            nomeClienteAC = Model.Util.CapitalizarNome(this.txtContatoAC.Text.Trim());

                            if(nomeClienteAC == null || String.IsNullOrEmpty(nomeClienteAC)) { validacoesErros += "Você deve informar o Contato(A/C).\n"; }
                            if(nomeConsultor == null || String.IsNullOrEmpty(nomeConsultor)) { validacoesErros += "Você deve selecionar o consultor.\n"; }

                        }

                        if (string.IsNullOrEmpty(validacoesErros))
                        {

                            if (cliente.SOCIO_ADM1 != null && cliente.SOCIO_ADM1.ToString().Equals("S"))
                            {
                                string socio1 = trechoSocioPadrao;
                                socio1 = socio1.Replace("#NOME_SOCIO#", cliente.SOCIO_NOME1.ToUpper());
                                socio1 = socio1.Replace("#CPF_SOCIO#", Model.Util.FormatCPF(cliente.SOCIO_CPF1)); ;
                                socio1 = socio1.Replace("#RG_SOCIO#", Utilitarios.Util.apenasNumeros(cliente.SOCIO_RG1));
                                listaTrechosSocios.Add(socio1);
                            }



                            if (cliente.SOCIO_ADM2 != null && cliente.SOCIO_ADM2.ToString().Equals("S"))
                            {
                                string socio2 = trechoSocioPadrao;
                                socio2 = socio2.Replace("#NOME_SOCIO#", cliente.SOCIO_NOME2.ToUpper());
                                socio2 = socio2.Replace("#CPF_SOCIO#", Model.Util.FormatCPF(cliente.SOCIO_CPF2));
                                socio2 = socio2.Replace("#RG_SOCIO#", Utilitarios.Util.apenasNumeros(cliente.SOCIO_RG2));
                                listaTrechosSocios.Add(socio2);
                            }

                            if (cliente.SOCIO_ADM3 != null && cliente.SOCIO_ADM3.ToString().Equals("S"))
                            {
                                string socio3 = trechoSocioPadrao;
                                socio3 = socio3.Replace("#NOME_SOCIO#", Model.Util.CapitalizarNome(cliente.SOCIO_NOME3));
                                socio3 = socio3.Replace("#CPF_SOCIO#", Model.Util.FormatCPF(cliente.SOCIO_CPF3));
                                socio3 = socio3.Replace("#RG_SOCIO#", Utilitarios.Util.apenasNumeros(cliente.SOCIO_RG3));
                                listaTrechosSocios.Add(socio3);
                            }


                            trechosSocios = String.Join(", ", listaTrechosSocios.ToArray());



                            IDocument replaceDocument = new Document(this.localizacaoContrato + this.cboTipoContrato.SelectedValue);
                            replaceDocument.Replace("#NOME_RAZAO#", cliente.NOME_RAZAO.Trim().ToUpper(), false, true);
                            replaceDocument.Replace("#CNPJ_CPF#", cliente.CNPJ_CPF, false, true);
                            replaceDocument.Replace("#ENDER_RUA#", Model.Util.CapitalizarNome(cliente.ENDERECO.Trim()), false, true);
                            replaceDocument.Replace("#ENDER_NUM#", cliente.ENDER_NUM.ToString(), false, true);
                            replaceDocument.Replace("#ENDER_BAIRRO#", Model.Util.CapitalizarNome(cliente.BAIRRO.Trim()), false, true);
                            replaceDocument.Replace("#ENDER_CIDADE#", Model.Util.CapitalizarNome(cliente.CIDADE.Trim()), false, true);
                            replaceDocument.Replace("#ENDER_UF#", cliente.UF.Trim().ToUpper(), false, true);
                            replaceDocument.Replace("#SOCIOS_TRECHO_01#", trechosSocios, false, true);
                            replaceDocument.Replace("#DIA_VCTO_FATURA#", !String.IsNullOrEmpty(cliente.CONTRATO_DIA_VCTO) ? Model.Util.OrdinalExtensoVCTO(Int32.Parse(cliente.CONTRATO_DIA_VCTO)) : "", false, true);
                            replaceDocument.Replace("#DATA_EXTENSA_COM_CIDADE#", obtemDataExtensaComCidade(), false, true);
                            replaceDocument.Replace("#VALOR_MENSAL_EXTENSO#", valorMensalidade.ToString("C") + " (" + Model.Util.FirstLetterToUpper(Model.Util.EscreverExtenso(valorMensalidade).ToLower()) + ")", false, true);
                            replaceDocument.Replace("#QTD_PDV#", Math.Abs(this.nudQtdPDV.Value).ToString().PadLeft(2, '0'), false, true);
                            replaceDocument.Replace("#QTD_TEF#", Math.Abs(this.nudQtdTEF.Value).ToString().PadLeft(2, '0'), false, true);
                            replaceDocument.Replace("#QTD_RETAGUARDA#", Math.Abs(this.nudQtdRetaguarda.Value).ToString().PadLeft(2, '0'), false, true);
                            replaceDocument.Replace("#PACOTE_NOME#", this.cboPacote.SelectedValue.ToString().ToUpper(), false, true);
                            replaceDocument.Replace("#QTD_USUARIOS#", qtdUsuariosSimultanos.ToString(), false, true);
                            replaceDocument.Replace("#MENSAGEM_IMPORTACAO_BONIFICADA#", valorImplantacao <= 0 ? "IMPLANTAÇÃO ISENTA" : "TEM VALOR DE IMPLANTACAO", false, true);
                            replaceDocument.Replace("#QTD_PARCELAS#", qtdParcelasImplantacao.ToString(), false, true);
                            replaceDocument.Replace("#VALOR_PARCELA_IMPLANTACAO#", valorParcelaImplantacao.ToString("C"), false, true);
                            replaceDocument.Replace("#VALOR_IMPLANTACAO_PARCELAS_TRECHO01#", valorImplantacao > 0 ? obtemTrecho01ValorImplantacao(qtdParcelasImplantacao, valorImplantacao) : String.Empty, false, true);
                            replaceDocument.Replace("#VALOR_IMPLANTACAO_INVESTIMENTO#", valorImplantacao.ToString("C") + " (" + Model.Util.FirstLetterToUpper(Model.Util.EscreverExtenso((decimal)valorImplantacao).ToLower()) + ")", false, true);
                            replaceDocument.Replace("#QTD_RETAGUARDA_MENOS_SERVIDOR#", (1).ToString().PadLeft(2, '0'), false, true);
                            

                            if (nomeConsultor != null)
                                replaceDocument.Replace("#NOME_CONSULTOR#", nomeConsultor, false, true);

                            if (nomeClienteAC != null)
                                replaceDocument.Replace("#NOME_CLIENTE_CONTATO#", nomeClienteAC, false, true);

                            //Salva o arquivo
                            replaceDocument.SaveToFile(pathSalvar + uuid + ".docx", FileFormat.Docx2013);

                            MessageBox.Show("Arquivo salvo com sucesso.");

                            //Abre a pasta no explorer
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

       

        private async void Form1_Load(object sender, EventArgs e)
        {


            List<Model.KeyValue> listaConsultores = new List<Model.KeyValue>();

            listaConsultores.Add(new Model.KeyValue() { Key = "", Value = "Selecione..." });
            listaConsultores.Add(new Model.KeyValue() { Key = "Gislene Moraes", Value = "Gislene Moraes" });
            listaConsultores.Add(new Model.KeyValue() { Key = "Jonathan Oliveira", Value = "Jonathan Oliveira" });

            this.cboConsultor.DataSource = listaConsultores;
            this.cboConsultor.DisplayMember = "Value";
            this.cboConsultor.ValueMember = "Key";
            this.cboConsultor.SelectedIndex = 0;


            List<Model.KeyValue>  listaPacote = new List<Model.KeyValue>();

           listaPacote.Add(new Model.KeyValue() { Key = "Selecione", Value = "Selecione..." });
            /*listaPacote.Add(new Model.KeyValue() { Key = " Silver", Value = "Silver" });
           listaPacote.Add(new Model.KeyValue() { Key = " Gold", Value = "Gold" });
           listaPacote.Add(new Model.KeyValue() { Key = " Platinum", Value = "Platinum" });*/
            listaPacote.Add(new Model.KeyValue() { Key = "", Value = "Nenhum(Em branco)" });

            this.cboPacote.DataSource = listaPacote;
            this.cboPacote.DisplayMember = "Value";
            this.cboPacote.ValueMember = "Key";
            this.cboPacote.SelectedIndex = 1;

            List<Model.KeyValue> listaTipoContrato = new List<Model.KeyValue>();

            //Não alterar sequência dos tipos devido as validações
            listaTipoContrato.Add(new Model.KeyValue() { Key = "", Value = "Selecione..." }); //0
            listaTipoContrato.Add(new Model.KeyValue() { Key = "contratoWeber.docx", Value = "Adm - Cliente Novo" });
            listaTipoContrato.Add(new Model.KeyValue() { Key = "contratoWeber24meses.docx", Value = "Adm - Cliente Novo Fidelidade 24 meses" });//1
            listaTipoContrato.Add(new Model.KeyValue() { Key = "adendoContratual.docx", Value = "Adm - Adendo" }); //2
            listaTipoContrato.Add(new Model.KeyValue() { Key = "propostaComercial.docx", Value = "Comercial - Proposta" }); //3
            //listaTipoContrato.Add(new Model.KeyValue() { Key = "adendoComercial.docx", Value = "Comercial - Adendo" }); //4


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

            resetaCamposDadosCliente();

            desativaCamposDadosCliente();

          //  populaDadosTeste();


        }

        private void resetaCamposDadosCliente()
        {

            cliente = null;

            this.txtCodCliente.Text = string.Empty;
            this.txtRazaoSocial.Text = string.Empty;
            this.txtContatoAC.Text = string.Empty;
            this.txtCNPJ.Text = string.Empty;
            this.cboConsultor.SelectedIndex = 0;


            Utilitarios.Util.dateInputBR_Clear(this.dtpDataPrimeiraParcelaImplantacao);

        }

        private void desativaCamposDadosCliente()
        {
            
            this.txtCodCliente.Enabled = false;
            this.txtRazaoSocial.Enabled = false;
            this.txtContatoAC.Enabled = false;
            this.txtCNPJ.Enabled = false;
            this.cboConsultor.Enabled = false;

        }

        private void setaCamposDadosCliente()
        {

            this.txtCodCliente.Text = cliente.ID_CLIENTE.ToString();
            this.txtRazaoSocial.Text = cliente.NOME_RAZAO.ToString();
            this.txtContatoAC.Text = string.Empty;
            this.txtCNPJ.Text = cliente.CNPJ_CPF;
            this.cboConsultor.SelectedIndex = 0;
           

            if (!String.IsNullOrEmpty(cliente.CONTRATO_DIA_VCTO))
            {
                this.dtpDataPrimeiraParcelaImplantacao.Text = (Int32.Parse(cliente.CONTRATO_DIA_VCTO) < DateTime.Now.Day ? DateTime.Now : DateTime.Now.AddMonths(1)).ToString("yyyy-MM-05");
                this.nudDiaVctoFatura.Value = decimal.Parse(cliente.CONTRATO_DIA_VCTO);
            }

        }

        private void cboTipoContrato_SelectedIndexChanged(object sender, EventArgs e)
        {

            resetaCamposDadosCliente();

            desativaCamposDadosCliente();


            switch ((sender as ComboBox).SelectedIndex)
            {
         

                 case 1:
                    this.txtCodCliente.Enabled = true;
                   break;

                case 2:
                    this.txtCodCliente.Enabled = true;
                    break;

                case 3:
                    this.txtCodCliente.Enabled = true;
                    break;

                case 4:
                    this.txtCodCliente.Enabled = true;
                    this.txtRazaoSocial.Enabled = true;
                    this.txtContatoAC.Enabled = true;
                    this.txtCNPJ.Enabled = true;
                    this.cboConsultor.Enabled = true;
                    break;


            }



        }



        private void txtCodCliente_Leave(object sender, EventArgs e)
        {

             
            string strCodClinente = txtCodCliente.Text;
            int codCliente = 0;
            if (int.TryParse(strCodClinente, out codCliente))
            {
              
                if (codCliente > 0)
                {



                }


            }


            if (cliente == null ||  cliente.ID_CLIENTE != codCliente)
            {
                this.Enabled = false;

                cliente = null;

                if (codCliente != 0)
                    resetaCamposDadosCliente();

                if(codCliente > 0)
                {

                    cliente = BD.ObtemDadosCliente(codCliente);

                    if (cliente != null)
                    {

                        setaCamposDadosCliente();

                    }
                    else
                    {
                        Alertas.Error(this, "Nenhum cliente localizado com código informado");
                    }

                }

                
                

                this.Enabled = true;
            }

        }

        private void txtCodCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCodCliente_Leave(this.txtCodCliente, null);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}
