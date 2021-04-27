using System;
using System.Collections.Generic;
using System.Text;

namespace IntroducaoOO
{
    class Professor : Pessoa
    {
        // Definir Atriutos/Propriedades
        string materia_lecionada;
        int matricula;


        public Professor(string _nome) : base(_nome)
        {

        }


        // Definir os Métodos
        public void Ensinar(string _disciplina)
        {
            Console.WriteLine("O Professor {0} está ensinando {1}.", nome, _disciplina);
        }
    }
}
