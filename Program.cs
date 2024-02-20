using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            float totalFacturado, comision, sueldofinal;
            Console.WriteLine("Ingresar el total facturado:");
            totalFacturado = float.Parse(Console.ReadLine());
            // aca Maxi explica algo muy interesante de (const float sueldofijo = 15000)
            // entre ese parentesis dice que esa es una variable constante o sea que no se va a cambiar nunca
            // siempre va a ser constante 
            comision = totalFacturado * 0.05F;
            sueldofinal = comision + 15000;
            Console.WriteLine("Sueldo total a cobrar es: " + sueldofinal);
        }
    }
}
