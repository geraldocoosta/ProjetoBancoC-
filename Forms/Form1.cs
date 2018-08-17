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
    public partial class Form1 : Form
    {
        
        // Declarando a lista de contas para todo a classe form1
        private List<Conta> contas;
        private int numeroDeContas;
        private Conta selecionada;
        private double valorOperacao;


        public void AdicionaConta(Conta conta)
        {
            contas.Add(conta);
            this.numeroDeContas++;
            comboContas.Items.Add("titular: " + conta.Titular.Nome);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // Criando uma lista de contas, pois é melhor que arrays
            contas = new List<Conta>();



        }

        private void botaoSaca_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            try
            {
                Conta selecionada = contas[indice];
                double valorOperacao = Convert.ToDouble(textoValor.Text);

                try
                {
                    selecionada.Sacar(valorOperacao);
                    textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                    MessageBox.Show("Sucesso");
                }
                catch (SaldoInsuficienteException)
                {
                    MessageBox.Show("Saldo insuficiente");
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Não é possivel sacar um valor negativo");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Escolher alguma conta");
            }
            

           
            

        }

        private void botaoDeposita_Click(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            try
            {
                Conta selecionada = contas[indice];
                double valorOperacao = Convert.ToDouble(textoValor.Text);

                try
                {
                    selecionada.Deposita(valorOperacao);
                    textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                    MessageBox.Show("Sucesso");
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Não é possivel depositar um valor negativo");

                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Escolher alguma conta");
            }
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            textoNumero.Text = Convert.ToString(selecionada.NumeroConta);
            
        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Caso não preencha o campo 'Tipo Conta', será criado uma Conta Corrente por padrão");
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);
            formularioDeCadastro.ShowDialog();
        }

        private void textoValor_KeyPress(object sender, KeyPressEventArgs e)
        {



            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (textoValor.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void textoValor_Leave(object sender, EventArgs e)
        {
            textoValor.Text = Convert.ToDouble(textoValor.Text.Trim()).ToString("####.00");
        }
    }
}
