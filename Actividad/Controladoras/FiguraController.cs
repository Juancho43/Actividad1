using Actividad.Interfaces;
using Actividad.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.Controladoras
{
    public class FiguraController
    {
        private List<ICalculable> Figuras = new List<ICalculable>();        
        public List<ICalculable> GetFiguras()
        {
            return Figuras;
        }
        
        public void SetFigura(ICalculable nuevaFigura)
        {
            Figuras.Add(nuevaFigura);
        }
      
        public bool VerificarTriangulo(double lado1, double lado2, double lado3)
        {
            bool esTriangulo = true;
            if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0)
            {
                esTriangulo = false; 
            }

            if (lado1 + lado2 <= lado3 || lado2 + lado3 <= lado1 || lado1 + lado3 <= lado2)
            {
                esTriangulo = false; 
            }

            return esTriangulo; 
        }

    }
}
