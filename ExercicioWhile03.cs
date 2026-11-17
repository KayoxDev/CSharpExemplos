using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExemplos
{
    internal class ExercicioWhile03
    {
        public static void Main(string[] args)
        {
            int contador = 2;

            while(contador <= 20)
            {               
               Console.WriteLine(contador);
                contador += 2;
            }
        }
    }
}
