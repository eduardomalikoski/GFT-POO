namespace Exercicio._2.Entities
{
    public class Livro : Produto, Iimposto
    {
        public string Autor { get; set; }
        public string Tema { get; set; }
        public int qtdPag { get; set; }

        public Livro() { }

        public Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPag) : base (nome, preco, qtd)
        {
            Autor = autor;
            Tema = tema;
            this.qtdPag = qtdPag;   
        }

        public double calculaImposto()
        {
            if (Tema != "educativo")
                Preco *= 0.10;
            return Preco;
        }
    }
}