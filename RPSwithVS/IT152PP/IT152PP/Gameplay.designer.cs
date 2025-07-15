
namespace IT152PP
{
    partial class Gameplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gameplay));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_play1 = new System.Windows.Forms.Label();
            this.lbl_play2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_win = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_pts1 = new System.Windows.Forms.Label();
            this.lbl_pts2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.P1status = new System.Windows.Forms.Label();
            this.P2status = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.nxtround_btn = new System.Windows.Forms.Button();
            this.winround_lbl = new System.Windows.Forms.Label();
            this.resetgame_btn = new System.Windows.Forms.Button();
            this.savematch_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 69);
            this.label1.TabIndex = 0;
            // 
            // lbl_play1
            // 
            this.lbl_play1.AutoSize = true;
            this.lbl_play1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_play1.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_play1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_play1.Location = new System.Drawing.Point(108, 388);
            this.lbl_play1.Name = "lbl_play1";
            this.lbl_play1.Size = new System.Drawing.Size(153, 31);
            this.lbl_play1.TabIndex = 1;
            this.lbl_play1.Text = "PLAYER 1";
            this.lbl_play1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_play2
            // 
            this.lbl_play2.AutoSize = true;
            this.lbl_play2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_play2.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_play2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_play2.Location = new System.Drawing.Point(892, 388);
            this.lbl_play2.Name = "lbl_play2";
            this.lbl_play2.Size = new System.Drawing.Size(159, 31);
            this.lbl_play2.TabIndex = 2;
            this.lbl_play2.Text = "PLAYER 2";
            this.lbl_play2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 181);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(719, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "POINTS";
            // 
            // lbl_win
            // 
            this.lbl_win.AutoSize = true;
            this.lbl_win.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_win.Location = new System.Drawing.Point(491, 354);
            this.lbl_win.Name = "lbl_win";
            this.lbl_win.Size = new System.Drawing.Size(0, 24);
            this.lbl_win.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(335, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "POINTS";
            // 
            // lbl_pts1
            // 
            this.lbl_pts1.AutoSize = true;
            this.lbl_pts1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pts1.Location = new System.Drawing.Point(363, 254);
            this.lbl_pts1.Name = "lbl_pts1";
            this.lbl_pts1.Size = new System.Drawing.Size(49, 54);
            this.lbl_pts1.TabIndex = 9;
            this.lbl_pts1.Text = "0";
            // 
            // lbl_pts2
            // 
            this.lbl_pts2.AutoSize = true;
            this.lbl_pts2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pts2.Location = new System.Drawing.Point(753, 254);
            this.lbl_pts2.Name = "lbl_pts2";
            this.lbl_pts2.Size = new System.Drawing.Size(49, 54);
            this.lbl_pts2.TabIndex = 10;
            this.lbl_pts2.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(842, 181);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(264, 186);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 9.75F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(987, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 33);
            this.button1.TabIndex = 22;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // P1status
            // 
            this.P1status.AutoSize = true;
            this.P1status.BackColor = System.Drawing.Color.Transparent;
            this.P1status.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1status.ForeColor = System.Drawing.Color.White;
            this.P1status.Location = new System.Drawing.Point(256, 135);
            this.P1status.Name = "P1status";
            this.P1status.Size = new System.Drawing.Size(44, 31);
            this.P1status.TabIndex = 25;
            this.P1status.Text = "...";
            // 
            // P2status
            // 
            this.P2status.AutoSize = true;
            this.P2status.BackColor = System.Drawing.Color.Transparent;
            this.P2status.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2status.ForeColor = System.Drawing.Color.White;
            this.P2status.Location = new System.Drawing.Point(1047, 135);
            this.P2status.Name = "P2status";
            this.P2status.Size = new System.Drawing.Size(44, 31);
            this.P2status.TabIndex = 26;
            this.P2status.Text = "...";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            // 
            // nxtround_btn
            // 
            this.nxtround_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.nxtround_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.nxtround_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nxtround_btn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nxtround_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nxtround_btn.Location = new System.Drawing.Point(497, 340);
            this.nxtround_btn.Name = "nxtround_btn";
            this.nxtround_btn.Size = new System.Drawing.Size(176, 58);
            this.nxtround_btn.TabIndex = 21;
            this.nxtround_btn.Text = "Next Round\r\n";
            this.nxtround_btn.UseVisualStyleBackColor = false;
            this.nxtround_btn.Visible = false;
            this.nxtround_btn.Click += new System.EventHandler(this.nxtround_btn_Click);
            // 
            // winround_lbl
            // 
            this.winround_lbl.AutoSize = true;
            this.winround_lbl.BackColor = System.Drawing.Color.Transparent;
            this.winround_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.winround_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.winround_lbl.Font = new System.Drawing.Font("Arial", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winround_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.winround_lbl.Location = new System.Drawing.Point(484, 117);
            this.winround_lbl.Name = "winround_lbl";
            this.winround_lbl.Size = new System.Drawing.Size(97, 34);
            this.winround_lbl.TabIndex = 28;
            this.winround_lbl.Text = "label3";
            this.winround_lbl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.winround_lbl.Visible = false;
            // 
            // resetgame_btn
            // 
            this.resetgame_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.resetgame_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.resetgame_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetgame_btn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetgame_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resetgame_btn.Location = new System.Drawing.Point(354, 340);
            this.resetgame_btn.Name = "resetgame_btn";
            this.resetgame_btn.Size = new System.Drawing.Size(176, 58);
            this.resetgame_btn.TabIndex = 29;
            this.resetgame_btn.Text = "Reset Game";
            this.resetgame_btn.UseVisualStyleBackColor = false;
            this.resetgame_btn.Visible = false;
            this.resetgame_btn.Click += new System.EventHandler(this.resetgame_btn_Click);
            // 
            // savematch_btn
            // 
            this.savematch_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.savematch_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.savematch_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.savematch_btn.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savematch_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.savematch_btn.Location = new System.Drawing.Point(637, 340);
            this.savematch_btn.Name = "savematch_btn";
            this.savematch_btn.Size = new System.Drawing.Size(176, 58);
            this.savematch_btn.TabIndex = 30;
            this.savematch_btn.Text = "Save Match";
            this.savematch_btn.UseVisualStyleBackColor = false;
            this.savematch_btn.Visible = false;
            this.savematch_btn.Click += new System.EventHandler(this.savematch_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(97, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 31);
            this.label3.TabIndex = 31;
            this.label3.Text = "PLAYER 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(882, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 31);
            this.label5.TabIndex = 32;
            this.label5.Text = "PLAYER 2";
            // 
            // Gameplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1149, 487);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.savematch_btn);
            this.Controls.Add(this.resetgame_btn);
            this.Controls.Add(this.winround_lbl);
            this.Controls.Add(this.nxtround_btn);
            this.Controls.Add(this.P2status);
            this.Controls.Add(this.P1status);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_pts2);
            this.Controls.Add(this.lbl_pts1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_win);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_play2);
            this.Controls.Add(this.lbl_play1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Gameplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_play1;
        private System.Windows.Forms.Label lbl_play2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_win;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_pts1;
        private System.Windows.Forms.Label lbl_pts2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label P1status;
        private System.Windows.Forms.Label P2status;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button nxtround_btn;
        private System.Windows.Forms.Label winround_lbl;
        private System.Windows.Forms.Button resetgame_btn;
        private System.Windows.Forms.Button savematch_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

