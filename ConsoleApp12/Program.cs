using System;
using System.Globalization;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod1, cod2, p1, p2;
            double preço1, preço2, total;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            cod1 = int.Parse(vet[0]);
            p1 = int.Parse(vet[1]);
            preço1 = double.Parse(vet[2], CultureInfo.InvariantCulture);


            vet = Console.ReadLine().Split(' ');
            cod2 = int.Parse(vet[0]);
            p2 = int.Parse(vet[1]);
            preço2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            total = preço1 * p1 + preço2 * p2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));







        }
    }
}
