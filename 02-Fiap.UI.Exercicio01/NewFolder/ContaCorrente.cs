using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Fiap.UI.Exercicio01.NewFolder
{
    class ContaCorrente : Conta
    {
        public ContaCorrente()
        { }
        public TipoConta TipoConta { get; set; }
        public override void Depositar(decimal valor)
        {
            Saldo += valor; 
        }

        public override void Retirar(decimal valor)
        {
            if ((Saldo - valor) < 0)
            {
                throw new Exception("Erro ao retirar.");
            }
            else { Saldo -= valor; }
        }
    }
}
