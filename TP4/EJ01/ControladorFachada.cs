using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ01
{
    class ControladorFachada
    {
        public double Dividir(int pDividendo, int pDivisor)
        {
           return Matematica.Dividir(pDividendo, pDivisor);
        }
    }
}
