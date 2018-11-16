using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ05
{
    class GestorPrestamos
    {

        private Dictionary<TipoCliente, IEvaluador> iEvaluadoresPorCliente;

        public GestorPrestamos()
        {
            iEvaluadoresPorCliente = new Dictionary<TipoCliente, IEvaluador>();
            EvaluadorCompuesto evaluadorNoCliente = CrearEvaluadorNoCliente(CrearEvaluadorGenerico());
            iEvaluadoresPorCliente.Add(TipoCliente.NoCliente, evaluadorNoCliente);

            EvaluadorCompuesto evaluadorCliente = CrearEvaluadorCliente(CrearEvaluadorGenerico());
            iEvaluadoresPorCliente.Add(TipoCliente.Cliente, evaluadorCliente);

            EvaluadorCompuesto evaluadorClienteGold = CrearEvaluadorClienteGold(CrearEvaluadorGenerico());
            iEvaluadoresPorCliente.Add(TipoCliente.ClienteGold, evaluadorCliente);

            EvaluadorCompuesto evaluadorClientePlatinum = CrearEvaluadorClientePlatinum(CrearEvaluadorGenerico());
            iEvaluadoresPorCliente.Add(TipoCliente.ClientePlatinum, evaluadorCliente);
        }

        public bool EsValida(SolicitudPrestamo pSolicitud)
        {
            return iEvaluadoresPorCliente[pSolicitud.Cliente.TipoCliente].EsValida(pSolicitud);
        }

        public EvaluadorCompuesto CrearEvaluadorGenerico()
        {
            EvaluadorCompuesto evaluador = new EvaluadorCompuesto();

            EvaluadorEdad evaluadorEdad = new EvaluadorEdad(18, 75);
            evaluador.AgregarEvaluador(evaluadorEdad);

            EvaluadorAntiguedadLaboral evaluadorAntiguedad = new EvaluadorAntiguedadLaboral(6);
            evaluador.AgregarEvaluador(evaluadorAntiguedad);

            EvaluadorSueldo evaluadorSueldo = new EvaluadorSueldo(5000);
            evaluador.AgregarEvaluador(evaluadorSueldo);

            return evaluador;
        }

        public EvaluadorCompuesto CrearEvaluadorNoCliente(EvaluadorCompuesto pEvaluadorGenerico)
        {
            EvaluadorCantidadCuotas evaluadorCuotas = new EvaluadorCantidadCuotas(12);
            pEvaluadorGenerico.AgregarEvaluador(evaluadorCuotas);

            EvaluadorMonto evaluadorMonto = new EvaluadorMonto(20000);
            pEvaluadorGenerico.AgregarEvaluador(evaluadorMonto);

            return pEvaluadorGenerico;
        }

        public EvaluadorCompuesto CrearEvaluadorCliente(EvaluadorCompuesto pEvaluadorGenerico)
        {
            EvaluadorCantidadCuotas evaluadorCuotas = new EvaluadorCantidadCuotas(32);
            pEvaluadorGenerico.AgregarEvaluador(evaluadorCuotas);

            EvaluadorMonto evaluadorMonto = new EvaluadorMonto(100000);
            pEvaluadorGenerico.AgregarEvaluador(evaluadorMonto);

            return pEvaluadorGenerico;
        }

        public EvaluadorCompuesto CrearEvaluadorClienteGold(EvaluadorCompuesto pEvaluadorGenerico)
        {
            EvaluadorCantidadCuotas evaluadorCuotas = new EvaluadorCantidadCuotas(60);
            pEvaluadorGenerico.AgregarEvaluador(evaluadorCuotas);

            EvaluadorMonto evaluadorMonto = new EvaluadorMonto(150000);
            pEvaluadorGenerico.AgregarEvaluador(evaluadorMonto);

            return pEvaluadorGenerico;
        }

        public EvaluadorCompuesto CrearEvaluadorClientePlatinum(EvaluadorCompuesto pEvaluadorGenerico)
        {
            EvaluadorCantidadCuotas evaluadorCuotas = new EvaluadorCantidadCuotas(60);
            pEvaluadorGenerico.AgregarEvaluador(evaluadorCuotas);

            EvaluadorMonto evaluadorMonto = new EvaluadorMonto(200000);
            pEvaluadorGenerico.AgregarEvaluador(evaluadorMonto);

            return pEvaluadorGenerico;
        }


    }
}
