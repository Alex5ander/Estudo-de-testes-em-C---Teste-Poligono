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

            Assert.AreEqual(2, diametro, "Falha teste diametro do circulo");
            Assert.AreEqual(6.2831853071795862, perimetro, "Falha teste perimetro do circulo");
            Assert.AreEqual(Math.PI, area, "Falha teste area do circulo");
        }

        [Test]
        public void TestarTriangulo()
        {
            double L1 = 100;
            double L2 = 100;
            double L3 = 100;
            Triangulo obj = new Triangulo(L1, L2, L3);
            double perimetro = obj.Perimetro();
            double area = obj.Area(100);
            string tipo = obj.Tipo();

            Assert.AreEqual(300, perimetro, "Falha teste perimetro do trângulo");
            Assert.AreEqual(5000, area, "Falha teste area do triângulo");
            Assert.AreEqual("equilatero", tipo, "Falha teste tipo do triângulo");
        }

        [TestCase(100, 100, 100, 300, "equilatero")]
        [TestCase(100, 200, 300, 600, "escaleno")]
        [TestCase(100, 200, 100, 400, "isoceles")]
        public void TestarTriangulo(double L1, double L2, double L3, double perimetroEsperado, string tipoEsperado)
        {
            Triangulo obj = new Triangulo(L1, L2, L3);
            double perimetro = obj.Perimetro();
            double area = obj.Area(100);
            string tipo = obj.Tipo();

            Assert.AreEqual(perimetroEsperado, perimetro, "Falha teste perimetro do trângulo "+tipoEsperado);
            Assert.AreEqual(5000, area, "Falha teste area do triângulo "+tipoEsperado);
            Assert.AreEqual(tipoEsperado, tipo, "Falha teste tipo do triângulo "+tipoEsperado);
        }
    }
}
