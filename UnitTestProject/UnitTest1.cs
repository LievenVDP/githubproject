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
        public void TestGedeeldDoor()
        {
            Logica Logica = new Logica();

            int getal1 = 5;
            int getal2 = 10;

            double quotient = Logica.GedeeldDoor(getal1, getal2);

            Assert.AreEqual(quotient, (getal1 / getal2));

        }
    }
}
