using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ05
{
    public class Empleo
    {
        private double iSueldo;
        private DateTime iFechaIngreso;

        public Empleo(double pSueldo, DateTime pFechaIngreso)
        {
            iSueldo = pSueldo;
            iFechaIngreso = pFechaIngreso;
        }

        public double Sueldo
        {
            get { return this.iSueldo; }
        }

        public DateTime FechaIngreso
        {
            get { return this.iFechaIngreso; }
        }
    }
}
