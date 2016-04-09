using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Auto
{
    class ConnectToDB
    {
        private SqlConnection cnn;

        public ConnectToDB()
        {
            string connetionString = null;
            connetionString = "Server=SQL5018.HostBuddy.com;Database=DB_9FB06E_service;User Id=DB_9FB06E_service_admin; Password = 651252ab; ";
            cnn = new SqlConnection(connetionString);
        }

        public SqlConnection getConnection()
        {
            return cnn;
        }

        public DataSet selectFrom(string selectString)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(selectString, cnn);
            cnn.Open();
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            cnn.Close();
            return ds;
        }

        public DataSet selectFrom(string fields, string table)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT " + fields + " FROM " + table, cnn);
            cnn.Open();
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            cnn.Close();
            return ds;
        }

        public DataSet selectFrom(string fields, string table, string where)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT " + fields + " FROM " + table + " WHERE " + where, cnn);
            cnn.Open();
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            cnn.Close();
            return ds;
        }

        public DataSet selectFrom(string fields, string table, string join, string where)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT " + fields + " FROM " + table + " JOIN " + join + " WHERE " + where, cnn);
            cnn.Open();
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            cnn.Close();
            return ds;
        }

        public void insertInto (string table, string cells, string values)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "INSERT INTO " + table + "(" + cells +")   VALUES(" + values +")";
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public void closeConnection()
        {
            cnn.Close();
        }
    }
}
