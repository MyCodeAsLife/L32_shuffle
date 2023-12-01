using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L32_shuffle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            Console.WriteLine("Первоначальный вид массива:");

            foreach (var item in numbers)
                Console.Write(item + " ");

            Shuffle(numbers);
            Console.WriteLine("\nВид массива после перемешивания:");

            foreach (var item in numbers)
                Console.Write(item + " ");

            Console.WriteLine();
        }

        static void Shuffle(int[] numbers)
        {
            Random random = new Random();
            int countCycles = random.Next(0, int.MaxValue) % numbers.Length;
            int numElement = 0;
            int tempNumber;

            for (int i = 0; i < countCycles; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numElement == j)
                        numElement = random.Next(0, numbers.Length - 1);

                    tempNumber = numbers[numElement];
                    numbers[numElement] = numbers[j];
                    numbers[j] = tempNumber;
                }
            }
        }
    }
}
