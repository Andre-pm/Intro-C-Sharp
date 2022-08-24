using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    internal class BemVindo
    {
        public static void Mensagem()
        {
            System.Console.WriteLine("Bem-vindo!\nInsira seu nome:");
            string nome = System.Console.ReadLine();

            System.Console.WriteLine("Até mais, " + nome);
            System.Console.ReadLine();
        }
    }
}
