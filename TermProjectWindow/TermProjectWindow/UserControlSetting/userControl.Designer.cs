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
            this.tabPageSearchUser = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUserNameSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewSearchUser = new System.Windows.Forms.DataGridView();
            this.tabPageAddUser = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.tabControlUser = new System.Windows.Forms.TabControl();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.tabPageSearchUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchUser)).BeginInit();
            this.tabPageAddUser.SuspendLayout();
            this.tabControlUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageSearchUser
            // 
            this.tabPageSearchUser.Controls.Add(this.dataGridViewSearchUser);
            this.tabPageSearchUser.Controls.Add(this.textBoxUserNameSearch);
            this.tabPageSearchUser.Controls.Add(this.label5);
            this.tabPageSearchUser.Controls.Add(this.label4);
            this.tabPageSearchUser.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchUser.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageSearchUser.Name = "tabPageSearchUser";
            this.tabPageSearchUser.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageSearchUser.Size = new System.Drawing.Size(1104, 334);
            this.tabPageSearchUser.TabIndex = 1;
            this.tabPageSearchUser.Text = "Search user ";
            this.tabPageSearchUser.UseVisualStyleBackColor = true;
            this.tabPageSearchUser.Click += new System.EventHandler(this.tabPageSearchUser_Click);
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
            // textBoxUserNameSearch
            // 
            this.textBoxUserNameSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUserNameSearch.Location = new System.Drawing.Point(167, 75);
            this.textBoxUserNameSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUserNameSearch.Name = "textBoxUserNameSearch";
            this.textBoxUserNameSearch.Size = new System.Drawing.Size(241, 22);
            this.textBoxUserNameSearch.TabIndex = 2;
            // 
            // dataGridViewSearchUser
            // 
            this.dataGridViewSearchUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchUser.Location = new System.Drawing.Point(5, 108);
            this.dataGridViewSearchUser.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewSearchUser.Name = "dataGridViewSearchUser";
            this.dataGridViewSearchUser.RowHeadersWidth = 51;
            this.dataGridViewSearchUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSearchUser.Size = new System.Drawing.Size(1095, 226);
            this.dataGridViewSearchUser.TabIndex = 3;
            this.dataGridViewSearchUser.DoubleClick += new System.EventHandler(this.dataGridViewSearchUser_DoubleClick);
            // 
            // tabPageAddUser
            // 
            this.tabPageAddUser.Controls.Add(this.buttonDelete);
            this.tabPageAddUser.Controls.Add(this.buttonUpdate);
            this.tabPageAddUser.Controls.Add(this.textBoxId);
            this.tabPageAddUser.Controls.Add(this.textBoxPassword);
            this.tabPageAddUser.Controls.Add(this.textBoxUserName);
            this.tabPageAddUser.Controls.Add(this.label9);
            this.tabPageAddUser.Controls.Add(this.buttonClear);
            this.tabPageAddUser.Controls.Add(this.buttonAdd);
            this.tabPageAddUser.Controls.Add(this.label3);
            this.tabPageAddUser.Controls.Add(this.label2);
            this.tabPageAddUser.Controls.Add(this.label1);
            this.tabPageAddUser.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageAddUser.Name = "tabPageAddUser";
            this.tabPageAddUser.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageAddUser.Size = new System.Drawing.Size(1104, 334);
            this.tabPageAddUser.TabIndex = 0;
            this.tabPageAddUser.Text = "User";
            this.tabPageAddUser.UseVisualStyleBackColor = true;
            this.tabPageAddUser.Click += new System.EventHandler(this.tabPageAddUser_Click);
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
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username : ";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUserName.Location = new System.Drawing.Point(167, 130);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(241, 22);
            this.textBoxUserName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(619, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password : ";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.Location = new System.Drawing.Point(623, 130);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(241, 22);
            this.textBoxPassword.TabIndex = 4;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.BackColor = System.Drawing.Color.LightBlue;
            this.buttonAdd.Location = new System.Drawing.Point(168, 188);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClear.Location = new System.Drawing.Point(764, 188);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 28);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(162, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 26);
            this.label9.TabIndex = 7;
            this.label9.Text = "ID :";
            // 
            // textBoxId
            // 
            this.textBoxId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxId.Location = new System.Drawing.Point(166, 63);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(120, 22);
            this.textBoxId.TabIndex = 8;
            // 
            // tabControlUser
            // 
            this.tabControlUser.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlUser.Controls.Add(this.tabPageAddUser);
            this.tabControlUser.Controls.Add(this.tabPageSearchUser);
            this.tabControlUser.Location = new System.Drawing.Point(128, 83);
            this.tabControlUser.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlUser.Name = "tabControlUser";
            this.tabControlUser.SelectedIndex = 0;
            this.tabControlUser.Size = new System.Drawing.Size(1112, 363);
            this.tabControlUser.TabIndex = 0;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonUpdate.Location = new System.Drawing.Point(308, 188);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 28);
            this.buttonUpdate.TabIndex = 9;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Location = new System.Drawing.Point(624, 188);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 28);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // userControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlUser);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "userControl";
            this.Size = new System.Drawing.Size(1479, 587);
            this.Load += new System.EventHandler(this.userControl_Load);
            this.tabPageSearchUser.ResumeLayout(false);
            this.tabPageSearchUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchUser)).EndInit();
            this.tabPageAddUser.ResumeLayout(false);
            this.tabPageAddUser.PerformLayout();
            this.tabControlUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageSearchUser;
        private System.Windows.Forms.DataGridView dataGridViewSearchUser;
        private System.Windows.Forms.TextBox textBoxUserNameSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageAddUser;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlUser;
    }
}
