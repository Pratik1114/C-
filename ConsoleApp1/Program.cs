using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World");
            
            int num = 5;
            string word = "Hello";
            
            const int ConstNum = 5;
            if (ConstNum > 4)
            {
                Console.WriteLine("Small");
            }
            else if (ConstNum < 2)
            {
                Console.WriteLine("Too Small");
            }
            else
            {
                Console.WriteLine("Big");
            }

            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            list.Add(6);
            list.Remove(2);


            Random rnd = new Random();
            int secretNun = rnd.Next(1,11);
            Console.WriteLine(secretNun);
            

        }
    }
}
