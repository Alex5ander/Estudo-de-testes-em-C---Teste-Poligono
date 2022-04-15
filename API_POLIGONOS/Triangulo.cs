using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_POLIGONOS
{
   public class Triangulo
    {
        public double L1 { get; set; }
        public double L2 { get; set; }
        public double L3 { get; set; }

        public Triangulo(double L1, double L2, double L3)
        {
            this.L1 = L1;
            this.L2 = L2;
            this.L3 = L3;
        }

        public double Perimetro()
        {
            return L1 + L2 + L3;
        }

        public double Area(double h)
        {
            return (L1 * h) / 2;
        }

        public string Tipo()
        {
            if (L1 == L2 && L2 == L3) return "equilatero";
            else if (L1 != L2 && L1 != L3) return "escaleno";
            else return "isoceles";
        }
    }
}
