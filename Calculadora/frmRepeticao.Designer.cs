namespace Calculadora
{
    partial class frmRepeticao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepeticao));
            this.cbbCategorias = new System.Windows.Forms.ComboBox();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.ltbCategorias = new System.Windows.Forms.ListBox();
            this.lblListarCategorias = new System.Windows.Forms.Label();
            this.btnListarCategorias = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbCategorias
            // 
            this.cbbCategorias.FormattingEnabled = true;
            this.cbbCategorias.Location = new System.Drawing.Point(61, 51);
            this.cbbCategorias.Name = "cbbCategorias";
            this.cbbCategorias.Size = new System.Drawing.Size(151, 21);
            this.cbbCategorias.TabIndex = 0;
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Location = new System.Drawing.Point(58, 35);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(57, 13);
            this.lblCategorias.TabIndex = 1;
            this.lblCategorias.Text = "Categorias";
            // 
            // btnCategorias
            // 
            this.btnCategorias.Location = new System.Drawing.Point(61, 234);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(151, 39);
            this.btnCategorias.TabIndex = 2;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // ltbCategorias
            // 
            this.ltbCategorias.FormattingEnabled = true;
            this.ltbCategorias.Location = new System.Drawing.Point(383, 51);
            this.ltbCategorias.Name = "ltbCategorias";
            this.ltbCategorias.Size = new System.Drawing.Size(205, 173);
            this.ltbCategorias.TabIndex = 3;
            // 
            // lblListarCategorias
            // 
            this.lblListarCategorias.AutoSize = true;
            this.lblListarCategorias.Location = new System.Drawing.Point(383, 35);
            this.lblListarCategorias.Name = "lblListarCategorias";
            this.lblListarCategorias.Size = new System.Drawing.Size(84, 13);
            this.lblListarCategorias.TabIndex = 4;
            this.lblListarCategorias.Text = "Listar categorias";
            // 
            // btnListarCategorias
            // 
            this.btnListarCategorias.Location = new System.Drawing.Point(383, 234);
            this.btnListarCategorias.Name = "btnListarCategorias";
            this.btnListarCategorias.Size = new System.Drawing.Size(151, 39);
            this.btnListarCategorias.TabIndex = 5;
            this.btnListarCategorias.Text = "Listar categorias";
            this.btnListarCategorias.UseVisualStyleBackColor = true;
            this.btnListarCategorias.Click += new System.EventHandler(this.btnListarCategorias_Click);
            // 
            // frmRepeticao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 314);
            this.Controls.Add(this.btnListarCategorias);
            this.Controls.Add(this.lblListarCategorias);
            this.Controls.Add(this.ltbCategorias);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.lblCategorias);
            this.Controls.Add(this.cbbCategorias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRepeticao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repetição";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbCategorias;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.ListBox ltbCategorias;
        private System.Windows.Forms.Label lblListarCategorias;
        private System.Windows.Forms.Button btnListarCategorias;
    }
}