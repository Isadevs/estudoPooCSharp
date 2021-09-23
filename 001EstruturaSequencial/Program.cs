using System;

namespace _001
{
    class Program
    {
        static void Main(string[] args)
        {
            //peça1
            String[] vet1 = Console.ReadLine().Split(' ');
            //peça2
            String[] vet2 = Console.ReadLine().Split(' ');

            int estoque1 = int.Parse(vet1[1]);
            int estoque2 = int.Parse(vet2[1]);

            double preco1 = double.Parse(vet1[2]);
            double preco2 = double.Parse(vet2[2]);

            var TotalAPagar = (preco1 * estoque1) + (preco2 * estoque2);

            Console.WriteLine($"VALOR A PAGAR: R$ {TotalAPagar.ToString("F2")}");



        }
    }
}
