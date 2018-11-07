using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ04
{
    public class UsuarioClave
    {
        private Usuario iUsuario;

        public Usuario Usuario
        {
            get { return iUsuario; }
            set { iUsuario = value; }
        }

        public string Codigo
        {
            get { return iUsuario.Codigo; }
            set { iUsuario.Codigo = value; }
        }

        public override bool Equals(Usuario pUsuario)
        {
            if (pUsuario.Codigo == Codigo)
                return true;
            else
                return
        }
    }
}
