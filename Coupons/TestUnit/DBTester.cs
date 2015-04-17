using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DAL;

namespace TestUnit
{
    [TestFixture]
    public class DBTester
    {
        [Test]
        public void addAdmin()
        {
            int x = 7;
            int y = 7;
            Assert.AreEqual(x, y);
        }

        [Test]
        public void positiveTest()
        {
            int x = 7;
            int y = 7;
            Assert.AreEqual(x, y);
        }

        [Test]
        public void negativeTest()
        {
            int x = 7;
            int y = 8;
            Assert.AreNotEqual(x, y);
        }
    }
}
