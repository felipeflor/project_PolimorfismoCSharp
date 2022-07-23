using Polimorfismo.Src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Peixe : Vertebrados, IAcoes
    {
        public Peixe(TipoPele pele, int qtdPatas, TipoHabitat habitat, bool cauda, string raca) : base(pele, qtdPatas, habitat, cauda, raca)
        {
        }

        public void Mover()
        {
            Console.WriteLine($"Peixe {base.Raca} está nadando");
        }

        public void Comer()
        {
            Console.WriteLine($"Peixe {base.Raca} está comendo");
        }

        public void Comunicar()
        {
            Console.WriteLine($"Peixe {base.Raca} faz bolhas");
        }

    }
}
