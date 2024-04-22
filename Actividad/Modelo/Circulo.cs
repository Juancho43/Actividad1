using Actividad.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.Modelo
{
    public class Circulo : ICalculable
    {
        private string Nombre;
        private double Radio {  get; set; }

        public Circulo() {
            Nombre = "nuevo";
        }
        public Circulo(double radio)
        {
            Radio = radio;            
        }
        
        public double GetRadio()
        {
            return Radio;
        }

        public double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }

        public override string ToString()
        {
            return "Circulo " + Nombre;
        }

    }
}
