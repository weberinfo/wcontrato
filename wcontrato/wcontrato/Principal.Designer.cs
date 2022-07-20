namespace wcontrato
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInicializando = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInicializando
            // 
            this.lblInicializando.AutoSize = true;
            this.lblInicializando.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicializando.Location = new System.Drawing.Point(188, 45);
            this.lblInicializando.Name = "lblInicializando";
            this.lblInicializando.Size = new System.Drawing.Size(170, 29);
            this.lblInicializando.TabIndex = 0;
            this.lblInicializando.Text = "Inicializando....";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 123);
            this.Controls.Add(this.lblInicializando);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicializando";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInicializando;
    }
}