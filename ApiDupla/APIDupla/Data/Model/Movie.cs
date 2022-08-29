using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Movie : BaseModel
    {
        public string Titulo { get; set; }
        public string TituloOriginal { get; set; }
        public string Diretor { get; set; }
        public string Descrição { get; set; }
        public string Categoria { get; set; }
        public int AnoLancamento { get; set; }
    }
}
