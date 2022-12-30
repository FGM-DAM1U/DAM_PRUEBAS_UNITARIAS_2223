using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using gestionBancariaApp;

namespace gestionBancariaTest
{
    [TestClass]
    public class gestionBancariaTests
    {
        [TestMethod] // unit test code
        public void validarMIngresoP1()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 1; // Valor límite (min+1)
            double saldoActual = 0;
            double saldoEsperado = 1001;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar

            cuenta.realizarIngreso(ingreso);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        [TestMethod] // unit test code
        public void validarMIngresoP2()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 0; // Valor límite (min)
            double saldoActual = 0;
            double saldoEsperado = 1000; // No deben producirse cambios

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar

            cuenta.realizarIngreso(ingreso);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        [TestMethod] // unit test code
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void validarMIngresoP3()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = -1; // Valor límite (min-1), CLASE INVÁLIDA
            double saldoActual = 0;
            double saldoEsperado = 1000;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar

            cuenta.realizarIngreso(ingreso);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        [TestMethod] // unit test code
        public void validarMetodoIngreso() // Código del enunciado: válido como prueba con valores normales, será la Prueba 4.
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 500;
            double saldoActual = 0;
            double saldoEsperado = 1500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar

            cuenta.realizarIngreso(ingreso);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        [TestMethod] // unit test code
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void validarMIngresoP5()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = -500; // Valor normal, CLASE INVÁLIDA
            double saldoActual = 0;
            double saldoEsperado = 1000;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar

            cuenta.realizarIngreso(ingreso);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        [TestMethod] // unit test code
        public void validarMReintegroP1()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = 1; // Valor límite (min+1)
            double saldoActual = 0;
            double saldoEsperado = 999;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar

            cuenta.realizarReintegro(reintegro);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        [TestMethod] // unit test code
        public void validarMReintegroP2()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = 0; // Valor límite (min)
            double saldoActual = 0;
            double saldoEsperado = 1000;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar

            cuenta.realizarReintegro(reintegro);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        [TestMethod] // unit test code
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void validarMReintegroP3()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = -1; // Valor límite (min-1), CLASE INVÁLIDA
            double saldoActual = 0;
            double saldoEsperado = 1000;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar

            cuenta.realizarReintegro(reintegro);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        [TestMethod] // unit test code
        public void validarMReintegroP4()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = 999; // Valor límite (max-1), saldoInicial-1
            double saldoActual = 0;
            double saldoEsperado = 1;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar

            cuenta.realizarReintegro(reintegro);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        [TestMethod] // unit test code
        public void validarMReintegroP5()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = 1000; // Valor límite (max), es decir, saldoInicial
            double saldoActual = 0;
            double saldoEsperado = 0;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar

            cuenta.realizarReintegro(reintegro);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        [TestMethod] // unit test code
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void validarMReintegroP6()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = 1001; // Valor límite (max+1), saldoInicial+1, CLASE INVÁLIDA
            double saldoActual = 0;
            double saldoEsperado = 1000; // ??

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar

            cuenta.realizarReintegro(reintegro);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        [TestMethod] // unit test code
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void validarMReintegroP7()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = 1555; // Valor normal, max+555 por ejemplo, CLASE INVÁLIDA
            double saldoActual = 0;
            double saldoEsperado = 1000;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar

            cuenta.realizarReintegro(reintegro);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        [TestMethod] // unit test code
        public void validarMReintegroP8()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = 500; // Valor normal, p. ejemplo saldoInicial/2
            double saldoActual = 0;
            double saldoEsperado = 500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar

            cuenta.realizarReintegro(reintegro);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        [TestMethod] // unit test code
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void validarMReintegroP9()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double reintegro = -555; // Valor normal, min-555, CLASE INVÁLIDA
            double saldoActual = 0;
            double saldoEsperado = 1000;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar

            cuenta.realizarReintegro(reintegro);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
    }
}
