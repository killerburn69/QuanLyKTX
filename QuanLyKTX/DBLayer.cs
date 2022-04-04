using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace QuanLyKTX
{
    public class DBLayer
    {
		//Ham dung chung cho viec ket noi va lay data
		// ham dung chung cho viec ket noi va lay data
		SqlConnection cnn;
		SqlCommand cmd;
		SqlDataAdapter adp;

		string strConnect =
			"Data Source=(local);Initial Catalog=Northwind;Integrated Security=True";

		public DBLayer()
		{
			cnn = new SqlConnection(strConnect);
			cmd = cnn.CreateCommand();
		}
		// Select query
		//Thuc thi cau lenh truy van va tra ve DataSet
		//DataSet là Database, co 1 tap cac DataTable
		public DataSet ExecuteQueryDataSet(
			string strSQL, CommandType ct,
			params SqlParameter[] p)
		{
			cmd.CommandText = strSQL; //Lay cau lenh
			cmd.CommandType = ct;       //Chi dinh loai cau lenh
			adp = new SqlDataAdapter(cmd);      //Lay DataAdapter
			DataSet ds = new DataSet();
			adp.Fill(ds);
			return ds;
		}
	}
}
