using System;

namespace Calculadora
{
    internal static class Program
    {
        public delegate void Operacao(int x, int y);
        static void Main()
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (!string.Equals(opcaoUsuario, "X", StringComparison.OrdinalIgnoreCase))
			{
            
				switch (opcaoUsuario)
				{
					case "1":
                        RecebeValores();
						Operacao op = new(Calculadora.Somar);
                        op.Invoke(10,10);
						break;
					case "2":
                        RecebeValores();
                        op = new(Calculadora.Subtrair);
                        op.Invoke(10,10);
						break;
					case "3":
                        RecebeValores();
                        op = new(Calculadora.Multiplicar);
                        op.Invoke(10,10);
						break;
					case "4":
                        RecebeValores();
						op = new(Calculadora.Dividir);
                        op.Invoke(10,10);
						break;
					case "5":
                        RecebeValores();
						op = new(Calculadora.Somar);
                        op += Calculadora.Subtrair;
                        op += Calculadora.Multiplicar;
                        op += Calculadora.Dividir;
                        op.Invoke(10,10);
						break;
                    case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}

            static void RecebeValores()
            {
                Console.WriteLine("Informe o 1º valor: ");
                int n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o 2º valor: ");
                int n2 = int.Parse(Console.ReadLine());
            }

            static string ObterOpcaoUsuario()
            {
                Console.WriteLine();
                Console.WriteLine("-Calculadora-");
                Console.WriteLine("Informe a operação desejada:");

                Console.WriteLine("1- Somar");
                Console.WriteLine("2- Subtrair");
                Console.WriteLine("3- Multiplicar");
                Console.WriteLine("4- Dividir");
                Console.WriteLine("5- Todas");
                Console.WriteLine("C- Limpar Tela");
                Console.WriteLine("X- Sair");
                Console.WriteLine();

                string opcaoUsuario = Console.ReadLine().ToUpper();
                Console.WriteLine();
                return opcaoUsuario;
            }
        }
    }
}