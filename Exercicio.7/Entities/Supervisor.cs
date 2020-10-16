namespace Exercicio._7.Entities
{
    public class Supervisor : Funcionario
    {
        public Supervisor(string nome, int idade, double salario) : base(nome, idade, salario) { }

        public override void bonificacao()
        {
            Salario += 5000.00;
        }
    }
}