using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ05
{
    class EvaluadorEdad : IEvaluador
    {

        private int iEdadMinima;
        private int iEdadMaxima;

        public EvaluadorEdad(int pEdadMinima, int pEdadMaxima)
        {
            iEdadMaxima = pEdadMaxima;
            iEdadMinima = pEdadMinima;
        }
        
        // Se calcula la edad en días y se evalúa si pertenece al intervalo de edades permitidas.
        public bool EsValida(SolicitudPrestamo pSolicitudPrestamo)
        {
            TimeSpan edad = DateTime.Today.Subtract(pSolicitudPrestamo.Cliente.FechaNacimiento);
            double edadEnDias = edad.TotalDays;
            if ((edadEnDias > iEdadMinima * 365) && (edadEnDias < iEdadMaxima * 365))
                return true;
            else
                return false;
        }
    }
}
