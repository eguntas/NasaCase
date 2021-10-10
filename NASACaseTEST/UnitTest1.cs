using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSenario_12N()
        {
            NASACase.Position position = new NASACase.Position()
            {

                X = 1,
                Y = 2,
                Yon = NASACase.Yons.N
            };

            var duzlemkordinat = new List<int> { 1, 2 };
            var harekets = "LMLMLMLMM";

            position.StartMove(duzlemkordinat, harekets);

            var alinansonuc = position.X + " " + position.Y + " " + position.Yon;
            var beklenensonuc = "1 3 N";

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(beklenensonuc, alinansonuc);

        }
        [TestMethod]
        public void TestSenario_33E()
        {
            NASACase.Position position = new NASACase.Position()
            {
                X = 3,
                Y = 3,
                Yon = NASACase.Yons.E

            };

            var duzlemkordinat = new List<int> { 3, 3 };
            var harekets = "MMRMMRMRRM";

            position.StartMove(duzlemkordinat, harekets);

            var alinansonuc = position.X + " " + position.Y + " " + position.Yon;
            var beklenensonuc = "5 1 E";

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(beklenensonuc, alinansonuc);
        }
    }
}
