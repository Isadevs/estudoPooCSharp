using System;

namespace _001
{
    class Program
    {
        static void Main(string[] args)
        {
            // aqui vai a definição das variáveis compostas,
            // cada uma tem dois espaços na memoria
            Pessoa a = new Pessoa();
            Pessoa b = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            a.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            b.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            b.idade = int.Parse(Console.ReadLine());


            if (a.idade > b.idade)
            {
                Console.WriteLine($"Pessoa mais velha: {a.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {b.Nome}");
            }
        }
    }
}
