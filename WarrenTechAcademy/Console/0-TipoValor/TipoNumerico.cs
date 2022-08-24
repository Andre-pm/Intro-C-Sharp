using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._0_TipoValor
{
    internal class TipoNumerico
    {
        public void Executa()
        {
            byte byteMin = Byte.MinValue;
            byte byteMax = Byte.MaxValue;
            System.Console.WriteLine("Byte");
            System.Console.WriteLine("Byte Min:" + byteMin);
            System.Console.WriteLine("Byte Max:" + byteMax);
            
            sbyte sbyteMin = sbyte.MinValue;
            sbyte sbyteMax = sbyte.MaxValue;
            System.Console.WriteLine("\nsByte");
            System.Console.WriteLine("sByte Min:" + sbyteMin);
            System.Console.WriteLine("sByte Max:" + sbyteMax);
            
            short shortMin = short.MinValue;
            short shortMax = short.MaxValue;
            System.Console.WriteLine("\nShort");
            System.Console.WriteLine("Short Min:" + shortMin);
            System.Console.WriteLine("Short Max:" + shortMax);

            ushort ushortMin = ushort.MinValue;
            ushort ushortMax = ushort.MaxValue;
            System.Console.WriteLine("\nuShort");
            System.Console.WriteLine("uShort Min:" + ushortMin);
            System.Console.WriteLine("uShort Max:" + ushortMax);

            System.Console.WriteLine("\nInt");
            int intMin = int.MinValue;
            int intMax = int.MaxValue;
            System.Console.WriteLine("int Min:" + intMin);
            System.Console.WriteLine("int Max:" + intMax);

            System.Console.WriteLine("\nInt16");
            Int16 int16Min = Int16.MinValue;
            Int16 int16Max = Int16.MaxValue;
            System.Console.WriteLine("int16 Min:" + int16Min);
            System.Console.WriteLine("int16 Max:" + int16Max);

            System.Console.WriteLine("\nInt32");
            Int32 int32Min = Int32.MinValue;
            Int32 int32Max = Int32.MaxValue;
            System.Console.WriteLine("int32 Min:" + int32Min);
            System.Console.WriteLine("int32 Max:" + int32Max);

            System.Console.WriteLine("\nInt64");
            Int64 int64Min = Int64.MinValue;
            Int64 int64Max = Int64.MaxValue;
            System.Console.WriteLine("int64 Min:" + int64Min);
            System.Console.WriteLine("int64 Max:" + int64Max);

            System.Console.WriteLine("\nLong");
            long longMin = long.MinValue;
            long longMax = long.MaxValue;
            System.Console.WriteLine("long Min: "+ longMin);
            System.Console.WriteLine("long Max: " + longMax);

        }
    }
}
