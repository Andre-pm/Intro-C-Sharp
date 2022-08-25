using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    //Adicionado T para transformar o Repository para aceitar tipos genéricos
    //Essa interface define que todos os repositórios vão ter esses métodos, seguindo essa assinatura
    internal interface IRepository<T>
    {
        string Create(T p);
        List<T> Read();
        string Update(T p);
        string Delete(int id);
    }
}
