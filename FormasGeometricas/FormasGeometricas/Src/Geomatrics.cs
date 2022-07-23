using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricas.Src
{
    public class Geomatrics
    {
        private double thebase;

        public double Base { get; set; }
        public double Height { get; set; }
        public double Area { get; set; }

        public Geomatrics(double thebase, double height, double area)
        {
            Base = thebase;
            Height = height;
            Area = area;
        }

        public Geomatrics(double thebase, double height)
        {
            Base = thebase;
            Height = height;
        }
    }
}
