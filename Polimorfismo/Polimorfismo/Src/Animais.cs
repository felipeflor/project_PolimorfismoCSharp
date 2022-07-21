using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Src
{
    public class Vertebrados : Animal
    {
        public int QtdOssos { get; set; }

        public Vertebrados(TipoPele pele, int qtdPatas, TipoHabitat habitat, 
            bool cauda, string raca) : base(pele, qtdPatas, habitat, cauda, raca){

        }

        public void AddQtdOssos(int qtdOssos){
            QtdOssos = qtdOssos;
        }

    }

    public class Invertebrados : Animal
    {
        public Invertebrados(TipoPele pele, int qtdPatas, TipoHabitat habitat, 
            bool cauda, string raca) : base(pele, qtdPatas, habitat, cauda, raca){

        }

        public bool Hexoesquetelo { get; set; }

        public void AddHexoesqueleto(bool aux){
            Hexoesquetelo = aux;
        }


    }
}
