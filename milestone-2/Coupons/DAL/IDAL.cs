using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDAL
    {
        /* Insert, Delete, Update */
        //Admin
        bool AdminExistsByKey(string id); /*for testing: does id exist in DB*/
        void AdminInsert(string id, string fname, string lname, string email, string phone, string password);
        void AdminUpdateByKey(string whereID, string fname, string lname, string email, string phone, string password);
        void AdminDeleteByKey(string whereID);
        //Business
        void BusinessInsert(int id, string name, string ownerID, string category, string description, string adress, string city, int moneyEarned, float rating);
        void BusinessUpdateByKey(int whereID, string name, string ownerID, string category, string description, string adress, string city, int moneyEarned, float rating);
        void BusinessDeleteByKey(int whereID);
        //Category
        void CategoryInsert(string name);
        void CategoryDeleteByKey(string name);
        //Coupon
        void CouponInsert(int serialCode, bool isActive, int couponMaker, string customer);
        void CouponUpdateByKey(int whereSerialCode, bool isActive, int couponMaker, string customer);
        void CouponDeleteByKey(int whereserialCode);
        //CouponMaker // TODO : edit 'string status' to 'Status status'
        void CouponMakerInsert(int id, string name, string description, int originalPrice, int couponPrice, float rating, DateTime startDate, DateTime endDate, int quantity, int maxQuantity, string status, int business);
        void CouponMakerUpdateByKey(int whereID, string name, string description, int originalPrice, int couponPrice, float rating, DateTime startDate, DateTime endDate, int quantity, int maxQuantity, string status, int business);
        void CouponMakerDeleteByKey(int whereID);
        //Customer
        bool CustomerExistsByKey(string id); /*for testing: does id exist in DB*/
        void CustomerInsert(string id, string fname, string lname, string email, string phone, int age, string password);
        int CustomerUpdateByKey(string whereID, string fname, string lname, string email, string phone, int age, string password);
        void CustomerDeleteByKey(string whereID);
        //Customer-Category
        void CustomerCategoryInsert(string customerID, string category);
        void CustomerCategoryDeleteByKey(string customerID, string category);
        //Owner
        bool OwnerExistsByKey(string id); /*for testing: does id exist in DB*/
        void OwnerInsert(string id, string fname, string lname, string email, string phone, int age, string password);
        void OwnerUpdateByKey(string whereID, string fname, string lname, string email, string phone, int age, string password);
        void OwnerDeleteByKey(string whereID);

        /* Queries */
        //Customer
        string CustomerNameByKey(string id);
    }
}
