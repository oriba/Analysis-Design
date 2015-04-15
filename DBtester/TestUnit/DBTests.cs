﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestUnit
{
    [TestFixture]
    public class DBTests
    {
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
