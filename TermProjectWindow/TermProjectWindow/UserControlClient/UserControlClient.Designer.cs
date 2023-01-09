namespace TermProjectWindow.UserControlClient
{
    partial class UserControlClient
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
            this.tabPageSearchClient = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.tabPageAddClient = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.tabControlClient = new System.Windows.Forms.TabControl();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.tabPageSearchClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.tabPageAddClient.SuspendLayout();
            this.tabControlClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageSearchClient
            // 
            this.tabPageSearchClient.Controls.Add(this.dataGridViewClient);
            this.tabPageSearchClient.Controls.Add(this.textBoxPhoneNo);
            this.tabPageSearchClient.Controls.Add(this.label7);
            this.tabPageSearchClient.Controls.Add(this.label6);
            this.tabPageSearchClient.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchClient.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageSearchClient.Name = "tabPageSearchClient";
            this.tabPageSearchClient.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageSearchClient.Size = new System.Drawing.Size(1093, 456);
            this.tabPageSearchClient.TabIndex = 1;
            this.tabPageSearchClient.Text = "Search client";
            this.tabPageSearchClient.UseVisualStyleBackColor = true;
            this.tabPageSearchClient.Click += new System.EventHandler(this.tabPageSearchClient_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(9, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Search client : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(175, 57);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "Phone No.:";
            // 
            // textBoxPhoneNo
            // 
            this.textBoxPhoneNo.Location = new System.Drawing.Point(180, 87);
            this.textBoxPhoneNo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPhoneNo.Name = "textBoxPhoneNo";
            this.textBoxPhoneNo.Size = new System.Drawing.Size(251, 22);
            this.textBoxPhoneNo.TabIndex = 2;
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Location = new System.Drawing.Point(9, 153);
            this.dataGridViewClient.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.RowHeadersWidth = 51;
            this.dataGridViewClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClient.Size = new System.Drawing.Size(1073, 293);
            this.dataGridViewClient.TabIndex = 3;
            this.dataGridViewClient.DoubleClick += new System.EventHandler(this.dataGridViewClient_DoubleClick);
            // 
            // tabPageAddClient
            // 
            this.tabPageAddClient.Controls.Add(this.textBoxId);
            this.tabPageAddClient.Controls.Add(this.label8);
            this.tabPageAddClient.Controls.Add(this.buttonUpdate);
            this.tabPageAddClient.Controls.Add(this.buttonDelete);
            this.tabPageAddClient.Controls.Add(this.buttonClear);
            this.tabPageAddClient.Controls.Add(this.buttonAdd);
            this.tabPageAddClient.Controls.Add(this.textBoxAddress);
            this.tabPageAddClient.Controls.Add(this.textBoxPhone);
            this.tabPageAddClient.Controls.Add(this.textBoxLastName);
            this.tabPageAddClient.Controls.Add(this.textBoxFirstName);
            this.tabPageAddClient.Controls.Add(this.label5);
            this.tabPageAddClient.Controls.Add(this.label4);
            this.tabPageAddClient.Controls.Add(this.label3);
            this.tabPageAddClient.Controls.Add(this.label2);
            this.tabPageAddClient.Controls.Add(this.label1);
            this.tabPageAddClient.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddClient.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageAddClient.Name = "tabPageAddClient";
            this.tabPageAddClient.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageAddClient.Size = new System.Drawing.Size(1093, 456);
            this.tabPageAddClient.TabIndex = 0;
            this.tabPageAddClient.Text = "Add client";
            this.tabPageAddClient.UseVisualStyleBackColor = true;
            this.tabPageAddClient.Click += new System.EventHandler(this.tabPageAddClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add client : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "First name  : ";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(173, 105);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(283, 22);
            this.textBoxFirstName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(647, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last name  : ";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(653, 105);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(283, 22);
            this.textBoxLastName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(167, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone  No.: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(173, 195);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(283, 22);
            this.textBoxPhone.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 240);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Address  : ";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(173, 270);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(763, 126);
            this.textBoxAddress.TabIndex = 8;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LightBlue;
            this.buttonAdd.Location = new System.Drawing.Point(173, 404);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(115, 46);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add ";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(499, 404);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(124, 46);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            // 
            // tabControlClient
            // 
            this.tabControlClient.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlClient.Controls.Add(this.tabPageAddClient);
            this.tabControlClient.Controls.Add(this.tabPageSearchClient);
            this.tabControlClient.Location = new System.Drawing.Point(156, 87);
            this.tabControlClient.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlClient.Name = "tabControlClient";
            this.tabControlClient.SelectedIndex = 0;
            this.tabControlClient.Size = new System.Drawing.Size(1101, 485);
            this.tabControlClient.TabIndex = 0;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Location = new System.Drawing.Point(652, 404);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(124, 46);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.LightCoral;
            this.buttonUpdate.Location = new System.Drawing.Point(332, 404);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(124, 46);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(165, 4);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 26);
            this.label8.TabIndex = 13;
            this.label8.Text = "ID : ";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(170, 34);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(100, 22);
            this.textBoxId.TabIndex = 14;
            // 
            // UserControlClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlClient);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserControlClient";
            this.Size = new System.Drawing.Size(1479, 651);
            this.Load += new System.EventHandler(this.UserControlClient_Load);
            this.tabPageSearchClient.ResumeLayout(false);
            this.tabPageSearchClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.tabPageAddClient.ResumeLayout(false);
            this.tabPageAddClient.PerformLayout();
            this.tabControlClient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageSearchClient;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.TextBox textBoxPhoneNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPageAddClient;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlClient;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label8;
    }
}
