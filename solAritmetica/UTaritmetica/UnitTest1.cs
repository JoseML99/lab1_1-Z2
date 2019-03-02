using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UTaritmetica
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            /// arrange
            const int numa = 5;
            const int numb = 3;
            const int numc = 8;

            /// act
            using (SRVaritmetica.WSaritmeticaClient cliente = new SRVaritmetica.WSaritmeticaClient())
            {
                var obj = cliente.sumar(numa, numb);

                /// assert
                Assert.AreEqual(numc, obj.resultado);
            }

        }
    }
}
