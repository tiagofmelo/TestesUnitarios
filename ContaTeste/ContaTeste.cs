using NUnit.Framework;
using Principal;

namespace ContaTeste
{
    [TestFixture]
    public class ContaTeste
    {
        [Test]
        public void TesteSacar()
        {
            Conta conta = new Conta("0001", 200);

            bool resutado = conta.Sacar(120);

            Assert.IsTrue(resutado);
        }

        [Test]
        public void TesteSacarSemSaldo()
        {
            Conta conta = new Conta("0002", 100);

            bool resutado = conta.Sacar(120);

            Assert.IsFalse(resutado);
        }
    }
}
