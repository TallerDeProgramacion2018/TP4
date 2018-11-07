using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ04
{
    public class ComparadorPorNombre : IComparer<Usuario>
    {
        public int Compare(Usuario x, Usuario y)
        {
            int resultado = x.NombreCompleto.CompareTo(y.NombreCompleto);
            if (resultado != 0)
                return resultado;
            else
                return x.CompareTo(y);
        }
    }
}
