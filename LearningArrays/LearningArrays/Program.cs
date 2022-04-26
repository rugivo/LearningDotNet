using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part1
            string[] firstArray;

            firstArray = new string[5];

            firstArray[0] = "house";
            firstArray[1] = "cow";
            firstArray[2] = "bread";
            firstArray[3] = "Hello World";
            firstArray[4] = "Newest";

            Console.WriteLine("First Part");
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.WriteLine(firstArray[i]);
            }
            Console.ReadLine();
            //Part2
            Console.WriteLine("Second Part");
            int [] secondArray;
            secondArray = new int[20];
            for (int i = 0; i < 20; i++)
            {
                secondArray[i] = i;
            }
            //print array backwards
            for (int i = 19; i >= 0; i--)
            {
                Console.WriteLine(secondArray[i]);
            }
            Console.ReadLine();
        }
    }
}
