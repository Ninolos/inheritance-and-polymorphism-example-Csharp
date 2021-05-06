using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio_fixação_Herança_e_Polimorfismo.Entities;


namespace Exercicio_fixação_Herança_e_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {   
            List<Product> list = new List<Product>(); //Nunca esquecer de declarar a lista, senão o programa nao guarda os produtos

            Console.Write("Enter the number of Products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i <= n; i++)
            {
                Console.Write($"Product #{n} data");
                Console.WriteLine("Common, used or imported (c/u/i)");
                char prodType = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price");
                double price = double.Parse(Console.ReadLine());
                
                
                if(prodType == 'c')
                {
                    list.Add(new Product(name, price));
                }
                
                else if(prodType == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }

                else
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product prod in list)
            
                Console.WriteLine(prod.PriceTag());
        }
    }
}
