using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ADO.NET classes
using System.Data;
using System.Data.SqlClient;

namespace Assignment1.Jacob.WindowsForm.V2
{
    public class DataAccessLayer
    {
        public SqlConnection GetDatabaseConnection()
        {
            //Stores the connectionstring from the configurationmanager in the local connectionString
            string connectionString = ConfigurationManager.ConnectionStrings["SYSA14ConnectionString"].ConnectionString;

            //Builds the connectionstring that we will be using to connect to the database
            SqlConnectionStringBuilder builder = new(connectionString);
            //Creates the SQL connection  
            SqlConnection connection = new(builder.ConnectionString);

            return connection;
        }

        public void PrintTest()
        {
            SqlConnection connection = GetDatabaseConnection();
           
            //Gives me an SQLCommand object. This one will contain my query
            SqlCommand command = connection.CreateCommand();
         
            command.CommandText = "SELECT * FROM Customer";
           
            //Opens the connection to my database
            connection.Open();
            
            //My dataReader contains the "rows" that I get back from my sqlcommand
            SqlDataReader sqlDataReader = command.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Console.WriteLine(sqlDataReader.GetString(0));
                Console.WriteLine(sqlDataReader.GetString(1));
                Console.WriteLine(sqlDataReader.GetString(2));
                Console.WriteLine(sqlDataReader.GetString(3));
                Console.WriteLine("--------------------");


            }

            sqlDataReader.Close();
            connection.Close();
            connection.Dispose();

        }

        public void AddCustomer (string customerFirstName, string customerLastName) 
        {
            SqlConnection connection = GetDatabaseConnection();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO Customer VALUES (@CustomerFirstName, @CustomerLastName)";

            command.Parameters.Add(new SqlParameter("@CustomerFirstName", customerFirstName));
            command.Parameters.Add(new SqlParameter("@CustomerLastName", customerLastName));

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
            connection.Dispose();
        }

    }
}
