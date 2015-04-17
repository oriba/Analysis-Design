using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface IDAL
    {
        //Admin
        public bool AdminExistsByKey(string id);
        public void AdminInsert(string id, string fname, string lname, string email, string phone, string password);
        public void AdminUpdateByKey(string whereID, string fname, string lname, string email, string phone, string password);
        public void AdminDeleteByKey(string whereID);
        //Customer
        public bool CustomerExistsByKey(string id);
        public void CustomerInsert(string id, string fname, string lname, string email, string phone, int age, string password);
        public void CustomerUpdateByKey(string whereID, string fname, string lname, string email, string phone, int age, string password);
        public void CustomerDeleteByKey(string whereID);
    }
}
