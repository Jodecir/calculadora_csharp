namespace Calculadora.src.Models
{
    public class CalculadoraModel
    {
        public static void Somar(int x, int y)
        {
            System.Console.WriteLine($"Adição: {x + y}");
        }

        public static void Subtrair(int x, int y)
        {
            System.Console.WriteLine($"Subtração: {x - y}");
        }

        public static void Multiplicar(int x, int y)
        {
            System.Console.WriteLine($"Multiplicação: {x * y}");
        }
        
        public static void Dividir(int x, int y)
        {
            System.Console.WriteLine($"Divisão: {x / y}");
        }
    }
}