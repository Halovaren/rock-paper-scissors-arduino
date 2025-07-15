using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using static System.Net.Mime.MediaTypeNames;
using System.Threading;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using System.Xml;
using System.Net.Http;


namespace IT152PP
{
    public partial class Gameplay : Form
    {
        public Validation _validation;
        bool player1HasChosen = false;
        bool player2HasChosen = false;
        string player1result = "";
        string player2result = "";
        int player1Score = 0;
        int player2Score = 0;

        public Gameplay()
        {
            InitializeComponent();
            _validation = new Validation();
            _validation.RunNonSelectQuery("UPDATE `rps` SET `formchoice`='qmark',`score`='0',`haschosen`='false' WHERE playerid=1");
            _validation.RunNonSelectQuery("UPDATE `rps` SET `formchoice`='qmark',`score`='0',`haschosen`='false' WHERE playerid=2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainMenu form2 = new MainMenu();
            form2.ShowDialog();
            this.Hide();
        }


        private void lbl3_Click(object sender, EventArgs e)
        {

        }

        string datasource = "172.20.10.2";
        string port = "3306";
        string username = "root";
        string password = "";
        string database = "iot";

        private void timer1_Tick(object sender, EventArgs e)
        {
            string roundResult = "";

            lbl_play1.Text = _validation.RunSelectQuery("playername", "1");
            lbl_play2.Text = _validation.RunSelectQuery("playername", "2");

            //Player 1 - show check after picking a handform
            if (player1HasChosen == false)
            {
                if (_validation.RunSelectQuery("haschosen", "1") == "true")
                {
                    P1status.Text = "✅";
                    P1status.ForeColor = Color.LightGreen;
                    player1HasChosen = true;
                }
            }

            //Player 2 - show check after picking a handform
            if (player2HasChosen == false)
            {
                if (_validation.RunSelectQuery("haschosen", "2") == "true")
                {
                    P2status.Text = "✅";
                    P2status.ForeColor = Color.LightGreen;
                    player2HasChosen = true;
                }
            }

            //Show both player's handforms after picking, decide game or round winner.
            if (player1HasChosen == true && player2HasChosen == true)
            {
                RevealForms();
                string p1form = _validation.RunSelectQuery("formchoice", "1");
                string p2form = _validation.RunSelectQuery("formchoice", "2");
                roundResult = _validation.PlayRound(p1form, p2form);
                winround_lbl.Visible = true;
                nxtround_btn.Visible = true;

                //Draw
                if (roundResult == "Draw")
                {
                    winround_lbl.Text = "Draw";
                }

                //Give score to Player 1
                else if (roundResult == "score P1")
                {
                    winround_lbl.Text = lbl_play1.Text+"\n scored!";
                    player1Score++;
                    lbl_pts1.Text = player1Score.ToString();
                    roundResult = "";
                    _validation.RunNonSelectQuery("UPDATE `rps` SET `score`='" + player1Score + "',`haschosen`='false' WHERE playerid=1");
                    player1HasChosen = false;
                    player2HasChosen = false;

                    //Notify Player 1 got 3 points and wins game
                    if (player1Score == 3)
                    {
                        winround_lbl.Text = lbl_play1.Text + "\nwins the game!";
                        nxtround_btn.Visible = false;
                        resetgame_btn.Visible = true;
                        savematch_btn.Visible = true;
                        player1result = "Win";
                        player2result = "Lose";
                        player2Score = 0;
                        player1Score = 0;
                    }

                }

                //Give score to Player 2
                else
                {
                    winround_lbl.Text = lbl_play2.Text+"\n scored!";
                    player2Score++;
                    lbl_pts2.Text = player2Score.ToString();
                    roundResult = "";
                    _validation.RunNonSelectQuery("UPDATE `rps` SET `score`='" + player2Score + "',`haschosen`='false' WHERE playerid=2");
                    player1HasChosen = false;
                    player2HasChosen = false;

                    //Notify Player 2 got 3 points and wins game
                    if (player2Score == 3)
                    {
                        winround_lbl.Text = lbl_play2.Text + "\nwins the game!";
                        nxtround_btn.Visible = false;
                        resetgame_btn.Visible = true;
                        savematch_btn.Visible = true;
                        player1result = "Lose";
                        player2result = "Win";
                        player2Score = 0;
                        player1Score = 0;
                    }

                }
            }
        }


        private void RecordMatch()
        {
            _validation.RunNonSelectQuery("INSERT INTO `matchrecords`(" +
                "`player1name`, `player1score`, `player1result`," +
                "`player2name`,`player2score`,`player2result`) " +
                "VALUES ('" + lbl_play1.Text + "','" + lbl_pts1.Text + "','" + player1result +
                "','" + lbl_play2.Text + "','" + lbl_pts2.Text + "','" + player2result + "')");
        }

        //Show handforms of players
        private void RevealForms()
        {
            //Player 1's handform ---
            String selectQuery = "SELECT formchoice FROM rps WHERE playerid = 1";
            string MySQLConnectionString = "datasource=" + datasource + ";port=" + port + ";username=" + username + ";password=" + password + ";database=" + database;
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);
            MySqlCommand commandDatabase = new MySqlCommand(selectQuery, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            databaseConnection.Open();
            MySqlDataReader myReader = commandDatabase.ExecuteReader();
            myReader.Read();
            pictureBox1.ImageLocation = @"C:\Users\pvsal\OneDrive\Desktop\IT152P\IT152P and IT153P Module 3 Project\RPSwithVS\IT152PP\IT152PP\images\" + myReader.GetString(0) + ".png";
            databaseConnection.Close();
            //---


            //Player 2's handform ---
            selectQuery = "SELECT formchoice FROM rps WHERE playerid = 2";
            MySqlCommand commandDatabase2 = new MySqlCommand(selectQuery, databaseConnection);
            commandDatabase2.CommandTimeout = 60;

            databaseConnection.Open();
            MySqlDataReader myReader2 = commandDatabase2.ExecuteReader();
            myReader2.Read();
            pictureBox2.ImageLocation = @"C:\Users\pvsal\OneDrive\Desktop\IT152P\IT152P and IT153P Module 3 Project\RPSwithVS\IT152PP\IT152PP\images\" + myReader2.GetString(0) + ".png";
            databaseConnection.Close();
            ///---
        }


        //Compare hand forms of players and decide the round winner

        //Return to main menu
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu form2 = new MainMenu();
            form2.Show();
        }

