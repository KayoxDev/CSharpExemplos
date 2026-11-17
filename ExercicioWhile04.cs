using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExemplos
{
    internal class ExercicioWhile04
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-- Programa ímpares do 1 ao 15 --");
            Console.WriteLine("");

            int contador = 1;

            while(contador <= 15)
            {
                Console.WriteLine(contador);
                contador += 2;
            }
        }
    }
}
