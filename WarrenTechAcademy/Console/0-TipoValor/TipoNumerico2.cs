using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._0_TipoValor
{
    internal class TipoNumerico2
    {
        public static void Executa()
        {
            char letra = 'A';
            System.Console.WriteLine("Char: "+letra);
            char charMin = char.MinValue;
            char charMax = char.MaxValue;

            System.Console.WriteLine("Min: " + charMin);
            System.Console.WriteLine("Max: " + charMax);

            System.Console.WriteLine("Letra A: " + (byte)letra);
        }
    }
}
