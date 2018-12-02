using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ03
{
    // Clase que contiene la lógica de persistencia de datos, utiliza el patrón repositorio.
    public class RepositorioUsuarios : iRepositorioUsuarios
    {
        readonly Dictionary<string, Usuario> iDiccionario = new Dictionary<string, Usuario>();

        public Dictionary<string, Usuario> Diccionario
        {
            get { return iDiccionario;  }
        }

        public void Actualizar(Usuario pUsuario)
        {
            iDiccionario.Remove(pUsuario.Codigo);
            iDiccionario.Add(pUsuario.Codigo, pUsuario);
        }

        public void Agregar(Usuario pUsuario)
        {
            iDiccionario.Add(pUsuario.Codigo, pUsuario);
        }

        public int Compare(Usuario pPrimerUsuario, Usuario pSegundoUsuario)
        {
            return pPrimerUsuario.CompareTo(pSegundoUsuario);
        }

        public void Eliminar(string pCodigo)
        {
            if (iDiccionario.ContainsKey(pCodigo))
                iDiccionario.Remove(pCodigo);
        }

        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        {
            List<Usuario> lista = iDiccionario.Values.ToList();
            for (int i = 0; i < lista.Count-1; i++)
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
            return iDiccionario[pCodigo];
        }

        public IList<Usuario> ObtenerTodos()
        {
            return iDiccionario.Values.ToList();
        }
    }
}
