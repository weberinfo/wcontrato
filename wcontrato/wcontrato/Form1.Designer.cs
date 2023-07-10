namespace wcontrato
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGeraDocContrato = new System.Windows.Forms.Button();
            this.lblLocalizacaoContrato = new System.Windows.Forms.Label();
            this.ofdLocalizacaoContrato = new System.Windows.Forms.OpenFileDialog();
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.tbpCliente = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpDataPrimeiraParcelaImplantacao = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.nudQtdParcelaImplantacao = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudValorImplantacao = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudValorMensal = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboConsultor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContatoAC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTipoContrato = new System.Windows.Forms.Label();
            this.cboTipoContrato = new System.Windows.Forms.ComboBox();
            this.lblQtdTEF = new System.Windows.Forms.Label();
            this.cboPacote = new System.Windows.Forms.ComboBox();
            this.nudQtdTEF = new System.Windows.Forms.NumericUpDown();
            this.lblPacote = new System.Windows.Forms.Label();
            this.lblQtdPDV = new System.Windows.Forms.Label();
            this.nudQtdRetaguarda = new System.Windows.Forms.NumericUpDown();
            this.nudQtdPDV = new System.Windows.Forms.NumericUpDown();
            this.lblQtdRetaguarda = new System.Windows.Forms.Label();
            this.tbpContrato = new System.Windows.Forms.TabPage();
            this.txtLocalizacaoContrato = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nudDiaVctoFatura = new System.Windows.Forms.NumericUpDown();
            this.tbcPrincipal.SuspendLayout();
            this.tbpCliente.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdParcelaImplantacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorImplantacao)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorMensal)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdTEF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdRetaguarda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdPDV)).BeginInit();
            this.tbpContrato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiaVctoFatura)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeraDocContrato
            // 
            this.btnGeraDocContrato.Location = new System.Drawing.Point(939, 477);
            this.btnGeraDocContrato.Margin = new System.Windows.Forms.Padding(2);
            this.btnGeraDocContrato.Name = "btnGeraDocContrato";
            this.btnGeraDocContrato.Size = new System.Drawing.Size(96, 19);
            this.btnGeraDocContrato.TabIndex = 0;
            this.btnGeraDocContrato.Text = "Gerar contrato";
            this.btnGeraDocContrato.UseVisualStyleBackColor = true;
            this.btnGeraDocContrato.Click += new System.EventHandler(this.btnGeraDocContrato_Click);
            // 
            // lblLocalizacaoContrato
            // 
            this.lblLocalizacaoContrato.AutoSize = true;
            this.lblLocalizacaoContrato.Location = new System.Drawing.Point(15, 22);
            this.lblLocalizacaoContrato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocalizacaoContrato.Name = "lblLocalizacaoContrato";
            this.lblLocalizacaoContrato.Size = new System.Drawing.Size(16, 13);
            this.lblLocalizacaoContrato.TabIndex = 1;
            this.lblLocalizacaoContrato.Text = "...";
            // 
            // ofdLocalizacaoContrato
            // 
            this.ofdLocalizacaoContrato.FileName = "openFileDialog1";
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Controls.Add(this.tbpCliente);
            this.tbcPrincipal.Controls.Add(this.tbpContrato);
            this.tbcPrincipal.Location = new System.Drawing.Point(11, 10);
            this.tbcPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(1028, 463);
            this.tbcPrincipal.TabIndex = 5;
            // 
            // tbpCliente
            // 
            this.tbpCliente.Controls.Add(this.groupBox4);
            this.tbpCliente.Controls.Add(this.groupBox3);
            this.tbpCliente.Controls.Add(this.groupBox2);
            this.tbpCliente.Controls.Add(this.groupBox1);
            this.tbpCliente.Location = new System.Drawing.Point(4, 22);
            this.tbpCliente.Margin = new System.Windows.Forms.Padding(2);
            this.tbpCliente.Name = "tbpCliente";
            this.tbpCliente.Padding = new System.Windows.Forms.Padding(2);
            this.tbpCliente.Size = new System.Drawing.Size(1020, 437);
            this.tbpCliente.TabIndex = 0;
            this.tbpCliente.Text = "Dados";
            this.tbpCliente.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpDataPrimeiraParcelaImplantacao);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.nudQtdParcelaImplantacao);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.nudValorImplantacao);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(545, 232);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(461, 75);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Implantação";
            // 
            // dtpDataPrimeiraParcelaImplantacao
            // 
            this.dtpDataPrimeiraParcelaImplantacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataPrimeiraParcelaImplantacao.Location = new System.Drawing.Point(306, 42);
            this.dtpDataPrimeiraParcelaImplantacao.Name = "dtpDataPrimeiraParcelaImplantacao";
            this.dtpDataPrimeiraParcelaImplantacao.Size = new System.Drawing.Size(131, 20);
            this.dtpDataPrimeiraParcelaImplantacao.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Data 1° Parc. implantação:";
            // 
            // nudQtdParcelaImplantacao
            // 
            this.nudQtdParcelaImplantacao.Location = new System.Drawing.Point(161, 42);
            this.nudQtdParcelaImplantacao.Margin = new System.Windows.Forms.Padding(2);
            this.nudQtdParcelaImplantacao.Name = "nudQtdParcelaImplantacao";
            this.nudQtdParcelaImplantacao.Size = new System.Drawing.Size(123, 20);
            this.nudQtdParcelaImplantacao.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Qtd Parc. implantação:";
            // 
            // nudValorImplantacao
            // 
            this.nudValorImplantacao.DecimalPlaces = 2;
            this.nudValorImplantacao.Location = new System.Drawing.Point(19, 42);
            this.nudValorImplantacao.Margin = new System.Windows.Forms.Padding(2);
            this.nudValorImplantacao.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudValorImplantacao.Name = "nudValorImplantacao";
            this.nudValorImplantacao.Size = new System.Drawing.Size(127, 20);
            this.nudValorImplantacao.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Valor implantação:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(21, 373);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(308, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 352);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Pacote:";
            this.label8.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nudDiaVctoFatura);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.nudValorMensal);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(545, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(470, 75);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mensalidade";
            // 
            // nudValorMensal
            // 
            this.nudValorMensal.DecimalPlaces = 2;
            this.nudValorMensal.Location = new System.Drawing.Point(18, 43);
            this.nudValorMensal.Margin = new System.Windows.Forms.Padding(2);
            this.nudValorMensal.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudValorMensal.Name = "nudValorMensal";
            this.nudValorMensal.Size = new System.Drawing.Size(118, 20);
            this.nudValorMensal.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 27);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Valor mensal:";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(21, 373);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(308, 21);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 352);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Pacote:";
            this.label12.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboConsultor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtContatoAC);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtCNPJ);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtRazaoSocial);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtCodCliente);
            this.groupBox2.Controls.Add(this.lblCodCliente);
            this.groupBox2.Location = new System.Drawing.Point(5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 427);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // cboConsultor
            // 
            this.cboConsultor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConsultor.FormattingEnabled = true;
            this.cboConsultor.Location = new System.Drawing.Point(151, 44);
            this.cboConsultor.Name = "cboConsultor";
            this.cboConsultor.Size = new System.Drawing.Size(353, 21);
            this.cboConsultor.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Consultor:";
            // 
            // txtContatoAC
            // 
            this.txtContatoAC.Location = new System.Drawing.Point(8, 195);
            this.txtContatoAC.Margin = new System.Windows.Forms.Padding(2);
            this.txtContatoAC.Name = "txtContatoAC";
            this.txtContatoAC.Size = new System.Drawing.Size(496, 20);
            this.txtContatoAC.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contato (A/C):";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(8, 142);
            this.txtCNPJ.Margin = new System.Windows.Forms.Padding(2);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(496, 20);
            this.txtCNPJ.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CNPJ:";
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Location = new System.Drawing.Point(8, 96);
            this.txtRazaoSocial.Margin = new System.Windows.Forms.Padding(2);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(496, 20);
            this.txtRazaoSocial.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Razão Social:";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(8, 43);
            this.txtCodCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(124, 20);
            this.txtCodCliente.TabIndex = 1;
            this.txtCodCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodCliente_KeyPress);
            this.txtCodCliente.Leave += new System.EventHandler(this.txtCodCliente_Leave);
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.Location = new System.Drawing.Point(5, 28);
            this.lblCodCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(127, 13);
            this.lblCodCliente.TabIndex = 0;
            this.lblCodCliente.Text = "Código do cliente Weber:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTipoContrato);
            this.groupBox1.Controls.Add(this.cboTipoContrato);
            this.groupBox1.Controls.Add(this.lblQtdTEF);
            this.groupBox1.Controls.Add(this.cboPacote);
            this.groupBox1.Controls.Add(this.nudQtdTEF);
            this.groupBox1.Controls.Add(this.lblPacote);
            this.groupBox1.Controls.Add(this.lblQtdPDV);
            this.groupBox1.Controls.Add(this.nudQtdRetaguarda);
            this.groupBox1.Controls.Add(this.nudQtdPDV);
            this.groupBox1.Controls.Add(this.lblQtdRetaguarda);
            this.groupBox1.Location = new System.Drawing.Point(545, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 140);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Licenças/Contratos";
            // 
            // lblTipoContrato
            // 
            this.lblTipoContrato.AutoSize = true;
            this.lblTipoContrato.Location = new System.Drawing.Point(16, 28);
            this.lblTipoContrato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoContrato.Name = "lblTipoContrato";
            this.lblTipoContrato.Size = new System.Drawing.Size(88, 13);
            this.lblTipoContrato.TabIndex = 13;
            this.lblTipoContrato.Text = "Tipo de contrato:";
            // 
            // cboTipoContrato
            // 
            this.cboTipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoContrato.FormattingEnabled = true;
            this.cboTipoContrato.Location = new System.Drawing.Point(19, 44);
            this.cboTipoContrato.Name = "cboTipoContrato";
            this.cboTipoContrato.Size = new System.Drawing.Size(401, 21);
            this.cboTipoContrato.TabIndex = 12;
            this.cboTipoContrato.SelectedIndexChanged += new System.EventHandler(this.cboTipoContrato_SelectedIndexChanged);
            // 
            // lblQtdTEF
            // 
            this.lblQtdTEF.AutoSize = true;
            this.lblQtdTEF.Location = new System.Drawing.Point(18, 81);
            this.lblQtdTEF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQtdTEF.Name = "lblQtdTEF";
            this.lblQtdTEF.Size = new System.Drawing.Size(88, 13);
            this.lblQtdTEF.TabIndex = 4;
            this.lblQtdTEF.Text = "Quantidade TEF:";
            // 
            // cboPacote
            // 
            this.cboPacote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPacote.FormattingEnabled = true;
            this.cboPacote.Location = new System.Drawing.Point(21, 373);
            this.cboPacote.Margin = new System.Windows.Forms.Padding(2);
            this.cboPacote.Name = "cboPacote";
            this.cboPacote.Size = new System.Drawing.Size(308, 21);
            this.cboPacote.TabIndex = 11;
            this.cboPacote.Visible = false;
            // 
            // nudQtdTEF
            // 
            this.nudQtdTEF.Location = new System.Drawing.Point(19, 97);
            this.nudQtdTEF.Margin = new System.Windows.Forms.Padding(2);
            this.nudQtdTEF.Name = "nudQtdTEF";
            this.nudQtdTEF.Size = new System.Drawing.Size(118, 20);
            this.nudQtdTEF.TabIndex = 5;
            // 
            // lblPacote
            // 
            this.lblPacote.AutoSize = true;
            this.lblPacote.Location = new System.Drawing.Point(18, 352);
            this.lblPacote.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPacote.Name = "lblPacote";
            this.lblPacote.Size = new System.Drawing.Size(44, 13);
            this.lblPacote.TabIndex = 10;
            this.lblPacote.Text = "Pacote:";
            this.lblPacote.Visible = false;
            // 
            // lblQtdPDV
            // 
            this.lblQtdPDV.AutoSize = true;
            this.lblQtdPDV.Location = new System.Drawing.Point(152, 81);
            this.lblQtdPDV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQtdPDV.Name = "lblQtdPDV";
            this.lblQtdPDV.Size = new System.Drawing.Size(90, 13);
            this.lblQtdPDV.TabIndex = 6;
            this.lblQtdPDV.Text = "Quantidade PDV:";
            // 
            // nudQtdRetaguarda
            // 
            this.nudQtdRetaguarda.Location = new System.Drawing.Point(297, 97);
            this.nudQtdRetaguarda.Margin = new System.Windows.Forms.Padding(2);
            this.nudQtdRetaguarda.Name = "nudQtdRetaguarda";
            this.nudQtdRetaguarda.Size = new System.Drawing.Size(123, 20);
            this.nudQtdRetaguarda.TabIndex = 9;
            // 
            // nudQtdPDV
            // 
            this.nudQtdPDV.Location = new System.Drawing.Point(155, 97);
            this.nudQtdPDV.Margin = new System.Windows.Forms.Padding(2);
            this.nudQtdPDV.Name = "nudQtdPDV";
            this.nudQtdPDV.Size = new System.Drawing.Size(127, 20);
            this.nudQtdPDV.TabIndex = 7;
            // 
            // lblQtdRetaguarda
            // 
            this.lblQtdRetaguarda.AutoSize = true;
            this.lblQtdRetaguarda.Location = new System.Drawing.Point(294, 81);
            this.lblQtdRetaguarda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQtdRetaguarda.Name = "lblQtdRetaguarda";
            this.lblQtdRetaguarda.Size = new System.Drawing.Size(124, 13);
            this.lblQtdRetaguarda.TabIndex = 8;
            this.lblQtdRetaguarda.Text = "Quantidade Retaguarda:";
            // 
            // tbpContrato
            // 
            this.tbpContrato.Controls.Add(this.txtLocalizacaoContrato);
            this.tbpContrato.Controls.Add(this.lblLocalizacaoContrato);
            this.tbpContrato.Location = new System.Drawing.Point(4, 22);
            this.tbpContrato.Margin = new System.Windows.Forms.Padding(2);
            this.tbpContrato.Name = "tbpContrato";
            this.tbpContrato.Padding = new System.Windows.Forms.Padding(2);
            this.tbpContrato.Size = new System.Drawing.Size(1020, 437);
            this.tbpContrato.TabIndex = 1;
            this.tbpContrato.Text = "Contrato";
            this.tbpContrato.UseVisualStyleBackColor = true;
            // 
            // txtLocalizacaoContrato
            // 
            this.txtLocalizacaoContrato.Location = new System.Drawing.Point(17, 46);
            this.txtLocalizacaoContrato.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocalizacaoContrato.Name = "txtLocalizacaoContrato";
            this.txtLocalizacaoContrato.ReadOnly = true;
            this.txtLocalizacaoContrato.Size = new System.Drawing.Size(532, 20);
            this.txtLocalizacaoContrato.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(158, 27);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Dia do vcto da fatura:";
            // 
            // nudDiaVctoFatura
            // 
            this.nudDiaVctoFatura.Location = new System.Drawing.Point(161, 43);
            this.nudDiaVctoFatura.Margin = new System.Windows.Forms.Padding(2);
            this.nudDiaVctoFatura.Maximum = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.nudDiaVctoFatura.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudDiaVctoFatura.Name = "nudDiaVctoFatura";
            this.nudDiaVctoFatura.Size = new System.Drawing.Size(123, 20);
            this.nudDiaVctoFatura.TabIndex = 24;
            this.nudDiaVctoFatura.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 507);
            this.Controls.Add(this.tbcPrincipal);
            this.Controls.Add(this.btnGeraDocContrato);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar contrato";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbcPrincipal.ResumeLayout(false);
            this.tbpCliente.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdParcelaImplantacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorImplantacao)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorMensal)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdTEF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdRetaguarda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdPDV)).EndInit();
            this.tbpContrato.ResumeLayout(false);
            this.tbpContrato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiaVctoFatura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeraDocContrato;
        private System.Windows.Forms.Label lblLocalizacaoContrato;
        private System.Windows.Forms.OpenFileDialog ofdLocalizacaoContrato;
        private System.Windows.Forms.TabControl tbcPrincipal;
        private System.Windows.Forms.TabPage tbpCliente;
        private System.Windows.Forms.TabPage tbpContrato;
        private System.Windows.Forms.TextBox txtLocalizacaoContrato;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label lblCodCliente;
        private System.Windows.Forms.NumericUpDown nudQtdTEF;
        private System.Windows.Forms.Label lblQtdTEF;
        private System.Windows.Forms.NumericUpDown nudQtdRetaguarda;
        private System.Windows.Forms.Label lblQtdRetaguarda;
        private System.Windows.Forms.NumericUpDown nudQtdPDV;
        private System.Windows.Forms.Label lblQtdPDV;
        private System.Windows.Forms.ComboBox cboPacote;
        private System.Windows.Forms.Label lblPacote;
        private System.Windows.Forms.Label lblTipoContrato;
        private System.Windows.Forms.ComboBox cboTipoContrato;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContatoAC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.ComboBox cboConsultor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudQtdParcelaImplantacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudValorImplantacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nudValorMensal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpDataPrimeiraParcelaImplantacao;
        private System.Windows.Forms.NumericUpDown nudDiaVctoFatura;
        private System.Windows.Forms.Label label9;
    }
}

