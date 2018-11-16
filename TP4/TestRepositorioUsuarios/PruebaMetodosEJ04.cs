using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EJ04;
using System.Collections.Generic;

namespace TestRepositorioUsuarios
{
    [TestClass]
    public class PruebaMetodosEJ04
    {
        [TestMethod]
            public void TestAgregar()
            {
                Usuario user = new Usuario();
                RepositorioUsuarios repo = new RepositorioUsuarios();

                user.Codigo = "123";
                user.NombreCompleto = "Ignacio Dentti Fuentes";

                repo.Agregar(user);
                Assert.AreEqual(repo.ObtenerPorCodigo("123"), user);
            }

        [TestMethod]
        public void TestActualizar()
        {
            Usuario user = new Usuario();
            RepositorioUsuarios repo = new RepositorioUsuarios();

            user.Codigo = "123";
            user.NombreCompleto = "Ignacio Dentti Fuentes";

            repo.Agregar(user);

            user.NombreCompleto = "Kevin Leonardo Pavon";

            repo.Actualizar(user);

            Assert.AreEqual(repo.ObtenerPorCodigo("123"), user);
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

            Assert.AreEqual(repo.ObtenerPorCodigo("123"), null);
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

        [TestMethod]
        public void TestBusquedaPorAproximacion()
        {
            
            RepositorioUsuarios repo = new RepositorioUsuarios();

            Usuario user1 = new Usuario();
            user1.Codigo = "3333";
            user1.NombreCompleto = "Ignacio Dentti Fuentes";
            user1.CorreoElectronico = "a";

            repo.Agregar(user1);

            Usuario user2 = new Usuario();
            user2.Codigo = "1111";
            user2.NombreCompleto = "Kevin Leonardo Pavon";
            user2.CorreoElectronico = "b";

            repo.Agregar(user2);

            Usuario user3 = new Usuario();
            user3.Codigo = "2222";
            user3.NombreCompleto = "Enzo Gaston Milano";
            user3.CorreoElectronico = "c";

            repo.Agregar(user3);

            IList<Usuario> listaResultado = new List<Usuario>();

            listaResultado.Add(user2);

            Assert.AreEqual(repo.BusquedaPorAproximacion("Kevin Leonardo P")[0], user2);
        }
    }
}
