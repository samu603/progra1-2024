﻿using System;
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
            //Uso de funciones...
            Console.WriteLine("La suma de 10+5={0}", suma());
            Console.ReadLine();
        }
        static int suma()
        {
            int respuesta = 10 + 5;
            return respuesta;
        }
    }
    }


