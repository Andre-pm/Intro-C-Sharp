using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    internal class TestaPessoas
    {
        public static void ExecutaFisica()
        {
            PessoaFisica pessoaFisica = new PessoaFisica(nome: "André", sobrenome: "Martins", cpf: "000.000.000-00");
            PessoaFisica pessoaFisica2 = new PessoaFisica(nome: "João", sobrenome: "Jesus dos Santos", cpf: "111.111.111-11");

            PessoaFisicaRepository repository = new PessoaFisicaRepository();
         
            repository.Create(pessoaFisica2);
            
            string msg = repository.Create(pessoaFisica);
            System.Console.WriteLine(msg);

            List<PessoaFisica> pessoas = repository.Read();

            foreach (PessoaFisica p in pessoas)
            {
                System.Console.WriteLine(p.Saudacao());
            }
        }

        public static void ExecutaJuridica()
        {
            PessoaJuridica pessoaJuridica = new PessoaJuridica(nome: "Warren", sobrenome: "Investimentos", cnpj: "06764477000120");
            PessoaJuridica pessoaJuridica2 = new PessoaJuridica(nome: "Outros", sobrenome: "Investimentos", cnpj: "65262626626262");
            PessoaJuridicaRepository repository1 = new PessoaJuridicaRepository();

      

            System.Console.WriteLine(repository1.Create(pessoaJuridica));
            System.Console.WriteLine(repository1.Create(pessoaJuridica2));

            List<PessoaJuridica> juridicas = repository1.Read();

            foreach (PessoaJuridica pj in juridicas)
            {
                System.Console.WriteLine(pj.Saudacao());
            }
        }
    }
}
