using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Fiap.UI.Exercicio01.NewFolder
{
     abstract class Conta
    {
        public Conta() {}

        public int Agencia { get; set; }

        public int Numero { get; set; }

        public DateTime DataAbertura { get; set; }

        public decimal Saldo { get; set; }

        public abstract void Depositar(decimal valor);

        public abstract void Retirar(decimal valor);
    }
}
