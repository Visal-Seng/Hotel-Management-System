namespace TermProjectWindow
{
    partial class UserControlSetting
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlUser = new System.Windows.Forms.TabControl();
            this.tabPageAddUser = new System.Windows.Forms.TabPage();
            this.tabPageSearchUser = new System.Windows.Forms.TabPage();
            this.tabPageUpdateDeleteUser = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControlUser.SuspendLayout();
            this.tabPageAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlUser
            // 
            this.tabControlUser.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlUser.Controls.Add(this.tabPageAddUser);
            this.tabControlUser.Controls.Add(this.tabPageSearchUser);
            this.tabControlUser.Controls.Add(this.tabPageUpdateDeleteUser);
            this.tabControlUser.Location = new System.Drawing.Point(3, 3);
            this.tabControlUser.Name = "tabControlUser";
            this.tabControlUser.SelectedIndex = 0;
            this.tabControlUser.Size = new System.Drawing.Size(1011, 636);
            this.tabControlUser.TabIndex = 0;
            // 
            // tabPageAddUser
            // 
            this.tabPageAddUser.Controls.Add(this.button1);
            this.tabPageAddUser.Controls.Add(this.textBox2);
            this.tabPageAddUser.Controls.Add(this.label3);
            this.tabPageAddUser.Controls.Add(this.textBox1);
            this.tabPageAddUser.Controls.Add(this.label2);
            this.tabPageAddUser.Controls.Add(this.label1);
            this.tabPageAddUser.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddUser.Name = "tabPageAddUser";
            this.tabPageAddUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddUser.Size = new System.Drawing.Size(1003, 607);
            this.tabPageAddUser.TabIndex = 0;
            this.tabPageAddUser.Text = "Add user";
            this.tabPageAddUser.UseVisualStyleBackColor = true;
            // 
            // tabPageSearchUser
            // 
            this.tabPageSearchUser.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchUser.Name = "tabPageSearchUser";
            this.tabPageSearchUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchUser.Size = new System.Drawing.Size(1003, 607);
            this.tabPageSearchUser.TabIndex = 1;
            this.tabPageSearchUser.Text = "Search user";
            this.tabPageSearchUser.UseVisualStyleBackColor = true;
            // 
            // tabPageUpdateDeleteUser
            // 
            this.tabPageUpdateDeleteUser.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateDeleteUser.Name = "tabPageUpdateDeleteUser";
            this.tabPageUpdateDeleteUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateDeleteUser.Size = new System.Drawing.Size(1003, 607);
            this.tabPageUpdateDeleteUser.TabIndex = 2;
            this.tabPageUpdateDeleteUser.Text = "Update and delete";
            this.tabPageUpdateDeleteUser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add user : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(215, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(557, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 22);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UserControlSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlUser);
            this.Name = "UserControlSetting";
            this.Size = new System.Drawing.Size(1017, 642);
            this.tabControlUser.ResumeLayout(false);
            this.tabPageAddUser.ResumeLayout(false);
            this.tabPageAddUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlUser;
        private System.Windows.Forms.TabPage tabPageAddUser;
        private System.Windows.Forms.TabPage tabPageSearchUser;
        private System.Windows.Forms.TabPage tabPageUpdateDeleteUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
