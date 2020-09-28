using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace MessageForYou
{
    class UseDataBase
    {

        static string conString = @"DataSource=data\DataBase.db3;Version=3;databasePassword=password";
        //static string conString = @"DataSource=E:\DataBase.db3;Version=3;databasePassword=password";
        SQLiteConnection connection = new SQLiteConnection(conString);
        SQLiteDataAdapter da;
        DataTable dt;
        

        public DataTable SQLQuery(string query)
        {
            connection.Open();
            da = new SQLiteDataAdapter(query, connection);
            dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            return dt;
        }
        
        public DataTable Find(string table, string combobox, string text)
        {
            connection.Open();
            string query = "select * from ["+table+"] where "+combobox+" like '"+text+"'";
            da = new SQLiteDataAdapter(query, connection);
            dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            return dt;
        }
        
    }
}
