using System;

class OperacionesBasicas
{
    static void Main()
    {
        int num1, num2, resultado;
        string operacion;

        Console.Write("Ingrese el primer número: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        num2 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese la operación (+, -, *, /): ");
        operacion = Console.ReadLine();

        switch (operacion)
        {
            case "+":
                resultado = num1 + num2;
                break;
            case "-":
                resultado = num1 - num2;
                break;
            case "*":
                resultado = num1 * num2;
                break;
            case "/":
                resultado = num1 / num2;
                break;
            default:
                resultado = 0;
                break;
        }

        Console.WriteLine("El resultado es: " + resultado);
        Console.ReadKey();
    }
}