namespace Exercicio._7.Entities
{
    public class Vendedor : Funcionario
    {
        public Vendedor(string nome, int idade, double salario) : base(nome, idade, salario) { }

        public override void bonificacao()
        {
            Salario += 3000.00;
        }
    }
}