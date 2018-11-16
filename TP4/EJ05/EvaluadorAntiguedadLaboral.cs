using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ05
{
    class EvaluadorAntiguedadLaboral : IEvaluador
    {

        private int iAntiguedadMinima;

        public EvaluadorAntiguedadLaboral(int pAntiguedadMinima)
        {
            iAntiguedadMinima = pAntiguedadMinima;
        }

        public bool EsValida(SolicitudPrestamo pSolicitudPrestamo)
        {
            TimeSpan tiempoTrabajo = DateTime.Today-(pSolicitudPrestamo.Cliente.Empleo.FechaIngreso);
            double mesesTrabajo = tiempoTrabajo.TotalDays / 30;

            if (mesesTrabajo > iAntiguedadMinima)
                return true;

            else
                return false;
        }
    }
}
