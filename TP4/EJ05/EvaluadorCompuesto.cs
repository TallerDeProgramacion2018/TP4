using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ05
{
    class EvaluadorCompuesto : IEvaluador
    {

        private List<IEvaluador> iEvaluadores = new List<IEvaluador>();

        public EvaluadorCompuesto()
        {

        }

        public bool EsValida(SolicitudPrestamo pSolicitudPrestamo)
        {
            foreach (IEvaluador evaluador in iEvaluadores)
            {
                if (!evaluador.EsValida(pSolicitudPrestamo))
                    return false;
            }

            return true;
        }

        public void AgregarEvaluador(IEvaluador pEvaluador)
        {
            iEvaluadores.Add(pEvaluador);
        }


    }
}
