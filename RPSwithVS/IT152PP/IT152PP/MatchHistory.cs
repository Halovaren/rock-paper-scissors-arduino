using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;

namespace IT152PP
{
    public partial class MatchHistory : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;

        public MatchHistory()
        {
            InitializeComponent();
            InitializeDatabase();


            
            
            listView1.Columns.Add("P1");
            listView1.Columns.Add("Score");
            listView1.Columns.Add("Result");

            listView1.Columns.Add("VS.");
            listView1.Columns.Add("P2");
            listView1.Columns.Add("Score");
            listView1.Columns.Add("Result");


            listView1.View = View.Details;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM matchrecords";

            try
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {

                    ListViewItem item = new ListViewItem();
                    item.Text = dataReader["player1name"].ToString();
                    item.SubItems.Add(dataReader["player1score"].ToString());
                    item.SubItems.Add(dataReader["player1result"].ToString());


                    item.SubItems.Add("");
                    item.SubItems.Add(dataReader["player2name"].ToString());
                    item.SubItems.Add(dataReader["player2score"].ToString());
                    item.SubItems.Add(dataReader["player2result"].ToString());


                    listView1.Items.Add(item);
                }

                foreach (ListViewItem item in listView1.Items)
                {
                    // Check if the sub-item belongs to "Player 1" and set its color to red
                    if (item.SubItems[0].Text == item.Text ||
                        item.SubItems[1].Text == item.SubItems[0].Text ||
                        item.SubItems[2].Text == item.SubItems[0].Text)
                    {
                        item.SubItems[0].ForeColor = Color.Red;
                        item.SubItems[1].ForeColor = Color.Red;
                        item.SubItems[2].ForeColor = Color.Red;
                    }
                    // Check if the sub-item belongs to "Player 2" and set its color to blue
                    else
                    {
                        item.SubItems[4].ForeColor = Color.Blue;
                        item.SubItems[5].ForeColor = Color.Blue;
                        item.SubItems[6].ForeColor = Color.Blue;
                    }
                }

                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }


        private void InitializeDatabase()
        {
            server = "localhost";
            database = "iot";
            uid = "root";

            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};";
            connection = new MySqlConnection(connectionString);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu form2 = new MainMenu();
            form2.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
                this.Hide();
                MainMenu form2 = new MainMenu();
                form2.Show();
            
        }
    }
}
