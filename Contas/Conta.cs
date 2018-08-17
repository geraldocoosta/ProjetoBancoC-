using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoBanco;


namespace ProjetoBanco.Contas
{
    public abstract class Conta
    {

        public Conta()
        {
            Conta.numeroDeContas++;
            this.NumeroConta = Conta.numeroDeContas;
        }

        public int NumeroConta { get; set; }
        public double Saldo { get; protected set; }
        public Cliente.Cliente Titular { get; set; }

        public abstract void Deposita(double valorOperacao);


        public abstract void Sacar(double valorOperacao);

        private static int numeroDeContas;

        public static int ProximaConta()
        {
            return Conta.numeroDeContas + 1;
        }


    }
}
