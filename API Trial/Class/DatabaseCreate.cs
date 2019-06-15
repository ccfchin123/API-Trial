using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using DigitalIntergrationModel;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace API_Trial.Class
{
    public class DatabaseCreate
    {
        //public void CreateCenterDatabase()
        //{
        //    string connectionString = (ConfigurationManager.ConnectionStrings["AMSConnectionString"]).ToString();
        //    SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder(connectionString);
        //    SqlConnection tmpConn;
        //    string sqlCreateDBQuery;
        //    tmpConn = new SqlConnection();
        //    tmpConn.ConnectionString = "SERVER = " + sqlConnectionStringBuilder.DataSource +
        //                         "; DATABASE = "+ sqlConnectionStringBuilder.InitialCatalog + "; User ID = " + sqlConnectionStringBuilder.UserID  +"; Pwd = "+ sqlConnectionStringBuilder.Password;
        //    //sqlCreateDBQuery = " CREATE DATABASE "
        //    //                   + DBParam.DatabaseName
        //    //                   + " ON PRIMARY "
        //    //                   + " (NAME = " + DBParam.DataFileName + ", "
        //    //                   + " FILENAME = '" + DBParam.DataPathName + "', "
        //    //                   + " SIZE = 2MB,"
        //    //                   + " FILEGROWTH =" + DBParam.DataFileGrowth + ") "
        //    //                   + " LOG ON (NAME =" + DBParam.LogFileName + ", "
        //    //                   + " FILENAME = '" + DBParam.LogPathName + "', "
        //    //                   + " SIZE = 1MB, "
        //    //                   + " FILEGROWTH =" + DBParam.LogFileGrowth + ") ";
        //    //SqlCommand myCommand = new SqlCommand(sqlCreateDBQuery, tmpConn);
        //    //try
        //    //{
        //    //    tmpConn.Open();
        //    //    MessageBox.Show(sqlCreateDBQuery);
        //    //    myCommand.ExecuteNonQuery();
        //    //    MessageBox.Show("Database has been created successfully!",
        //    //                      "Create Database", MessageBoxButtons.OK,
        //    //                                  MessageBoxIcon.Information);
        //    //}
        //    //catch (System.Exception ex)
        //    //{
        //    //    MessageBox.Show(ex.ToString(), "Create Database",
        //    //                                MessageBoxButtons.OK,
        //    //                         MessageBoxIcon.Information);
        //    //}
        //    //finally
        //    //{
        //    //    tmpConn.Close();
        //    //}
        //    return;
        //}

        //public void CreateDatabase()
        //{
        //    string connectionString = (ConfigurationManager.ConnectionStrings["AMSConnectionString"]).ToString();
        //    SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder(connectionString);
        //    SqlConnection tmpConn;
        //    string sqlCreateDBQuery;
        //    tmpConn = new SqlConnection();
        //    //tmpConn.ConnectionString = "SERVER = " + sqlConnectionStringBuilder.DataSource +
        //    //                     "; DATABASE = master; User ID = sa; Pwd = sa";
        //    //sqlCreateDBQuery = " CREATE DATABASE "
        //    //                   + DBParam.DatabaseName
        //    //                   + " ON PRIMARY "
        //    //                   + " (NAME = " + DBParam.DataFileName + ", "
        //    //                   + " FILENAME = '" + DBParam.DataPathName + "', "
        //    //                   + " SIZE = 2MB,"
        //    //                   + " FILEGROWTH =" + DBParam.DataFileGrowth + ") "
        //    //                   + " LOG ON (NAME =" + DBParam.LogFileName + ", "
        //    //                   + " FILENAME = '" + DBParam.LogPathName + "', "
        //    //                   + " SIZE = 1MB, "
        //    //                   + " FILEGROWTH =" + DBParam.LogFileGrowth + ") ";
        //    //SqlCommand myCommand = new SqlCommand(sqlCreateDBQuery, tmpConn);
        //    //try
        //    //{
        //    //    tmpConn.Open();
        //    //    MessageBox.Show(sqlCreateDBQuery);
        //    //    myCommand.ExecuteNonQuery();
        //    //    MessageBox.Show("Database has been created successfully!",
        //    //                      "Create Database", MessageBoxButtons.OK,
        //    //                                  MessageBoxIcon.Information);
        //    //}
        //    //catch (System.Exception ex)
        //    //{
        //    //    MessageBox.Show(ex.ToString(), "Create Database",
        //    //                                MessageBoxButtons.OK,
        //    //                         MessageBoxIcon.Information);
        //    //}
        //    //finally
        //    //{
        //    //    tmpConn.Close();
        //    //}
        //    return;
        //}
    }
}