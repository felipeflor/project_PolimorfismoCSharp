using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormasGeometricas;
using FormasGeometricas.Src;

namespace FormasGeometricas
{
    public class Square : Geomatrics
    {
        public  Square(double thebase, double height) : base(thebase, height)
        {
        }

        public double CalcularArea()
        {
            double area = Base * Height;
            return area;
        }


    }
}
