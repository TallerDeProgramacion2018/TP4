using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ05
{
    class EvaluadorMonto : IEvaluador
    {

        private double iMontoMaximo;

        public EvaluadorMonto(double pMontoMaximo)
        {
            iMontoMaximo = pMontoMaximo;
        }

        public bool EsValida(SolicitudPrestamo pSolicitudPrestamo)
        {
            if (pSolicitudPrestamo.Monto <= iMontoMaximo)
                return true;
            else
                return false;
        }
    }
}
