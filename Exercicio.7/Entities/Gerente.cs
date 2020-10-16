namespace Exercicio._7.Entities
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, int idade, double salario) : base(nome, idade, salario) { }

        public override void bonificacao()
        {
            Salario += 10000.00;
        }
    }
}