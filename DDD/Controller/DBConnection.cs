﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK.Controller
{
	public class DBConnection
	{
		SqlConnection sqlConnection = new SqlConnection(@"Data Sourse =localhost ;Initial Catalog = BANK; Integrated Security = True");
		public void openConnection()
		{
			if (sqlConnection.State == System.Data.ConnectionState.Closed) 
			{
				sqlConnection.Open();
			}
		}
		public void closeConnection()
		{
			if (sqlConnection.State == System.Data.ConnectionState.Open)
			{
				sqlConnection.Close();
			}
		}
		public SqlConnection getConnection()
		{
			return sqlConnection;
		}
	}
}
