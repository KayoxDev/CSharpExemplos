using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExemplos
{
    internal class ExercicioFor01
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-- Programa que exiba números do 1 até o 10 --");
            Console.WriteLine("");

            for (int contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine(contador);
            }
        }
    }
}
