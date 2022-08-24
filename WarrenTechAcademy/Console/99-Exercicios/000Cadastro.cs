using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._99_Exercicios
{
    internal class _000Cadastro
    {
        public void Exer1() {
            System.Console.WriteLine("Bem Vindo!");
            
            System.Console.WriteLine("Para começar, informe seu primeiro nome:");
            string primeiroNome = System.Console.ReadLine();

            System.Console.WriteLine("Certo " + primeiroNome + ", agora preciso do seu sobrenome");
            string sobrenome = System.Console.ReadLine();

            System.Console.WriteLine("E qual a sua idade?");
            Byte idade = System.Convert.ToByte(System.Console.ReadLine());

            System.Console.WriteLine("Cadastro Efetuado! Confira as informações:");
            System.Console.WriteLine("Nome Completo: " + primeiroNome + " " + sobrenome);
            System.Console.WriteLine("Idade: " + idade);
            System.Console.WriteLine("Até mais " + primeiroNome);

        }
    }
}
