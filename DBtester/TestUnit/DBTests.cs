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
        public void connectionTest()
        {
            string serverPath = "blablabla";
            db.connection(serverPath);
        }

        [Test]
        public void connectionFailureTest()
        {
            string serverPath = "blablabla";
            db.connection(serverPath);
            //suposed to throw an error 
        }

        [Test]
        public void add()
        {
            string newCustomerQuery = "INSERT INTO Customer VALUES (1111,Aviram,Adiri,aa@gmail.com,0523908209,26,0000);";
            db.addAndRemove(newCustomerQuery);
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
