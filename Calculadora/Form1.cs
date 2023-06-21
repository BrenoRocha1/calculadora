using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora {
    public partial class Calculadora : Form {
        decimal valor2 = 0;
        decimal valor1 = 0;
            string operacao = "";
        string excluir = "";
        public Calculadora() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            //7
            TxtResultado.Text = TxtResultado.Text + "7";
        }

        private void button17_Click(object sender, EventArgs e) {
            //0
            TxtResultado.Text = TxtResultado.Text + "0";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //8
            TxtResultado.Text = TxtResultado.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //9
            TxtResultado.Text = TxtResultado.Text + "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //+
            if (TxtResultado.Text != "")
            {
                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);

                TxtResultado.Text = "";

                operacao = "SOMA";

                labelOperacao.Text = "+";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //CE


           
            TxtResultado.Text = "";


        }

        private void button7_Click(object sender, EventArgs e)
        {
            //4
            TxtResultado.Text = TxtResultado.Text + "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //5
            TxtResultado.Text = TxtResultado.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //6
            TxtResultado.Text = TxtResultado.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //-
            if (TxtResultado.Text != "")
            {
                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);

                TxtResultado.Text = "";

                operacao = "SUBTRACAO";

                labelOperacao.Text = "-";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //c
            TxtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            labelOperacao.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //1
            TxtResultado.Text = TxtResultado.Text + "1";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //2
            TxtResultado.Text = TxtResultado.Text + "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //3
            TxtResultado.Text = TxtResultado.Text + "3";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //x
            if (TxtResultado.Text != "")
            {
                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);

                TxtResultado.Text = "";

                operacao = "MULTIPLICACAO";

                labelOperacao.Text = "x";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //=
            if (TxtResultado.Text != "")
            {
                valor2 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);
                if (operacao == "SOMA")
                {
                    TxtResultado.Text = Convert.ToString(valor1 + valor2);
                }
                else if (operacao == "SUBTRACAO")
                {

                    TxtResultado.Text = Convert.ToString(valor1 - valor2);
                }
                else if (operacao == "MULTIPLICACAO")
                {
                    TxtResultado.Text = Convert.ToString(valor1 * valor2);
                }
                else if (operacao == "DIVISAO")
                {
                    TxtResultado.Text = Convert.ToString(valor1 / valor2);
                }
            }
        }
        private void button19_Click(object sender, EventArgs e)
        {
            //.
            //2
            TxtResultado.Text = TxtResultado.Text + ".";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // /
            if (TxtResultado.Text != "")
            {
                valor1 = decimal.Parse(TxtResultado.Text, CultureInfo.InvariantCulture);

                TxtResultado.Text = "";

                operacao = "DIVISAO";

                labelOperacao.Text = "/";
            }
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
