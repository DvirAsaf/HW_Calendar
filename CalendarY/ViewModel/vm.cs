using System;
using System.Data.SQLite;
namespace CalendarY.ViewModel
{
    class VM
    {
        public static string Connect;
        public static string LbEvent;
        public static bool Flag;
        
        //  Set up the first database connection
        public static SQLiteConnection Connection()
        {
            var conn = Model.DB.CreateConnection(Connect);
            return conn;
        }

        /*
            In order to create a table in DataBase, we use this method.
            This method calls the method that actually creates the table */
        public static SQLiteConnection Table()
        {
            var conn = Connection();
            Model.DB.CreateTable(conn);
            return conn;
        }
        
        //  Whenever a view wants to insert a row into a table in a database, this method calls the method that does it.
        public static void Insert(String date, String even)
        {
            var conn = Connection();
            Model.DB.InsertData(conn, date, even);
        }
        public static void CloseConnection(SQLiteConnection sqlite) 
        {
            sqlite.Close();
        }

        //  When the view wants the data from the database, we call the method that calls the database's method
        public static void PassUserInput(string dateDay)
        {
            Model.DB.GetDataFromUser(dateDay);
        }
    }
}
