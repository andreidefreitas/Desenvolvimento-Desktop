namespace Calculadora
{
    partial class frmCalculadora
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
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPonto = new System.Windows.Forms.Button();
            this.btnAdicao = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnDividirPor1 = new System.Windows.Forms.Button();
            this.btnRaizQuad = new System.Windows.Forms.Button();
            this.btnPotenciacao = new System.Windows.Forms.Button();
            this.btnPotenQuadrado = new System.Windows.Forms.Button();
            this.btnRemoveDigito = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnTrocaSinal = new System.Windows.Forms.Button();
            this.btnRemoveUltimoDigito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(92, 121);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 38);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(173, 121);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 38);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(173, 165);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 38);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(92, 165);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 38);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(11, 165);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 38);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(173, 209);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 38);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(92, 209);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 38);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(11, 209);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 38);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(11, 121);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 38);
            this.btn1.TabIndex = 9;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Enabled = false;
            this.txtDisplay.Font = new System.Drawing.Font("Lucida Console", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.MaxLength = 10;
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(398, 48);
            this.txtDisplay.TabIndex = 10;
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(12, 253);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(155, 38);
            this.btn0.TabIndex = 11;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnPonto
            // 
            this.btnPonto.Location = new System.Drawing.Point(173, 253);
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Size = new System.Drawing.Size(75, 38);
            this.btnPonto.TabIndex = 12;
            this.btnPonto.Text = ".";
            this.btnPonto.UseVisualStyleBackColor = true;
            this.btnPonto.Click += new System.EventHandler(this.btnPonto_Click);
            // 
            // btnAdicao
            // 
            this.btnAdicao.Location = new System.Drawing.Point(254, 253);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(75, 38);
            this.btnAdicao.TabIndex = 16;
            this.btnAdicao.Text = "+";
            this.btnAdicao.UseVisualStyleBackColor = true;
            this.btnAdicao.Click += new System.EventHandler(this.btnAdicao_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Location = new System.Drawing.Point(254, 209);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(75, 38);
            this.btnSubtracao.TabIndex = 15;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Location = new System.Drawing.Point(254, 165);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(75, 38);
            this.btnMultiplicacao.TabIndex = 14;
            this.btnMultiplicacao.Text = "*";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(254, 121);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(75, 38);
            this.btnDivisao.TabIndex = 13;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(335, 253);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(75, 38);
            this.btnIgual.TabIndex = 20;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnDividirPor1
            // 
            this.btnDividirPor1.Location = new System.Drawing.Point(335, 209);
            this.btnDividirPor1.Name = "btnDividirPor1";
            this.btnDividirPor1.Size = new System.Drawing.Size(75, 38);
            this.btnDividirPor1.TabIndex = 19;
            this.btnDividirPor1.Text = "1/x";
            this.btnDividirPor1.UseVisualStyleBackColor = true;
            this.btnDividirPor1.Click += new System.EventHandler(this.btnDividirPor1_Click);
            // 
            // btnRaizQuad
            // 
            this.btnRaizQuad.Location = new System.Drawing.Point(335, 165);
            this.btnRaizQuad.Name = "btnRaizQuad";
            this.btnRaizQuad.Size = new System.Drawing.Size(75, 38);
            this.btnRaizQuad.TabIndex = 18;
            this.btnRaizQuad.Text = "sqrt";
            this.btnRaizQuad.UseVisualStyleBackColor = true;
            this.btnRaizQuad.Click += new System.EventHandler(this.btnRaizQuad_Click);
            // 
            // btnPotenciacao
            // 
            this.btnPotenciacao.Location = new System.Drawing.Point(335, 121);
            this.btnPotenciacao.Name = "btnPotenciacao";
            this.btnPotenciacao.Size = new System.Drawing.Size(75, 38);
            this.btnPotenciacao.TabIndex = 17;
            this.btnPotenciacao.Text = "^";
            this.btnPotenciacao.UseVisualStyleBackColor = true;
            this.btnPotenciacao.Click += new System.EventHandler(this.btnPotenciacao_Click);
            // 
            // btnPotenQuadrado
            // 
            this.btnPotenQuadrado.Location = new System.Drawing.Point(335, 77);
            this.btnPotenQuadrado.Name = "btnPotenQuadrado";
            this.btnPotenQuadrado.Size = new System.Drawing.Size(75, 38);
            this.btnPotenQuadrado.TabIndex = 25;
            this.btnPotenQuadrado.Text = "^2";
            this.btnPotenQuadrado.UseVisualStyleBackColor = true;
            this.btnPotenQuadrado.Click += new System.EventHandler(this.btnPotenQuadrado_Click);
            // 
            // btnRemoveDigito
            // 
            this.btnRemoveDigito.Location = new System.Drawing.Point(254, 77);
            this.btnRemoveDigito.Name = "btnRemoveDigito";
            this.btnRemoveDigito.Size = new System.Drawing.Size(75, 38);
            this.btnRemoveDigito.TabIndex = 24;
            this.btnRemoveDigito.Text = "<--";
            this.btnRemoveDigito.UseVisualStyleBackColor = true;
            this.btnRemoveDigito.Click += new System.EventHandler(this.btnRemoveDigito_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(11, 77);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 38);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnTrocaSinal
            // 
            this.btnTrocaSinal.Location = new System.Drawing.Point(173, 77);
            this.btnTrocaSinal.Name = "btnTrocaSinal";
            this.btnTrocaSinal.Size = new System.Drawing.Size(75, 38);
            this.btnTrocaSinal.TabIndex = 22;
            this.btnTrocaSinal.Text = "+-";
            this.btnTrocaSinal.UseVisualStyleBackColor = true;
            this.btnTrocaSinal.Click += new System.EventHandler(this.btnTrocaSinal_Click);
            // 
            // btnRemoveUltimoDigito
            // 
            this.btnRemoveUltimoDigito.Location = new System.Drawing.Point(92, 77);
            this.btnRemoveUltimoDigito.Name = "btnRemoveUltimoDigito";
            this.btnRemoveUltimoDigito.Size = new System.Drawing.Size(75, 38);
            this.btnRemoveUltimoDigito.TabIndex = 21;
            this.btnRemoveUltimoDigito.Text = "CE";
            this.btnRemoveUltimoDigito.UseVisualStyleBackColor = true;
            this.btnRemoveUltimoDigito.Click += new System.EventHandler(this.btnRemoveUltimoDigito_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(419, 301);
            this.Controls.Add(this.btnPotenQuadrado);
            this.Controls.Add(this.btnRemoveDigito);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTrocaSinal);
            this.Controls.Add(this.btnRemoveUltimoDigito);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnDividirPor1);
            this.Controls.Add(this.btnRaizQuad);
            this.Controls.Add(this.btnPotenciacao);
            this.Controls.Add(this.btnAdicao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnPonto);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.frmCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPonto;
        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnDividirPor1;
        private System.Windows.Forms.Button btnRaizQuad;
        private System.Windows.Forms.Button btnPotenciacao;
        private System.Windows.Forms.Button btnPotenQuadrado;
        private System.Windows.Forms.Button btnRemoveDigito;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnTrocaSinal;
        private System.Windows.Forms.Button btnRemoveUltimoDigito;
    }
}

