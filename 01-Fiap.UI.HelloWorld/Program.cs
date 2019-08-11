using _01_Fiap.UI.HelloWorld.NewFolder;
using System;


namespace _01_Fiap.UI.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar uma Pessoa Fisica
            PessoaFisica pf = new PessoaFisica();
            //Atribuir um nome para a pessoa
            pf.Nome = "Joao Rodrigo";
            pf.Sexo = Genero.Masculino;
            //Exibir o nome da pessoa

            PessoaFisica pf2 = new PessoaFisica()
            {
                Nome = "Thiago",
                Cpf = "000.000.000-43",
                Idade = 40
            };

            Console.WriteLine(pf.Nome);
        }
    }
}
