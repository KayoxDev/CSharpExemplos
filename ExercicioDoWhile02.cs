using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExemplos
{
    internal class ExercicioDoWhile02
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-- Programa que exiba números de 15 até 5 --");
            Console.WriteLine("");

            int contador = 15;

            do
            {
                Console.WriteLine(contador);
                contador--;
            }
            while (contador >= 5);
        }
    }
}
