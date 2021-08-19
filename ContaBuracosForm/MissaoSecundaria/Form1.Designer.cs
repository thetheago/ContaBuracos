
namespace MissaoSecundaria
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbTexto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbBuracos = new System.Windows.Forms.Label();
            this.lbPalavras = new System.Windows.Forms.Label();
            this.lbLetras = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTexto
            // 
            this.tbTexto.Location = new System.Drawing.Point(172, 165);
            this.tbTexto.Name = "tbTexto";
            this.tbTexto.Size = new System.Drawing.Size(437, 23);
            this.tbTexto.TabIndex = 0;
            this.tbTexto.TextChanged += new System.EventHandler(this.tbTexto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite um texto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número de buracos :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Número de palavras :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Número de letras :";
            // 
            // lbBuracos
            // 
            this.lbBuracos.AutoSize = true;
            this.lbBuracos.Location = new System.Drawing.Point(296, 262);
            this.lbBuracos.Name = "lbBuracos";
            this.lbBuracos.Size = new System.Drawing.Size(0, 15);
            this.lbBuracos.TabIndex = 5;
            // 
            // lbPalavras
            // 
            this.lbPalavras.AutoSize = true;
            this.lbPalavras.Location = new System.Drawing.Point(297, 302);
            this.lbPalavras.Name = "lbPalavras";
            this.lbPalavras.Size = new System.Drawing.Size(0, 15);
            this.lbPalavras.TabIndex = 6;
            // 
            // lbLetras
            // 
            this.lbLetras.AutoSize = true;
            this.lbLetras.Location = new System.Drawing.Point(282, 340);
            this.lbLetras.Name = "lbLetras";
            this.lbLetras.Size = new System.Drawing.Size(0, 15);
            this.lbLetras.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Analisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 447);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbLetras);
            this.Controls.Add(this.lbPalavras);
            this.Controls.Add(this.lbBuracos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTexto);
            this.Name = "Inicio";
            this.Text = "Hmb Teste Thiago";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbBuracos;
        private System.Windows.Forms.Label lbPalavras;
        private System.Windows.Forms.Label lbLetras;
        private System.Windows.Forms.Button button1;
    }
}

