using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoParcela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            // Aula Calcular Parcela
            
            //Declarando as variaveis

            double valorTotal, parcela, resultado;
            valorTotal = Convert.ToDouble(textValorTotal.Text);
            parcela = Convert.ToDouble(textParcela.Text);
            resultado = (valorTotal / parcela);

            //Declarando o buttom calcular

            textResultado.Text = resultado.ToString();

            MessageBox.Show("Valor da Parcela é!!!","Messagem");

            //fim do programa

        }

        private void BtnLimpa_Click(object sender, EventArgs e)
        {
            //Declarando codigo limpar das textbox

            textValorTotal.Text = " ";
            textParcela.Text = " ";
            textResultado.Text = " ";

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            //Declarando codigo fechar

            Close();

        }
    }
}
