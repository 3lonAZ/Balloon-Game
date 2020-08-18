using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balloon_Game
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            fill_panel.Cursor = myBalloon.CreateCursor((Bitmap)Image.FromFile(Application.StartupPath+ "\\images\\cursor\\default.ico"), new Size(48, 48));
        }

        private Balloon myBalloon = new Balloon();
        int score = 0;
        int flying = 0;
        int speed = 10;
        bool mode = false;
        bool mute = false;
        bool move;
        bool screenMode = false;

        int mouse_X;
        int mouse_Y;

        private void Createballoon()
        {
            var balloon = myBalloon.balloonPictureBox(fill_panel.Width, fill_panel.Height);
            balloon.Click += balloon_Click;
            fill_panel.Controls.Add(balloon);
        }

        private void balloon_Click(object sender, EventArgs e)
        {
            AddScore();
            IncreaseScore();
            if(!mute)
            {
                myBalloon.Boom();
            }
            Thread th = new Thread(new ParameterizedThreadStart(myBalloon.BoomAnimation));
            th.Start(sender);
        }
        private void AddScore()
        {
            score++;
            score_label.Text = score.ToString();
        }
        private void IncreaseScore()
        {
            if (score % 10 == 0)
            {
                speed += 5;
            }
        }
        private void Flyballoon()
        {
            foreach (PictureBox balloons in fill_panel.Controls)
            {
                if (balloons.Top < -100)
                {
                    if (!balloons.Name.Contains("+boombed"))
                    {
                        flying++;
                        flying_label.Text = flying.ToString();
                        if (Balloon.challengeCheckbox && flying >= 3)
                        {
                            StopAllTimer();
                            MessageBox.Show("Game Over ! Score: " + score, "balloon Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Restart();
                        }
                    }

                    fill_panel.Controls.Remove(balloons);
                }
                else
                {
                    balloons.Top -= speed;
                }
            }
        }

        private void CreaterTimer_Tick(object sender, EventArgs e)
        {
            Createballoon();
            CreaterTimer.Stop();
        }

        private void FlyerTimer_Tick(object sender, EventArgs e)
        {
            Flyballoon();
            CreaterTimer.Start();
        }
        private void StopAllTimer()
        {
            CreaterTimer.Stop();
            FlyerTimer.Stop();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            score = 0;
            flying = 0;
            score_label.Text = "0";
            flying_label.Text = "0";
            
            fill_panel.Controls.Clear();
        }

        private void windows_Mode_Click(object sender, EventArgs e)
        {
            if (!mode)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                FullScreen.Visible = false;
                minimize.Visible = false;
                exit.Visible = false;
                toolTip1.SetToolTip(windows_Mode, "Normal Mode");
                mode = true;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.None;
                FullScreen.Visible = true;
                minimize.Visible = true;
                exit.Visible = true;
                toolTip1.SetToolTip(windows_Mode, "Windows Mode");
                mode = false;
            }
        }

       

        private void top_panel_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
            top_panel.Cursor = Cursors.Default;
        }

        private void top_panel_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_X = e.X;
            mouse_Y = e.Y;
            top_panel.Cursor = Cursors.SizeAll;
        }

        private void top_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_X, MousePosition.Y - mouse_Y);
            }
        }

        private void Voice_Click(object sender, EventArgs e)
        {
            if (!mute)
            {
                toolTip1.SetToolTip(Voice, "Voice");
                Voice.ImageLocation = Application.StartupPath+"\\sound\\sound mute.png";
                mute = true;
            }
            else
            {
                toolTip1.SetToolTip(Voice, "Mute");
                Voice.ImageLocation = Application.StartupPath + "\\sound\\sound voiced.png";
                mute = false;
            }
        }

        private void fullscreen_Click(object sender, EventArgs e)
        {
            if(!screenMode)
            {
                WindowState = FormWindowState.Maximized;
                FullScreen.ImageLocation = Application.StartupPath + "\\images\\fullscreen\\fullscreen.png";
                toolTip1.SetToolTip(FullScreen, "Default Screen");
                screenMode = true;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                FullScreen.ImageLocation = Application.StartupPath + "\\images\\fullscreen\\default screen.png";
                toolTip1.SetToolTip(FullScreen, "Full Screen");

                screenMode = false;
            }
        }
    }
}