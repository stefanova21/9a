using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // zadelane na pamet 
            double[] pari = new double[2];
            string[] vidZakuska = new string[2];
            // vhod
            for (int i = 0; i <= 2; i++) 
            {
                Console.WriteLine("vuvedi pari");
                pari[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("vuvedi vidZakuska");
                vidZakuska[i] = Console.ReadLine();
            }
            for (int i = 0; i <= 2; i++) 
            {
                Console.WriteLine(vidZakuska[i] + "/" + pari[i]);
            }
        }
       
         

    
    }
}
