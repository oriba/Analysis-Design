using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CDAL : IDAL
    {
        //Adapters
        private CouponsDataSetTableAdapters.AdminTableAdapter adminAdapter = null;

        private CDAL()
        {
            //initialize adapters
            this.adminAdapter = new CouponsDataSetTableAdapters.AdminTableAdapter();
        }
        public IDAL create()
        {
            return new CDAL();
        }
        /* End of Singleton Pattern */

        /* Queries */
        //public void test2(){
        //    this.AdminInsert()
        //    //testing SELECT query
        //    if (adminTable.Rows.Count == 1)
        //    {
        //        Console.WriteLine("found");
        //    }
        //    else
        //    {
        //        Console.WriteLine("not found");
        //    }
        //}
        //public void test1(){
        //    //testing INSERT query
        //    adminAdapter.InsertAdmin("303013114", "dima", "dimitry", "dima@dimahoo.com", "0542222333", "1234");
        //}


        public bool AdminExistsByKey(string id)
        {
            CouponsDataSet.AdminDataTable adminTable = this.adminAdapter.SelectByKey("303013114");
            if (adminTable.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AdminInsert(string id, string fname, string lname, string email, string phone, string password)
        {
            throw new NotImplementedException();
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