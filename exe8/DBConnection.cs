using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe8
{
    class DBConnection
    {
        string strCon = @"Data Source=laptop-u9v1lavn\sqlexpress;Initial Catalog = EXE_8_C#;Integrated Security=True";
        string strCmd;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        public DBConnection()
        {
            con = new SqlConnection(strCon);
        }

        public string ReadItemsTable()
        {
            try
            {
                string res = "";
                strCmd = "select * from TBItem1";
                cmd = new SqlCommand(strCmd, con);
                con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    res += $"Code: {reader["Code"]} ,Name: {reader["Name"]}, Description: {reader["Description"]}, Price: {reader["Price"]}\n";
                }
                return res;
            }
            catch (Exception err)
            {
                return "Exception:" + err.Message;
            }
            finally
            {
                con.Close();
            }

        }

        public int AddItemToDB(Item item)
        {
            try
            {
                strCmd = $"insert TBItem1 values ('{item.Name}','{item.Description}','{item.Price}')";
                cmd = new SqlCommand(strCmd, con);
                con.Open();
                return cmd.ExecuteNonQuery();

            }
            catch (Exception err)
            {
                Console.WriteLine("Exception:" + err.Message);
                return -1;
            }
            finally
            {
                con.Close();
            }
        }

        public int DeletItemFromDB(int code)
        {
            try
            {
                strCmd = $"delete from TBItem1 where Code = {code}";
                cmd = new SqlCommand(strCmd, con);
                con.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                Console.WriteLine("Exception:" + err.Message);
                return -1;
            }
            finally
            {
                con.Close();
            }
        }

    }
}
