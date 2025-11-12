using System;

namespace MiPrimerPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cual es tu nombre?");
            string nombre = Console.ReadLine();
            string fecha=DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine("Hola, " + nombre + "! hoy estamos  " + fecha);


            Console.WriteLine("Por favor, ingresa el primer número:");
            // Leer la entrada y convertir la cadena de texto a un entero
        int numero1 = int.Parse(Console.ReadLine());
        
        // 2. Pedir el segundo número
        Console.WriteLine("Por favor, ingresa el segundo número:");
        
        // Leer la entrada y convertir la cadena de texto a un entero
        int numero2 = int.Parse(Console.ReadLine());
        
        // 3. Calcular la suma
        int suma = numero1 + numero2;
        
        // 4. Mostrar el resultado
        Console.WriteLine($"La suma de {numero1} y {numero2} es: {suma}");
        }

        // Probando commist-profe ayudeme con mi compilacion porfaaa :(
    }
    
}
