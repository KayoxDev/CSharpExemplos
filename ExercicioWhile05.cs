using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExemplos
{
    internal class ExercicioWhile05
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-- Programa contagem regressiva de 30 até 0 em 3 em 3 --");
                Console.WriteLine("");

            int contador = 30;

            while(contador >= 0)
            {
                Console.WriteLine(contador);
                contador -= 3;
            }
        }
    }
}
