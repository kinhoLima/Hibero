namespace HiberoExtintores
{
    partial class frmPrincipal
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
            this.btnAnotar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnotar
            // 
            this.btnAnotar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAnotar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAnotar.Location = new System.Drawing.Point(12, 12);
            this.btnAnotar.Name = "btnAnotar";
            this.btnAnotar.Size = new System.Drawing.Size(101, 63);
            this.btnAnotar.TabIndex = 0;
            this.btnAnotar.Text = "+";
            this.btnAnotar.UseVisualStyleBackColor = false;
            this.btnAnotar.Click += new System.EventHandler(this.btnAnotar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anotar Extintores";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnotar);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnotar;
        private System.Windows.Forms.Label label1;
    }
}