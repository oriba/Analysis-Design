using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDAL
    {
        /* constructor call */
        IDAL create();

        /* Queries */
        //Admin
        bool AdminExistsByKey(string id); /*for testing: does id exist in DB*/
        void AdminInsert(string id, string fname, string lname, string email, string phone, string password);
        void AdminUpdateByKey(string whereID, string fname, string lname, string email, string phone, string password);
        void AdminDeleteByKey(string whereID);
        //Customer
        bool CustomerExistsByKey(string id); /*for testing: does id exist in DB*/
        void CustomerInsert(string id, string fname, string lname, string email, string phone, int age, string password);
        void CustomerUpdateByKey(string whereID, string fname, string lname, string email, string phone, int age, string password);
        void CustomerDeleteByKey(string whereID);
    }
}
