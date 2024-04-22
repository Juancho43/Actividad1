using Actividad.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.Modelo
{
    public  class Triangulo : ICalculable
    {
        private string Nombre;
        private double Lado1 {  get; set; }
        private double Lado2 {  get; set; }
        private double Lado3 {  get; set; }
        private double Altura {  get; set; }
        
        public Triangulo() {
            Nombre = "nuevo";
        }
        public Triangulo(double lado1, double lado2, double lado3)
        {
            this.Lado1 = lado1;
            this.Lado2 = lado2;
            this.Lado3 = lado3;
            
        }

        enum TipoTriangulo
        {
            Equilatero,
            Isosceles,
            Escaleno
        }

        public double CalcularArea()
        {
            double semiperimetro = CalcularPerimetro() / 2;
            double area = Math.Sqrt(semiperimetro * (semiperimetro - Lado1) * (semiperimetro - Lado2) * (semiperimetro - Lado3));
            return area;
        }

        public double CalcularPerimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }
        

        public double CalcularAltura()
        {  
            
            TipoTriangulo tipoTriangulo = GetTipoTriangulo();
            double height;
            switch (tipoTriangulo)
            {
                case TipoTriangulo.Equilatero:
                    height = Lado1 * Math.Sqrt(3) / 2;
                    break;
                case TipoTriangulo.Isosceles:
                    double equalSide = Lado1 == Lado2 ? Lado1 : Lado2;
                    height = Math.Sqrt(equalSide * equalSide - (Lado3 / 2) * (Lado3 / 2));
                    break;
                case TipoTriangulo.Escaleno: 
                    height = (2 * CalcularArea()) / GetLadoMasLargo();
                    break;
                default:
                    throw new Exception("Tipo triangulo invalido");
            }
            Altura = height;
            return height;
        }

        
        private TipoTriangulo GetTipoTriangulo()
        {
            if (Lado1 == Lado2 && Lado2 == Lado3)
            {
                return TipoTriangulo.Equilatero;
            }
            else if (Lado1 == Lado2 || Lado2 == Lado3 || Lado1 == Lado3)
            {
                return TipoTriangulo.Isosceles;
            }
            else
            {
                return TipoTriangulo.Escaleno;
            }
        }

        
        private double GetLadoMasLargo()
        {
            double max = Math.Max(Lado1, Lado2);
            return Math.Max(max, Lado3);
        }

      

        public override string ToString()
        {
            return "Triangulo " + Nombre;
        }
    }
}
