using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ01
{
    class Matematica
    {

        static public double Dividir(int pDividendo, int pDivisor)
        {
            if (pDivisor == 0)
            {
                throw new DivisorPorCeroException();
            }
            return (double) pDividendo / (double) pDivisor;
        }
    }
}
