using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT152PP
{
    public partial class EnterPlayerNames : Form
    {
        public EnterPlayerNames()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrWhiteSpace(player1_name.Text) || string.IsNullOrWhiteSpace(player2_name.Text))
            {
                MessageBox.Show("Please put both player's names.");
            }
            else
            {
                this.Hide();
                Gameplay form1 = new Gameplay();
                form1.Show();



                string player1 = player1_name.Text;
                string player2 = player2_name.Text;

                UpdatePlayerNames(player1, player2);
            }
        }

        private void UpdatePlayerNames(string player1name, string player2name)
        {
            string server = "localhost";
            string uid = "root";
            string password = "";
            string database = "iot";
            string constring = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();

            string query = "UPDATE `rps` SET `playername`='" + player1name + "' WHERE playerid=1";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();

            string query2 = "UPDATE `rps` SET `playername`='" + player2name + "' WHERE playerid=2";
            MySqlCommand cmd2 = new MySqlCommand(query2, con);
            cmd2.ExecuteNonQuery();

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu form2 = new MainMenu();
            form2.Show();
        }
    }
}