using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ05
{
    class EvaluadorSueldo : IEvaluador
    {

        private double iSueldoMinimo;

        public EvaluadorSueldo(double pSueldoMinimo)
        {
            iSueldoMinimo = pSueldoMinimo;
        }

        public bool EsValida(SolicitudPrestamo pSolicitudPrestamo)
        {
            if (pSolicitudPrestamo.Cliente.Empleo.Sueldo >= iSueldoMinimo)
                return true;
            else
                return false;
        }
    }
}
