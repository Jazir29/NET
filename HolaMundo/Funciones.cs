using System;

class Funciones
{
    public int Cuadrado(int numero)
    {
        return numero * numero;
    }

    public void Intercambio(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public int sumar(int x, int y)
    {
        return x + y;
    }

    public void mostrarResultado(int resultado)
    {
        Console.WriteLine("Suma: " + resultado);
    }

    //metodo para calcular el mayor entre dos numeros
    public int Mayor(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    //metodo para calcular el aumento del 10% del salario
    public void AumentoSalario(ref double salario)
    {
        salario = salario * 1.10;
    }

}