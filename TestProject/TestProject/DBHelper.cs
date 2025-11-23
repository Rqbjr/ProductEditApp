using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace TestProject
{
    internal static class DBHelper
    {
        private static string _connectionString=string.Empty;
        internal static string ConnectionString   
        {
            get { return _connectionString; }  
            set { _connectionString = value; } 
        }
        
        internal static string ReadConnectionStringFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                return File.ReadAllText(filePath);
            }
            else 
            {
                return string.Empty;
            }
        }
        internal static DataTable ExecuteSelectQuery(string sql)
        {
            using var conn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand(sql, conn);

            conn.Open();

            using var reader = cmd.ExecuteReader();
            var table = new DataTable();
            table.Load(reader);

            return table;
        }

        internal static int ExecuteQuery(string sql)
        {
            using var conn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand(sql, conn);

            conn.Open();
            return cmd.ExecuteNonQuery();
        }
        internal static int ExecuteWithParameters(string sql, List<SqlParameter> parameters)
        {
            using var conn = new SqlConnection(_connectionString);
            using var cmd = new SqlCommand(sql, conn);
            foreach (var param in parameters)
            {
                cmd.Parameters.Add(param);
            }
            conn.Open();
            return cmd.ExecuteNonQuery();
        }
    }
}


