using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1_TipoReferencia
{
    internal class Animal : BaseModel
    {
        public string Nome { get; set; }

        public string NomeCientifico { get; set; }

        public double Peso { get; set; }

        public string Categoria { get; set; }

        public Animal(string nome, string nomeCientifico, double peso, string categoria)
        {
            this.Nome = nome;
            this.NomeCientifico = nomeCientifico;
            this.Peso = peso;
            this.Categoria = categoria;
        }

        public string getInfo()
        {
            return $"Nome : {Nome}\nNome Científico: {NomeCientifico}\nPeso: {Peso}\nCategoria: {Categoria}";
        }
    }
}
