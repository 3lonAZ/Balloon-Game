namespace Balloon_Game
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_div = new System.Windows.Forms.Panel();
            this.Start_BTN = new System.Windows.Forms.Button();
            this.Start_BTN_Backgroun = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.challengeCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.button_div.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Start_BTN_Backgroun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(576, 342);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button_div
            // 
            this.button_div.Controls.Add(this.Start_BTN);
            this.button_div.Controls.Add(this.Start_BTN_Backgroun);
            this.button_div.Location = new System.Drawing.Point(136, 174);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(329, 159);
            this.button_div.TabIndex = 4;
            // 
            // Start_BTN
            // 
            this.Start_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(83)))));
            this.Start_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start_BTN.FlatAppearance.BorderSize = 0;
            this.Start_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(83)))));
            this.Start_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(83)))));
            this.Start_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_BTN.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Start_BTN.ForeColor = System.Drawing.Color.White;
            this.Start_BTN.Location = new System.Drawing.Point(81, 54);
            this.Start_BTN.Name = "Start_BTN";
            this.Start_BTN.Size = new System.Drawing.Size(168, 47);
            this.Start_BTN.TabIndex = 7;
            this.Start_BTN.Text = "Start";
            this.Start_BTN.UseVisualStyleBackColor = false;
            this.Start_BTN.Click += new System.EventHandler(this.Start_BTN_Click);
            this.Start_BTN.MouseLeave += new System.EventHandler(this.Start_BTN_MouseLeave);
            this.Start_BTN.MouseHover += new System.EventHandler(this.Start_BTN_MouseHover);
            // 
            // Start_BTN_Backgroun
            // 
            this.Start_BTN_Backgroun.Image = ((System.Drawing.Image)(resources.GetObject("Start_BTN_Backgroun.Image")));
            this.Start_BTN_Backgroun.Location = new System.Drawing.Point(18, 8);
            this.Start_BTN_Backgroun.Name = "Start_BTN_Backgroun";
            this.Start_BTN_Backgroun.Size = new System.Drawing.Size(292, 144);
            this.Start_BTN_Backgroun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Start_BTN_Backgroun.TabIndex = 6;
            this.Start_BTN_Backgroun.TabStop = false;
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(547, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(29, 28);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 5;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // challengeCheckBox
            // 
            this.challengeCheckBox.AutoSize = true;
            this.challengeCheckBox.Checked = true;
            this.challengeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.challengeCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.challengeCheckBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.challengeCheckBox.ForeColor = System.Drawing.Color.White;
            this.challengeCheckBox.Location = new System.Drawing.Point(246, 149);
            this.challengeCheckBox.Name = "challengeCheckBox";
            this.challengeCheckBox.Size = new System.Drawing.Size(113, 27);
            this.challengeCheckBox.TabIndex = 6;
            this.challengeCheckBox.Text = "Challenge";
            this.challengeCheckBox.UseVisualStyleBackColor = true;
            this.challengeCheckBox.MouseLeave += new System.EventHandler(this.challengeCheckBox_MouseLeave);
            this.challengeCheckBox.MouseHover += new System.EventHandler(this.challengeCheckBox_MouseHover);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(576, 342);
            this.Controls.Add(this.challengeCheckBox);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.button_div);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.button_div.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Start_BTN_Backgroun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel button_div;
        private System.Windows.Forms.PictureBox Start_BTN_Backgroun;
        private System.Windows.Forms.Button Start_BTN;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.CheckBox challengeCheckBox;
    }
}

