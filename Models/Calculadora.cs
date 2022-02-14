namespace calculadora_csharp.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            System.Console.WriteLine($"Adição: (x + y)");
        }

        public void Subtrair(int x, int y)
        {
            System.Console.WriteLine($"Subtração: (x - y)");
        }
    }
}