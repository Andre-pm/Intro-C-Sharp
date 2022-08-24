using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._0_TipoValor
{
    internal class Enumeradores
    {
        public static void Executa()
        {
            System.Console.WriteLine(DiasDaSemana.DOM);
            System.Console.WriteLine((byte)DiasDaSemana.DOM);

            DiasDaSemana seg = DiasDaSemana.SEG;
            System.Console.WriteLine(seg);
            
            //Busca o conteúdo do enum na posição 3
            DiasDaSemana ter = (DiasDaSemana)3;
            System.Console.WriteLine(ter);

        }
    }

    public enum DiasDaSemana
    {
        DOM = 1,//Se definir um valor para o primeiro ele continua
        SEG,
        TER,
        QUA,
        QUI,
        SEX,
        SAB
    }
}
