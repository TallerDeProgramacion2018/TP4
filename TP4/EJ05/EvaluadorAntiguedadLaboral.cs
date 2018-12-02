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

        // Evalúa la edad calculando la diferencia entre el día en cual se llama el método
        // y el día de ingreso al trabajo, se toma la cantidad de días y se divide entre 30
        // para conseguir la cantidad de meses de trabajo con un mínimo error.
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
