using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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

        private void OpenConnection(){
            try{
                connection.Open();
            }
            catch (MySqlException ex){
                Console.WriteLine(ex);
            }
        }

        private void CloseConnection(){
            try{
                connection.Close();
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
