
namespace ElectoralManagementSystemGUI
{
    partial class adminMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminMenuForm));
            this.homeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutECPMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.honourableECEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citizenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.votersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationspMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newsLetterPublicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewElectionResultMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tmrChangeImage = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.slierPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slierPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // homeMenuItem
            // 
            this.homeMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.homeMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.homeMenuItem.Name = "homeMenuItem";
            this.homeMenuItem.Size = new System.Drawing.Size(112, 63);
            this.homeMenuItem.Text = "      Home";
            // 
            // aboutECPMenuItem
            // 
            this.aboutECPMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.aboutECPMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.honourableECEToolStripMenuItem});
            this.aboutECPMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aboutECPMenuItem.Name = "aboutECPMenuItem";
            this.aboutECPMenuItem.Size = new System.Drawing.Size(266, 63);
            this.aboutECPMenuItem.Text = "|           About ECP            ";
            // 
            // honourableECEToolStripMenuItem
            // 
            this.honourableECEToolStripMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.honourableECEToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.honourableECEToolStripMenuItem.Name = "honourableECEToolStripMenuItem";
            this.honourableECEToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.honourableECEToolStripMenuItem.Text = "Honourable CEC";
            this.honourableECEToolStripMenuItem.Click += new System.EventHandler(this.honourableECEToolStripMenuItem_Click);
            // 
            // manageMenuItem
            // 
            this.manageMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.manageMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citizenMenuItem,
            this.candidateMenuItem,
            this.votersMenuItem});
            this.manageMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.manageMenuItem.Name = "manageMenuItem";
            this.manageMenuItem.Size = new System.Drawing.Size(199, 63);
            this.manageMenuItem.Text = "|            Manage     ";
            // 
            // citizenMenuItem
            // 
            this.citizenMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.citizenMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.citizenMenuItem.Name = "citizenMenuItem";
            this.citizenMenuItem.Size = new System.Drawing.Size(224, 26);
            this.citizenMenuItem.Text = "Citizen";
            this.citizenMenuItem.Click += new System.EventHandler(this.citizenMenuItem_Click);
            // 
            // candidateMenuItem
            // 
            this.candidateMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.candidateMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.candidateMenuItem.Name = "candidateMenuItem";
            this.candidateMenuItem.Size = new System.Drawing.Size(224, 26);
            this.candidateMenuItem.Text = "Candidate";
            this.candidateMenuItem.Click += new System.EventHandler(this.candidateMenuItem_Click);
            // 
            // votersMenuItem
            // 
            this.votersMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.votersMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.votersMenuItem.Name = "votersMenuItem";
            this.votersMenuItem.Size = new System.Drawing.Size(224, 26);
            this.votersMenuItem.Text = "Party";
            this.votersMenuItem.Click += new System.EventHandler(this.votersMenuItem_Click);
            // 
            // notificationspMenuItem
            // 
            this.notificationspMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.notificationspMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newsLetterPublicationsToolStripMenuItem,
            this.notificationsToolStripMenuItem});
            this.notificationspMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.notificationspMenuItem.Name = "notificationspMenuItem";
            this.notificationspMenuItem.Size = new System.Drawing.Size(232, 63);
            this.notificationspMenuItem.Text = "|        Media ECP         ";
            // 
            // newsLetterPublicationsToolStripMenuItem
            // 
            this.newsLetterPublicationsToolStripMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.newsLetterPublicationsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newsLetterPublicationsToolStripMenuItem.Name = "newsLetterPublicationsToolStripMenuItem";
            this.newsLetterPublicationsToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.newsLetterPublicationsToolStripMenuItem.Text = "News/Letter Publications";
            this.newsLetterPublicationsToolStripMenuItem.Click += new System.EventHandler(this.newsLetterPublicationsToolStripMenuItem_Click);
            // 
            // notificationsToolStripMenuItem
            // 
            this.notificationsToolStripMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.notificationsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.notificationsToolStripMenuItem.Name = "notificationsToolStripMenuItem";
            this.notificationsToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.notificationsToolStripMenuItem.Text = "Notifications";
            this.notificationsToolStripMenuItem.Click += new System.EventHandler(this.notificationsToolStripMenuItem_Click);
            // 
            // viewElectionResultMenuItem
            // 
            this.viewElectionResultMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.viewElectionResultMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewElectionResultMenuItem.Name = "viewElectionResultMenuItem";
            this.viewElectionResultMenuItem.Size = new System.Drawing.Size(344, 63);
            this.viewElectionResultMenuItem.Text = "|              View Election Result       ";
            this.viewElectionResultMenuItem.Click += new System.EventHandler(this.viewElectionResultMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowItemReorder = true;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GrayText;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeMenuItem,
            this.aboutECPMenuItem,
            this.manageMenuItem,
            this.notificationspMenuItem,
            this.viewElectionResultMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(240, 285);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1637, 67);
            this.menuStrip1.TabIndex = 8;
            // 
            // tmrChangeImage
            // 
            this.tmrChangeImage.Enabled = true;
            this.tmrChangeImage.Interval = 2000;
            this.tmrChangeImage.Tick += new System.EventHandler(this.tmrChangeImage_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.png");
            this.imageList1.Images.SetKeyName(1, "2.png");
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::ElectoralGUI.Properties.Resources.qqq;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(1502, 762);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(421, 226);
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::ElectoralGUI.Properties.Resources.nn;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(22, 762);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(442, 226);
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::ElectoralGUI.Properties.Resources.sd;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(1502, 413);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(421, 268);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::ElectoralGUI.Properties.Resources.ss;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(33, 413);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(421, 246);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // slierPictureBox
            // 
            this.slierPictureBox.Image = global::ElectoralGUI.Properties.Resources.electionone1;
            this.slierPictureBox.Location = new System.Drawing.Point(481, 453);
            this.slierPictureBox.MaximumSize = new System.Drawing.Size(999, 457);
            this.slierPictureBox.MinimumSize = new System.Drawing.Size(999, 457);
            this.slierPictureBox.Name = "slierPictureBox";
            this.slierPictureBox.Size = new System.Drawing.Size(999, 457);
            this.slierPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slierPictureBox.TabIndex = 10;
            this.slierPictureBox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gold;
            this.pictureBox2.Location = new System.Drawing.Point(240, 342);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1637, 10);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ElectoralGUI.Properties.Resources.com;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-247, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2420, 309);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // adminMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.slierPictureBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "adminMenuForm";
            this.Text = "Admin Menu ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slierPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem homeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutECPMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citizenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candidateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem votersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificationspMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewElectionResultMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem newsLetterPublicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem honourableECEToolStripMenuItem;
        private System.Windows.Forms.Timer tmrChangeImage;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox slierPictureBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}