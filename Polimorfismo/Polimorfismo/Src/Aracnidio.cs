using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Src
{
    public class Aracnidio : Invertebrados, IAcoes
    {
        public Aracnidio(TipoPele pele, int qtdPatas, TipoHabitat habitat, bool cauda, string raca) : base(pele, qtdPatas, habitat, cauda, raca)
        {
        }

        public bool Pelo { get; set; }


        public void Comer()
        {
            Console.WriteLine($"Aracnidio {base.Raca} está comendo");
        }

        public void Mover()
        {
            Console.WriteLine($"Aracnidio {base.Raca} está se movendo");
        }

        public void Comunicar()
        {
            Console.WriteLine($"Aracnideo {base.Raca} está se comunicando");
        }

    }
}
