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
            // Changing The |DataDirectory| To be relative to the DAL project.
            var dataDirectory = System.IO.Path.GetFullPath(Environment.CurrentDirectory + @"\..\..\..\DAL");
            Console.WriteLine("Running From {0}", dataDirectory);
            AppDomain.CurrentDomain.SetData("DataDirectory", dataDirectory);

            CDAL db = new CDAL();
            db.AdminInsert("4444", "a", "a", "a", "12", "2222");
            //Console.WriteLine( db.AdminExistsByKey("3333"));
            Console.ReadLine();
        }
    }
}