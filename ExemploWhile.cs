using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExemplos
{
    internal class ExemploWhile
    {
        public static void Main(string[] args)
        {
            int contador = 1;

            while (contador <= 10){
                Console.WriteLine(contador);
                    contador++;
            }
        }
    }
}
