using System;
using System.Globalization;

namespace _002
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios funcionario1, funcionario2;
            funcionario1 = new Funcionarios();
            funcionario2 = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario1.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            funcionario2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (funcionario1.Salario + funcionario2.Salario)/ 2;

            Console.Write("Salário médio = " + media.ToString("N2", CultureInfo.InvariantCulture));
                 

        }
    }
}
