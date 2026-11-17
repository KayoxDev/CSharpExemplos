using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExemplos
{
    internal class ExercicioDoWhile03
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-- Programa que exiba números pares de 2 até 20 --");
            Console.WriteLine("");

            int contador = 2;

            do
            {
                Console.WriteLine(contador);
                contador += 2;
            }
            while (contador <= 20);
        }
    }
}
