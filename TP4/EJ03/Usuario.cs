using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ03
{
    // Clase usuario que implementa la interfaz IComparable para utilizar el método CompareTo.
    public class Usuario : IComparable<Usuario>
    {
        private string iCodigo;
        private string iNombreCompleto;
        private string iCorreoElectronico;

        public string Codigo
        {
            get { return iCodigo; }
            set { iCodigo = value; }
        }

        public string NombreCompleto
        {
            get { return iNombreCompleto; }
            set { iNombreCompleto = value; }
        }

        public string CorreoElectronico
        {
            get { return iCorreoElectronico; }
            set { iCorreoElectronico = value; }
        }

        public int CompareTo(Usuario otro)
        {
            return String.Compare(this.iCodigo, otro.iCodigo);
        }
    }
}
