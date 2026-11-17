using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExemplos
{
    internal class ExercicioDoWhile01
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa que exibe números do 1 ao 10");
            Console.WriteLine("");

            int contador = 1;

            do
            {
                Console.WriteLine(contador);
                contador++;
            }
            while (contador <= 10);
        }
    }
}
