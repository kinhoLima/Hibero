namespace Exercicios
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoSaque = new System.Windows.Forms.RadioButton();
            this.rdoDeposito = new System.Windows.Forms.RadioButton();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblMostrarSaldo = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seu saldo é: R$ ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor";
            // 
            // rdoSaque
            // 
            this.rdoSaque.AutoSize = true;
            this.rdoSaque.Checked = true;
            this.rdoSaque.Location = new System.Drawing.Point(55, 69);
            this.rdoSaque.Name = "rdoSaque";
            this.rdoSaque.Size = new System.Drawing.Size(53, 17);
            this.rdoSaque.TabIndex = 4;
            this.rdoSaque.TabStop = true;
            this.rdoSaque.Text = "Sacar";
            this.rdoSaque.UseVisualStyleBackColor = true;
            this.rdoSaque.CheckedChanged += new System.EventHandler(this.rdoSaque_CheckedChanged);
            // 
            // rdoDeposito
            // 
            this.rdoDeposito.AutoSize = true;
            this.rdoDeposito.Location = new System.Drawing.Point(146, 69);
            this.rdoDeposito.Name = "rdoDeposito";
            this.rdoDeposito.Size = new System.Drawing.Size(70, 17);
            this.rdoDeposito.TabIndex = 5;
            this.rdoDeposito.Text = "Depositar";
            this.rdoDeposito.UseVisualStyleBackColor = true;
            this.rdoDeposito.CheckedChanged += new System.EventHandler(this.rdoDeposito_CheckedChanged);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(85, 42);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(0, 13);
            this.lblSaldo.TabIndex = 6;
            // 
            // lblMostrarSaldo
            // 
            this.lblMostrarSaldo.AutoSize = true;
            this.lblMostrarSaldo.ForeColor = System.Drawing.Color.Black;
            this.lblMostrarSaldo.Location = new System.Drawing.Point(114, 29);
            this.lblMostrarSaldo.Name = "lblMostrarSaldo";
            this.lblMostrarSaldo.Size = new System.Drawing.Size(28, 13);
            this.lblMostrarSaldo.TabIndex = 7;
            this.lblMostrarSaldo.Text = "0,00";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Location = new System.Drawing.Point(168, 114);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 23);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Sacar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            this.btnSalvar.MouseEnter += new System.EventHandler(this.btnSalvar_MouseEnter);
            this.btnSalvar.MouseLeave += new System.EventHandler(this.btnSalvar_MouseLeave);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Yellow;
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(254, 114);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(71, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(50, 119);
            this.txtValor.Mask = "000,00";
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 10;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 273);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblMostrarSaldo);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.rdoDeposito);
            this.Controls.Add(this.rdoSaque);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoSaque;
        private System.Windows.Forms.RadioButton rdoDeposito;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblMostrarSaldo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MaskedTextBox txtValor;
    }
}

