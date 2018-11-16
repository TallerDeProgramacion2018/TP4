using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ04
{
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

        public override int GetHashCode()
        {
            return Convert.ToInt32(this.Codigo);
        }

        public override bool Equals(object obj)
        {
            var usuario = obj as Usuario;
            if (obj == null)
                return false;
            else
                return this.Codigo.Equals(usuario.Codigo);
        }
    }
}
