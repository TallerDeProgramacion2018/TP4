using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ03
{
    // Clase que implementa IComparer usada para comparar usuarios por su correo electronico.
    public class ComparadorPorCorreo : IComparer<Usuario>
    {
        public int Compare(Usuario x, Usuario y)
        {
            int resultado = x.CorreoElectronico.CompareTo(y.CorreoElectronico);
            if (resultado != 0)
                return resultado;
            else
                return x.CompareTo(y);
        }
    }
}
