using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class Form1 : Form
    {
        // lista de opções
        enum Operacoes
        {
            Soma,
            Subtrai,
            Multiplica,
            Divide,
            Nenhuma
        }

        static Operacoes ultimaOperacao = Operacoes.Nenhuma;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Se a ultima operação for diferente de nenhuma.
            if (ultimaOperacao != Operacoes.Nenhuma)
            {
                FazerCalculo(ultimaOperacao);
            }
            ultimaOperacao = Operacoes.Nenhuma;

        }

        private void buttonDeleta_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
            ultimaOperacao = Operacoes.Nenhuma;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacoes.Nenhuma)
            {
                ultimaOperacao = Operacoes.Subtrai;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }

            textBoxDisplay.Text += (sender as Button).Text;

        }

        private void buttonApaga_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text.Length > 0)
            {
                textBoxDisplay.Text = textBoxDisplay.Text.Remove(textBoxDisplay.Text.Length - 1, 1);
            }
            else
            {
                return;
            }
        }

        private void FazerCalculo(Operacoes ultimaOperacao)
        {
            // double é número real
            List<double> listaDeNumeros = new List<double>();
            switch (ultimaOperacao)
            {
                case Operacoes.Soma:
                    listaDeNumeros = textBoxDisplay.Text.Split('+').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listaDeNumeros[0] + listaDeNumeros[1]).ToString();
                    break;
                case Operacoes.Subtrai:
                    listaDeNumeros = textBoxDisplay.Text.Split('-').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listaDeNumeros[0] - listaDeNumeros[1]).ToString();
                    break;
                case Operacoes.Multiplica:
                    listaDeNumeros = textBoxDisplay.Text.Split('X').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listaDeNumeros[0] * listaDeNumeros[1]).ToString();
                    break;
                case Operacoes.Divide:
                    try
                    {
                        listaDeNumeros = textBoxDisplay.Text.Split('÷').Select(double.Parse).ToList();
                        textBoxDisplay.Text = (listaDeNumeros[0] / listaDeNumeros[1]).ToString();
                    }
                    catch (DivideByZeroException)
                    {
                        textBoxDisplay.Text = "Divisão por zero";
                    }
                    break;
                case Operacoes.Nenhuma:
                    break;
                default:
                    break;


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacoes.Nenhuma)
            {
                ultimaOperacao = Operacoes.Soma;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }

            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacoes.Nenhuma)
            {
                ultimaOperacao = Operacoes.Multiplica;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }

            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacoes.Nenhuma)
            {
                ultimaOperacao = Operacoes.Divide;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }

            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "1";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "3";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "2";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "9";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "8";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += ",";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "0";
        }
        private bool parentesesDeNovo;
        private void buttonParenteses_Click(object sender, EventArgs e)
        {
          

    // A pessoa digitou algo dentro dos parênteses

            // Se clicado no botão novamente, fechar os parênteses
            if (parentesesDeNovo == true)
            {
                textBoxDisplay.Text += ")";
                parentesesDeNovo = false;
            }
            else
            {
                textBoxDisplay.Text += "(";
                parentesesDeNovo = true;
            }
        }
    }
}
