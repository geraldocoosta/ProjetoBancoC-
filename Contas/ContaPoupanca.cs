using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Contas
{
    class ContaPoupanca : Conta
    {

        public override void Deposita(double valorOperacao)
        {
            if (valorOperacao < 0.0)
            {
                throw new ArgumentException();
            }
            else
                Saldo += valorOperacao;
        }

        public override void Sacar(double valorOperacao)
        {
            if (valorOperacao < 0.0)
            {
                throw new ArgumentException();
            }
            else if (valorOperacao + 0.1 > Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else
                Saldo -= valorOperacao + 0.1;
        }
    }
}
