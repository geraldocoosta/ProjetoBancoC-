using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoBanco.Contas;

namespace ProjetoBanco
{
    public partial class FormCadastroConta : Form
    {
        private Form1 formPrincipal;
        private int indice;
        

        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {
            textoNumero.Text = Convert.ToString(Conta.ProximaConta());
        }

        private void botaoCadastro_Click(object sender, EventArgs e)
        {
            if (indice == 0)
            {
                Conta novaConta = new ContaCorrente();
                novaConta.Titular = new Cliente.Cliente(textoTitular.Text);
                textoNumero.Text = Convert.ToString(Conta.ProximaConta());


                this.formPrincipal.AdicionaConta(novaConta);
                MessageBox.Show("Sucesso");
            }
            else
            {
                Conta novaConta = new ContaPoupanca();
                novaConta.Titular = new Cliente.Cliente(textoTitular.Text);
                textoNumero.Text = Convert.ToString(Conta.ProximaConta());


                this.formPrincipal.AdicionaConta(novaConta);
                MessageBox.Show("Sucesso");
            }
            Close();
        }

        private void comboTipoConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = comboTipoConta.SelectedIndex;

        }
    }
}
