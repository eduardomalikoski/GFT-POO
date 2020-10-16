using System;
using System.Collections.Generic;
using Exercicio._3.Entities;

namespace Exercicio._3
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Guerreiro> guerreiros = new List<Guerreiro>();
            List<Mago> magos = new List<Mago>();
            Guerreiro guerreiroAlfa = new Guerreiro();
            Mago magoAlfa = new Mago();

            System.Console.WriteLine("Nome do guerreiro: ");
            guerreiroAlfa.Nome = Console.ReadLine();

            System.Console.WriteLine("Nome do mago: ");
            magoAlfa.Nome = Console.ReadLine();
            System.Console.WriteLine();

            magoAlfa.lvlUp();
            guerreiroAlfa.lvlUp();

            double attackGuerreiro = 150;
            guerreiroAlfa.attack(attackGuerreiro);
            double attackMago = 100;
            magoAlfa.attack(attackMago);

            guerreiros.Add(guerreiroAlfa);
            magos.Add(magoAlfa);
            
            int countGuerreiro = 0;
            foreach (Personagem item in guerreiros)
            {
                countGuerreiro++;
            }

            int countMago = 0;
            foreach (Personagem item in magos)
            {
                countMago++;
            }

            int somaCount = countGuerreiro + countMago;

            Console.Clear();

            System.Console.WriteLine("Dados dos guerreiros:");
            System.Console.WriteLine("Nome guerreiro:");
            System.Console.WriteLine(guerreiroAlfa.Nome);
            System.Console.WriteLine("Ataque:");
            System.Console.WriteLine(attackGuerreiro);
            System.Console.WriteLine("Level guerreiro");
            System.Console.WriteLine(guerreiroAlfa.Level);
            System.Console.WriteLine();
            System.Console.WriteLine("Nome mago:");
            System.Console.WriteLine(magoAlfa.Nome);
            System.Console.WriteLine("Ataque:");
            System.Console.WriteLine(attackMago);
            System.Console.WriteLine("Level mago");
            System.Console.WriteLine(magoAlfa.Level);
            System.Console.WriteLine();
            Console.WriteLine("Quantidade de personagens");
            System.Console.WriteLine(somaCount);

        }
    }
}
