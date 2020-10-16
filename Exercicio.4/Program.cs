using System;
using System.Collections.Generic;

namespace Exercicio._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa("Joao", 15);
            Pessoa pessoa2 = new Pessoa("Leandro", 21);
            Pessoa pessoa3 = new Pessoa("Paulo", 17);
            Pessoa pessoa4 = new Pessoa("Jessica", 18);

            List<Pessoa> pessoas = new List<Pessoa>();

            pessoas.Add(pessoa1);
            pessoas.Add(pessoa2);
            pessoas.Add(pessoa3);
            pessoas.Add(pessoa4);

            Pessoa r1 = pessoa1;
            foreach (var item in pessoas)
            {
                if (item.Idade > r1.Idade)
                {
                    r1 = item;
                }
            }

            System.Console.WriteLine("Pessoa mais velha: " + r1.Nome);
            System.Console.WriteLine("Total de pessoas:");
            System.Console.WriteLine(pessoas.Count);

        }
    }
}
