using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora_6A.Libreria;

namespace Calculadora6A.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodos misMetodos = new Metodos();
            Console.WriteLine(misMetodos.Saludo());
            Console.Write("Suma: ");
            Console.WriteLine(misMetodos.Sumar(15,45));
            Console.Write("Resta: ");
            Console.WriteLine(misMetodos.Restar(15,5));
            Console.Write("Multiplicacion: ");
            Console.WriteLine(misMetodos.Multiplicar(5,4));
            Console.Write("Division: ");
            Console.WriteLine(misMetodos.Dividir(45,15));
            Console.ReadKey();
        }
    }
}
