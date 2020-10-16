using System;
using System.Collections.Generic;

namespace Exercicio._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa("Joao", 15);
            Pessoa pessoa2 = new Pessoa("Leandro", 21);
            Pessoa pessoa3 = new Pessoa("Paulo", 16);
            Pessoa pessoa4 = new Pessoa("Jessica", 18);

            List<Pessoa> pessoas = new List<Pessoa>();

            pessoas.Add(pessoa1);
            pessoas.Add(pessoa2);
            pessoas.Add(pessoa3);
            pessoas.Add(pessoa4);

            System.Console.WriteLine("Total de pessoas:");
            Console.WriteLine(pessoas.Count);

            if (pessoa1.Idade < 18)
            {
                pessoas.Remove(pessoa1);
            }
                

            if (pessoa2.Idade < 18)
            {
                pessoas.Remove(pessoa2);
            }
                
            
            if (pessoa3.Idade < 18)
            {
                pessoas.Remove(pessoa3);
            }
                

            if (pessoa4.Idade < 18)
            {
                pessoas.Remove(pessoa4);
            }

            System.Console.WriteLine("Total de pessoas com menos de 18 anos:");
            Console.WriteLine(pessoas.Count);


        
        }
    
    }  
}
