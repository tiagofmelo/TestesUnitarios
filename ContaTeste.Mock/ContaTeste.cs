using Moq;
using NUnit.Framework;
using Principal;
using System;

namespace ContaTeste.Mock
{
    [TestFixture]
    public class ContaTeste
    {
        [Test]
        [Category("Mock")]
        public void TestSolicitarEmprestimo()
        {
            var conta = new Conta("0001", 200);

            var mock = new Mock<IValidadorCredito>();

            mock.Setup(x => x.ValidarCredito(It.IsAny<string>(), It.Is<decimal>(i => i <= 5000))).Returns(true);

            conta.SetValidadorCredito(mock.Object);

            int resultadoEsperado = 1200;

            conta.SolicitarEmprestimo(1000);

            Assert.IsTrue(conta.GetSaldo() == resultadoEsperado);
        }

        [Test]
        [Category("Mock")]
        public void TestSolicitarEmprestimoComException()
        {
            var conta = new Conta("0002", 1000);

            var mock = new Mock<IValidadorCredito>();

            mock.Setup(x => x.ValidarCredito(It.IsAny<string>(), It.IsAny<decimal>()))
                .Throws<InvalidOperationException>();

            conta.SetValidadorCredito(mock.Object);

            int resultadoEsperado = 100;

            conta.SolicitarEmprestimo(5000);

            Assert.IsFalse(resultadoEsperado == conta.GetSaldo());
        }

        [Test]
        [Category("Mock")]
        public void TestSolicitarEmprestimoAcimaDoLimite()
        {
            var conta = new Conta("0003", 100);

            var mock = new Mock<IValidadorCredito>();

            conta.SetValidadorCredito(mock.Object);

            bool resultado = conta.SolicitarEmprestimo(1200);

            mock.Verify(x => x.ValidarCredito(It.IsAny<string>(), It.IsAny<decimal>()), Times.Never());
        }
    }
}