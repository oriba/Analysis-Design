using System;
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
        DB db;

        [Test]
        public void add()
        {
            string newCutomerQuery = " "; //change the string
            db.addAndRemove(newCutomerQuery);
            string newOwnerQuery = " "; //change the string
            db.addAndRemove(newOwnerQuery);
            string newbusinessQuery = " "; //change the string
            db.addAndRemove(newbusinessQuery);
            string newCouponMakerQuery = " "; //change the string
            db.addAndRemove(newCouponMakerQuery);
            //The test should not make a exception & 
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
