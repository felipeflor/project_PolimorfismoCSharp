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
            gato.Respirar();
            Console.WriteLine($"O gato tem {gato.QtdOssos} ossos\n");

            Crustaceo lagosta = new Crustaceo(TipoPele.Outro, 8, TipoHabitat.Aquatico, true, "lagosta");
            lagosta.AddHexoesqueleto(true);
            lagosta.Comer();
            lagosta.Comunicar();
            lagosta.Mover();
            lagosta.Respirar();
            Console.WriteLine($"A lagosta tem hexoesqueleto? {lagosta.Hexoesquetelo}\n");

            Aracnidio aranha = new Aracnidio(TipoPele.Cabelo, 10, TipoHabitat.Terrestre, false, "aranha");
            aranha.Comer();
            aranha.Mover();
            aranha.Comunicar();
            aranha.Respirar();
            aranha.Pelo = true;
            Console.WriteLine($"A aranha possui pelos? {aranha.Pelo}\n");

            Passaro passarinho = new Passaro(TipoPele.Penas, 2, TipoHabitat.Aéreo, true, "Colerinha", "Preto");
            passarinho.Comer();
            passarinho.Mover();
            passarinho.Respirar();
            passarinho.Comunicar();
            passarinho.AddQtdOssos(15);

        }
    }
}
