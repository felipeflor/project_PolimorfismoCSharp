using System;
using Polimorfismo.Src;

namespace Polimorfismo
{
    public class Program
    {
        static void Main(string[] args){
            var gato = new Mamifero(TipoPele.Cabelo, 4, TipoHabitat.Terrestre, true, "gato");
            gato.AddQtdOssos(150);

            gato.Comer();
            gato.Comunicar();
            gato.Mover();

            Console.WriteLine($"O gato tem {gato.QtdOssos} ossos");
        }
    }
}
