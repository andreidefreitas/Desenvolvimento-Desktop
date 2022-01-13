using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private double numero1;
        private double numero2;
        private string operacao;
        private double resultado = 0;

        private bool PressionouIgual = false;

        private void LimparCampos()
        {
            txtDisplay.Text = String.Empty;
            numero1 = 0;
            numero2 = 0;
            operacao = string.Empty;
            PressionouIgual = true;
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void AddCaracterNumerico(string num)
        {
            if (PressionouIgual == true)
            {
                txtDisplay.Clear();
                PressionouIgual = false;
            }
            if (txtDisplay.Text.Trim().Equals("0"))
            {
                txtDisplay.Text = num;
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + num;
            }
        }

        private void AddCaracterOperacao(string caractere)
        {
            if (!txtDisplay.Text.Trim().Equals(string.Empty))
            {
                if (txtDisplay.Text.Trim().Contains("."))
                {
                    numero1 = Convert.ToDouble(txtDisplay.Text.Trim().Replace(".", ","));
                }
                else
                {
                    numero1 = Convert.ToDouble(txtDisplay.Text.Trim());
                }
                operacao = caractere;
                txtDisplay.Clear();
            }
            else
            {
                MessageBox.Show("Você deve inserir um valor!");
            }
        }

        private void Calcular()
        {
            switch (operacao)
            {
                case "/":
                    if (numero2 == 0)
                    {
                        MessageBox.Show("Divisão por zero!");
                        break;
                    }
                    resultado = numero1 / numero2;
                    break;

                case "*":
                    resultado = numero1 * numero2;
                    break;

                case "-":
                    resultado = numero1 - numero2; ;
                    break;

                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "^":
                    resultado = CalcularPotencia();
                    break;
            }
            txtDisplay.Text = resultado.ToString().Replace(".",",");
        }

        public double CalcularPotencia()
        {
            return Math.Pow(numero1, numero2);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if(!txtDisplay.Text.Trim().Equals("0"))
            {
                txtDisplay.Text = txtDisplay.Text + "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AddCaracterNumerico("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AddCaracterNumerico("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AddCaracterNumerico("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AddCaracterNumerico("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AddCaracterNumerico("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AddCaracterNumerico("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AddCaracterNumerico("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AddCaracterNumerico("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AddCaracterNumerico("9");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            if (PressionouIgual)
            {
                txtDisplay.Text = "0.";
                PressionouIgual = false;
                return;
            }
            if (txtDisplay.Text.Trim().Equals(string.Empty)) txtDisplay.Text = "0.";
            if (txtDisplay.Text.Trim().Contains(".")) return;

            txtDisplay.Text += ".";
            PressionouIgual = false;
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            AddCaracterOperacao("+");
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            AddCaracterOperacao("-");
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            AddCaracterOperacao("*");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            AddCaracterOperacao("/");
        }

        private void btnRemoveUltimoDigito_Click(object sender, EventArgs e)
        {
            if (operacao.Equals(string.Empty) || PressionouIgual)
            {
                LimparCampos();
            }
            else
            {
                txtDisplay.Clear();
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (PressionouIgual)
            {
                txtDisplay.Clear();
                PressionouIgual = false;
                return;
            }

            if (!txtDisplay.Text.Trim().Equals(string.Empty))
            {
                if (txtDisplay.Text.Trim().Contains("."))
                {
                    numero2 = Convert.ToDouble(txtDisplay.Text.Trim().Replace(".", ","));
                }
                else
                {
                    numero2 = Convert.ToDouble(txtDisplay.Text.Trim());
                }
               
                Calcular();
            }
        }

        private void btnTrocaSinal_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Trim().Equals(String.Empty))
            {
                txtDisplay.Text = (Convert.ToDouble(txtDisplay.Text.Trim().Replace(".", ",")) * (-1)).ToString().Replace(",", ".");
            }
        }

        private void btnRemoveDigito_Click(object sender, EventArgs e)
        {
            int tam = txtDisplay.Text.Trim().Length;
            string texto = txtDisplay.Text.Trim();
            txtDisplay.Clear();

            for(int i = 0; i < tam -1; i++)
            {
                txtDisplay.Text = txtDisplay.Text + texto[i];
            }
        }

        private void btnPotenQuadrado_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Trim().Equals(String.Empty))
            {
                numero1 = Convert.ToDouble(txtDisplay.Text.Trim().Replace(".", ","));
                numero2 = 2;
                resultado = CalcularPotencia();

                txtDisplay.Text = resultado.ToString().Replace(",", ".");
                PressionouIgual = true;
            }
        }

        private void btnPotenciacao_Click(object sender, EventArgs e)
        {
            AddCaracterOperacao("^");
        }

        private void btnRaizQuad_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Trim().Equals(String.Empty))
            {
                numero1 = Convert.ToDouble(txtDisplay.Text.Trim().Replace(".", ","));
                resultado = Math.Sqrt(numero1);

                txtDisplay.Text = resultado.ToString().Replace(",", ".");
                PressionouIgual = true;
            }
        }

        private void btnDividirPor1_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Trim().Equals(String.Empty))
            {
                numero1 = Convert.ToDouble(txtDisplay.Text.Trim().Replace(".", ","));
                if (numero1 == 0)
                {
                    MessageBox.Show("Erro. Divisão por zero!");
                    return;
                }
                resultado = 1 / numero1;
                txtDisplay.Text = resultado.ToString().Replace(",", ".");
                PressionouIgual = true;
            }
        }
    }
}
