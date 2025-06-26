namespace Heranca
{
    partial class frmConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConta));
            this.btnSacar = new System.Windows.Forms.Button();
            this.gpbInformacoes = new System.Windows.Forms.GroupBox();
            this.rdbContaPoupança = new System.Windows.Forms.RadioButton();
            this.rdbContaCorrente = new System.Windows.Forms.RadioButton();
            this.lblExtrato = new System.Windows.Forms.Label();
            this.ltbExtrato = new System.Windows.Forms.ListBox();
            this.txtTransferir = new System.Windows.Forms.TextBox();
            this.lblTransferir = new System.Windows.Forms.Label();
            this.txtDepositar = new System.Windows.Forms.TextBox();
            this.lblDepositar = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.btnMostrarSaldo = new System.Windows.Forms.Button();
            this.gpbInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(318, 301);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(144, 47);
            this.btnSacar.TabIndex = 0;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnConta_Click);
            // 
            // gpbInformacoes
            // 
            this.gpbInformacoes.BackColor = System.Drawing.Color.LightGray;
            this.gpbInformacoes.Controls.Add(this.rdbContaPoupança);
            this.gpbInformacoes.Controls.Add(this.rdbContaCorrente);
            this.gpbInformacoes.Controls.Add(this.lblExtrato);
            this.gpbInformacoes.Controls.Add(this.ltbExtrato);
            this.gpbInformacoes.Controls.Add(this.txtTransferir);
            this.gpbInformacoes.Controls.Add(this.lblTransferir);
            this.gpbInformacoes.Controls.Add(this.txtDepositar);
            this.gpbInformacoes.Controls.Add(this.lblDepositar);
            this.gpbInformacoes.Controls.Add(this.txtValor);
            this.gpbInformacoes.Controls.Add(this.lblValor);
            this.gpbInformacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInformacoes.Location = new System.Drawing.Point(12, 12);
            this.gpbInformacoes.Name = "gpbInformacoes";
            this.gpbInformacoes.Size = new System.Drawing.Size(600, 278);
            this.gpbInformacoes.TabIndex = 1;
            this.gpbInformacoes.TabStop = false;
            this.gpbInformacoes.Text = "Informações da conta";
            // 
            // rdbContaPoupança
            // 
            this.rdbContaPoupança.AutoSize = true;
            this.rdbContaPoupança.Location = new System.Drawing.Point(223, 173);
            this.rdbContaPoupança.Name = "rdbContaPoupança";
            this.rdbContaPoupança.Size = new System.Drawing.Size(145, 24);
            this.rdbContaPoupança.TabIndex = 9;
            this.rdbContaPoupança.TabStop = true;
            this.rdbContaPoupança.Text = "Conta poupança";
            this.rdbContaPoupança.UseVisualStyleBackColor = true;
            // 
            // rdbContaCorrente
            // 
            this.rdbContaCorrente.AutoSize = true;
            this.rdbContaCorrente.Location = new System.Drawing.Point(223, 118);
            this.rdbContaCorrente.Name = "rdbContaCorrente";
            this.rdbContaCorrente.Size = new System.Drawing.Size(133, 24);
            this.rdbContaCorrente.TabIndex = 8;
            this.rdbContaCorrente.TabStop = true;
            this.rdbContaCorrente.Text = "Conta corrente";
            this.rdbContaCorrente.UseVisualStyleBackColor = true;
            // 
            // lblExtrato
            // 
            this.lblExtrato.AutoSize = true;
            this.lblExtrato.Location = new System.Drawing.Point(421, 56);
            this.lblExtrato.Name = "lblExtrato";
            this.lblExtrato.Size = new System.Drawing.Size(60, 20);
            this.lblExtrato.TabIndex = 7;
            this.lblExtrato.Text = "Extrato";
            // 
            // ltbExtrato
            // 
            this.ltbExtrato.FormattingEnabled = true;
            this.ltbExtrato.ItemHeight = 20;
            this.ltbExtrato.Location = new System.Drawing.Point(421, 88);
            this.ltbExtrato.Name = "ltbExtrato";
            this.ltbExtrato.Size = new System.Drawing.Size(157, 164);
            this.ltbExtrato.TabIndex = 6;
            // 
            // txtTransferir
            // 
            this.txtTransferir.Location = new System.Drawing.Point(18, 244);
            this.txtTransferir.MaxLength = 10;
            this.txtTransferir.Name = "txtTransferir";
            this.txtTransferir.Size = new System.Drawing.Size(144, 26);
            this.txtTransferir.TabIndex = 5;
            // 
            // lblTransferir
            // 
            this.lblTransferir.AutoSize = true;
            this.lblTransferir.Location = new System.Drawing.Point(18, 221);
            this.lblTransferir.Name = "lblTransferir";
            this.lblTransferir.Size = new System.Drawing.Size(76, 20);
            this.lblTransferir.TabIndex = 4;
            this.lblTransferir.Text = "Transferir";
            // 
            // txtDepositar
            // 
            this.txtDepositar.Location = new System.Drawing.Point(18, 166);
            this.txtDepositar.MaxLength = 10;
            this.txtDepositar.Name = "txtDepositar";
            this.txtDepositar.Size = new System.Drawing.Size(144, 26);
            this.txtDepositar.TabIndex = 3;
            // 
            // lblDepositar
            // 
            this.lblDepositar.AutoSize = true;
            this.lblDepositar.Location = new System.Drawing.Point(18, 143);
            this.lblDepositar.Name = "lblDepositar";
            this.lblDepositar.Size = new System.Drawing.Size(78, 20);
            this.lblDepositar.TabIndex = 2;
            this.lblDepositar.Text = "Depositar";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(18, 88);
            this.txtValor.MaxLength = 10;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(144, 26);
            this.txtValor.TabIndex = 1;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(18, 65);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 20);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor";
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(12, 301);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(144, 47);
            this.btnDepositar.TabIndex = 2;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(468, 301);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(144, 47);
            this.btnTransferir.TabIndex = 3;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // btnMostrarSaldo
            // 
            this.btnMostrarSaldo.Location = new System.Drawing.Point(162, 301);
            this.btnMostrarSaldo.Name = "btnMostrarSaldo";
            this.btnMostrarSaldo.Size = new System.Drawing.Size(144, 47);
            this.btnMostrarSaldo.TabIndex = 4;
            this.btnMostrarSaldo.Text = "Mostrar Saldo";
            this.btnMostrarSaldo.UseVisualStyleBackColor = true;
            // 
            // frmConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 360);
            this.Controls.Add(this.btnMostrarSaldo);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.gpbInformacoes);
            this.Controls.Add(this.btnSacar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conta Bancária";
            this.gpbInformacoes.ResumeLayout(false);
            this.gpbInformacoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.GroupBox gpbInformacoes;
        private System.Windows.Forms.Label lblExtrato;
        private System.Windows.Forms.ListBox ltbExtrato;
        private System.Windows.Forms.TextBox txtTransferir;
        private System.Windows.Forms.Label lblTransferir;
        private System.Windows.Forms.TextBox txtDepositar;
        private System.Windows.Forms.Label lblDepositar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.Button btnMostrarSaldo;
        private System.Windows.Forms.RadioButton rdbContaPoupança;
        private System.Windows.Forms.RadioButton rdbContaCorrente;
    }
}