using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Src
{
    public class Passaro : Vertebrados, IAcoes
    {
        public Passaro(TipoPele pele, int qtdPatas, TipoHabitat habitat, bool cauda, string raca, string corBico) : base(pele, qtdPatas, habitat, cauda, raca)
        {
            this.corBico = corBico;
        }

        public void Comer()
        {
            Console.WriteLine($"Passaro {base.Raca} está comendo");
        }

        public void Mover()
        {
            Console.WriteLine($"Passaro {base.Raca} está voando");
        }

        public void Comunicar()
        {
            Console.WriteLine($"Passaro {base.Raca} está piando");
        }

        public string corBico { get; set; }
        public int qtdPenas { get; set; }
    }

}
