using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2._21._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // vhod 
            Console.WriteLine("Kolko chisla she vuvejdash ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("kolko puti she zavurtva");
            // zadelqne na pamet
            int[] chislo = new int[n];

            int i;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("vuvedi chisla");
                chislo[i] = int.Parse(Console.ReadLine());

            }
            // izhod 
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("vuvedi chislo");
                chislo[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k ++)
                {
                    k = k + 1 + k;
                }
            }
            Console.WriteLine("izhod bez  ");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("vuvedi chislo");
                chislo[i] = int.Parse(Console.ReadLine());
            }
           
            Array.Resize(ref chislo, n);
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine("vuvedi chislo");
                chislo[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

        }
                   
    
     
    }
}
