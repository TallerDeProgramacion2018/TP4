﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ03
{
    class RepositorioUsuarios : iRepositorioUsuarios
    {
        readonly Dictionary<string, Usuario> iDiccionario = new Dictionary<string, Usuario>();

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
            iDiccionario.Remove(pCodigo);
        }

        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        {
            List<Usuario> lista = iDiccionario.Values.ToList();
            lista.OrderBy(a => a.NombreCompleto);
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
