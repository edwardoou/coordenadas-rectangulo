using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Rectangulo
    {
        public Punto Coordenada1 { get; set; }
        public Punto Coordenada2 { get; set; }
        public Punto Coordenada3 { get; set; }
        public Punto Coordenada4 { get; set; }
        double Multiply(Punto p)
        {
            double res = p.x * p.y;
            return res;
        }
        int Distancia(Punto p, Punto q)
        {
            int res = (p.x - q.x) * (p.x - q.x) + (p.y - q.y) * (p.y - q.y);
            return res;
        }
        public double Area(Punto Coordenada1, Punto Coordenada2, Punto Coordenada3, Punto Coordenada4)
        {
            double a1 = Multiply(Coordenada1);
            double a2 = Multiply(Coordenada2);
            double a3 = Multiply(Coordenada3);
            double a4 = Multiply(Coordenada4);
            double res = Math.Abs((a1 + a2 + a3 + a4) - (a1 - a2 - a3 - a4));
            return (res / 2);
        }
        public double Perimetro(Punto Coordenada1, Punto Coordenada2, Punto Coordenada3, Punto Coordenada4)
        {
            double d1 = Distancia(Coordenada1, Coordenada2);
            double d2 = Distancia(Coordenada2, Coordenada3);
            double d3 = Distancia(Coordenada3, Coordenada4);
            double d4 = Distancia(Coordenada4, Coordenada1);
            return d1 + d2 + d3 + d4;
        }
    }
}
