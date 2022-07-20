using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Src
{
    public class Animal
    {
        public TipoPele Pele { get; set; }
        public int QtdPatas { get; set; }
        public TipoHabitat Habitat { get; set; }
        public bool Cauda { get; set; }
        public string Raca { get; set; }

        public virtual void Respirar()
        {
            Console.WriteLine("Respiração comum...");
        }

        public virtual void Caracteristicas()
        {
            Console.WriteLine("Caracteristicas comum...");
        }

        public Animal(TipoPele pele, int qtdPatas, TipoHabitat habitat, bool cauda, string raca)
        {
            Pele = pele;
            QtdPatas = qtdPatas;
            Habitat = habitat;
            Cauda = cauda;
            Raca = raca;
        }
    }

    public enum TipoHabitat
    {
        Aquatico,
        Terrestre,
        Aéreo
    }

    public enum TipoPele
    {
        Penas, 
        Cabelo,
        Escama,
        Outro
    }
}
