using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ01
{
    class ControladorFachada
    {
        private Matematica matematica = new Matematica();

        public double Dividir(int pDividendo, int pDivisor)
        {
           return matematica.Dividir(pDividendo, pDivisor);
        }

    }
}
