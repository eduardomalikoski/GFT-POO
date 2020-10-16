using System;
using System.Collections.Generic;

namespace Exercicio._3.Entities
{
    public class Guerreiro : Personagem
    {
        public List<string> Habilidade { get; set; }

        public override void lvlUp()
        {
            Level++;
            Vida += 10;
            Forca += 10;
        }

        public override void attack(double ataque)
        {
            Random random = new Random();
            int nmr = random.Next(300);
            ataque = (Forca * Level) + nmr;
        }

        public string aprenderHabilidade(string habilidade)
        {
            Habilidade.Add(habilidade);
            return habilidade;

        }
    }
}