
namespace TwitterBotGUI
{
    partial class TwitterBotUI
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
            this.tabControlHome = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewConsole = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnStopAutoTweet = new System.Windows.Forms.Button();
            this.btnStartAutoTweet = new System.Windows.Forms.Button();
            this.numericSeconds = new System.Windows.Forms.NumericUpDown();
            this.numericMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericHours = new System.Windows.Forms.NumericUpDown();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.listViewAutoTweets = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddTweet = new System.Windows.Forms.Button();
            this.lblTweet = new System.Windows.Forms.Label();
            this.txtTweet = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlHome.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHours)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlHome
            // 
            this.tabControlHome.Controls.Add(this.tabPage1);
            this.tabControlHome.Controls.Add(this.tabPage2);
            this.tabControlHome.Controls.Add(this.tabPage3);
            this.tabControlHome.Location = new System.Drawing.Point(0, 27);
            this.tabControlHome.Name = "tabControlHome";
            this.tabControlHome.SelectedIndex = 0;
            this.tabControlHome.Size = new System.Drawing.Size(428, 342);
            this.tabControlHome.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewConsole);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(420, 316);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewConsole
            // 
            this.listViewConsole.BackColor = System.Drawing.SystemColors.InfoText;
            this.listViewConsole.HideSelection = false;
            this.listViewConsole.Location = new System.Drawing.Point(8, 6);
            this.listViewConsole.Name = "listViewConsole";
            this.listViewConsole.Size = new System.Drawing.Size(416, 306);
            this.listViewConsole.TabIndex = 0;
            this.listViewConsole.UseCompatibleStateImageBehavior = false;
            this.listViewConsole.View = System.Windows.Forms.View.List;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnStopAutoTweet);
            this.tabPage2.Controls.Add(this.btnStartAutoTweet);
            this.tabPage2.Controls.Add(this.numericSeconds);
            this.tabPage2.Controls.Add(this.numericMinutes);
            this.tabPage2.Controls.Add(this.numericHours);
            this.tabPage2.Controls.Add(this.lblTime);
            this.tabPage2.Controls.Add(this.lblSeconds);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lblHours);
            this.tabPage2.Controls.Add(this.btnClearAll);
            this.tabPage2.Controls.Add(this.listViewAutoTweets);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnClear);
            this.tabPage2.Controls.Add(this.btnAddTweet);
            this.tabPage2.Controls.Add(this.lblTweet);
            this.tabPage2.Controls.Add(this.txtTweet);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(420, 316);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tweet";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnStopAutoTweet
            // 
            this.btnStopAutoTweet.Enabled = false;
            this.btnStopAutoTweet.Location = new System.Drawing.Point(146, 292);
            this.btnStopAutoTweet.Name = "btnStopAutoTweet";
            this.btnStopAutoTweet.Size = new System.Drawing.Size(113, 23);
            this.btnStopAutoTweet.TabIndex = 19;
            this.btnStopAutoTweet.Text = "Stop Auto-Tweet";
            this.btnStopAutoTweet.UseVisualStyleBackColor = true;
            this.btnStopAutoTweet.Click += new System.EventHandler(this.btnStopAutoTweet_Click);
            // 
            // btnStartAutoTweet
            // 
            this.btnStartAutoTweet.Location = new System.Drawing.Point(10, 292);
            this.btnStartAutoTweet.Name = "btnStartAutoTweet";
            this.btnStartAutoTweet.Size = new System.Drawing.Size(114, 23);
            this.btnStartAutoTweet.TabIndex = 18;
            this.btnStartAutoTweet.Text = "Start Auto-Tweet";
            this.btnStartAutoTweet.UseVisualStyleBackColor = true;
            this.btnStartAutoTweet.Click += new System.EventHandler(this.btnStartAutoTweet_Click);
            // 
            // numericSeconds
            // 
            this.numericSeconds.Location = new System.Drawing.Point(176, 266);
            this.numericSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericSeconds.Name = "numericSeconds";
            this.numericSeconds.Size = new System.Drawing.Size(33, 20);
            this.numericSeconds.TabIndex = 17;
            // 
            // numericMinutes
            // 
            this.numericMinutes.Location = new System.Drawing.Point(91, 266);
            this.numericMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericMinutes.Name = "numericMinutes";
            this.numericMinutes.Size = new System.Drawing.Size(33, 20);
            this.numericMinutes.TabIndex = 16;
            // 
            // numericHours
            // 
            this.numericHours.Location = new System.Drawing.Point(10, 266);
            this.numericHours.Name = "numericHours";
            this.numericHours.Size = new System.Drawing.Size(33, 20);
            this.numericHours.TabIndex = 15;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(7, 246);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(132, 13);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "Time Between Tweets";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(210, 268);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(49, 13);
            this.lblSeconds.TabIndex = 13;
            this.lblSeconds.Text = "Seconds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Minutes";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(43, 268);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(35, 13);
            this.lblHours.TabIndex = 11;
            this.lblHours.Text = "Hours";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(8, 216);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(93, 23);
            this.btnClearAll.TabIndex = 7;
            this.btnClearAll.Text = "Clear All Tweets";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // listViewAutoTweets
            // 
            this.listViewAutoTweets.HideSelection = false;
            this.listViewAutoTweets.Location = new System.Drawing.Point(8, 113);
            this.listViewAutoTweets.Name = "listViewAutoTweets";
            this.listViewAutoTweets.Size = new System.Drawing.Size(407, 97);
            this.listViewAutoTweets.TabIndex = 6;
            this.listViewAutoTweets.UseCompatibleStateImageBehavior = false;
            this.listViewAutoTweets.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Auto-Tweeted Tweets:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(89, 57);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear Text";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddTweet
            // 
            this.btnAddTweet.Location = new System.Drawing.Point(8, 57);
            this.btnAddTweet.Name = "btnAddTweet";
            this.btnAddTweet.Size = new System.Drawing.Size(75, 23);
            this.btnAddTweet.TabIndex = 2;
            this.btnAddTweet.Text = "Add Tweet";
            this.btnAddTweet.UseVisualStyleBackColor = true;
            this.btnAddTweet.Click += new System.EventHandler(this.btnAddTweet_Click);
            // 
            // lblTweet
            // 
            this.lblTweet.AutoSize = true;
            this.lblTweet.Location = new System.Drawing.Point(3, 15);
            this.lblTweet.Name = "lblTweet";
            this.lblTweet.Size = new System.Drawing.Size(40, 13);
            this.lblTweet.TabIndex = 1;
            this.lblTweet.Text = "Tweet:";
            // 
            // txtTweet
            // 
            this.txtTweet.Location = new System.Drawing.Point(8, 31);
            this.txtTweet.Name = "txtTweet";
            this.txtTweet.Size = new System.Drawing.Size(407, 20);
            this.txtTweet.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(420, 316);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reply";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(428, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeProfileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // changeProfileToolStripMenuItem
            // 
            this.changeProfileToolStripMenuItem.Name = "changeProfileToolStripMenuItem";
            this.changeProfileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.U)));
            this.changeProfileToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.changeProfileToolStripMenuItem.Text = "Change Profile";
            this.changeProfileToolStripMenuItem.Click += new System.EventHandler(this.changeProfileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // TwitterBotUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 372);
            this.Controls.Add(this.tabControlHome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TwitterBotUI";
            this.Text = "TwitterBotUI";
            this.Load += new System.EventHandler(this.TwitterBotUI_Load);
            this.tabControlHome.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHours)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlHome;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddTweet;
        private System.Windows.Forms.Label lblTweet;
        private System.Windows.Forms.TextBox txtTweet;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView listViewAutoTweets;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.NumericUpDown numericSeconds;
        private System.Windows.Forms.NumericUpDown numericMinutes;
        private System.Windows.Forms.NumericUpDown numericHours;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Button btnStopAutoTweet;
        private System.Windows.Forms.Button btnStartAutoTweet;
        private System.Windows.Forms.ListView listViewConsole;
    }
}