using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._03._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vuvedi chisla");
            int[] number = new int[10];
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0;i < number.Length; i++)
            {
                if (number[i] % 2 == 0)
                { 
                    Console.WriteLine(number[i]); 
                }
            }


        }
    }
}
