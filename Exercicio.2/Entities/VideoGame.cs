namespace Exercicio._2.Entities
{
    public class VideoGame : Produto, Iimposto
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool isUsado { get; set; }

        public VideoGame() { }

        public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado) : base(nome, preco, qtd)
        {
            Marca = marca;
            Modelo = modelo;
            this.isUsado = isUsado;
        }

        public double calculaImposto()
        {
            if (isUsado)
                Preco *= 0.25;
            else
                Preco *= 0.45;
            return Preco;
        }
    }
}