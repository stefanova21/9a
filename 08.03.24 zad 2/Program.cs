using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._03._24_zad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vivedi chisla");
            int n = int.Parse(Console.ReadLine());
            int[] number = new int[n];
            int sum = 0;
            sum += number[0];
            
            for (int i = 1; i < number.Length; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
                sum += number[i];
               sum += (i * number[i]) + sum;
            }
            for (int i = 1; i < number.Length; i++)
            {
                sum += (number[i] * i);
              //  sum  = sum + (number[i]) * i) 

            }
            Console.WriteLine(sum);
        }
    }
}
