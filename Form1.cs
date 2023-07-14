using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula04AppBanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            double valor = double.Parse( textValor.Text );
            double saldo = double.Parse ( lblSaldo.Text.Replace("R$", "") );

            double soma;

            if( lblOperacao.Text =="SAQUE" )
            {

                 soma = saldo- valor;
            }
            else
            {
                
                soma = valor + saldo;
            }

             
            lblSaldo.Text = "R$" + soma;


        }

        private void lblOperacao_Click(object sender, EventArgs e)
        {

        }

        private void textValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsacar_Click(object sender, EventArgs e)
        {
            btnDepositar.BackColor = Color.Gainsboro;
            btnDepositar.ForeColor = Color.Black;
            btnsacar.BackColor = Color.LightBlue;
            btnsacar.ForeColor = Color.DodgerBlue;
            lblOperacao.Text = "SAQUE";

        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            btnsacar.BackColor = Color.Gainsboro;
            btnsacar.ForeColor = Color.Black;
            btnDepositar.BackColor = Color.LightBlue;
            btnDepositar.ForeColor = Color.DodgerBlue;
            lblOperacao.Text = "Deposito";

        }

        private void bntExtrato_Click(object sender, EventArgs e)
        {
            Form2 telaExtrato = new Form2();
            telaExtrato.Show();
        }
    }
}
