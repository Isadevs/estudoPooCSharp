using System;

namespace _003EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vet[0]);
            int qtde = int.Parse(vet[1]);
            double ValPagar = 0;

            switch (codigo)
            {
                case 1:
                    ValPagar = qtde * 4.00;
                    break;

                case 2:
                    ValPagar = qtde * 4.50;
                    break;

                case 3:
                    ValPagar = qtde * 5.00;
                    break;

                case 4:
                    ValPagar = qtde * 2.00;
                    break;

                case 5:
                    ValPagar = qtde * 1.50;
                    break;
            }

            Console.WriteLine($"Total: R$ {ValPagar.ToString("N2")}");
        }
    }
}
