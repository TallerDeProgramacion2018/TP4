using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ05
{
    class EvaluadorCantidadCuotas : IEvaluador
    {

        private int iCantidadMaximaCuotas;

        public EvaluadorCantidadCuotas(int pCantidadMaximaCuotas)
        {
            iCantidadMaximaCuotas = pCantidadMaximaCuotas;
        }

        public bool EsValida(SolicitudPrestamo pSolicitudPrestamo)
        {
            if (pSolicitudPrestamo.CantidadCuotas <= iCantidadMaximaCuotas)
                return true;
            else
                return false;
        }

    }
}
