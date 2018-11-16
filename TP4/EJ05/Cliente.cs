using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ05
{
    public class Cliente
    {
        private string iNombre;
        private string iApellido;
        private DateTime iFechaNacimiento;
        private Empleo iEmpleo;
        private TipoCliente iTipoCliente;

        public Cliente(string pNombre, string pApellido, DateTime pFechaNacimiento, Empleo pEmpleo)
        {
            iNombre = pNombre;
            iApellido = pApellido;
            iFechaNacimiento = pFechaNacimiento;
            iEmpleo = pEmpleo;
        }

        public string Nombre
        {
            get {return iNombre; }
        }

        public string Apellido
        {
            get { return iApellido; }
        }

        public DateTime FechaNacimiento
        {
            get { return iFechaNacimiento; }
        }

        public Empleo Empleo
        {
            get { return iEmpleo; }
        }

        public TipoCliente TipoCliente
        {
            get { return iTipoCliente; }
            set { iTipoCliente = value; }
        }
    }
}
    
