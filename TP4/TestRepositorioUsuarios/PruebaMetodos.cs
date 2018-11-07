using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EJ03;
using System.Collections.Generic;
namespace TestRepositorioUsuarios
{
    [TestClass]
    public class PruebaMetodos
    {
        [TestMethod]
        public void TestAgregar()
        {
            Usuario user = new Usuario();
            RepositorioUsuarios repo = new RepositorioUsuarios();

            user.Codigo = "123";
            user.NombreCompleto = "Ignacio Dentti Fuentes";

            repo.Agregar(user);
            Assert.AreEqual(repo.Diccionario[user.Codigo], user);
        }

        [TestMethod]
        public void TestActualizar()
        {
            Usuario user = new Usuario();
            RepositorioUsuarios repo = new RepositorioUsuarios();

            user.Codigo = "123";
            user.NombreCompleto = "Ignacio Dentti Fuentes";

            repo.Agregar(user);

            user.Codigo = "334";

            repo.Actualizar(user);

            Assert.AreEqual(repo.Diccionario[user.Codigo], user);
        }

        [TestMethod]
        public void TestCompare()
        {
            Usuario user = new Usuario();
            RepositorioUsuarios repo = new RepositorioUsuarios();

            user.Codigo = "123";
            user.NombreCompleto = "Ignacio Dentti Fuentes";

            repo.Agregar(user);

            Usuario user2 = new Usuario();
            user2.Codigo = "112";
            user.NombreCompleto = "Pevin Kavon";

            Assert.AreEqual(repo.Compare(user, user2), 1);
        }

        [TestMethod]
        public void TestBorrar()
        {
            Usuario user = new Usuario();
            RepositorioUsuarios repo = new RepositorioUsuarios();

            user.Codigo = "123";
            user.NombreCompleto = "Ignacio Dentti Fuentes";

            repo.Agregar(user);
            repo.Eliminar("123");
            
            Assert.AreEqual(repo.Diccionario.ContainsKey("123"),false);
        }

        [TestMethod]
        public void TestObtenerOrdenadosPor()
        {
            Usuario user = new Usuario();
            RepositorioUsuarios repo = new RepositorioUsuarios();

            user.Codigo = "1234";
            user.NombreCompleto = "Ignacio Dentti Fuentes";
            user.CorreoElectronico = "b";

            repo.Agregar(user);

            Usuario user2 = new Usuario();

            user2.Codigo = "1233";
            user2.NombreCompleto = "Gaston Milano";
            user2.CorreoElectronico = "a";

            repo.Agregar(user2);

            IList<Usuario> resultado = repo.ObtenerOrdenadosPor(new ComparadorPorNombre());

            Assert.AreEqual(resultado[0], user2);
            Assert.AreEqual(resultado[1], user);
        }
    }
}
