using NUnit.Framework;
using Principal;
using System;

namespace ContaTeste
{
    [TestFixture]
    public class ContaTeste
    {
        Conta conta;

        [OneTimeSetUp]
        public void SetUp()
        {
            conta = new Conta("0001", 200);
        }

        [TearDown]
        public void TearDown()
        {
            //C�digo executado ap�s cada teste unit�rio
        }

        [Test]
        public void TesteSacar()
        {
            bool resutado = conta.Sacar(120);

            Assert.IsTrue(resutado);
        }

        [Test]
        public void TesteSacarSemSaldo()
        {
            bool resutado = conta.Sacar(300);

            Assert.IsFalse(resutado);
        }

        [Test]
        [Category("Valores Inv�lidos")]
        //[Ignore("Pendencia de implementa��o")]
        public void TesteSacarValorNegativo()
        {
            //Assert.Catch<Exception>(delegate { conta.Sacar(-100); });

            Assert.Throws<ArgumentOutOfRangeException>(delegate { conta.Sacar(-100); });
        }

        [Test]
        [Category("Valores Inv�lidos")]
        public void TesteSacarValorZero()
        {
            bool resutado = conta.Sacar(0);

            Assert.IsFalse(resutado);
        }

        [Test]
        [Timeout(4000)]
        public void TesteMetodoLento()
        {

        }
    }
}
