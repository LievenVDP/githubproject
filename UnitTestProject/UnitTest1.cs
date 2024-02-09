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


        public void TestGemiddelde()
        {
            Logica logica = new Logica();
            double getal1 = 12;
           double getal2 = 12;
            var gemmidelde = logica.Berekengemiddelde(getal1, getal2);

        }
    }
}
