//////////////////////////////////////////////////////////// good one
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DAL;

using System.Transactions;

namespace TestUnit
{
    [TestFixture]
    public class DBTester
    {
        IDAL db;

        /*test for adding admin*/
        [Test]
        public void insertAdmin()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                db.AdminInsert("000000", "adiri", "aviram", "aa@gmail.com", "0523000000", "111111");
                Assert.IsTrue(db.AdminExistsByKey("000000"));
            }
        }

        /*test for adding exist admin*/
        [Test, ExpectedException(/*typeof(TODO: add ecxeption)*/)]
        public void insertExistAdmin()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                db.AdminInsert("000000", "adiri", "aviram", "aa@gmail.com", "0523000000", "111111");
                db.AdminInsert("000000", "adiri", "aviram", "aa@gmail.com", "0523000000", "111111");
            }
        }
        
//        /*test for edit customer*/
//        [Test]
//        public void editCustomer()
//        {
//            using (TransactionScope scope = new TransactionScope())
//            {
//                db.CustomerInsert("000000", "adiri", "aviram", "aa@gmail.com", "0523000000", 25, "111111");
//                db.CustomerUpdateByKey("000000", "newName", "aviram", "aa@gmail.com", "0523000000", 25, "111111");
//                Assert.AreEqual(db.customerNameByKey("000000"), "newName");
//            }
//        }
//
//        /*test for edit non-exist customer*/
//        [Test, ExpectedException(/*typeof(TODO: add ecxeption)*/)]
//        public void editNonExistCustomer()
//        {
//            using (TransactionScope scope = new TransactionScope())
//            {
//                db.CustomerUpdateByKey("111111", "newName", "aviram", "aa@gmail.com", "0523000000", 25, "111111");
//            }
//        }
//
//        /*test for remove owner*/
//        [Test]
//        public void removeowner()
//        {
//            using (TransactionScope scope = new TransactionScope())
//            {
//                db.ownerInsert("000000", "newName", "aviram", "aa@gmail.com", "0523000000", "111111");
//                Assert.IsTrue(db.ownerExistsByKey("000000"));
//                db.ownerDeleteByKey("000000");
//                Assert.IsFalse(db.ownerExistsByKey("000000"));
//            }
//        }
//
//        /*test for delete non-exist owner*/
//        [Test, ExpectedException(/*typeof(TODO: add ecxeption)*/)]
//        public void removeNonExistOwner()
//        {
//            using (TransactionScope scope = new TransactionScope())
//            {
//                db.ownerDeleteByKey("000000");
//                db.ownerDeleteByKey("000000");
//            }
//        }
//
//        /*test for create business with non-exist owner*/
//        [Test, ExpectedException(/*typeof(TODO: add ecxeption)*/)]
//        public void insertBusinessWithWrongOwner()
//        {
//            using (TransactionScope scope = new TransactionScope())
//            {
//                db.categoryInsert("testCategory");
//                db.businessInsert("testID", "busName", "nonExist", "testCategory", "bla", "bla", "", 1, 1);
//            }
//        }
//
//        /*test for update business's owner to non-exist owner*/
//        [Test, ExpectedException(/*typeof(TODO: add ecxeption)*/)]
//        public void updateBusinessToWrongOwner()
//        {
//            using (TransactionScope scope = new TransactionScope())
//            {
//                db.categoryInsert("testCategory");
//                db.ownerInsert("ownerID", "newName", "aviram", "aa@gmail.com", "0523000000", "111111");
//                db.businessInsert("testID", "busName", "ownerID", "testCategory", "bla", "bla", "", 1, 1);
//                db.businessUpdateByKey("testID", "busName", "nonExist", "testCategory", "bla", "bla", "", 1, 1);
//            }
//        }
//
//        /*test for delete owner which has a business*/
//        [Test, ExpectedException(/*typeof(TODO: add ecxeption)*/)]
//        public void deleteOwnerWithBusiness()
//        {
//            using (TransactionScope scope = new TransactionScope())
//            {
//                db.categoryInsert("testCategory");
//                db.ownerInsert("ownerID", "newName", "aviram", "aa@gmail.com", "0523000000", "111111");
//                db.businessInsert("testID", "busName", "ownerID", "testCategory", "bla", "bla", "", 1, 1);
//                db.ownerDeleteByKey("ownerID");
//                /*TODO: check what kind of error is it*/
//            }
//        }
//
//        /*test for insert business with negetive money*/
//        [Test, ExpectedException(/*typeof(TODO: add ecxeption)*/)]
//        public void inserteBusinessWithWrongMoney()
//        {
//            using (TransactionScope scope = new TransactionScope())
//            {
//                db.categoryInsert("testCategory");
//                db.ownerInsert("ownerID", "newName", "aviram", "aa@gmail.com", "0523000000", "111111");
//                db.businessInsert("testID", "busName", "ownerID", "testCategory", "bla", "bla", "", -10, 1);
//            }
//        }
//
        [Test]
        public void negativeTest()
        {
            int x = 7;
            int y = 8;
            Assert.AreNotEqual(x, y);
        }
    }
}
