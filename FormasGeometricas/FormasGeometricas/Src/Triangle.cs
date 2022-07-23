using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas.Src
{
    public class Triangle : Geomatrics
    {
        public Triangle(double thebase, double height) : base(thebase, height)
        {
        }

        public double CalcularArea()
        {
            double area = ( Base * Height ) / 2;
            return area;
        }
    }
}
