using System;
using System.Collections.Generic;
using Exercicio._2.Entities;

namespace Exercicio._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro l1 = new Livro("Harry Potter", 40, 50, "Rowling", "fantasia", 300);
            Livro l2 = new Livro("Senhor dos Anéis", 60, 30, "Tolkien", "fantasia", 500);
            Livro l3 = new Livro(".NET POO", 20, 50, "GFT", "educativo", 500);

            VideoGame ps5 = new VideoGame("PS5", 1800, 100, "Sony", "Slim", false);
            VideoGame ps5Usado = new VideoGame("PS5", 1000, 7, "Sony", "Slim", true);
            VideoGame xbox = new VideoGame("XBOX", 1500, 500, "Microsoft", "One", false);

            List<Livro> livros = new List<Livro>();
            livros.Add(l1);
            livros.Add(l2);
            livros.Add(l3);

            List<VideoGame> games = new List<VideoGame>();
            games.Add(ps5);
            games.Add(ps5Usado);
            games.Add(xbox);

            Loja americanas = new Loja("Americanas", "1234", livros, games);

            l2.calculaImposto();
            l3.calculaImposto();

            ps5Usado.calculaImposto();
            ps5.calculaImposto();

            americanas.listaLivros(livros);
            americanas.listaVideoGames(games);
            americanas.calculaPatrimonio();

            System.Console.WriteLine("Imposto sobre livro 1:");
            System.Console.WriteLine(l1.calculaImposto());

            System.Console.WriteLine("Imposto sobre livro 2:");
            System.Console.WriteLine(l2.calculaImposto());

            System.Console.WriteLine("Imposto sobre livro 3:");
            System.Console.WriteLine(l3.calculaImposto());

            System.Console.WriteLine("Imposto sobre Videogame 1:");
            System.Console.WriteLine(ps5.calculaImposto());

            System.Console.WriteLine("Imposto sobre Videogame 2:");
            System.Console.WriteLine(ps5Usado.calculaImposto());

            System.Console.WriteLine("Imposto sobre Videogame 3:");
            Console.WriteLine(ps5Usado.calculaImposto());

            System.Console.WriteLine(americanas.calculaPatrimonio());
        }
    }
}
