namespace TermProjectWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.buttonReservation = new System.Windows.Forms.Button();
            this.buttonRoom = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.userControlClient1 = new TermProjectWindow.UserControlClient.UserControlClient();
            this.userControlReservation1 = new TermProjectWindow.UserControlReservation();
            this.userControlRoom1 = new TermProjectWindow.UserControlRoom.UserControlRoom();
            this.userControlReservation2 = new TermProjectWindow.UserControlReservation();
            this.userControl1 = new TermProjectWindow.UserSetting.userControl();
            this.userControlClient2 = new TermProjectWindow.UserControlClient.UserControlClient();
            this.userControlRoom2 = new TermProjectWindow.UserControlRoom.UserControlRoom();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.buttonSetting);
            this.panel1.Controls.Add(this.buttonReservation);
            this.panel1.Controls.Add(this.buttonRoom);
            this.panel1.Controls.Add(this.buttonClient);
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 836);
            this.panel1.TabIndex = 0;
            // 
            // buttonSetting
            // 
            this.buttonSetting.FlatAppearance.BorderSize = 0;
            this.buttonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetting.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetting.Image = global::TermProjectWindow.Properties.Resources._1904675_configuration_edit_gear_options_preferences_setting_settings_122525;
            this.buttonSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSetting.Location = new System.Drawing.Point(0, 506);
            this.buttonSetting.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(311, 63);
            this.buttonSetting.TabIndex = 13;
            this.buttonSetting.Text = "Setting";
            this.buttonSetting.UseVisualStyleBackColor = true;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // buttonReservation
            // 
            this.buttonReservation.FlatAppearance.BorderSize = 0;
            this.buttonReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReservation.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReservation.Image = global::TermProjectWindow.Properties.Resources.flexiblechagedatecalendarbooking_109688;
            this.buttonReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReservation.Location = new System.Drawing.Point(0, 435);
            this.buttonReservation.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReservation.Name = "buttonReservation";
            this.buttonReservation.Size = new System.Drawing.Size(311, 63);
            this.buttonReservation.TabIndex = 12;
            this.buttonReservation.Text = "Reservation";
            this.buttonReservation.UseVisualStyleBackColor = true;
            this.buttonReservation.Click += new System.EventHandler(this.buttonReservation_Click);
            // 
            // buttonRoom
            // 
            this.buttonRoom.FlatAppearance.BorderSize = 0;
            this.buttonRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoom.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoom.Image = global::TermProjectWindow.Properties.Resources.bed_bed_room_sleep_furniture_icon_124423;
            this.buttonRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRoom.Location = new System.Drawing.Point(0, 364);
            this.buttonRoom.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRoom.Name = "buttonRoom";
            this.buttonRoom.Size = new System.Drawing.Size(311, 63);
            this.buttonRoom.TabIndex = 11;
            this.buttonRoom.Text = "Room";
            this.buttonRoom.UseVisualStyleBackColor = true;
            this.buttonRoom.Click += new System.EventHandler(this.buttonRoom_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.FlatAppearance.BorderSize = 0;
            this.buttonClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClient.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClient.Image = global::TermProjectWindow.Properties.Resources.Room1;
            this.buttonClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClient.Location = new System.Drawing.Point(0, 303);
            this.buttonClient.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(311, 63);
            this.buttonClient.TabIndex = 10;
            this.buttonClient.Text = "Client";
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.Image = global::TermProjectWindow.Properties.Resources._48_dashboard_101171;
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(0, 240);
            this.buttonDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(311, 63);
            this.buttonDashboard.TabIndex = 9;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(311, 233);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "system";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hotel management";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TermProjectWindow.Properties.Resources.grey_hotel_building_icon_icons_com_59461;
            this.pictureBox2.Location = new System.Drawing.Point(64, 13);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(179, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(311, 736);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1140, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(311, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1140, 202);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 112);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1140, 90);
            this.panel5.TabIndex = 0;
            // 
            // userControlClient1
            // 
            this.userControlClient1.Location = new System.Drawing.Point(311, 202);
            this.userControlClient1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlClient1.Name = "userControlClient1";
            this.userControlClient1.Size = new System.Drawing.Size(1140, 534);
            this.userControlClient1.TabIndex = 3;
            this.userControlClient1.Visible = false;
            // 
            // userControlReservation1
            // 
            this.userControlReservation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlReservation1.Location = new System.Drawing.Point(311, 202);
            this.userControlReservation1.Name = "userControlReservation1";
            this.userControlReservation1.Size = new System.Drawing.Size(1140, 534);
            this.userControlReservation1.TabIndex = 4;
            this.userControlReservation1.Visible = false;
            // 
            // userControlRoom1
            // 
            this.userControlRoom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlRoom1.Location = new System.Drawing.Point(311, 202);
            this.userControlRoom1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlRoom1.Name = "userControlRoom1";
            this.userControlRoom1.Size = new System.Drawing.Size(1140, 534);
            this.userControlRoom1.TabIndex = 5;
            this.userControlRoom1.Visible = false;
            // 
            // userControlReservation2
            // 
            this.userControlReservation2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlReservation2.Location = new System.Drawing.Point(311, 202);
            this.userControlReservation2.Name = "userControlReservation2";
            this.userControlReservation2.Size = new System.Drawing.Size(1140, 534);
            this.userControlReservation2.TabIndex = 6;
            this.userControlReservation2.Visible = false;
            // 
            // userControl1
            // 
            this.userControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl1.Location = new System.Drawing.Point(311, 202);
            this.userControl1.Margin = new System.Windows.Forms.Padding(4);
            this.userControl1.Name = "userControl1";
            this.userControl1.Size = new System.Drawing.Size(1140, 534);
            this.userControl1.TabIndex = 7;
            this.userControl1.Visible = false;
            // 
            // userControlClient2
            // 
            this.userControlClient2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlClient2.Location = new System.Drawing.Point(311, 202);
            this.userControlClient2.Margin = new System.Windows.Forms.Padding(4);
            this.userControlClient2.Name = "userControlClient2";
            this.userControlClient2.Size = new System.Drawing.Size(1140, 534);
            this.userControlClient2.TabIndex = 8;
            this.userControlClient2.Visible = false;
            // 
            // userControlRoom2
            // 
            this.userControlRoom2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlRoom2.Location = new System.Drawing.Point(311, 202);
            this.userControlRoom2.Margin = new System.Windows.Forms.Padding(4);
            this.userControlRoom2.Name = "userControlRoom2";
            this.userControlRoom2.Size = new System.Drawing.Size(1140, 534);
            this.userControlRoom2.TabIndex = 9;
            this.userControlRoom2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 836);
            this.Controls.Add(this.userControlRoom2);
            this.Controls.Add(this.userControlClient2);
            this.Controls.Add(this.userControl1);
            this.Controls.Add(this.userControlReservation2);
            this.Controls.Add(this.userControlRoom1);
            this.Controls.Add(this.userControlReservation1);
            this.Controls.Add(this.userControlClient1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Hotel management system";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonRoom;
        private System.Windows.Forms.Button buttonReservation;
        private System.Windows.Forms.Button buttonSetting;
        private UserControlClient.UserControlClient userControlClient1;
        private UserControlReservation userControlReservation1;
        private UserControlRoom.UserControlRoom userControlRoom1;
        private UserControlReservation userControlReservation2;
        private UserSetting.userControl userControl1;
        private UserControlClient.UserControlClient userControlClient2;
        private UserControlRoom.UserControlRoom userControlRoom2;
    }
}