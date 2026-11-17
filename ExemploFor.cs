using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExemplos
{
    internal class ExemploFor
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-- Programa exibe número do 1 até 5 --");
            Console.WriteLine("");

            for (int contador = 1; contador <= 5; contador++)
            {
                Console.WriteLine(contador);
            }
        }
    }
}
