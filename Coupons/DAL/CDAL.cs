using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CDAL
    {
        public void test2(){
            //creating admin adapters
            CouponsDataSetTableAdapters.AdminTableAdapter adminAdapter = new CouponsDataSetTableAdapters.AdminTableAdapter();
            //testing SELECT query
            CouponsDataSet.AdminDataTable adminTable = adminAdapter.SelectByKey("303013114");
            if (adminTable.Rows.Count == 1)
            {
                Console.WriteLine("found");
            }
            else
            {
                Console.WriteLine("not found");
            }
        }
        public void test1(){
            //creating admin adapters
            CouponsDataSetTableAdapters.AdminTableAdapter adminAdapter = new CouponsDataSetTableAdapters.AdminTableAdapter();
            //testing INSERT query
            adminAdapter.InsertAdmin("303013114", "dima", "dimitry", "dima@dimahoo.com", "0542222333", "1234");
            //
        }
   
    }
}