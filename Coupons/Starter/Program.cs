using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            CDAL db = new CDAL();
            db.AdminInsert("2222", "a", "a", "a", "12", "2222");
            //Console.WriteLine( db.AdminExistsByKey("134"));
            Console.ReadLine();
        }
    }
}