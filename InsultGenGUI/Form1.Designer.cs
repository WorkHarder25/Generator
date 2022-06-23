namespace InsultGenGUI
{
    partial class Form1
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
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.displayText = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartCounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GeneratedTextBox = new System.Windows.Forms.TextBox();
            this.statBox = new System.Windows.Forms.TextBox();
            this.GeneratedTextBox2 = new System.Windows.Forms.TextBox();
            this.statBox2 = new System.Windows.Forms.TextBox();
            this.changeNumberOfWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GeneratedTextBox3 = new System.Windows.Forms.TextBox();
            this.statBox3 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // yesButton
            // 
            this.yesButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.yesButton.Location = new System.Drawing.Point(164, 337);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(75, 23);
            this.yesButton.TabIndex = 0;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = false;
            this.yesButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // noButton
            // 
            this.noButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.noButton.Location = new System.Drawing.Point(333, 337);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(75, 23);
            this.noButton.TabIndex = 2;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = false;
            this.noButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.Location = new System.Drawing.Point(164, 298);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(244, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Do you need a compliment?";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // displayText
            // 
            this.displayText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayText.Location = new System.Drawing.Point(0, 151);
            this.displayText.Name = "displayText";
            this.displayText.ReadOnly = true;
            this.displayText.Size = new System.Drawing.Size(588, 13);
            this.displayText.TabIndex = 4;
            this.displayText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(0, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(588, 13);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(1, 213);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(588, 13);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.statsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(591, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.insultToolStripMenuItem,
            this.compToolStripMenuItem,
            this.changeNumberOfWordsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.CheckOnClick = true;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.ToolTipText = "Close Program";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // insultToolStripMenuItem
            // 
            this.insultToolStripMenuItem.CheckOnClick = true;
            this.insultToolStripMenuItem.Name = "insultToolStripMenuItem";
            this.insultToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.insultToolStripMenuItem.Text = "Insult Gen";
            this.insultToolStripMenuItem.Click += new System.EventHandler(this.insultToolStripMenuItem_Click);
            // 
            // compToolStripMenuItem
            // 
            this.compToolStripMenuItem.Checked = true;
            this.compToolStripMenuItem.CheckOnClick = true;
            this.compToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.compToolStripMenuItem.Name = "compToolStripMenuItem";
            this.compToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.compToolStripMenuItem.Text = "Compliment Gen";
            this.compToolStripMenuItem.Click += new System.EventHandler(this.compToolStripMenuItem_Click);
            // 
            // statsToolStripMenuItem
            // 
            this.statsToolStripMenuItem.CheckOnClick = true;
            this.statsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayStatsToolStripMenuItem,
            this.restartCounterToolStripMenuItem});
            this.statsToolStripMenuItem.Name = "statsToolStripMenuItem";
            this.statsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.statsToolStripMenuItem.Text = "Stats";
            // 
            // displayStatsToolStripMenuItem
            // 
            this.displayStatsToolStripMenuItem.CheckOnClick = true;
            this.displayStatsToolStripMenuItem.Name = "displayStatsToolStripMenuItem";
            this.displayStatsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.displayStatsToolStripMenuItem.Text = "Display Stats";
            this.displayStatsToolStripMenuItem.Click += new System.EventHandler(this.displayStatsToolStripMenuItem_Click);
            // 
            // restartCounterToolStripMenuItem
            // 
            this.restartCounterToolStripMenuItem.Name = "restartCounterToolStripMenuItem";
            this.restartCounterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restartCounterToolStripMenuItem.Text = "Restart Counter";
            this.restartCounterToolStripMenuItem.Click += new System.EventHandler(this.restartCounterToolStripMenuItem_Click);
            // 
            // GeneratedTextBox
            // 
            this.GeneratedTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GeneratedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GeneratedTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.GeneratedTextBox.Location = new System.Drawing.Point(427, 27);
            this.GeneratedTextBox.Name = "GeneratedTextBox";
            this.GeneratedTextBox.ReadOnly = true;
            this.GeneratedTextBox.Size = new System.Drawing.Size(130, 13);
            this.GeneratedTextBox.TabIndex = 8;
            this.GeneratedTextBox.Text = "Insults Generated:";
            this.GeneratedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.GeneratedTextBox.Visible = false;
            // 
            // statBox
            // 
            this.statBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statBox.Enabled = false;
            this.statBox.ForeColor = System.Drawing.SystemColors.Info;
            this.statBox.Location = new System.Drawing.Point(556, 27);
            this.statBox.Name = "statBox";
            this.statBox.ReadOnly = true;
            this.statBox.Size = new System.Drawing.Size(32, 13);
            this.statBox.TabIndex = 9;
            this.statBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.statBox.Visible = false;
            this.statBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // GeneratedTextBox2
            // 
            this.GeneratedTextBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GeneratedTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GeneratedTextBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.GeneratedTextBox2.Location = new System.Drawing.Point(427, 40);
            this.GeneratedTextBox2.Name = "GeneratedTextBox2";
            this.GeneratedTextBox2.ReadOnly = true;
            this.GeneratedTextBox2.Size = new System.Drawing.Size(130, 13);
            this.GeneratedTextBox2.TabIndex = 10;
            this.GeneratedTextBox2.Text = "Compliments Generated:";
            this.GeneratedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.GeneratedTextBox2.Visible = false;
            // 
            // statBox2
            // 
            this.statBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statBox2.Enabled = false;
            this.statBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.statBox2.Location = new System.Drawing.Point(556, 40);
            this.statBox2.Name = "statBox2";
            this.statBox2.ReadOnly = true;
            this.statBox2.Size = new System.Drawing.Size(32, 13);
            this.statBox2.TabIndex = 11;
            this.statBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.statBox2.Visible = false;
            // 
            // changeNumberOfWordsToolStripMenuItem
            // 
            this.changeNumberOfWordsToolStripMenuItem.Name = "changeNumberOfWordsToolStripMenuItem";
            this.changeNumberOfWordsToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.changeNumberOfWordsToolStripMenuItem.Text = "Change Number of Words";
            this.changeNumberOfWordsToolStripMenuItem.Click += new System.EventHandler(this.changeNumberOfWordsToolStripMenuItem_Click);
            // 
            // GeneratedTextBox3
            // 
            this.GeneratedTextBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GeneratedTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GeneratedTextBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.GeneratedTextBox3.Location = new System.Drawing.Point(427, 53);
            this.GeneratedTextBox3.Name = "GeneratedTextBox3";
            this.GeneratedTextBox3.ReadOnly = true;
            this.GeneratedTextBox3.Size = new System.Drawing.Size(130, 13);
            this.GeneratedTextBox3.TabIndex = 12;
            this.GeneratedTextBox3.Text = "Number of Words Per Gen:";
            this.GeneratedTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.GeneratedTextBox3.Visible = false;
            // 
            // statBox3
            // 
            this.statBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statBox3.Enabled = false;
            this.statBox3.ForeColor = System.Drawing.SystemColors.Info;
            this.statBox3.Location = new System.Drawing.Point(556, 53);
            this.statBox3.Name = "statBox3";
            this.statBox3.ReadOnly = true;
            this.statBox3.Size = new System.Drawing.Size(32, 13);
            this.statBox3.TabIndex = 13;
            this.statBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.statBox3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 438);
            this.Controls.Add(this.GeneratedTextBox3);
            this.Controls.Add(this.statBox3);
            this.Controls.Add(this.GeneratedTextBox2);
            this.Controls.Add(this.statBox2);
            this.Controls.Add(this.GeneratedTextBox);
            this.Controls.Add(this.statBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.displayText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Generator 3000";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox displayText;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayStatsToolStripMenuItem;
        private System.Windows.Forms.TextBox GeneratedTextBox;
        private System.Windows.Forms.TextBox statBox;
        private System.Windows.Forms.ToolStripMenuItem restartCounterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compToolStripMenuItem;
        private System.Windows.Forms.TextBox GeneratedTextBox2;
        private System.Windows.Forms.TextBox statBox2;
        private System.Windows.Forms.ToolStripMenuItem changeNumberOfWordsToolStripMenuItem;
        private System.Windows.Forms.TextBox GeneratedTextBox3;
        private System.Windows.Forms.TextBox statBox3;
    }
}

