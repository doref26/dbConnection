using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Form_A;

namespace form_A
{
    class DBConnection
    {
        string strCon = @"Data Source=laptop-u9v1lavn\sqlexpress;Initial Catalog = EXE_8_C#;Integrated Security=True";
        string strCmd;

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adtr;
        DataSet ds;
        DataTable dt;

        public DBConnection()
        {
            con = new SqlConnection(strCon);
            dt = new DataTable();
        }

        public DataTable ItemsTable()
        {
            try
            {
                strCmd = @"select * from TBItem1";
                cmd = new SqlCommand(strCmd, con);
                adtr = new SqlDataAdapter(cmd);
                dt.Clear();
                ds = new DataSet();
                adtr.Fill(ds, "TbItem1");
                dt = ds.Tables["TBItem1"];
                return dt;
            }
            catch (Exception)
            {
                return null;
            }

        }
        public DataTable FilterByAbovePrice(int price)
        {
            try
            {
                cmd = new SqlCommand("Item_By_Above_Price", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parPrice = new SqlParameter("@price", SqlDbType.Int);
                parPrice.Direction = ParameterDirection.Input;
                parPrice.Value = price;
                cmd.Parameters.Add(parPrice);
                adtr = new SqlDataAdapter(cmd);
                ds.Clear();
                adtr.Fill(ds, "TBItem1");
                dt = ds.Tables["TBItem1"];
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable InsertItem(Item item) {
            try
            {
                DataRow dr = dt.NewRow();
                dr["Name"] = item.Name;
                dr["Description"] = item.Description;
                dr["Price"] = item.Price;
                dt.Rows.Add(dr);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable DeleteItem(int code) {
            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["Code"].ToString() == code.ToString())
                    {
                        dt.Rows[i].Delete();
                    }
                }
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public void UpdateDB(DataTable table) {

            string updtCmd = "select * from TBItem1";
            adtr = new SqlDataAdapter(updtCmd, con);
            SqlCommandBuilder comb = new SqlCommandBuilder(adtr);
            adtr.Update(dt);
        }
    }
}
