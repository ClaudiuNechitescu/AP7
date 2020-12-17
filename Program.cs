using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AP7
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.Ej1();
        }
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
        public static void Ej2()
        {
            string frase1 = "Esta es una frase";
            string frase2 = "Esta es una frase";
            if (frase1 == frase2)
            {
                Console.WriteLine("Estas frases son iguales");
            }
            Console.ReadKey();
        }
    }
}
