using System;
namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, opciones;
            //MENÚ DE FUNCIONES//
            Console.WriteLine("CALCULADORA \n"+"Ingresa el número de la función a realizar. \n"
                +"1.SUMA \n" + "2.RESTA \n" + "3.MULTIPLICACIÓN \n" + "4.DIVISIÓN");
            opciones = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el Primer Número");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el Segundo Numero");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (opciones == 1)/*SUMA*/ { n3 = n1 + n2;
                Console.WriteLine("La Suma es: " + n3);
            }
            if(opciones == 2)/*RESTA*/{ n3 = n1 - n2;
                Console.WriteLine("La Resta es: " + n3);
            }
            if(opciones == 3)/*DIVISIÓN*/ { n3 = n1 / n2;
                Console.WriteLine("La Multiplicación es: " + n3);
            }
            if(opciones == 4)/*MULTIPLICACIÓN*/ { n3 = n1 * n2;
                Console.WriteLine("La División es: " + n3);
            }
            Console.ReadKey();
        }
    }
}
