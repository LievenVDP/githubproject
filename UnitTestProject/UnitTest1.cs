using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTestVB.Lgoic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestVierkantsWortel()
        {
            Logica logica = new Logica();

            Random rnd = new Random();
            int getal = rnd.Next(5000);

            var vierkantswortel = logica.BerekenVierkantwortel(getal);

            Assert.AreEqual(Math.Sqrt(getal), vierkantswortel);
        }

        [TestMethod]
        public void TestLowercase()
        {
            Logica logica = new Logica();
            string woord = "AAAAAAAAAA";

            string LowerWoord = logica.Lowercase(woord);

            Assert.AreEqual(logica.Lowercase(woord), LowerWoord);
        }
    }
}
