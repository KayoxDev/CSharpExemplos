using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExemplos
{
    internal class ExemploDoWhile
    {
        public static void Main(string[] args)
        {
            int contador = 1;

            do
            {
                Console.WriteLine(contador);
                contador++;
            }
            while (contador <= 5);
        }
    }
}
