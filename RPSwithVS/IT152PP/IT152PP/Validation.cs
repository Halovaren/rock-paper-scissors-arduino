using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Http;



namespace IT152PP
{
    public partial class Validation
    {
        public readonly HttpClient _client = new HttpClient();
        string datasource = "172.20.10.2";
        string port = "3306";
        string username = "root";
        string password = "";
        string database = "iot";
        public string PlayRound(string p1Choice, string p2Choice)
        {

            if ((p1Choice == "1R" && p2Choice == "2R") ||
                (p1Choice == "1P" && p2Choice == "2P") ||
                (p1Choice == "1S" && p2Choice == "2S"))
            {
                return "Draw";

            }
            else if ((p1Choice == "1R" && p2Choice == "2S") ||
                (p1Choice == "1P" && p2Choice == "2R") ||
                (p1Choice == "1S" && p2Choice == "2P"))
            {
                return "score P1";
            }
            else
            {
                return "score P2";
            }
        }

        public void RunNonSelectQuery(string Query)
        {
            try
            {
                string MySQLConnectionString2 = "datasource=" + datasource + ";port=" + port + ";username=" + username + ";password=" + password + ";database=" + database;
                MySqlConnection databaseConnection2 = new MySqlConnection(MySQLConnectionString2);
                MySqlCommand commandDatabase2 = new MySqlCommand(Query, databaseConnection2);
                commandDatabase2.CommandTimeout = 60;
                databaseConnection2.Open();
                commandDatabase2.ExecuteNonQuery();
                databaseConnection2.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error!" + error.Message);
            }
        }



        public string RunSelectQuery(string requestItem, string playerNumber)
        {
            string selectQueryResult = "";
            String selectQuery2 = "SELECT " + requestItem + " FROM rps WHERE playerid = " + playerNumber;
            string MySQLConnectionString2 = "datasource=" + datasource + ";port=" + port + ";username=" + username + ";password=" + password + ";database=" + database;
            MySqlConnection databaseConnection2 = new MySqlConnection(MySQLConnectionString2);
            MySqlCommand commandDatabase2 = new MySqlCommand(selectQuery2, databaseConnection2);
            commandDatabase2.CommandTimeout = 60;
            databaseConnection2.Open();

            MySqlDataReader myReader2 = commandDatabase2.ExecuteReader();

            myReader2.Read();
            selectQueryResult = myReader2.GetString(0);
            databaseConnection2.Close();

            return selectQueryResult;

        }
    }
}