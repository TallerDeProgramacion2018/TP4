using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EJ05;

namespace TestSolicitudPrestamos
{
    [TestClass]
    public class PruebaFuncionalidades
    {
        [TestMethod]
        public void TestSolicitudValida()
        {

            ControladorFachada fachada = new ControladorFachada();
            Empleo empleo = new Empleo(50000, new DateTime(2000, 5, 20));
            Cliente cliente = new Cliente("Ignacio", "Dentti", new DateTime(1997,12,31), empleo)
            {
                TipoCliente = TipoCliente.NoCliente
            };
            SolicitudPrestamo prestamo = new SolicitudPrestamo(cliente, 10000, 12);

            bool resultado = fachada.EsValida(prestamo);
            bool esperado = true;

            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void TestSolicitudInvalidaPorMonto()
        {
            ControladorFachada fachada = new ControladorFachada();
            Empleo empleo = new Empleo(50000, new DateTime(2000, 5, 20));
            Cliente cliente = new Cliente("Ignacio", "Dentti", new DateTime(1997, 12, 31), empleo)
            {
                TipoCliente = TipoCliente.ClienteGold
            };
            SolicitudPrestamo prestamo = new SolicitudPrestamo(cliente, 170000, 12);

            bool resultado = fachada.EsValida(prestamo);
            bool esperado = false;

            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void TestSolicitudInvalidaPorAntiguedad()
        {
            ControladorFachada fachada = new ControladorFachada();
            Empleo empleo = new Empleo(50000, new DateTime(2018, 9, 20));
            Cliente cliente = new Cliente("Ignacio", "Dentti", new DateTime(1997, 12, 31), empleo)
            {
                TipoCliente = TipoCliente.ClienteGold
            };
            SolicitudPrestamo prestamo = new SolicitudPrestamo(cliente, 100000, 12);

            bool resultado = fachada.EsValida(prestamo);
            bool esperado = false;

            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void TestSolicitudInvalidaPorEdad()
        {
            ControladorFachada fachada = new ControladorFachada();
            Empleo empleo = new Empleo(50000, new DateTime(2005, 9, 20));
            Cliente cliente = new Cliente("Ignacio", "Dentti", new DateTime(2004, 12, 31), empleo)
            {
                TipoCliente = TipoCliente.ClienteGold
            };
            SolicitudPrestamo prestamo = new SolicitudPrestamo(cliente, 100000, 12);

            bool resultado = fachada.EsValida(prestamo);
            bool esperado = false;

            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void TestSolicitudInvalidaPorCuotas()
        {
            ControladorFachada fachada = new ControladorFachada();
            Empleo empleo = new Empleo(50000, new DateTime(2012, 9, 20));
            Cliente cliente = new Cliente("Ignacio", "Dentti", new DateTime(1997, 12, 31), empleo)
            {
                TipoCliente = TipoCliente.ClientePlatinum
            };
            SolicitudPrestamo prestamo = new SolicitudPrestamo(cliente, 100000, 100);

            bool resultado = fachada.EsValida(prestamo);
            bool esperado = false;

            Assert.AreEqual(resultado, esperado);
        }

        [TestMethod]
        public void TestSolicitudInvalidaPorSueldo()
        {
            ControladorFachada fachada = new ControladorFachada();
            Empleo empleo = new Empleo(1000, new DateTime(2018, 9, 20));
            Cliente cliente = new Cliente("Ignacio", "Dentti", new DateTime(1997, 12, 31), empleo)
            {
                TipoCliente = TipoCliente.ClienteGold
            };
            SolicitudPrestamo prestamo = new SolicitudPrestamo(cliente, 100000, 12);

            bool resultado = fachada.EsValida(prestamo);
            bool esperado = false;

            Assert.AreEqual(resultado, esperado);
        }
    }
}
