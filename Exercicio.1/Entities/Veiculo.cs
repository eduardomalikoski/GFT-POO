using System;

namespace Exercicio._1.Entities
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public float Km { get; set; }
        public bool isLigado { get; set; }
        public int litrosCombustivel { get; set; }
        public int Velocidade { get; set; }
        public double Preco { get; set; }

        public Veiculo()
        {
            isLigado = false;
        }

        public void acelerar()
        {
            Velocidade += 20;
        }
        
        public void abastecer(int combustivel)
        {
            if (combustivel > 60)
                Console.WriteLine("Excedeu o limite!");
            else
                litrosCombustivel = combustivel;
                System.Console.WriteLine(("Abastecido"));
        }

        public void frear()
        {
            if (Velocidade == 0 || isLigado == false)
                Console.WriteLine("Não é possível frear!");
            else
                Velocidade -= 20;
        }

        public void pintar(string cor)
        {
            Cor = cor;
            System.Console.WriteLine("Pintura feita com sucesso");
        }

        public void ligar()
        {
            if (isLigado == false)
            {
                isLigado = true;
            }
            else
            {
                Console.WriteLine("O carro já está ligado!");
            }

        }

        public void desligar()
        {
            if (Velocidade > 0)
            {
                Console.WriteLine("Não é possível desligar o carro em movimento");
            }
            
            else if (isLigado == true)
            {
                isLigado = false;
                Console.WriteLine("Voce desligou o carro");
            }
            else
            {
                Console.WriteLine("O carro já está desligado");
            }
        }

        public override string ToString()
        {
            return "Dados do seu carro:\n" + Marca + "\n" + Modelo + "\n" + Placa + "\n" + Cor + "\n" + Km + "\n" + Preco + "\n";
        }
    }
}