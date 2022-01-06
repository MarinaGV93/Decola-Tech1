using Microsoft.VisualStudio.TestTools.UnitTesting;
using Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas.Tests
{
    [TestClass()]
    public class ContasTests
    {
        [TestMethod()]
        public void SomaTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 10;
            var contas = new Contas();

            var result = contas.Soma(a, b);

            Assert.AreEqual(esperado, result);
        }

        [TestMethod()]
        public void SubTest()
        {
            var a = 5;
            var b = 5;
            var esperado =0;
            var contas = new Contas();

            var result = contas.Sub(a, b);
            Assert.AreEqual(esperado, result);
        }

        [TestMethod()]
        public void DivTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 1;
            var contas = new Contas();

            var result = contas.Div(a, b);
            Assert.AreEqual(esperado, result);
        }

        [TestMethod()]
        public void MultTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 25;
            var contas = new Contas();

            var result = contas.Mult(a, b);
            Assert.AreEqual(esperado, result);
        }
    }
}