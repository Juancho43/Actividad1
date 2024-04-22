using Actividad.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.Modelo
{
    public class Cuadrado : ICalculable
    {
        private string Nombre;
        private double Lado {  get; set; }
        public Cuadrado() {
            Nombre = "nuevo";
        }
        public Cuadrado(double Lado)
        {
            this.Lado = Lado;
            
        }
        public double GetLado()
        {
            return this.Lado;
        }
        public double CalcularArea()
        {
            return Lado * Lado;
        }
        public double CalcularPerimetro()
        {
            return 4 * Lado;
        }
        public override string ToString()
        {
            return "Cuadrado " + Nombre;
        }
    }
}
