namespace Gravity_Run_Game_Win_FORMS_MOOICT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            player = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            lblScore = new Label();
            lblhighScore = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.platform_tilesblue;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(797, 35);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.platform_tilesblue;
            pictureBox2.Location = new Point(-1, 271);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(797, 37);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // player
            // 
            player.BackColor = Color.Transparent;
            player.Image = Properties.Resources.run_up0;
            player.Location = new Point(51, 23);
            player.Name = "player";
            player.Size = new Size(66, 76);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 2;
            player.TabStop = false;
            player.Click += player_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.box;
            pictureBox3.Location = new Point(517, 206);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 69);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "obstacle";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.box;
            pictureBox4.Location = new Point(352, 28);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(34, 81);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "obstacle";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.Transparent;
            lblScore.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblScore.ForeColor = Color.White;
            lblScore.Location = new Point(-1, 3);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(56, 17);
            lblScore.TabIndex = 5;
            lblScore.Text = "Score: 0";
            lblScore.Click += lblScore_Click;
            // 
            // lblhighScore
            // 
            lblhighScore.AutoSize = true;
            lblhighScore.BackColor = Color.Transparent;
            lblhighScore.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblhighScore.ForeColor = Color.White;
            lblhighScore.Location = new Point(0, 289);
            lblhighScore.Name = "lblhighScore";
            lblhighScore.Size = new Size(90, 17);
            lblhighScore.TabIndex = 6;
            lblhighScore.Text = "High Score: 0";
            lblhighScore.Click += label1_Click;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += GameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_still;
            ClientSize = new Size(654, 309);
            Controls.Add(lblhighScore);
            Controls.Add(lblScore);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(player);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Gravity Run Game MOOICT";
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox player;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label lblScore;
        private Label lblhighScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}