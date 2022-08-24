using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._0_TipoValor
{
    internal class TipoBooleano
    {
        public static void Executa()
        {
            bool gostaDeCalypso = true;
            bool GostaDeBaroes = false;
            
            bool ehmaior = 10>11;
            bool ehigual = 10 + 11 == 21;

            if (ehmaior)
            {
                System.Console.WriteLine("Sim");
            }
            else
            {
                System.Console.WriteLine("Não");
            }

        }
    }
}
