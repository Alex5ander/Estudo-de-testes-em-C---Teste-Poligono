using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_POLIGONOS;
using NUnit.Framework;

namespace ClassLibrary1
{
    [TestFixture]
    public class TestePoligono
    {

        [Test]
        public void TestarCirculo()
        {
            Circulo obj = new Circulo(1);
            double diametro = obj.Diametro();
            double perimetro = obj.Perimetro();
            double area = obj.Area();

            Assert.AreEqual(Math.PI, area, "Falha teste area");

            Assert.AreEqual(6.2831853071795862, perimetro, "Falha teste perimetro");
        }

        public void TestarTriangulo()
        {
            double L1 = 100;
            double L2 = 100;
            double L3 = 100;
            Triangulo obj = new Triangulo(L1, L2, L3);
            double perimetro = obj.Perimetro();
            double area = obj.Area(100);
            string tipo = obj.Tipo();
        }
    }
}
