using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._0_TipoValor
{
    internal class TipoNumerico3
    {
        public static void Executa()
        {
            System.Console.WriteLine("Float");
            float floatMin = float.MinValue;
            float floatMax = float.MaxValue;
            System.Console.WriteLine("Float min: " + floatMin);
            System.Console.WriteLine("Floar max: " + floatMax);

            System.Console.WriteLine("\nDouble");
            double doubleMin = double.MinValue;
            double doubleMax = double.MaxValue;
            System.Console.WriteLine("Double min: " + doubleMin);
            System.Console.WriteLine("Double max: " + doubleMax);
            
            System.Console.WriteLine("\nDecimal");
            decimal decimalMin = decimal.MinValue;
            decimal decimalMax = decimal.MaxValue;
            System.Console.WriteLine("Decimal min: " + decimalMin);
            System.Console.WriteLine("Decimal max: " + decimalMax);

            decimal n1d = 10.1m;
            decimal n2d = 20.2m;
            decimal resultd = 30.3m;

            System.Console.WriteLine((n1d + n2d) + " - " + resultd);
            System.Console.WriteLine((n1d + n2d) == resultd);

        }
    }
}
