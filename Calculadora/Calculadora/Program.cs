using System;
namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, opciones;
            //MENÚ DE FUNCIONES//
            Console.WriteLine("CALCULADORA \n"+"Ingresa el numero de la funcion a realizar \n"
                +"1.SUMA \n" + "2.RESTA \n" + "3.MULTIPLICACION \n" + "4.DIVICION");
            opciones = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Primer Numero");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Segundo Numero");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (opciones == 1)/*SUMA*/ { n3 = n1 + n2;
                Console.WriteLine("La resta es: " + n3);
            }
            if(opciones == 2)/*RESTA*/{ n3 = n1 - n2;
                Console.WriteLine("La resta es: " + n3);
            }
            if(opciones == 3)/*DIVICION*/ { n3 = n1 / n2;
                Console.WriteLine("La resta es: " + n3);
            }
            if(opciones == 4)/*MULTIPLICACION*/ { n3 = n1 * n2;
                Console.WriteLine("La resta es: " + n3);
            }
            Console.ReadKey();
        }
    }
}
