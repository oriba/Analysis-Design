using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDAL
    {
        /* Queries */
        //Admin
        bool AdminExistsByKey(string id); /*for testing: does id exist in DB*/
        void AdminInsert(string id, string fname, string lname, string email, string phone, string password);
        void AdminUpdateByKey(string whereID, string fname, string lname, string email, string phone, string password);
        void AdminDeleteByKey(string whereID);
        //Customer
        bool CustomerExistsByKey(string id); /*for testing: does id exist in DB*/
        void CustomerInsert(string id, string fname, string lname, string email, string phone, int age, string password);
        int CustomerUpdateByKey(string whereID, string fname, string lname, string email, string phone, int age, string password);
        void CustomerDeleteByKey(string whereID);
        //Customer-info
        string CustomerNameByKey(string id);
        //Owner
        bool OwnerExistsByKey(string id); /*for testing: does id exist in DB*/
        void OwnerInsert(string id, string fname, string lname, string email, string phone, int age, string password);
        void OwnerUpdateByKey(string whereID, string fname, string lname, string email, string phone, int age, string password);
        void OwnerDeleteByKey(string whereID);
        //Category-insert
        void CategoryInsert(string name);
        //Business-insert&update
        void BusinessInsert(int id, string name, string ownerid, string category, string description, string adress, string city, int moneyEarned, float rating);
        void BusinessUpdateByKey(int whereID, string name, string ownerid, string category, string description, string adress, string city, int moneyEarned, float rating);
        //Customer-Category
        void CustomerCategoryInsert(string customerID, string category);
    }
}
