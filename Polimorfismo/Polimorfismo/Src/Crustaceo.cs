using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Src
{
    public class Crustaceo : Invertebrados, IAcoes
    {
        public Crustaceo(TipoPele pele, int qtdPatas, TipoHabitat habitat, bool cauda, string raca) : base(pele, qtdPatas, habitat, cauda, raca)
        {
        }

        public int drzHexoesqueleto { get; set; }

        public void Comer()
        {
            Console.WriteLine($"Crustaceo {base.Raca} está comendo");
        }

        public void Mover()
        {
            Console.WriteLine($"Crustaceo {base.Raca} está se movendo");
        }

        public void Comunicar()
        {
            Console.WriteLine($"Crustaceo {base.Raca} está se comunicando");
        }

    }
}
