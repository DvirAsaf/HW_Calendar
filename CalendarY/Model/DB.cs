using System;
using System.Data.SQLite;
using System.ComponentModel;

namespace CalendarY.Model
{
    class DB
    {
        //  Connect to the database
        public static SQLiteConnection CreateConnection(string connection)
        {
            SQLiteConnection conn;
            conn = new SQLiteConnection(connection);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {

            }
            return conn;
        }

        //  Creating a new table if it doesn't exist
        public static void CreateTable(SQLiteConnection conn)
        {
            SQLiteCommand sqlitecommand = conn.CreateCommand();
            string sql = "CREATE TABLE IF NOT EXISTS myTable (date VARCHAR(30), event VARCHAR(30))";
            sqlitecommand.CommandText = sql;
            sqlitecommand.ExecuteNonQuery();
        }
        
        /*
            Add a pair of information (date, event) to the DataBase
            In the case of old data with the same date, delete the old one and then insert the new one*/
        public static void InsertData(SQLiteConnection conn, string date, string even)
        {
            SQLiteCommand sqlitecommand = conn.CreateCommand();
            String insert = "INSERT INTO myTable(date, event) VALUES (?,?);";
            String drop = "DELETE FROM myTable where date = ?";
            sqlitecommand.CommandText = drop;
            sqlitecommand.Parameters.AddWithValue("date", date);
            sqlitecommand.ExecuteNonQuery();
            sqlitecommand.CommandText = insert;
            sqlitecommand.Parameters.AddWithValue("date", date);
            sqlitecommand.Parameters.AddWithValue("event", even);
            sqlitecommand.ExecuteNonQuery();
        }
        
        /*  Get all information from the database and display it on the calendar
            Step one is to connect to the database
            Once the two veribales readers and the command line have been created
            Create a command with cmd and enter the SQL command and the correct data.
            Change the label event in userControl with the correct data*/
        public static void GetDataFromUser(string dateDay)
        {
            ViewModel.VM.Flag = false;
            var conn = CreateConnection("Data Source=database.db; Version = 3; New = True; Compress = True;");
            CreateTable(conn);
            SQLiteDataReader reader;
            SQLiteCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM myTable where date = ?";
            cmd.Parameters.AddWithValue("date", Form1.StaticMonthI + "/" + dateDay + "/" + Form1.StaticYearI);
            reader = cmd.ExecuteReader(); 
            if (reader.Read())
            {
                ViewModel.VM.LbEvent = reader["event"].ToString();
                ViewModel.VM.Flag = true;
            }
            reader.Dispose();
            cmd.Dispose();
            conn.Close();
        }
    }
}