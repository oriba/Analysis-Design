using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace DAL
{
    public class CDAL : IDAL
    {
        //Adapters
        private DBCouponsDataSetTableAdapters.AdminTableAdapter adminAdapter = new DBCouponsDataSetTableAdapters.AdminTableAdapter();
        private DBCouponsDataSetTableAdapters.CustomerTableAdapter customerAdapter = new DBCouponsDataSetTableAdapters.CustomerTableAdapter();
        private DBCouponsDataSetTableAdapters.OwnerTableAdapter ownerAdapter = new DBCouponsDataSetTableAdapters.OwnerTableAdapter();
        private DBCouponsDataSetTableAdapters.BusinessTableAdapter businessAdapter = new DBCouponsDataSetTableAdapters.BusinessTableAdapter();
        private DBCouponsDataSetTableAdapters.CategoryTableAdapter categoryAdapter = new DBCouponsDataSetTableAdapters.CategoryTableAdapter();
        private DBCouponsDataSetTableAdapters.CustomerCategoryTableAdapter customerCategoryAdapter = new DBCouponsDataSetTableAdapters.CustomerCategoryTableAdapter();

        //Admin
        public bool AdminExistsByKey(string id)
        {
            DBCouponsDataSet.AdminDataTable admins = adminAdapter.GetDataByID(id);
            return (admins.Rows.Count != 0);
        }

        public void AdminInsert(string id, string fname, string lname, string email, string phone, string password)
        {
            adminAdapter.InsertQuery(id, fname, lname, email, phone, password);
        }

        public void AdminUpdateByKey(string whereID, string fname, string lname, string email, string phone, string password)
        {
            adminAdapter.UpdateQuery(fname, lname, email, phone, password, whereID);
        }

        public void AdminDeleteByKey(string whereID)
        {
            adminAdapter.DeleteQuery(whereID);
        }

        //Customer
        public bool CustomerExistsByKey(string id)
        {
            DBCouponsDataSet.CustomerDataTable customers = customerAdapter.GetDataByID(id);
            return (customers.Rows.Count != 0);
        }

        public void CustomerInsert(string id, string fname, string lname, string email, string phone, int age, string password)
        {
            customerAdapter.InsertQuery(id, fname, lname, email, phone, age, password);
        }

        public int CustomerUpdateByKey(string whereID, string fname, string lname, string email, string phone, int age, string password)
        {
            return customerAdapter.UpdateQuery(fname, lname, email, phone, age, password, whereID);
        }

        public void CustomerDeleteByKey(string whereID)
        {
            customerAdapter.DeleteQuery(whereID);
        }
        //Customer-info
        public string CustomerNameByKey(string id)
        {
            return customerAdapter.NameByID(id);
        }

        //Owner
        public bool OwnerExistsByKey(string id)
        {
            DBCouponsDataSet.OwnerDataTable owners = ownerAdapter.GetDataByID(id);
            return (owners.Rows.Count != 0);
        }

        public void OwnerInsert(string id, string fname, string lname, string email, string phone, int age, string password)
        {
            ownerAdapter.InsertQuery(id, fname, lname, email, phone, password);
        }

        public void OwnerUpdateByKey(string whereID, string fname, string lname, string email, string phone, int age, string password)
        {
            ownerAdapter.UpdateQuery(fname, lname, email, phone, password, whereID);
        }

        public void OwnerDeleteByKey(string whereID)
        {
            ownerAdapter.DeleteQuery(whereID);
        }

        //Category
        public void CategoryInsert(string name)
        {
            categoryAdapter.InsertQuery(name);
        }

        //Business
        public void BusinessInsert(int id, string name, string ownerid, string category, string description, string adress, string city, int moneyEarned, float rating)
        {
            businessAdapter.InsertQuery(id, name, ownerid, category, description, adress, city, moneyEarned, rating);
        }

        public void BusinessUpdateByKey(int whereID, string name, string ownerid, string category, string description, string adress, string city, int moneyEarned, float rating)
        {
            businessAdapter.UpdateQuery(name, ownerid, category, description, adress, city, moneyEarned, rating, whereID);
        }

        //CustomerCategory
        public void CustomerCategoryInsert(string customerID, string category)
        {
            customerCategoryAdapter.InsertQuery(customerID, category);
        }


        public void BusinessDeleteByKey(int whereID)
        {
            throw new NotImplementedException();
        }

        public void CategoryDeleteByKey(string name)
        {
            throw new NotImplementedException();
        }

        public void CouponInsert(int serialCode, bool isActive, int couponMaker, string customer)
        {
            throw new NotImplementedException();
        }

        public void CouponUpdateByKey(int whereSerialCode, bool isActive, int couponMaker, string customer)
        {
            throw new NotImplementedException();
        }

        public void CouponDeleteByKey(int whereserialCode)
        {
            throw new NotImplementedException();
        }

        public void CouponMakerInsert(int id, string name, string description, int originalPrice, int couponPrice, float rating, DateTime startDate, DateTime endDate, int quantity, int maxQuantity, string status, int business)
        {
            throw new NotImplementedException();
        }

        public void CouponMakerUpdateByKey(int whereID, string name, string description, int originalPrice, int couponPrice, float rating, DateTime startDate, DateTime endDate, int quantity, int maxQuantity, string status, int business)
        {
            throw new NotImplementedException();
        }

        public void CouponMakerDeleteByKey(int whereID)
        {
            throw new NotImplementedException();
        }

        public void CustomerCategoryDeleteByKey(string customerID, string category)
        {
            throw new NotImplementedException();
        }
    }
}
