using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MondayCollections
{
    class Task2
    {
        public static void Main(string[] args)
        {
            Stack stack = new Stack();
            Console.WriteLine("Write integers separated with commas");
            string[] input = Console.ReadLine().Split(',');
            foreach (var elem in input)
            {
                try
                {
                    stack.Push(int.Parse(elem));
                }
                catch
                {
                    Console.WriteLine("found a not-integer in the input");
                }
            }

            while (stack.Count > 0)
            {
                Console.WriteLine($"From Stack: {stack.Pop()}");
            }

        }
    }
}
