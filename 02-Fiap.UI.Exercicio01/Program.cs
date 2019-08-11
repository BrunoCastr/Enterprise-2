using _02_Fiap.UI.Exercicio01.NewFolder;
using System;

namespace _02_Fiap.UI.Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ContaCorrente cc = new ContaCorrente();
            cc.Agencia = 01;
            cc.DataAbertura = DateTime.Now;
            cc.Numero = 005;
            cc.Saldo = 500;
            cc.Depositar(500);
            Console.WriteLine(cc.Saldo);
            cc.Retirar(1001);
            Console.WriteLine(cc.Saldo);*/
            ContaPoupanca cp = new ContaPoupanca(0.05M);
            cp.Agencia = 01;
            cp.DataAbertura = DateTime.Now;
            cp.Numero = 005;
            cp.Saldo = 1000;
            cp.Taxa = 10;
            cp.Retirar(500);
            Console.WriteLine(cp.Saldo);
            Console.WriteLine("Seu rendimento foi de: "+cp.CalculaRetornoInvestimento());
           
        }
    }
}
