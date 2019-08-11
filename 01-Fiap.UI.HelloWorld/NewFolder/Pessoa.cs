using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Fiap.UI.HelloWorld.NewFolder
{
    abstract class Pessoa
    {
        //Atributos - Fields
        private string _nome;

        //Contrutor
        public Pessoa(String nome) {
            _nome = nome;
        }

        public Pessoa(){}

        //Gets e Sets - Propriedades

        public int Idade
        {
            get;set;
        }

        public string Nome
        {
            get { return _nome;  }
            set { _nome = value; }
        }

        //Métodos
        public abstract void Beber(string liquid);

        public void Comer(string comida)
        {
          
        }

    }
}

