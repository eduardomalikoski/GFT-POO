using System;
using System.Collections.Generic;

namespace Exercicio._6
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

            if (pessoas.Contains(pessoa4))
            {
                System.Console.WriteLine("Idade de Jessica: " + pessoa4.Idade);
            }

        }
    }
}
