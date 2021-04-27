using System;
using System.Collections.Generic;
using IntroducaoOO;

namespace EtecArrayDeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Array de objetos = lista de vários objetos do mesmo tipo.
             *    i    |   0    |    1    |    2     |     3     |   4   | .....
             * alunos  |  Kevin | Rafaela |  João    |  Gabriel  |
             */
            List<Aluno> alunos = new List<Aluno>();

            
            //Aluno a1 = new Aluno("Kevin");
            //alunos.Add(a1);
            

            alunos.Add(new Aluno("Kevin"));
            alunos.Add(new Aluno("Rafaela"));
            alunos.Add(new Aluno("João"));

            Console.WriteLine("Temos {0} alunos no sistema", alunos.Count);


            alunos.Add(new Aluno("Gabriel")
            {
                Idade = 16,
                Rm = 789456,
                Altura = 1.80,
                Peso = 70,
            });


            Console.WriteLine("Posição 3: ");
            Console.WriteLine("Nome: {0} ",   alunos[3].Nome);
            Console.WriteLine("Idade: {0} ",  alunos[3].Idade);
            Console.WriteLine("Rm: {0} ",     alunos[3].Rm);
            Console.WriteLine("Altura: {0} ", alunos[3].Altura);
            Console.WriteLine("Peso: {0} ",   alunos[3].Peso);

            Console.WriteLine("");




            Console.WriteLine("Percorrendo com um Looping For");
            
            for(int i=0; i < alunos.Count; i++)
            {
                Console.WriteLine("Posição {0}: ", i);

                Console.WriteLine("Nome: {0} ",   alunos[i].Nome);
                Console.WriteLine("Idade: {0} ",  alunos[i].Idade);
                Console.WriteLine("Rm: {0} ",     alunos[i].Rm);
                Console.WriteLine("Altura: {0} ", alunos[i].Altura);
                Console.WriteLine("Peso: {0} ",   alunos[i].Peso);

                Console.WriteLine("");
            }


            Console.WriteLine("");
            Console.WriteLine("Percorrendo com um Looping Foreach");

            foreach(Aluno item in alunos)
            {
                Console.WriteLine("Nome: {0} ",   item.Nome);
                Console.WriteLine("Idade: {0} ",  item.Idade);
                Console.WriteLine("Rm: {0} ",     item.Rm);
                Console.WriteLine("Altura: {0} ", item.Altura);
                Console.WriteLine("Peso: {0} ",   item.Peso);

                Console.WriteLine("");
            }

            /**
             * Insrindo os dados de um aluno
             */
            Console.WriteLine("Informe o nome do aluno: ");
            string nome = Console.ReadLine();

            Aluno x = new Aluno(nome);

            Console.WriteLine("Informe a Idade do aluno: ");
            x.Idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o Rm do aluno: ");
            x.Rm = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o Altura do aluno: ");
            x.Altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o Peso do aluno: ");
            x.Peso = Convert.ToDouble(Console.ReadLine());


            // add na lista de alunos
            alunos.Add(x);


            Console.WriteLine("");
            Console.WriteLine("Percorrendo com um Looping For");

            for (int i = 0; i < alunos.Count; i++)
            {
                Console.WriteLine("Posição {0}: ", i);

                Console.WriteLine("Nome: {0} ", alunos[i].Nome);
                Console.WriteLine("Idade: {0} ", alunos[i].Idade);
                Console.WriteLine("Rm: {0} ", alunos[i].Rm);
                Console.WriteLine("Altura: {0} ", alunos[i].Altura);
                Console.WriteLine("Peso: {0} ", alunos[i].Peso);

                Console.WriteLine("");
            }




            Console.ReadKey();
        }
    }
}
