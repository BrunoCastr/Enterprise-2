using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Fiap.UI.Exercicio01.NewFolder
{
    class ContaPoupanca : Conta, IContaInvestimento
    {

        public decimal Taxa { get; set; }

        private decimal _rendimento;

        public decimal MyProperty
        {
            get { return _rendimento; }
        }

        public ContaPoupanca(decimal rendimento)
        {
            _rendimento = rendimento;
        }

        public decimal CalculaRetornoInvestimento()
        {
            return  Saldo * _rendimento;
        }

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public override void Retirar(decimal valor)
        {
            if ((Saldo - valor) < 0 || ((Saldo - valor) - Taxa) < 0)
            {
                throw new Exception("Erro");
            }
            else { Saldo = ((Saldo - valor) - Taxa); }
        }

    }
}
