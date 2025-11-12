using System;

namespace MiPrimerPrograma
{
    class Program
    {
        static void Main(string[] args)
        {   

        string[] frutas = new string[3];
            frutas[0] = "Manzana";
            frutas[1] = "Banana";
            frutas[2] = "Naranja";

        for (int i = 0; i < frutas.Length; i++)
        {
            Console.WriteLine($"Fruta [{i}]: {frutas[i]}");
        };

        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        var frutasList = new List<string> { "Manzana", "Banana", "Naranja" };
        
        foreach (string fruta in frutasList)
        {
            Console.WriteLine(fruta);
        }

        Dictionary<string, int> frutasDict = new Dictionary<string, int>();
            frutasDict.Add("Manzana", 1);
            frutasDict.Add("Banana", 2);
            frutasDict.Add("Naranja", 3);
            frutasDict.Add("Pina", 3);

        foreach (var fruta in frutasDict)
        {
            Console.WriteLine($"Fruta: {fruta.Key} - {fruta.Value}");
        }


            /*
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
        */
        }
    }
    
}
