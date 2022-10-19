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
            this.lblTipoContrato = new System.Windows.Forms.Label();
            this.cboTipoContrato = new System.Windows.Forms.ComboBox();
            this.cboPacote = new System.Windows.Forms.ComboBox();
            this.lblPacote = new System.Windows.Forms.Label();
            this.nudQtdRetaguarda = new System.Windows.Forms.NumericUpDown();
            this.lblQtdRetaguarda = new System.Windows.Forms.Label();
            this.nudQtdPDV = new System.Windows.Forms.NumericUpDown();
            this.lblQtdPDV = new System.Windows.Forms.Label();
            this.nudQtdTEF = new System.Windows.Forms.NumericUpDown();
            this.lblQtdTEF = new System.Windows.Forms.Label();
            this.nudValorMensal = new System.Windows.Forms.NumericUpDown();
            this.lblValorMensal = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.tbpContrato = new System.Windows.Forms.TabPage();
            this.txtLocalizacaoContrato = new System.Windows.Forms.TextBox();
            this.tbcPrincipal.SuspendLayout();
            this.tbpCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdRetaguarda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdPDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdTEF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorMensal)).BeginInit();
            this.tbpContrato.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGeraDocContrato
            // 
            this.btnGeraDocContrato.Location = new System.Drawing.Point(649, 415);
            this.btnGeraDocContrato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGeraDocContrato.Name = "btnGeraDocContrato";
            this.btnGeraDocContrato.Size = new System.Drawing.Size(128, 23);
            this.btnGeraDocContrato.TabIndex = 0;
            this.btnGeraDocContrato.Text = "Gerar contrato";
            this.btnGeraDocContrato.UseVisualStyleBackColor = true;
            this.btnGeraDocContrato.Click += new System.EventHandler(this.btnGeraDocContrato_Click);
            // 
            // lblLocalizacaoContrato
            // 
            this.lblLocalizacaoContrato.AutoSize = true;
            this.lblLocalizacaoContrato.Location = new System.Drawing.Point(20, 27);
            this.lblLocalizacaoContrato.Name = "lblLocalizacaoContrato";
            this.lblLocalizacaoContrato.Size = new System.Drawing.Size(16, 16);
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
            this.tbcPrincipal.Location = new System.Drawing.Point(15, 12);
            this.tbcPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(763, 398);
            this.tbcPrincipal.TabIndex = 5;
            // 
            // tbpCliente
            // 
            this.tbpCliente.Controls.Add(this.lblTipoContrato);
            this.tbpCliente.Controls.Add(this.cboTipoContrato);
            this.tbpCliente.Controls.Add(this.cboPacote);
            this.tbpCliente.Controls.Add(this.lblPacote);
            this.tbpCliente.Controls.Add(this.nudQtdRetaguarda);
            this.tbpCliente.Controls.Add(this.lblQtdRetaguarda);
            this.tbpCliente.Controls.Add(this.nudQtdPDV);
            this.tbpCliente.Controls.Add(this.lblQtdPDV);
            this.tbpCliente.Controls.Add(this.nudQtdTEF);
            this.tbpCliente.Controls.Add(this.lblQtdTEF);
            this.tbpCliente.Controls.Add(this.nudValorMensal);
            this.tbpCliente.Controls.Add(this.lblValorMensal);
            this.tbpCliente.Controls.Add(this.txtCodCliente);
            this.tbpCliente.Controls.Add(this.lblCodCliente);
            this.tbpCliente.Location = new System.Drawing.Point(4, 25);
            this.tbpCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpCliente.Name = "tbpCliente";
            this.tbpCliente.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpCliente.Size = new System.Drawing.Size(755, 369);
            this.tbpCliente.TabIndex = 0;
            this.tbpCliente.Text = "Cliente";
            this.tbpCliente.UseVisualStyleBackColor = true;
            // 
            // lblTipoContrato
            // 
            this.lblTipoContrato.AutoSize = true;
            this.lblTipoContrato.Location = new System.Drawing.Point(245, 22);
            this.lblTipoContrato.Name = "lblTipoContrato";
            this.lblTipoContrato.Size = new System.Drawing.Size(108, 16);
            this.lblTipoContrato.TabIndex = 13;
            this.lblTipoContrato.Text = "Tipo de contrato:";
            // 
            // cboTipoContrato
            // 
            this.cboTipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoContrato.FormattingEnabled = true;
            this.cboTipoContrato.Location = new System.Drawing.Point(249, 44);
            this.cboTipoContrato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTipoContrato.Name = "cboTipoContrato";
            this.cboTipoContrato.Size = new System.Drawing.Size(160, 24);
            this.cboTipoContrato.TabIndex = 12;
            // 
            // cboPacote
            // 
            this.cboPacote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPacote.FormattingEnabled = true;
            this.cboPacote.Location = new System.Drawing.Point(28, 251);
            this.cboPacote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPacote.Name = "cboPacote";
            this.cboPacote.Size = new System.Drawing.Size(260, 24);
            this.cboPacote.TabIndex = 11;
            // 
            // lblPacote
            // 
            this.lblPacote.AutoSize = true;
            this.lblPacote.Location = new System.Drawing.Point(25, 231);
            this.lblPacote.Name = "lblPacote";
            this.lblPacote.Size = new System.Drawing.Size(53, 16);
            this.lblPacote.TabIndex = 10;
            this.lblPacote.Text = "Pacote:";
            // 
            // nudQtdRetaguarda
            // 
            this.nudQtdRetaguarda.Location = new System.Drawing.Point(319, 183);
            this.nudQtdRetaguarda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudQtdRetaguarda.Name = "nudQtdRetaguarda";
            this.nudQtdRetaguarda.Size = new System.Drawing.Size(120, 22);
            this.nudQtdRetaguarda.TabIndex = 9;
            // 
            // lblQtdRetaguarda
            // 
            this.lblQtdRetaguarda.AutoSize = true;
            this.lblQtdRetaguarda.Location = new System.Drawing.Point(316, 164);
            this.lblQtdRetaguarda.Name = "lblQtdRetaguarda";
            this.lblQtdRetaguarda.Size = new System.Drawing.Size(155, 16);
            this.lblQtdRetaguarda.TabIndex = 8;
            this.lblQtdRetaguarda.Text = "Quantidade Retaguarda:";
            // 
            // nudQtdPDV
            // 
            this.nudQtdPDV.Location = new System.Drawing.Point(168, 182);
            this.nudQtdPDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudQtdPDV.Name = "nudQtdPDV";
            this.nudQtdPDV.Size = new System.Drawing.Size(120, 22);
            this.nudQtdPDV.TabIndex = 7;
            // 
            // lblQtdPDV
            // 
            this.lblQtdPDV.AutoSize = true;
            this.lblQtdPDV.Location = new System.Drawing.Point(165, 162);
            this.lblQtdPDV.Name = "lblQtdPDV";
            this.lblQtdPDV.Size = new System.Drawing.Size(111, 16);
            this.lblQtdPDV.TabIndex = 6;
            this.lblQtdPDV.Text = "Quantidade PDV:";
            // 
            // nudQtdTEF
            // 
            this.nudQtdTEF.Location = new System.Drawing.Point(25, 182);
            this.nudQtdTEF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudQtdTEF.Name = "nudQtdTEF";
            this.nudQtdTEF.Size = new System.Drawing.Size(120, 22);
            this.nudQtdTEF.TabIndex = 5;
            // 
            // lblQtdTEF
            // 
            this.lblQtdTEF.AutoSize = true;
            this.lblQtdTEF.Location = new System.Drawing.Point(21, 162);
            this.lblQtdTEF.Name = "lblQtdTEF";
            this.lblQtdTEF.Size = new System.Drawing.Size(109, 16);
            this.lblQtdTEF.TabIndex = 4;
            this.lblQtdTEF.Text = "Quantidade TEF:";
            // 
            // nudValorMensal
            // 
            this.nudValorMensal.DecimalPlaces = 2;
            this.nudValorMensal.Location = new System.Drawing.Point(25, 113);
            this.nudValorMensal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudValorMensal.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudValorMensal.Name = "nudValorMensal";
            this.nudValorMensal.Size = new System.Drawing.Size(120, 22);
            this.nudValorMensal.TabIndex = 3;
            // 
            // lblValorMensal
            // 
            this.lblValorMensal.AutoSize = true;
            this.lblValorMensal.Location = new System.Drawing.Point(21, 94);
            this.lblValorMensal.Name = "lblValorMensal";
            this.lblValorMensal.Size = new System.Drawing.Size(89, 16);
            this.lblValorMensal.TabIndex = 2;
            this.lblValorMensal.Text = "Valor mensal:";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(25, 46);
            this.txtCodCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(120, 22);
            this.txtCodCliente.TabIndex = 1;
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.Location = new System.Drawing.Point(21, 27);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(159, 16);
            this.lblCodCliente.TabIndex = 0;
            this.lblCodCliente.Text = "Código do cliente Weber:";
            // 
            // tbpContrato
            // 
            this.tbpContrato.Controls.Add(this.txtLocalizacaoContrato);
            this.tbpContrato.Controls.Add(this.lblLocalizacaoContrato);
            this.tbpContrato.Location = new System.Drawing.Point(4, 25);
            this.tbpContrato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpContrato.Name = "tbpContrato";
            this.tbpContrato.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbpContrato.Size = new System.Drawing.Size(755, 369);
            this.tbpContrato.TabIndex = 1;
            this.tbpContrato.Text = "Contrato";
            this.tbpContrato.UseVisualStyleBackColor = true;
            // 
            // txtLocalizacaoContrato
            // 
            this.txtLocalizacaoContrato.Location = new System.Drawing.Point(23, 57);
            this.txtLocalizacaoContrato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLocalizacaoContrato.Name = "txtLocalizacaoContrato";
            this.txtLocalizacaoContrato.ReadOnly = true;
            this.txtLocalizacaoContrato.Size = new System.Drawing.Size(708, 22);
            this.txtLocalizacaoContrato.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.tbcPrincipal);
            this.Controls.Add(this.btnGeraDocContrato);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar contrato";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbcPrincipal.ResumeLayout(false);
            this.tbpCliente.ResumeLayout(false);
            this.tbpCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdRetaguarda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdPDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdTEF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorMensal)).EndInit();
            this.tbpContrato.ResumeLayout(false);
            this.tbpContrato.PerformLayout();
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
        private System.Windows.Forms.NumericUpDown nudValorMensal;
        private System.Windows.Forms.Label lblValorMensal;
        private System.Windows.Forms.NumericUpDown nudQtdRetaguarda;
        private System.Windows.Forms.Label lblQtdRetaguarda;
        private System.Windows.Forms.NumericUpDown nudQtdPDV;
        private System.Windows.Forms.Label lblQtdPDV;
        private System.Windows.Forms.ComboBox cboPacote;
        private System.Windows.Forms.Label lblPacote;
        private System.Windows.Forms.Label lblTipoContrato;
        private System.Windows.Forms.ComboBox cboTipoContrato;
    }
}

