using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ05
{
    public class ControladorFachada
    {

        private GestorPrestamos iGestor = new GestorPrestamos();

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return iGestor.EsValida(pSolicitud);
        }

    }
}
