using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public abstract class BaseModel
    {
        //Colocado o Key para ele gerar corretamente a primary key em todos os bancos
        [Key]
        public int Id { get; set; }
    }
}
