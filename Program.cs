﻿using System;

namespace Calculadora
{
    internal static class Program
    {
        public delegate void Operacao(int x, int y);
        static void Main()
        {
            Operacao op = new(Calculadora.Somar);
            op.Invoke(10,10);
        }
    }
}