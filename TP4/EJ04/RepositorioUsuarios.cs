using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ04
{
    public class RepositorioUsuarios : iRepositorioUsuarios
    {
        private IList<Usuario> iLista = new List<Usuario>();

        public IList<Usuario> Lista
        {
            get { return iLista; }
        }

        public void Actualizar(Usuario pUsuario)
        {
            foreach(Usuario usuario in iLista)
            {
                if (usuario.Codigo == pUsuario.Codigo)
                    iLista.Remove(usuario);
                break;
            }

            iLista.Add(pUsuario);
        }

        public void Agregar(Usuario pUsuario)
        {
            iLista.Add(pUsuario);
        }

        public int Compare(Usuario pPrimerUsuario, Usuario pSegundoUsuario)
        {
            return pPrimerUsuario.CompareTo(pSegundoUsuario);
        }

        public void Eliminar(string pCodigo)
        {
            foreach (Usuario usuario in iLista)
            {
                if (usuario.Codigo == pCodigo)
                    iLista.Remove(usuario);
                break;
            }
        }

        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        {
            IList<Usuario> lista = iLista;
            for (int i = 0; i < lista.Count - 1; i++)
            {
                if (pComparador.Compare(lista[i], lista[i + 1]) == 1)
                {
                    Usuario aux = lista[i];
                    lista[i] = lista[i + 1];
                    lista[i + 1] = aux;
                }
            }
            return lista;
        }

        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            int pCodigoint = Convert.ToInt32(pCodigo);

            foreach (Usuario usuario in iLista)
            {
                if (usuario.GetHashCode()==pCodigoint)
                {
                    return usuario;
                }
            }

            return null;
        }

        public IList<Usuario> ObtenerTodos()
        {
            return iLista;
        }

        public Usuario CopiaDefensiva(string pCodigo)
        {
            Usuario usuario = this.ObtenerPorCodigo(pCodigo);
            if (usuario != null)
            {
                Usuario copiaUsuario = new Usuario();
                copiaUsuario.Codigo = usuario.Codigo;
                copiaUsuario.NombreCompleto = usuario.NombreCompleto;
                copiaUsuario.CorreoElectronico = usuario.CorreoElectronico;
                return copiaUsuario;
            }
            return null;
        }

        public static int Compute(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];

            // Step 1
            if (n == 0)
            {
                return m;
            }

            if (m == 0)
            {
                return n;
            }

            // Step 2
            for (int i = 0; i <= n; d[i, 0] = i++)
            {
            }

            for (int j = 0; j <= m; d[0, j] = j++)
            {
            }

            // Step 3
            for (int i = 1; i <= n; i++)
            {
                //Step 4
                for (int j = 1; j <= m; j++)
                {
                    // Step 5
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;

                    // Step 6
                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);
                }
            }
            // Step 7
            return d[n, m];
        }

        // Devuelve una lista con los usuarios cuyo nombre tiene una distancia de errores menor a 5.

        public IList<Usuario> BusquedaPorAproximacion(string pAproximacion)
        {
            IList<Usuario> listaResultado = new List<Usuario>();
            foreach(Usuario user in iLista)
            {
                if (RepositorioUsuarios.Compute(pAproximacion,user.NombreCompleto) < 5)
                {
                    listaResultado.Add(this.CopiaDefensiva(user.Codigo));
                }
            }
            return listaResultado;
        }
    }
}
