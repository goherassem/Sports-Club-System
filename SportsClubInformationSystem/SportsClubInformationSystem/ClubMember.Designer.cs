namespace SportsClubInformationSystem
{
    partial class ClubMember
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
            this.sportlist = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.avalSession = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sportlist
            // 
            this.sportlist.FormattingEnabled = true;
            this.sportlist.Location = new System.Drawing.Point(129, 43);
            this.sportlist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sportlist.Name = "sportlist";
            this.sportlist.Size = new System.Drawing.Size(121, 24);
            this.sportlist.TabIndex = 0;
            this.sportlist.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sport";
            // 
            // avalSession
            // 
            this.avalSession.FormattingEnabled = true;
            this.avalSession.Location = new System.Drawing.Point(129, 111);
            this.avalSession.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avalSession.Name = "avalSession";
            this.avalSession.Size = new System.Drawing.Size(121, 24);
            this.avalSession.TabIndex = 2;
            this.avalSession.SelectedIndexChanged += new System.EventHandler(this.avalSession_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Available Session";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 225);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Insert Session";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(409, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ClubMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 298);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.avalSession);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sportlist);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClubMember";
            this.Text = "ClubMember";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClubMember_FormClosing);
            this.Load += new System.EventHandler(this.ClubMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sportlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox avalSession;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}