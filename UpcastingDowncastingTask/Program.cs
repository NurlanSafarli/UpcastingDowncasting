using System.Reflection;
using UpcastingDowncastingTask.Models;

namespace UpcastingDowncastingTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruit[] basket = new Fruit[]
            {
            new Apple { Price = 1.5, Sort = "QizilEhmedi", VitaminA = 10, VitaminB = 5 },
            new Pineapple { Price = 5, Sort = "Yetismis", VitaminE = 7, VitaminD = 3.2 },
            new Orange { Price = 3, Sort = "Turkiye", VitaminC = 8 }
            };

            foreach (Fruit fruit in basket)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Meyvenin Adi  " + fruit.GetType().Name);

                if (fruit is Apple apple)
                {

                    Console.WriteLine("Qiymeti: " + apple.Price);
                    Console.WriteLine("Sortu: " + apple.Sort);
                    Console.WriteLine("VitaminA: " + apple.VitaminA);
                    Console.WriteLine("VitaminB: " + apple.VitaminB);
                    Console.WriteLine("------------------------------------");
                }
                else if (fruit is Pineapple pineapple)
                {
                    Console.WriteLine("Qiymeti: " + pineapple.Price);
                    Console.WriteLine("Sortu: " + pineapple.Sort);
                    Console.WriteLine("VitaminE: " + pineapple.VitaminE);
                    Console.WriteLine("VitaminD: " + pineapple.VitaminD);
                    Console.WriteLine("------------------------------------");
                }
                else if (fruit is Orange orange)
                {
                    Console.WriteLine("Qiymeti: " + orange.Price);
                    Console.WriteLine("Sortu: " + orange.Sort);
                    Console.WriteLine("VitaminC: " + orange.VitaminC);
                    Console.WriteLine("------------------------------------");
                }

            }
        }
    }
}