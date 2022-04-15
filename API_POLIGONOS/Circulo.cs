using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_POLIGONOS
{
    public class Circulo
    {
        public double Raio { get; set; }
        public Circulo(double Raio)
        {
            this.Raio = Raio;
        }

        public double Diametro()
        {
            return Raio * 2;
        }

        public double Perimetro()
        {
            return 2 * Math.PI * Raio;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }
    }
}
