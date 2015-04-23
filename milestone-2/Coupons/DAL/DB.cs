//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;
//
//namespace DAL
//{
//    public class DB
//    {
//        //Fields
//        private SqlConnection connection;
//        private SqlCommand command;
//        private string conStr;
//        private bool conStatus = false;
//
//        //Getter
//        public bool ConnectionStatus()
//        {
//            return conStatus;
//        }
//
//        //Constructor
//        public CDAL()
//        {
//            conStr = global::DAL.Properties.Settings.Default.DatabaseConnectionString;
//            connection = new SqlConnection(conStr);
//            bool thrown = false;
//            conStatus = false;
//            try
//            {
//                connection.Open();
//            }
//            catch (Exception e)
//            {
//                thrown = true;
//                throw e;
//            }
//            finally
//            {
//                if (!thrown)
//                {
//                    conStatus = true;
//                }
//                connection.Close();
//            }
//        }
//
//        // Methods for safely execute queries
//        public void ExecuteNonQuery(string query)
//        {
//            try
//            {
//                connection.Open();
//                command = new SqlCommand(query, connection);
//                command.ExecuteNonQuery();
//            }
//            catch (Exception e)
//            {
//                throw e;
//            }
//            finally
//            {
//                connection.Close();
//            }
//        }
//        public SqlDataReader ExecuteQuery(string query)
//        {
//            SqlDataReader dr = null;
//            try
//            {
//                connection.Open();
//                command = new SqlCommand(query, connection);
//                command.ExecuteNonQuery();
//                dr = command.ExecuteReader();
//            }
//            catch (Exception e)
//            {
//                throw e;
//            }
//            finally
//            {
//                connection.Close();
//            }
//            return dr;
//        }
//    }
//}
//