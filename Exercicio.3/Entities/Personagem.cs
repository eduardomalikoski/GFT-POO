namespace Exercicio._3.Entities
{
    public abstract class Personagem
    {
        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Mana { get; set; }
        public float Xp { get; set; }
        public int Inteligencia { get; set; }
        public int Forca { get; set; }
        public int Level { get; set; }

        public abstract void lvlUp();

        public abstract void attack(double ataque);
    }
}