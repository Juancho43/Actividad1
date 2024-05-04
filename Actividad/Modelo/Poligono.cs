using Actividad.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.Modelo
{
    public class Poligono : ICalculable
    {
        private string Nombre;
        private double Lado;
        private double CantidadLados;

        public Poligono() {
            Nombre = "nuevo";
        }
        public Poligono(double lado, double cantidaLados) { 
            Lado = lado;
            CantidadLados = cantidaLados;
        }

        public double LADO
        {
            set { Lado = value; }
            get { return Lado; }
        }

        public double CalcularArea()
        {
            double apotema = Lado / (2 * Math.Tan(Math.PI / CantidadLados));
            double areaTriangulo = (Lado * apotema) / 2;
            return CantidadLados * areaTriangulo;
        }

        public double CalcularPerimetro()
        {
            return Lado * CantidadLados;
        }
        public override string ToString()
        {
            return "Poligono " + Nombre;
        }
    }
}

