
namespace ex11_at_2tri
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
            this.btn1 = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lblInutil2 = new System.Windows.Forms.Label();
            this.lblInutil1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(126, 177);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(146, 39);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Verificar";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(55, 37);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(294, 39);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Pontes Impedidas";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(73, 115);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(34, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Peso:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(214, 115);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(37, 13);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "Altura:";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(76, 131);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 4;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(217, 131);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 5;
            this.txt2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblInutil2
            // 
            this.lblInutil2.AutoSize = true;
            this.lblInutil2.Location = new System.Drawing.Point(323, 138);
            this.lblInutil2.Name = "lblInutil2";
            this.lblInutil2.Size = new System.Drawing.Size(15, 13);
            this.lblInutil2.TabIndex = 6;
            this.lblInutil2.Text = "m";
            // 
            // lblInutil1
            // 
            this.lblInutil1.AutoSize = true;
            this.lblInutil1.Location = new System.Drawing.Point(182, 138);
            this.lblInutil1.Name = "lblInutil1";
            this.lblInutil1.Size = new System.Drawing.Size(10, 13);
            this.lblInutil1.TabIndex = 7;
            this.lblInutil1.Text = "t";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 298);
            this.Controls.Add(this.lblInutil1);
            this.Controls.Add(this.lblInutil2);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lblInutil2;
        private System.Windows.Forms.Label lblInutil1;
    }
}

