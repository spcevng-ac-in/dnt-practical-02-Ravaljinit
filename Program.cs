using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Km, Kg, Ch;
            Console.WriteLine("Enter the Kilometer");
            Km = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Kg value");
            Kg = int.Parse(Console.ReadLine());
            if (Km <= 100)
            {
                Ch = 50 * Km;
            }
            else if (Km >100 && Km <= 200)
            {
                Ch = 65 * Km;
            }
            else if (Km > 200 && Km <= 300)
            {
                Ch = 90 * Km;
            }
            else
            {
                Ch = 120 * Km;
            }
            Console.WriteLine("Total Charge = " + Ch);
            Console.ReadLine();
        }
    }
}
