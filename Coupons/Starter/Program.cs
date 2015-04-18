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
            IDAL db = new CDAL();
            bool ans = db.AdminExistsByKey("30303114");
            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}