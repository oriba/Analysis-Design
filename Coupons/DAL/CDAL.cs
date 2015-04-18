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
        private CouponsDatabaseDataSetTableAdapters.AdminTableAdapter adminAdapter = new CouponsDatabaseDataSetTableAdapters.AdminTableAdapter();

        public bool AdminExistsByKey(string id)
        {
            CouponsDatabaseDataSet.AdminDataTable admins = adminAdapter.GetDataByID(id);
            return (admins.Rows.Count != 0);
        }

        public void AdminInsert(string id, string fname, string lname, string email, string phone, string password)
        {
            adminAdapter.InsertQuery(id, fname, lname, email, phone, password);
        }

        public void AdminUpdateByKey(string whereID, string fname, string lname, string email, string phone, string password)
        {
            throw new NotImplementedException();
        }

        public void AdminDeleteByKey(string whereID)
        {
            throw new NotImplementedException();
        }

        public bool CustomerExistsByKey(string id)
        {
            throw new NotImplementedException();
        }

        public void CustomerInsert(string id, string fname, string lname, string email, string phone, int age, string password)
        {
            throw new NotImplementedException();
        }

        public void CustomerUpdateByKey(string whereID, string fname, string lname, string email, string phone, int age, string password)
        {
            throw new NotImplementedException();
        }

        public void CustomerDeleteByKey(string whereID)
        {
            throw new NotImplementedException();
        }
    }
}
