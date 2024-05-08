using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._03._203
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("vuvedi 3 elementa");
            // v cikala predmet 

            int n = int.Parse(Console.ReadLine());

            // zadelqne na pamet 
            
            string[] predmrt = new string[n];
            
            int[] chas = new int[n];

            // vhod
            for (int i = 0; i < n; i++)
            {
                predmrt[i] = Console.ReadLine();
                chas[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("izhod 1");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}/{1}", predmrt[i], chas[i]);

            }

            Console.WriteLine("izhod 2");
            for (int i = 0; i < n; i++)
            {
                if (chas[i] >= 4)
                    Console.WriteLine("{0}/{1}", predmrt[i], chas[i]);
            }

            Console.WriteLine("izhod 3 sortirane ot malko kum golqmo");
            Array.Sort(chas);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}/{1}", predmrt[i], chas[i]);

            }
            Array.Resize(ref chas, n);
            Array.Sort(chas);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}/{1}", predmrt[i], chas[i]);

            }
            
            Array.Sort(predmrt);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}/{1}", predmrt[i], chas[i]);

            }
            Array.Resize(ref predmrt, n);
            Array.Sort(predmrt);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}/{1}", predmrt[i], chas[i]);

            }
            Console.WriteLine("izhod 6 ");
            for (int i = 0; i < n; i++)
            {
                string[] tekst = new string[n];
                string newPredmet = "Matematika";
                predmrt[i] == newPredmet;
                Console.WriteLine("{0}/{1}", predmrt[i], chas[i]);
            }
            Console.WriteLine("izhod 7");
            for (int i = 0;i < n; i++)
            { 
                Console.WriteLine("{0}/{1}", predmrt[i], chas[i]);

            }
           
        } 
    }
}
