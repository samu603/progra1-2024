using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerproyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Num1: ");
            sbyte num1 = sbyte.Parse(Console.ReadLine());
            Console.Write("Num2: ");
            sbyte num2 = sbyte.Parse(Console.ReadLine());
            int suma = num1 + num2;
            Console.WriteLine("La suma de {0} + {1} = {2}", num1, num2, suma);
            //Pausa.
            Console.ReadLine();
        }
    }
}
