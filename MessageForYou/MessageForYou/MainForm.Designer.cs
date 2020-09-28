namespace MessageForYou
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.DataBaseEdit = new MetroFramework.Controls.MetroLink();
            this.MultiMessage = new MetroFramework.Controls.MetroLink();
            this.SingleMessage = new MetroFramework.Controls.MetroLink();
            this.ChangeUser = new MetroFramework.Controls.MetroLink();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.InfoButton = new MetroFramework.Controls.MetroLink();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.UserNameLabel = new MetroFramework.Controls.MetroLabel();
            this.ExitBox = new System.Windows.Forms.PictureBox();
            this.MinimizedBox = new System.Windows.Forms.PictureBox();
            this.MailLabel = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizedBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 281);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.DataBaseEdit_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.DataBaseEdit_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.DataBaseEdit_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseEnter += new System.EventHandler(this.SingleMessage_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.SingleMessage_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(23, 201);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseEnter += new System.EventHandler(this.MultiMessage_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.MultiMessage_MouseLeave);
            // 
            // DataBaseEdit
            // 
            this.DataBaseEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataBaseEdit.CustomForeColor = true;
            this.DataBaseEdit.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.DataBaseEdit.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.DataBaseEdit.Location = new System.Drawing.Point(69, 281);
            this.DataBaseEdit.Name = "DataBaseEdit";
            this.DataBaseEdit.Size = new System.Drawing.Size(358, 34);
            this.DataBaseEdit.Style = MetroFramework.MetroColorStyle.Blue;
            this.DataBaseEdit.TabIndex = 13;
            this.DataBaseEdit.Text = "Редактирование базы данных";
            this.DataBaseEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DataBaseEdit.UseStyleColors = true;
            this.DataBaseEdit.Click += new System.EventHandler(this.DataBaseEdit_Click);
            this.DataBaseEdit.MouseEnter += new System.EventHandler(this.DataBaseEdit_MouseEnter);
            this.DataBaseEdit.MouseLeave += new System.EventHandler(this.DataBaseEdit_MouseLeave);
            // 
            // MultiMessage
            // 
            this.MultiMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MultiMessage.CustomForeColor = true;
            this.MultiMessage.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.MultiMessage.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.MultiMessage.Location = new System.Drawing.Point(69, 201);
            this.MultiMessage.Name = "MultiMessage";
            this.MultiMessage.Size = new System.Drawing.Size(358, 34);
            this.MultiMessage.Style = MetroFramework.MetroColorStyle.Blue;
            this.MultiMessage.TabIndex = 14;
            this.MultiMessage.Text = "Массовая рассылка уведомлений";
            this.MultiMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MultiMessage.UseStyleColors = true;
            this.MultiMessage.Click += new System.EventHandler(this.MultiMessage_Click);
            this.MultiMessage.MouseEnter += new System.EventHandler(this.MultiMessage_MouseEnter);
            this.MultiMessage.MouseLeave += new System.EventHandler(this.MultiMessage_MouseLeave);
            // 
            // SingleMessage
            // 
            this.SingleMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SingleMessage.CustomForeColor = true;
            this.SingleMessage.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.SingleMessage.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.SingleMessage.Location = new System.Drawing.Point(69, 123);
            this.SingleMessage.Name = "SingleMessage";
            this.SingleMessage.Size = new System.Drawing.Size(358, 34);
            this.SingleMessage.Style = MetroFramework.MetroColorStyle.Blue;
            this.SingleMessage.TabIndex = 15;
            this.SingleMessage.Text = "Одноадресная рассылка уведомлений";
            this.SingleMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SingleMessage.UseStyleColors = true;
            this.SingleMessage.Click += new System.EventHandler(this.SingleMessage_Click);
            this.SingleMessage.MouseEnter += new System.EventHandler(this.SingleMessage_MouseEnter);
            this.SingleMessage.MouseLeave += new System.EventHandler(this.SingleMessage_MouseLeave);
            // 
            // ChangeUser
            // 
            this.ChangeUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeUser.CustomForeColor = true;
            this.ChangeUser.ForeColor = System.Drawing.Color.Red;
            this.ChangeUser.Location = new System.Drawing.Point(54, 383);
            this.ChangeUser.Name = "ChangeUser";
            this.ChangeUser.Size = new System.Drawing.Size(100, 34);
            this.ChangeUser.Style = MetroFramework.MetroColorStyle.Blue;
            this.ChangeUser.TabIndex = 16;
            this.ChangeUser.Text = "Сменить\r\nпользователя";
            this.ChangeUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeUser.UseStyleColors = true;
            this.ChangeUser.Click += new System.EventHandler(this.ChangeUser_Click);
            this.ChangeUser.MouseEnter += new System.EventHandler(this.ChangeUser_MouseEnter);
            this.ChangeUser.MouseLeave += new System.EventHandler(this.ChangeUser_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(364, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.InfoButton_Click);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.InfoButton_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.InfoButton_MouseLeave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(14, 383);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(34, 34);
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.MouseEnter += new System.EventHandler(this.ChangeUser_MouseEnter);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.ChangeUser_MouseLeave);
            // 
            // InfoButton
            // 
            this.InfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoButton.CustomForeColor = true;
            this.InfoButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.InfoButton.Location = new System.Drawing.Point(272, 11);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(86, 22);
            this.InfoButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.InfoButton.TabIndex = 19;
            this.InfoButton.Text = "О программе";
            this.InfoButton.UseStyleColors = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            this.InfoButton.MouseEnter += new System.EventHandler(this.InfoButton_MouseEnter);
            this.InfoButton.MouseLeave += new System.EventHandler(this.InfoButton_MouseLeave);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(23, 26);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(64, 64);
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.CustomForeColor = true;
            this.UserNameLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.UserNameLabel.Location = new System.Drawing.Point(93, 47);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(46, 19);
            this.UserNameLabel.TabIndex = 21;
            this.UserNameLabel.Text = "admin";
            // 
            // ExitBox
            // 
            this.ExitBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBox.Image = ((System.Drawing.Image)(resources.GetObject("ExitBox.Image")));
            this.ExitBox.Location = new System.Drawing.Point(421, 9);
            this.ExitBox.Name = "ExitBox";
            this.ExitBox.Size = new System.Drawing.Size(24, 24);
            this.ExitBox.TabIndex = 22;
            this.ExitBox.TabStop = false;
            this.ExitBox.Click += new System.EventHandler(this.ExitBox_Click);
            // 
            // MinimizedBox
            // 
            this.MinimizedBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizedBox.Image = ((System.Drawing.Image)(resources.GetObject("MinimizedBox.Image")));
            this.MinimizedBox.Location = new System.Drawing.Point(394, 9);
            this.MinimizedBox.Name = "MinimizedBox";
            this.MinimizedBox.Size = new System.Drawing.Size(24, 24);
            this.MinimizedBox.TabIndex = 23;
            this.MinimizedBox.TabStop = false;
            this.MinimizedBox.Click += new System.EventHandler(this.MinimizedBox_Click);
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.CustomForeColor = true;
            this.MailLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.MailLabel.Location = new System.Drawing.Point(93, 71);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(111, 19);
            this.MailLabel.TabIndex = 24;
            this.MailLabel.Text = "admin@admin.ru";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(450, 427);
            this.ControlBox = false;
            this.Controls.Add(this.MailLabel);
            this.Controls.Add(this.MinimizedBox);
            this.Controls.Add(this.ExitBox);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.ChangeUser);
            this.Controls.Add(this.SingleMessage);
            this.Controls.Add(this.MultiMessage);
            this.Controls.Add(this.DataBaseEdit);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizedBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroLink DataBaseEdit;
        private MetroFramework.Controls.MetroLink MultiMessage;
        private MetroFramework.Controls.MetroLink SingleMessage;
        private MetroFramework.Controls.MetroLink ChangeUser;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private MetroFramework.Controls.MetroLink InfoButton;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox ExitBox;
        private System.Windows.Forms.PictureBox MinimizedBox;
        public MetroFramework.Controls.MetroLabel UserNameLabel;
        public MetroFramework.Controls.MetroLabel MailLabel;
    }
}