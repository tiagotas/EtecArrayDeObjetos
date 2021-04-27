using System;
using System.Collections.Generic;
using System.Text;

namespace IntroducaoOO
{
    //Especificação de como o "Objeto" será
    // Classe abstrata não pode ter instância, serve como meio comum.
    abstract class Pessoa
    {
        // atributo (campo)
        private static int instancias = 0;


        // Atributos/Propriedades (Caracteristicas)
        double altura;
        double peso;    // private ou sem nada, apenas dentro da própria classe
        protected int idade;   // public é acessível por todos (dentro e fora da classe)
        protected string nome; // protected é acessível apenas as Classes FILHAS


        // Propriedade (regula o acesso [leitura e escrita] aos campos/atributos)
        public static int Instancias
        {
            get { return instancias; } // Define Instancias como somente leitura.
        }


        public string Nome
        {
            get { return nome; } // Define Nome como somente leitura, pois tem apenas o get.
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; } // Define que é possívle gravar valores
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }


        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }



        // Método Construtor
        public Pessoa(string _nome)
        {
            //Console.WriteLine("Chamou o método construtor assim que criou o objeto");

            nome = _nome;

            // instancias++;
            instancias = instancias + 1;
        }


        // Métodos (Ações)
        public void Respirar()
        {
            // programar as ações.
            Console.WriteLine("A pessoa {0} está respirando.", nome);
        }

        // Adicionando um método com Parâmetro
        public void Comer(string _comida)
        {
            Console.WriteLine("A pessoa {0} está comendo {1}.", nome, _comida);
        }

        public void Andar()
        {
            Console.WriteLine("A pessoa {0} está andando", nome);
        }
    }
}
