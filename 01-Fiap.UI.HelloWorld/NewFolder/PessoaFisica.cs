using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Fiap.UI.HelloWorld.NewFolder
{
    class PessoaFisica : Pessoa, Interface
    {
        //Construtor
        public PessoaFisica(string nome) : base(nome)
        {

        }
        public PessoaFisica() { }

        //Propriedades (gets e sets)
        public string Cpf { get; set; }

        public string Porte { get; set; }

        public Genero Sexo { get; set; }

        public override void Beber(string liquido)
        {
            Console.WriteLine("Bebendo" + liquido);
        }

        public virtual void Comer(string comida)
        {
            Console.WriteLine("Pessoa fisica comendo" + comida);
        }

        public void Correr()
        {
            Console.WriteLine("Sem tempo irmão");
        }
    }
}
