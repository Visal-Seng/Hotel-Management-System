namespace TermProjectWindow.UserSetting
{
    partial class userControl
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
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearchUser = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxUserNameSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageUpdateDelete = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonClearUD = new System.Windows.Forms.Button();
            this.buttonAddUD = new System.Windows.Forms.Button();
            this.textBoxPasswordUD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUserNameUD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonDeleteUD = new System.Windows.Forms.Button();
            this.tabControlUser.SuspendLayout();
            this.tabPageAddUser.SuspendLayout();
            this.tabPageSearchUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageUpdateDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlUser
            // 
            this.tabControlUser.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlUser.Controls.Add(this.tabPageAddUser);
            this.tabControlUser.Controls.Add(this.tabPageSearchUser);
            this.tabControlUser.Controls.Add(this.tabPageUpdateDelete);
            this.tabControlUser.Location = new System.Drawing.Point(128, 83);
            this.tabControlUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControlUser.Name = "tabControlUser";
            this.tabControlUser.SelectedIndex = 0;
            this.tabControlUser.Size = new System.Drawing.Size(1112, 363);
            this.tabControlUser.TabIndex = 0;
            // 
            // tabPageAddUser
            // 
            this.tabPageAddUser.Controls.Add(this.buttonClear);
            this.tabPageAddUser.Controls.Add(this.buttonAdd);
            this.tabPageAddUser.Controls.Add(this.textBoxPassword);
            this.tabPageAddUser.Controls.Add(this.label3);
            this.tabPageAddUser.Controls.Add(this.textBoxUserName);
            this.tabPageAddUser.Controls.Add(this.label2);
            this.tabPageAddUser.Controls.Add(this.label1);
            this.tabPageAddUser.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageAddUser.Name = "tabPageAddUser";
            this.tabPageAddUser.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageAddUser.Size = new System.Drawing.Size(1104, 334);
            this.tabPageAddUser.TabIndex = 0;
            this.tabPageAddUser.Text = "Add user";
            this.tabPageAddUser.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClear.Location = new System.Drawing.Point(308, 164);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 28);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.BackColor = System.Drawing.Color.LightBlue;
            this.buttonAdd.Location = new System.Drawing.Point(168, 164);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.Location = new System.Drawing.Point(623, 106);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(241, 22);
            this.textBoxPassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(619, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password : ";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUserName.Location = new System.Drawing.Point(167, 106);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(241, 22);
            this.textBoxUserName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add user : ";
            // 
            // tabPageSearchUser
            // 
            this.tabPageSearchUser.Controls.Add(this.dataGridView1);
            this.tabPageSearchUser.Controls.Add(this.textBoxUserNameSearch);
            this.tabPageSearchUser.Controls.Add(this.label5);
            this.tabPageSearchUser.Controls.Add(this.label4);
            this.tabPageSearchUser.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageSearchUser.Name = "tabPageSearchUser";
            this.tabPageSearchUser.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageSearchUser.Size = new System.Drawing.Size(1104, 334);
            this.tabPageSearchUser.TabIndex = 1;
            this.tabPageSearchUser.Text = "Search user ";
            this.tabPageSearchUser.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(5, 108);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1383, 346);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Username ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Password";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // textBoxUserNameSearch
            // 
            this.textBoxUserNameSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUserNameSearch.Location = new System.Drawing.Point(167, 75);
            this.textBoxUserNameSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUserNameSearch.Name = "textBoxUserNameSearch";
            this.textBoxUserNameSearch.Size = new System.Drawing.Size(241, 22);
            this.textBoxUserNameSearch.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(163, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "Username : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Search user : ";
            // 
            // tabPageUpdateDelete
            // 
            this.tabPageUpdateDelete.Controls.Add(this.buttonDeleteUD);
            this.tabPageUpdateDelete.Controls.Add(this.label8);
            this.tabPageUpdateDelete.Controls.Add(this.buttonClearUD);
            this.tabPageUpdateDelete.Controls.Add(this.buttonAddUD);
            this.tabPageUpdateDelete.Controls.Add(this.textBoxPasswordUD);
            this.tabPageUpdateDelete.Controls.Add(this.label6);
            this.tabPageUpdateDelete.Controls.Add(this.textBoxUserNameUD);
            this.tabPageUpdateDelete.Controls.Add(this.label7);
            this.tabPageUpdateDelete.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageUpdateDelete.Name = "tabPageUpdateDelete";
            this.tabPageUpdateDelete.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageUpdateDelete.Size = new System.Drawing.Size(1104, 334);
            this.tabPageUpdateDelete.TabIndex = 2;
            this.tabPageUpdateDelete.Text = "Update and delete";
            this.tabPageUpdateDelete.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(9, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 31);
            this.label8.TabIndex = 13;
            this.label8.Text = "Update and delete : ";
            // 
            // buttonClearUD
            // 
            this.buttonClearUD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClearUD.Location = new System.Drawing.Point(494, 189);
            this.buttonClearUD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClearUD.Name = "buttonClearUD";
            this.buttonClearUD.Size = new System.Drawing.Size(100, 28);
            this.buttonClearUD.TabIndex = 12;
            this.buttonClearUD.Text = "Clear";
            this.buttonClearUD.UseVisualStyleBackColor = true;
            // 
            // buttonAddUD
            // 
            this.buttonAddUD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddUD.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonAddUD.Location = new System.Drawing.Point(242, 189);
            this.buttonAddUD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddUD.Name = "buttonAddUD";
            this.buttonAddUD.Size = new System.Drawing.Size(100, 28);
            this.buttonAddUD.TabIndex = 11;
            this.buttonAddUD.Text = "Add";
            this.buttonAddUD.UseVisualStyleBackColor = false;
            // 
            // textBoxPasswordUD
            // 
            this.textBoxPasswordUD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPasswordUD.Location = new System.Drawing.Point(697, 110);
            this.textBoxPasswordUD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPasswordUD.Name = "textBoxPasswordUD";
            this.textBoxPasswordUD.Size = new System.Drawing.Size(241, 22);
            this.textBoxPasswordUD.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(693, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "Password : ";
            // 
            // textBoxUserNameUD
            // 
            this.textBoxUserNameUD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUserNameUD.Location = new System.Drawing.Point(241, 110);
            this.textBoxUserNameUD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUserNameUD.Name = "textBoxUserNameUD";
            this.textBoxUserNameUD.Size = new System.Drawing.Size(241, 22);
            this.textBoxUserNameUD.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(237, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 26);
            this.label7.TabIndex = 7;
            this.label7.Text = "Username : ";
            // 
            // buttonDeleteUD
            // 
            this.buttonDeleteUD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteUD.BackColor = System.Drawing.Color.LightCoral;
            this.buttonDeleteUD.Location = new System.Drawing.Point(365, 189);
            this.buttonDeleteUD.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteUD.Name = "buttonDeleteUD";
            this.buttonDeleteUD.Size = new System.Drawing.Size(100, 28);
            this.buttonDeleteUD.TabIndex = 14;
            this.buttonDeleteUD.Text = "Delete";
            this.buttonDeleteUD.UseVisualStyleBackColor = false;
            // 
            // userControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlUser);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "userControl";
            this.Size = new System.Drawing.Size(1479, 587);
            this.tabControlUser.ResumeLayout(false);
            this.tabPageAddUser.ResumeLayout(false);
            this.tabPageAddUser.PerformLayout();
            this.tabPageSearchUser.ResumeLayout(false);
            this.tabPageSearchUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageUpdateDelete.ResumeLayout(false);
            this.tabPageUpdateDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlUser;
        private System.Windows.Forms.TabPage tabPageAddUser;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageSearchUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox textBoxUserNameSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageUpdateDelete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonClearUD;
        private System.Windows.Forms.Button buttonAddUD;
        private System.Windows.Forms.TextBox textBoxPasswordUD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxUserNameUD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonDeleteUD;
    }
}
