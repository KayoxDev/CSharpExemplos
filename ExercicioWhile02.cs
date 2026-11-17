using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExemplos
{
    internal class ExercicioWhile02
    {
        public static void Main(string[] args)
        {
            int contador = 20;

            while (contador >= 1)
            {
                Console.WriteLine(contador);
                contador--;
            }
        }
    }
}