        //Reset UI for next round
        private void nxtround_btn_Click(object sender, EventArgs e)
        {
            ResetRound();
        }

        //Reset UI to default for next game
        private void ResetRound()
        {
            _validation.RunNonSelectQuery("UPDATE `rps` SET `formchoice`='qmark',`haschosen`='false' WHERE playerid=1");
            _validation.RunNonSelectQuery("UPDATE `rps` SET `formchoice`='qmark',`haschosen`='false' WHERE playerid=2");
            pictureBox1.ImageLocation = @"C:\Users\pvsal\OneDrive\Desktop\IT152P\IT152P and IT153P Module 3 Project\RPSwithVS\IT152PP\IT152PP\images\qmark.png";
            pictureBox2.ImageLocation = @"C:\Users\pvsal\OneDrive\Desktop\IT152P\IT152P and IT153P Module 3 Project\RPSwithVS\IT152PP\IT152PP\images\qmark.png";
            player1HasChosen = false;
            player2HasChosen = false;
            winround_lbl.Visible = false;
            nxtround_btn.Visible = false;
            P1status.Text = "...";
            P1status.ForeColor = Color.White;
            P2status.Text = "...";
            P2status.ForeColor = Color.White;
        }


        //Execute UPDATE,DELETE,INSERT sql queries


        //Reset game if reset game button is clicked
        private void resetgame_btn_Click(object sender, EventArgs e)
        {
            resetgame_btn.Visible = false;
            ResetRound();
            _validation.RunNonSelectQuery("UPDATE `rps` SET `score`='0' WHERE playerid = 1");
            _validation.RunNonSelectQuery("UPDATE `rps` SET `score`='0' WHERE playerid = 2");
            lbl_pts1.Text = "0";
            lbl_pts2.Text = "0";
            player1Score = 0;
            player2Score = 0;

            //Return to enter player name form
            this.Hide();
            EnterPlayerNames form4 = new EnterPlayerNames();
            form4.ShowDialog();
        }

        private void savematch_btn_Click(object sender, EventArgs e)
        {
            RecordMatch();
            winround_lbl.Text = "Match Saved!";
        }
    }

}

