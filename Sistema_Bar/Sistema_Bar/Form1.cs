using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Bar
{
    public partial class Form1 : Form
    {
        string[] produtos = new string[10];
        string[] codigo = new string[10];
        double[] valor = new double[10];
        double soma;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /* if (textBox1.Text.Length == 5)
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
                textBox1.Focus();

            } */
            if (textBox1.Text.Length == 4)
            {
                int indice = 0;
                for (int prod = 1; prod < codigo.Length; prod ++)
                {
                    if(textBox1.Text == codigo[prod])
                    {
                        indice = prod;
                    }
                }
                if (indice == 0)
                {
                    MessageBox.Show("Produto não encontrado");
                }
                else
                {
                    listBox1.Items.Add(textBox1.Text + "--" + produtos[indice] + "-- R$ " + valor[indice]);
                    soma = soma + valor[indice];
                    label3.Text = ("Valor Total R$ " + soma);
                    picImagem.ImageLocation = "../Sistema_Bar/image/" + codigo[indice] + ".png";
                    textBox1.Text = "";
                    textBox1.Focus();
                }
            }
    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadArray();
            soma = 0;
        }

        private void loadArray()
        {
            codigo[1] = "0001";
            codigo[2] = "0002";
            codigo[3] = "0003";
            codigo[4] = "0004";
            codigo[5] = "0005";

            produtos[1] = "Cerveja";
            produtos[2] = "Lanche";
            produtos[3] = "Chocolate";
            produtos[4] = "Bala";
            produtos[5] = "Suco";

            valor[1] = 7.00;
            valor[2] = 12.00;
            valor[3] = 4.50;
            valor[4] = 2.50;
            valor[5] = 6.00;
        }
    }
}
