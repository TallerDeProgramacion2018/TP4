using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ02
{
    class ControladorFachada
    {

        Cuentas cuentas = new Cuentas();

        public double ObtenerSaldoCajaDeAhorro()
        {
            return cuentas.CajaAhorro.Saldo;
        }

        public double ObtenerSaldoCuentaCorriente()
        {
            return cuentas.CuentaCorriente.Saldo;
        }

        // Los métodos utilizados lanzan excepciones en casos particulares,
        // que deberán ser controladas cuando se invoquen en la práctica.

        public double TransferirCajaDeAhorro(double pMonto)
        {
            cuentas.CuentaCorriente.DebitarSaldo(pMonto);
            return cuentas.CajaAhorro.AcreditarSaldo(pMonto);
        }

        public double TransferirCuentaCorriente(double pMonto)
        {
            cuentas.CajaAhorro.DebitarSaldo(pMonto);
            return cuentas.CuentaCorriente.AcreditarSaldo(pMonto);
        }
    }
}
