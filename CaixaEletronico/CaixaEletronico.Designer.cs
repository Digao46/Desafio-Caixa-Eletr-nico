namespace CaixaEletronico
{
    partial class CaixaEletronico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaixaEletronico));
            this.lbWithdraw = new System.Windows.Forms.Label();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lbNotas100 = new System.Windows.Forms.Label();
            this.lbNotas50 = new System.Windows.Forms.Label();
            this.lbNotas2 = new System.Windows.Forms.Label();
            this.lbNotas5 = new System.Windows.Forms.Label();
            this.lbNotas10 = new System.Windows.Forms.Label();
            this.lbNotas20 = new System.Windows.Forms.Label();
            this.txt100 = new System.Windows.Forms.TextBox();
            this.txt50 = new System.Windows.Forms.TextBox();
            this.txt20 = new System.Windows.Forms.TextBox();
            this.txt10 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbWithdraw
            // 
            this.lbWithdraw.AutoSize = true;
            this.lbWithdraw.Location = new System.Drawing.Point(30, 65);
            this.lbWithdraw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWithdraw.Name = "lbWithdraw";
            this.lbWithdraw.Size = new System.Drawing.Size(199, 20);
            this.lbWithdraw.TabIndex = 0;
            this.lbWithdraw.Text = "Digite o valor a ser sacado:";
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Location = new System.Drawing.Point(207, 88);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(149, 26);
            this.txtWithdraw.TabIndex = 1;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(195, 141);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(174, 28);
            this.btnWithdraw.TabIndex = 2;
            this.btnWithdraw.Text = "Sacar";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // lbNotas100
            // 
            this.lbNotas100.AutoSize = true;
            this.lbNotas100.Location = new System.Drawing.Point(75, 208);
            this.lbNotas100.Name = "lbNotas100";
            this.lbNotas100.Size = new System.Drawing.Size(104, 20);
            this.lbNotas100.TabIndex = 3;
            this.lbNotas100.Text = "Notas de 100";
            // 
            // lbNotas50
            // 
            this.lbNotas50.AutoSize = true;
            this.lbNotas50.Location = new System.Drawing.Point(84, 277);
            this.lbNotas50.Name = "lbNotas50";
            this.lbNotas50.Size = new System.Drawing.Size(95, 20);
            this.lbNotas50.TabIndex = 4;
            this.lbNotas50.Text = "Notas de 50";
            // 
            // lbNotas2
            // 
            this.lbNotas2.AutoSize = true;
            this.lbNotas2.Location = new System.Drawing.Point(359, 349);
            this.lbNotas2.Name = "lbNotas2";
            this.lbNotas2.Size = new System.Drawing.Size(86, 20);
            this.lbNotas2.TabIndex = 6;
            this.lbNotas2.Text = "Notas de 2";
            // 
            // lbNotas5
            // 
            this.lbNotas5.AutoSize = true;
            this.lbNotas5.Location = new System.Drawing.Point(359, 277);
            this.lbNotas5.Name = "lbNotas5";
            this.lbNotas5.Size = new System.Drawing.Size(86, 20);
            this.lbNotas5.TabIndex = 7;
            this.lbNotas5.Text = "Notas de 5";
            // 
            // lbNotas10
            // 
            this.lbNotas10.AutoSize = true;
            this.lbNotas10.Location = new System.Drawing.Point(359, 208);
            this.lbNotas10.Name = "lbNotas10";
            this.lbNotas10.Size = new System.Drawing.Size(95, 20);
            this.lbNotas10.TabIndex = 8;
            this.lbNotas10.Text = "Notas de 10";
            // 
            // lbNotas20
            // 
            this.lbNotas20.AutoSize = true;
            this.lbNotas20.Location = new System.Drawing.Point(84, 349);
            this.lbNotas20.Name = "lbNotas20";
            this.lbNotas20.Size = new System.Drawing.Size(95, 20);
            this.lbNotas20.TabIndex = 9;
            this.lbNotas20.Text = "Notas de 20";
            // 
            // txt100
            // 
            this.txt100.Location = new System.Drawing.Point(79, 231);
            this.txt100.Name = "txt100";
            this.txt100.ReadOnly = true;
            this.txt100.Size = new System.Drawing.Size(100, 26);
            this.txt100.TabIndex = 10;
            this.txt100.Text = "0";
            // 
            // txt50
            // 
            this.txt50.Location = new System.Drawing.Point(79, 300);
            this.txt50.Name = "txt50";
            this.txt50.ReadOnly = true;
            this.txt50.Size = new System.Drawing.Size(100, 26);
            this.txt50.TabIndex = 11;
            this.txt50.Text = "0";
            // 
            // txt20
            // 
            this.txt20.Location = new System.Drawing.Point(79, 372);
            this.txt20.Name = "txt20";
            this.txt20.ReadOnly = true;
            this.txt20.Size = new System.Drawing.Size(100, 26);
            this.txt20.TabIndex = 12;
            this.txt20.Text = "0";
            // 
            // txt10
            // 
            this.txt10.Location = new System.Drawing.Point(354, 231);
            this.txt10.Name = "txt10";
            this.txt10.ReadOnly = true;
            this.txt10.Size = new System.Drawing.Size(100, 26);
            this.txt10.TabIndex = 13;
            this.txt10.Text = "0";
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(354, 300);
            this.txt5.Name = "txt5";
            this.txt5.ReadOnly = true;
            this.txt5.Size = new System.Drawing.Size(100, 26);
            this.txt5.TabIndex = 14;
            this.txt5.Text = "0";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(354, 372);
            this.txt2.Name = "txt2";
            this.txt2.ReadOnly = true;
            this.txt2.Size = new System.Drawing.Size(100, 26);
            this.txt2.TabIndex = 15;
            this.txt2.Text = "0";
            // 
            // CaixaEletronico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 452);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt10);
            this.Controls.Add(this.txt20);
            this.Controls.Add(this.txt50);
            this.Controls.Add(this.txt100);
            this.Controls.Add(this.lbNotas20);
            this.Controls.Add(this.lbNotas10);
            this.Controls.Add(this.lbNotas5);
            this.Controls.Add(this.lbNotas2);
            this.Controls.Add(this.lbNotas50);
            this.Controls.Add(this.lbNotas100);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.txtWithdraw);
            this.Controls.Add(this.lbWithdraw);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CaixaEletronico";
            this.Text = "Caixa Eletronico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWithdraw;
        private System.Windows.Forms.TextBox txtWithdraw;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label lbNotas100;
        private System.Windows.Forms.Label lbNotas50;
        private System.Windows.Forms.Label lbNotas2;
        private System.Windows.Forms.Label lbNotas5;
        private System.Windows.Forms.Label lbNotas10;
        private System.Windows.Forms.Label lbNotas20;
        private System.Windows.Forms.TextBox txt100;
        private System.Windows.Forms.TextBox txt50;
        private System.Windows.Forms.TextBox txt20;
        private System.Windows.Forms.TextBox txt10;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt2;
    }
}

