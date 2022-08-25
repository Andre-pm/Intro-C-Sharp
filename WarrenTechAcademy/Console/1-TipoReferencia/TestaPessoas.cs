using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    internal class TestaPessoas
    {
        public static void ExecutaPessoa()
        {
            //Criado instâncias de pessoa, pessoa física e pessoa juridíca
            Pessoa p = new Pessoa("André", "Martins");
            Pessoa pf = new PessoaFisica("N", "S", "cpf");
            Pessoa pj = new PessoaJuridica("N", "S", "cnpj");
            
            //Para mostrar os dados ocultos das filhas é necessário converter novamente, assim conseguimos acessar os atributos daquela classe e não apenas o da mãe
            PessoaFisica pf2 = (PessoaFisica)pf;
            PessoaJuridica pj2 = (PessoaJuridica)pj;

            //Instanciamos a BaseRepository
            BaseRepository repo = new BaseRepository();
            //Adicionamos a classe Pessoa, Pessoa física e Jurídica criados 
            repo.Create(p);
            repo.Create(pf2);
            repo.Create(pj2);
            
            //Aqui está executando em cada pessoa da lista do repositório o método Saudação
            foreach (var pessoas in repo.Read())
            {
                System.Console.WriteLine(pessoas.Saudacao());
            }
        }
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
