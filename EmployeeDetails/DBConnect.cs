using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace EmployeeDetails
{
    class DBConnect{
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public DBConnect() {
            initialize();
        }

        public void initialize() {
            server = "localhost";
            database = "employee_management";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        public void OpenConnection(){
            try{
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                else
                    return;
            }
            catch (MySqlException ex){
                Console.WriteLine(ex);
            }
        }

        public void CloseConnection(){
            try{
                if (connection.State == ConnectionState.Open)
                    connection.Close();
                else
                    return;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void execute(String query) {
            this.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            this.CloseConnection();

        }

        public MySqlConnection getConnection() {
            return connection;
        }
    }
}
