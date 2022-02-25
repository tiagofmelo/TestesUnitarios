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
            //Código executado após cada teste unitário
        }

        [Test]
        [Category("Teste")]
        public void TesteSacar()
        {
            bool resutado = conta.Sacar(120);

            Assert.IsTrue(resutado);
        }

        [Test]
        [Category("Teste")]
        public void TesteSacarSemSaldo()
        {
            bool resutado = conta.Sacar(300);

            Assert.IsFalse(resutado);
        }

        [Test]
        [Category("Teste")]
        //[Ignore("Pendencia de implementação")]
        public void TesteSacarValorNegativo()
        {
            //Assert.Catch<Exception>(delegate { conta.Sacar(-100); });

            Assert.Throws<ArgumentOutOfRangeException>(delegate { conta.Sacar(-100); });
        }

        [Test]
        [Category("Teste")]
        public void TesteSacarValorZero()
        {
            bool resutado = conta.Sacar(0);

            Assert.IsFalse(resutado);
        }

        [Test]
        [Category("Teste")]
        public void TesteSolicitarEmprestimo()
        {
            conta.SetValidadorCredito(new ValidadorCreditoFake());

            bool resutado = conta.SolicitarEmprestimo(1000);

            Assert.IsTrue(resutado);
        }
    }
}
