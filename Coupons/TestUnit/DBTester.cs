using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DAL;
using System.Data.SqlClient;

using System.Transactions;

namespace TestUnit
{
    [TestFixture]
    public class DBTester
    {
        IDAL db = new CDAL();

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
        [Test, ExpectedException(typeof(SqlException))]
        public void insertExistAdmin()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                db.AdminInsert("000000", "adiri", "aviram", "aa@gmail.com", "0523000000", "111111");
                db.AdminInsert("000000", "adiri", "aviram", "aa@gmail.com", "0523000000", "111111");
            }
        }
        
        /*test for edit customer*/
        [Test]
        public void editCustomer()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                db.CustomerInsert("000000", "adiri", "aviram", "aa@gmail.com", "0523000000", 25, "111111");
                db.CustomerUpdateByKey("000000", "newName", "aviram", "aa@gmail.com", "0523000000", 25, "111111");
                Assert.AreEqual(db.CustomerNameByKey("000000"), "newName");
            }
        }

        /*test for edit non-exist customer*/
        [Test]
        public void editNonExistCustomer()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                int numUpdated = 0;
                numUpdated = db.CustomerUpdateByKey("111111", "newName", "aviram", "aa@gmail.com", "0523000000", 25, "111111");
                Assert.AreEqual(numUpdated, 0);
            }
        }

        /*test for remove owner*/
        [Test]
        public void removeowner()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                db.OwnerInsert("000000","newName","aviram","aa@gmail.com","0523000000",19,"111111");
                Assert.IsTrue(db.OwnerExistsByKey("000000"));
                db.OwnerDeleteByKey("000000");
                Assert.IsFalse(db.OwnerExistsByKey("000000"));
            }
        }

        /*test for delete non-exist owner*/
        [Test, ExpectedException(typeof(SqlException))]
        public void InsertCustomerCategoryWithWrongCustomer()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                db.CustomerInsert("000000", "adiri", "aviram", "aa@gmail.com", "0523000000", 25, "111111");
                db.CustomerCategoryInsert("000000", "Food");
            }
        }

        /*test for create business with non-exist owner*/
        [Test, ExpectedException(typeof(SqlException))]
        public void insertBusinessWithWrongOwner()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                db.CategoryInsert("testCategory");
                db.BusinessInsert(1, "busName", "nonExist", "testCategory", "bla", "bla", "", 1, 1);
            }
        }

        /*test for update business's owner to non-exist owner*/
        [Test, ExpectedException(typeof(SqlException))]
        public void updateBusinessToWrongOwner()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                db.CategoryInsert("testCategory");
                db.OwnerInsert("ownerID", "newName", "aviram", "aa@gmail.com", "0523000000",19, "111111");
                db.BusinessInsert(1, "busName", "ownerID", "testCategory", "bla", "bla", "", 1, 1);
                db.BusinessUpdateByKey(1, "busName", "nonExist", "testCategory", "bla", "bla", "", 1, 1);
            }
        }

        /*test for delete owner which has a business*/
        [Test, ExpectedException(typeof(SqlException))]
        public void deleteOwnerWithBusiness()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                db.CategoryInsert("testCategory");
                db.OwnerInsert("ownerID", "newName", "aviram", "aa@gmail.com", "0523000000", 19, "111111");
                db.BusinessInsert(1, "busName", "ownerID", "testCategory", "bla", "bla", "", 1, 1);
                db.OwnerDeleteByKey("ownerID");
                /*TODO: check what kind of error is it*/
            }
        }

        /*test for insert business with negetive money*/
        [Test, ExpectedException(typeof(SqlException))]
        public void inserteBusinessWithWrongMoney()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                db.CategoryInsert("testCategory");
                db.OwnerInsert("ownerID", "newName", "aviram", "aa@gmail.com", "0523000000",19, "111111");
                db.BusinessInsert(1, "busName", "ownerID", "testCategory", "bla", "bla", "", -10, 1);
            }
        }
    }
}