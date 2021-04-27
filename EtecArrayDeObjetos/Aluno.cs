using System;
using System.Collections.Generic;
using System.Text;

namespace IntroducaoOO
{
    class Aluno : Pessoa // A classe "Aluno" herda atributos e métodos da classe "Pessoa"
    {
        // Definir os Atributos/Campo
        int rm;


        public int Rm 
        {
            get { return rm; }
            set { rm = value; }
        }




        public Aluno(string _nome) : base(_nome)
        {

        }

        // Definir os métodos
        public void Estudar(string _disciplina)
        {
            Console.WriteLine("{0} está estudando {1}", nome, _disciplina);
        }
    }
}
