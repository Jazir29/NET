using System;

namespace MiPrimerPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------------- CLASE 9 C# Parte 1 ----------------

            /*
            Funciones funciones = new Funciones();
            //Console.WriteLine(funciones.Cuadrado(5));

            // calcular el mayor entre dos numeros
            int numero1 = 10;
            int numero2 = 20;
            int mayor = funciones.Mayor(numero1, numero2);
            Console.WriteLine($"El mayor entre {numero1} y {numero2} es: {mayor}");


            // calcular el aumento del 10% del salario
            double salario = 5000;
            double nuevoSalario = funciones.AumentoSalario(salario);
            Console.WriteLine($"El nuevo salario con aumento es: {nuevoSalario}");
            */

            // ---------------- CLASE 9 C# Parte 2 ----------------

            Producto producto1 = new Producto("Laptop", 1500, 10);
            producto1.MostrarInfo();
            Producto producto2 = new Producto("Compu Gamer", 1999.99m, 10);
            producto2.MostrarInfo();


        }
    }

}
