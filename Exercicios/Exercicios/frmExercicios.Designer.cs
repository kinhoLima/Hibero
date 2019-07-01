namespace Exercicios
{
    partial class frmExercicios
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
            this.btnConta = new System.Windows.Forms.Button();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConta
            // 
            this.btnConta.Location = new System.Drawing.Point(13, 31);
            this.btnConta.Name = "btnConta";
            this.btnConta.Size = new System.Drawing.Size(110, 57);
            this.btnConta.TabIndex = 0;
            this.btnConta.Text = "Conta";
            this.btnConta.UseVisualStyleBackColor = true;
            this.btnConta.Click += new System.EventHandler(this.btnConta_Click);
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.Location = new System.Drawing.Point(154, 30);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(103, 58);
            this.btnCalculadora.TabIndex = 1;
            this.btnCalculadora.Text = "Calculadora";
            this.btnCalculadora.UseVisualStyleBackColor = true;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // frmExercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnCalculadora);
            this.Controls.Add(this.btnConta);
            this.Name = "frmExercicios";
            this.Text = "frmExercicios";
            this.Load += new System.EventHandler(this.frmExercicios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConta;
        private System.Windows.Forms.Button btnCalculadora;
    }
}