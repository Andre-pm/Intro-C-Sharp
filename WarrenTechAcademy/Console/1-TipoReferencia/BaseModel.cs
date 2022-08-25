using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    //Essa classe é a mãe de todos as entidades, nela está definido o Id que é usado para o nosso "CRUD"
    internal class BaseModel
    {
        public int Id { get; set; }
    }
}
