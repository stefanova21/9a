using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _26._02._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("kolko dani she vuvejdash");
           int n = int.Parse(Console.ReadLine());

            // zadelqne na pamet
            
            string[] pitie = new string[n];
            double[] brpitie = new double[n];
            int[] cena = new int[n];
                
            // vhod 
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("KAKVO SHE PIESH");
                pitie[i] = Console.ReadLine();
                Console.WriteLine("kolko brpitieta she vzemash");
                brpitie[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("kolko she struva");
                cena[i] = int.Parse(Console.ReadLine());
            }
            // izhod 1 normalen [1,2,3,4,5]-> index0,1,2,3,4 array[1]
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(  pitie[i],"/", brpitie[i], "/",cena[i]);
            }
            // izhod 2 brpitieta nad 2,50
            for (int i = 0; i < n; i++)
            {
                if (brpitie[n] > 2.50 ) 
                Console.WriteLine(  pitie[i],"/", brpitie[i],"/",cena[i]);
            }
            // izhod 3 cena = 2lv. pitie = kafe
            for (int i = 0; i < n; i++)
            {
                if (cena[n] > 2)
                    Console.WriteLine( pitie[i],"/", brpitie[i],"/", cena[i]);
            }
            // izhod 4 sortirane vuv vuzhodq4st red po ime 
            
            Array.Resize(ref pitie, n);
            Array.Sort(pitie);
              for (int i = 0; i < n; i++)
            {
                Console.WriteLine( pitie[i],"/", brpitie[i],"/", cena[i]);
            }
            // izhod 5 izvadi na 3 mqsto zapisaneto
            for (int i = 0; i < n; i++) 
            {
                if (brpitie[n] == 3)
                Console.WriteLine(  pitie[i],"/", brpitie[i],"/" ,cena[i]);
            }
            // izhod 6 izvajdane i na 3 te vuvedeni
            {
                Console.WriteLine(pitie[0]);
                Console.WriteLine(brpitie[1]);
                Console.WriteLine(cena[2]);
            }
            // izhod 7 tursi i izvejda artikul kafe
            for (int i = 0; i < n; i++)
            {
                //   arr[1,2,3]
                //index0 1 2 
                Console.WriteLine(pitie[0]);
                    Console.WriteLine( pitie[i],"/", brpitie[i],"/", cena[i]);
            }

        }
    }
}
