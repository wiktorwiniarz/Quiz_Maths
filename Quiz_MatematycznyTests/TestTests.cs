using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiz_Matematyczny;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Matematyczny.Tests
{
    [TestClass()]
    public class TestTests
    {
        [TestMethod()]
        public void TestCorrectAddRandom()
        {       
            var test = new Test();
            Random randomizer = new Random();
            int addend1 = randomizer.Next(51);
            int addend2 = randomizer.Next(51);

            Assert.AreEqual( addend1 > 0 && addend1 < 50, true);
        }

        [TestMethod()]
        public void TestCorrectSubtracRandom()
        {
            var test = new Test();
            Random randomizer = new Random();
            int minuend = randomizer.Next(1, 101);
            int subtrahend = randomizer.Next(1, minuend);

            Assert.AreEqual(minuend > 0 && minuend < 100 && subtrahend<= minuend, true);
        }

        [TestMethod()]
        public void TestCorrectMultiplicationRandom()
        {
            var test = new Test();
            Random randomizer = new Random();
            int multiplicand = randomizer.Next(2, 11);
            int multiplier = randomizer.Next(2, 11);

            Assert.AreEqual(multiplicand > 1 && multiplicand < 10 && multiplier > 1 && multiplier < 10, true);
        }


        [TestMethod()]
        public void TestSumEqual()
        {
            var test = new Test();
            int addend1 = 20;
            int addend = 30;
            int sum = 50;
            int minuend = 30;
            int subtrahend = 20;
            int roznica =2;
            int multiplicand = 2;
            int multiplier = 10;
            int iloczyn = 3; 
            int dividend = 10;
            int divisor = 2;
            int iloraz = 5;

            Assert.AreEqual(addend + addend1, sum);
            Assert.AreNotEqual(minuend - subtrahend, roznica);
            Assert.AreNotEqual(multiplicand * multiplier, iloczyn);
            Assert.AreEqual(dividend / divisor,  iloraz);
        }
    }


}