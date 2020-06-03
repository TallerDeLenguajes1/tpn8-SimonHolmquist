using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Calculadora Calculator = new Calculadora();
        private List<Calculadora> historial = new List<Calculadora>();

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                if (textBox1.Text.Length < 25) textBox1.Text += (e.KeyValue - 48);
            }
            else if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                if (textBox1.Text.Length > 0) textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            else if(e.KeyCode == Keys.Oemcomma)
            {
                if (textBox1.Text.Length < 25 && !textBox1.Text.Contains(','))
                {
                    if (textBox1.Text.Length == 0) textBox1.Text = "0";
                    textBox1.Text += ",";
                }
            }
            else if(e.KeyCode == Keys.Oemplus)
            {
                Operacion('+');
            }
            else if(e.KeyCode == Keys.OemMinus)
            {
                Operacion('-');
            }
            else if(e.KeyCode == Keys.Enter)
            {
                if (Calculator.Numero1 >= 0 && textBox1.Text.Length > 0)
                {
                    Calculator.Numero2 = Convert.ToDouble(textBox1.Text);
                    switch (Calculator.Operador)
                    {
                        case '+':
                            textBox1.Text = Calculator.Suma().ToString();
                            break;
                        case '-':
                            textBox1.Text = Calculator.Resta().ToString();
                            break;
                        case '*':
                            textBox1.Text = Calculator.Multiplicacion().ToString();
                            break;
                        case '/':
                            if (Calculator.Numero2 != 0)
                            {
                                textBox1.Text = Calculator.Division().ToString();
                            }
                            break;
                        default:
                            break;
                    }
                    Calculator.Resultado = Convert.ToDouble(textBox1.Text);
                    Calculator.Hora = DateTime.Now;
                    historial.Add(Calculator);
                    listBox1.DataSource = null;
                    listBox1.DataSource = historial;
                    Calculator = new Calculadora();
                }
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 25) textBox1.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 25) textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 25) textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 25) textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 25) textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 25) textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 25) textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 25) textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 25) textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 25) textBox1.Text += "9";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Operacion('+');
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            Operacion('-');
        }
        private void buttonProd_Click(object sender, EventArgs e)
        {
            Operacion('*');
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            Operacion('/');
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if(Calculator.Numero1>=0 && textBox1.Text.Length>0)
            {
                Calculator.Numero2 = Convert.ToDouble(textBox1.Text);
                switch (Calculator.Operador)
                {
                    case '+':
                        textBox1.Text = Calculator.Suma().ToString();
                        break;
                    case '-':
                        textBox1.Text = Calculator.Resta().ToString();
                        break;
                    case '*':
                        textBox1.Text = Calculator.Multiplicacion().ToString();
                        break;
                    case '/':
                        if (Calculator.Numero2 != 0)
                        {
                            textBox1.Text = Calculator.Division().ToString();
                        }
                        break;
                    default:
                        break;
                }
                Calculator.Resultado = Convert.ToDouble(textBox1.Text);
                Calculator.Hora = DateTime.Now;
                historial.Add(Calculator);
                listBox1.DataSource = null;
                listBox1.DataSource = historial;
                Calculator = new Calculadora();
            }
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 25 && !textBox1.Text.Contains(','))
            {
                if (textBox1.Text.Length == 0) textBox1.Text = "0";
                textBox1.Text += ",";
            }
        }

        private void Operacion(char c)
        {
            if (textBox1.Text.Length > 0)
            {
                if (Calculator.Numero1 < 0)
                {
                    Calculator.Numero1 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = "";
                }
                Calculator.Operador = c;
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            historial.Clear();
            listBox1.DataSource = null;
        }
    }
}
