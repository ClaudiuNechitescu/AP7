﻿using System;

namespace AP7
{
    public class Ejercicio1
    {
        public static void Ej1()
        {
            Console.Write("Introduce un número del 1 al 10: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            switch (numero)
            {
                case 1:
                    {
                        Console.WriteLine("I");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("II");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("III");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("IV");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("V");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("VI");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("VII");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("VIII");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("IX");
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("X");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
