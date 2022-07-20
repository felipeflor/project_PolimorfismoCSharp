using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Src
{
    internal class Mamifero : Vertebrados, IAcoes
    {
        public string Praga { get; set; }
        public Mamifero(TipoPele pele, int qtdPatas, TipoHabitat habitat, 
            bool cauda, string raca) : base(pele, qtdPatas, habitat, cauda, raca)
        {
        }

        public void Comer()
        {
            Console.WriteLine($"Mamifero {base.Raca} comendo!");
        }

        public void Comunicar()
        {
            Console.WriteLine($"Mamifero {base.Raca} está se comunicando!");
        }

        public void Mover()
        {
            Console.WriteLine($"Mamifero {base.Raca} está se comunicando!");
        }
    }
}
