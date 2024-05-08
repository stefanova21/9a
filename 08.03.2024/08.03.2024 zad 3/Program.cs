using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._03._2024_zad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Vuvedi danni");
            int n = int.Parse(Console.ReadLine());
            int[] number = new int[] {1, 2, 3};
            for (int i= n-1; i > 0; i--)
            {
                number [i] = int.Parse(Console.ReadLine());
                number[i] = number[i-1];
            }
            for (int i= n-1; i > 0; i--)
            {
                Console.WriteLine("{0}", number[i]);
            }
             
        }
    }
}
