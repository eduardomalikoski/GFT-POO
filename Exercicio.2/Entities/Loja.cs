using System.Collections.Generic;
using Exercicio._2.Entities;

namespace Exercicio._2.Entities
{
    public class Loja
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public List<Livro> Livros { get; set; }
        public List<VideoGame> VideoGames { get; set; }

        public Loja(){ }

        public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videoGames)
        {
            Nome = nome;
            Cnpj = cnpj;
            List<Livro> Livros = livros;
            List<VideoGame> VideoGames = videoGames;
        }

        public void listaLivros(List<Livro> livros)
        {
            livros = new List<Livro>();
            foreach (Livro lista in livros)
            {
                System.Console.WriteLine(lista.Nome + ", " + lista.Preco + ", " + lista.Qtd);
            }
        }

        public void listaVideoGames(List<VideoGame> videogames)
        {
            videogames = new List<VideoGame>();
            foreach (VideoGame list in videogames)
            {
                System.Console.WriteLine(list.Nome + ", " + list.Preco + ", " + list.Qtd);
            }
        }

        public double calculaPatrimonio()
        {
            double calculoLivro = 0;
            double calculoVideoGame = 0;

            List<Livro> livro = new List<Livro>();
            foreach (Livro list in livro)
            {
                calculoLivro = list.Preco * list.Qtd;
            }

             List<VideoGame> game = new List<VideoGame>();
            foreach (VideoGame videogame in game)
            {
                calculoVideoGame = videogame.Preco * videogame.Qtd;
            }
            double calculoTotal;
            calculoTotal = calculoVideoGame + calculoLivro;

            return calculoTotal;
        }
    }
}