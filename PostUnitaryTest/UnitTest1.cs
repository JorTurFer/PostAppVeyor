using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostAppVeyor;

namespace PostUnitaryTest
{
    [TestClass]
    public class PostUnitTest
    {
        [TestMethod]
        public void Test()
        {
            string strEsperado = "Mascando Bits";
            Assert.AreEqual(strEsperado, Example.Message);
        }
    }
}
