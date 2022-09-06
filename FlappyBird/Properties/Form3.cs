using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace FlappyBird.Properties
{
    public partial class Form3 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        int pipespeed = 16;
        int gravity = 10;
        int score = 0;
        int timeleft = 3;
        int timeleft2 = 1;

        public Form3()
        {
            InitializeComponent();
            player.URL = "bg music.mp3";
            Bird.ImageLocation = @"C:\Users\Moiz\Pictures\Project Resources\birdgif.gif";
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            GameTimer.Stop();
            gameovertimer.Stop();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {


                playtimer.Stop();
                Bird.Top += gravity;
                PipeBottom.Left -= pipespeed;
                PipeTop.Left -= pipespeed;
                PipeBottom2.Left -= pipespeed;
                PipeTop2.Left -= pipespeed;
                scoreBox.Text = "Score: " + score;

                Random r = new Random();
                int j = r.Next(-270, 270);

                if (PipeBottom.Left < -130)
                {
                    PipeBottom.Left = 1930;
                    PipeBottom.Top = 590 - j;
                    PipeBottom.Height = 275 + j;
                }

                if (PipeTop.Left < -130)
                {
                    PipeTop.Left = 1930;
                    PipeTop.Height = 275 - j;
                    score++;
                }

                if (PipeBottom2.Left < -130)
                {
                    PipeBottom2.Left = 1930;
                    PipeBottom2.Top = 590 - j;
                    PipeBottom2.Height = 275 + j;
                }

                if (PipeTop2.Left < -130)
                {
                    PipeTop2.Left = 1930;
                    PipeTop2.Height = 275 - j;
                    score++;
                }

                if (Bird.Bounds.IntersectsWith(PipeBottom.Bounds) ||
                    Bird.Bounds.IntersectsWith(PipeTop.Bounds) ||
                    Bird.Bounds.IntersectsWith(Ground.Bounds) || Bird.Top < -25 ||
                    Bird.Bounds.IntersectsWith(PipeBottom2.Bounds) ||
                    Bird.Bounds.IntersectsWith(PipeTop2.Bounds)
                    )
                {
                    player.URL = "crash.mp3";
                    endGame();
                }
            
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Space) || (e.KeyCode == Keys.Up))
            {
                gravity = -15;
            }

        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Space) || (e.KeyCode == Keys.Up))
            {
                gravity = 15;
            }
        }

        private void endGame()
        {

            GameTimer.Stop();
            gameovertimer.Start();

        }



        private void Form3_PressKey(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                GameTimer.Stop();
                DialogResult result1 = MessageBox.Show("Are you sure want to quit?", "ALERT", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    GameTimer.Start();
                }
            }
            if (e.KeyChar == (char)Keys.Tab)
            {
                pause_Click(null, null);
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                play_Click(null, null);
            }
        }

        private void pause_Click(object sender, EventArgs e)
        {
            GameTimer.Stop();
            play.Image = Image.FromFile(@"C:\Users\Moiz\Pictures\Project Resources/Play.png");
            pause.Visible = false;
        }

        private void play_Click(object sender, EventArgs e)
        {
            playtimer.Start();
        }

        private void playtimer_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                countdown.Text = Convert.ToString(timeleft);
                timeleft = timeleft - 1;
            }
            else
            {
                GameTimer.Start();
                timeleft = 3;
                countdown.Text = "";
                pause.Visible = true;
            }
        }

        private void gameovertimer_Tick(object sender, EventArgs e)
        {
            if (timeleft2 > 0)
            {
                timeleft2 = timeleft2 - 1;
            }
            else
            {
                endgamescreen();
            }
        }

        private void endgamescreen()
        {
            gameovertimer.Stop();
            endgamepic.Image = Image.FromFile(@"C:\Users\Moiz\Pictures\Project Resources/Bluebg.jpg");
            endgamepic.BringToFront();
            DialogResult result = MessageBox.Show("Do you want to play again?", "ALERT", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
