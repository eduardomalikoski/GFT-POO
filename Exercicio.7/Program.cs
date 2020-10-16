using System;
using Exercicio._7.Entities;

namespace Exercicio._7
{
    class Program
    {
        static void Main(string[] args)
        {

            Gerente gerentes = new Gerente("Jose Eduardo", 19, 10000);
            Funcionario supervisor = new Supervisor("Edu", 30, 5000);
            Funcionario vendedor = new Vendedor("Jeff Bezos", 30, 7000);

            gerentes.bonificacao();
            supervisor.bonificacao();
            vendedor.bonificacao();

            System.Console.WriteLine("Dados atualizados!");
            System.Console.Write("Salario gerente: ");
            System.Console.WriteLine(gerentes.Salario);
            System.Console.Write("Salario supervisor: ");
            System.Console.WriteLine(supervisor.Salario);
            System.Console.Write("Salario vendedor: ");
            System.Console.WriteLine(vendedor.Salario);
        }
    }
}
