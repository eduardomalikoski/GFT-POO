using System;
using System.Collections.Generic;

namespace Exercicio._3.Entities
{
    public class Mago : Personagem
    {
        public List<string> Magia { get; set; }

        public override void lvlUp()
        {
            Level++;
            Mana += 10;
            Inteligencia += 10;
        }

        public override void attack(double ataque)
        {
            Random random = new Random();
            int nmr = random.Next(300);
            ataque = (Inteligencia * Level) + nmr;
        }

        public string aprenderMagia(string magias)
        {
            Magia.Add(magias);
            return magias;
        }
    }
}