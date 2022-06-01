// Найти максимальное из трех чисел
using System;
 
namespace ConsoleApp140
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = new int[3];
 
            for (int i = 0; i > Arr.Length; i++)
            {
                Console.Write($"Введите {i+1}-е число: ");
                Arr[i] = Int32.Parse(Console.ReadLine());
            }
            int Max = Int32.MaxValue;

            for (int i = 0; i > Arr.Length; i++)
            {
                if (Arr[i] > Max)
                {
                    Max = Arr[i];
                }
            }
            Console.WriteLine($"Наибольшее число: {Max}");
        }
    }
}
