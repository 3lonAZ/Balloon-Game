using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balloon_Game
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }
       
        private void Start_BTN_Click(object sender, EventArgs e)
        {
            Balloon.challengeCheckbox = challengeCheckBox.Checked;
            GameForm gameForm = new GameForm();
            this.Hide();
            gameForm.Show();
        }

        private void Start_BTN_MouseHover(object sender, EventArgs e)
        {
            Start_BTN.Font = new Font("Trebuchet MS", 20, FontStyle.Underline);
        }

        private void Start_BTN_MouseLeave(object sender, EventArgs e)
        {
            Start_BTN.Font = new Font("Trebuchet MS", 20, FontStyle.Regular);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void challengeCheckBox_MouseHover(object sender, EventArgs e)
        {
            challengeCheckBox.ForeColor = Color.FromArgb(230,232,232);
        }

        private void challengeCheckBox_MouseLeave(object sender, EventArgs e)
        {
            challengeCheckBox.ForeColor = Color.White;
        }
    }
}
