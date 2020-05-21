using System;
using System.Linq;

namespace FruitMe
{
    class Program
    {
        static void Main(string[] args)
        {
            DoWork();
            Console.Write("Press the [ANY] key to continue...");
            Console.ReadKey();
        }

        public static void DoWork()
        {
            var fruitIndex = (new Random()).Next(0, Fruit.AllFruits.Count); // inclusive min, exclusive max
            var fruit = Fruit.AllFruits.ElementAt(fruitIndex);
            Console.WriteLine($"Hello :)");
            Console.WriteLine($"Here, have {fruit.Key}.");
            Console.WriteLine(fruit.Value);
        }
    }
}
