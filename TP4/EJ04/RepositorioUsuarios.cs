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
            foreach (Usuario usuario in iLista)
            {
                if (usuario.Codigo == pCodigo)
                    return usuario;
            }
        }

        public IList<Usuario> ObtenerTodos()
        {
            return iDiccionario.Values.ToList();
        }
    }
}
