using System;
using System.Linq;

namespace FruitMe
{
    class Program
    {
        static void Main(string[] args)
        {
            DoWork();
        }

        public static void DoWork()
        {
            var fruitIndex = (new Random()).Next(0, Fruit.AllFruits.Count); // inclusive min, exclusive max
            var fruit = Fruit.AllFruits.ElementAt(fruitIndex);
            Console.WriteLine($"Hello :)");
            Console.WriteLine($"Here, have {fruit.Key}.");
            Console.Write(fruit.Value);
        }
    }
}
