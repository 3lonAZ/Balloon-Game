namespace Balloon_Game
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.fill_panel = new System.Windows.Forms.Panel();
            this.top_panel = new System.Windows.Forms.Panel();
            this.windows_Mode = new System.Windows.Forms.PictureBox();
            this.FullScreen = new System.Windows.Forms.PictureBox();
            this.Voice = new System.Windows.Forms.PictureBox();
            this.Restart = new System.Windows.Forms.PictureBox();
            this.flying_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.score_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.CreaterTimer = new System.Windows.Forms.Timer(this.components);
            this.FlyerTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windows_Mode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Voice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // fill_panel
            // 
            this.fill_panel.BackColor = System.Drawing.Color.Gainsboro;
            this.fill_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fill_panel.Location = new System.Drawing.Point(0, 49);
            this.fill_panel.Name = "fill_panel";
            this.fill_panel.Size = new System.Drawing.Size(824, 526);
            this.fill_panel.TabIndex = 2;
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.top_panel.Controls.Add(this.windows_Mode);
            this.top_panel.Controls.Add(this.FullScreen);
            this.top_panel.Controls.Add(this.Voice);
            this.top_panel.Controls.Add(this.Restart);
            this.top_panel.Controls.Add(this.flying_label);
            this.top_panel.Controls.Add(this.label3);
            this.top_panel.Controls.Add(this.score_label);
            this.top_panel.Controls.Add(this.label1);
            this.top_panel.Controls.Add(this.minimize);
            this.top_panel.Controls.Add(this.exit);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(824, 49);
            this.top_panel.TabIndex = 0;
            this.top_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseDown);
            this.top_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseMove);
            this.top_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseUp);
            // 
            // windows_Mode
            // 
            this.windows_Mode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windows_Mode.Dock = System.Windows.Forms.DockStyle.Right;
            this.windows_Mode.Image = ((System.Drawing.Image)(resources.GetObject("windows_Mode.Image")));
            this.windows_Mode.Location = new System.Drawing.Point(456, 0);
            this.windows_Mode.Name = "windows_Mode";
            this.windows_Mode.Size = new System.Drawing.Size(61, 49);
            this.windows_Mode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.windows_Mode.TabIndex = 16;
            this.windows_Mode.TabStop = false;
            this.toolTip1.SetToolTip(this.windows_Mode, "Windows Mode");
            this.windows_Mode.Click += new System.EventHandler(this.windows_Mode_Click);
            // 
            // FullScreen
            // 
            this.FullScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FullScreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.FullScreen.Image = ((System.Drawing.Image)(resources.GetObject("FullScreen.Image")));
            this.FullScreen.Location = new System.Drawing.Point(517, 0);
            this.FullScreen.Name = "FullScreen";
            this.FullScreen.Size = new System.Drawing.Size(61, 49);
            this.FullScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FullScreen.TabIndex = 15;
            this.FullScreen.TabStop = false;
            this.toolTip1.SetToolTip(this.FullScreen, "Full Screen");
            this.FullScreen.Click += new System.EventHandler(this.fullscreen_Click);
            // 
            // Voice
            // 
            this.Voice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Voice.Dock = System.Windows.Forms.DockStyle.Right;
            this.Voice.Image = ((System.Drawing.Image)(resources.GetObject("Voice.Image")));
            this.Voice.Location = new System.Drawing.Point(578, 0);
            this.Voice.Name = "Voice";
            this.Voice.Size = new System.Drawing.Size(61, 49);
            this.Voice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Voice.TabIndex = 13;
            this.Voice.TabStop = false;
            this.toolTip1.SetToolTip(this.Voice, "Mute");
            this.Voice.Click += new System.EventHandler(this.Voice_Click);
            // 
            // Restart
            // 
            this.Restart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Restart.Dock = System.Windows.Forms.DockStyle.Right;
            this.Restart.Image = ((System.Drawing.Image)(resources.GetObject("Restart.Image")));
            this.Restart.Location = new System.Drawing.Point(639, 0);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(61, 49);
            this.Restart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Restart.TabIndex = 11;
            this.Restart.TabStop = false;
            this.toolTip1.SetToolTip(this.Restart, "Reset");
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // flying_label
            // 
            this.flying_label.AutoSize = true;
            this.flying_label.Dock = System.Windows.Forms.DockStyle.Left;
            this.flying_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flying_label.ForeColor = System.Drawing.Color.Red;
            this.flying_label.Location = new System.Drawing.Point(241, 0);
            this.flying_label.Name = "flying_label";
            this.flying_label.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flying_label.Size = new System.Drawing.Size(29, 41);
            this.flying_label.TabIndex = 10;
            this.flying_label.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(139, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label3.Size = new System.Drawing.Size(102, 41);
            this.label3.TabIndex = 9;
            this.label3.Text = "Flying: ";
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.Dock = System.Windows.Forms.DockStyle.Left;
            this.score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.score_label.ForeColor = System.Drawing.Color.Aqua;
            this.score_label.Location = new System.Drawing.Point(100, 0);
            this.score_label.Name = "score_label";
            this.score_label.Padding = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.score_label.Size = new System.Drawing.Size(39, 41);
            this.score_label.TabIndex = 8;
            this.score_label.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(100, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score: ";
            // 
            // minimize
            // 
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.Location = new System.Drawing.Point(700, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(61, 49);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 7;
            this.minimize.TabStop = false;
            this.toolTip1.SetToolTip(this.minimize, "Minimize");
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(761, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(63, 49);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 6;
            this.exit.TabStop = false;
            this.toolTip1.SetToolTip(this.exit, "Exit");
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // CreaterTimer
            // 
            this.CreaterTimer.Enabled = true;
            this.CreaterTimer.Interval = 2000;
            this.CreaterTimer.Tick += new System.EventHandler(this.CreaterTimer_Tick);
            // 
            // FlyerTimer
            // 
            this.FlyerTimer.Enabled = true;
            this.FlyerTimer.Interval = 20;
            this.FlyerTimer.Tick += new System.EventHandler(this.FlyerTimer_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 575);
            this.Controls.Add(this.fill_panel);
            this.Controls.Add(this.top_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameForm";
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windows_Mode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Voice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel fill_panel;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer CreaterTimer;
        private System.Windows.Forms.Timer FlyerTimer;
        private System.Windows.Forms.Label flying_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox Voice;
        private System.Windows.Forms.PictureBox windows_Mode;
        private System.Windows.Forms.PictureBox FullScreen;
        private System.Windows.Forms.PictureBox Restart;
    }
}