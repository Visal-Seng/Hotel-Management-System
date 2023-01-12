namespace TermProjectWindow.UserControlRoom
{
    partial class UserControlRoom
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
            this.tabControlRoom = new System.Windows.Forms.TabControl();
            this.tabPageAddRoom = new System.Windows.Forms.TabPage();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFree = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRoomNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageSearchRoom = new System.Windows.Forms.TabPage();
            this.buttonClearSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxRoom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControlRoom.SuspendLayout();
            this.tabPageAddRoom.SuspendLayout();
            this.tabPageSearchRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlRoom
            // 
            this.tabControlRoom.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlRoom.Controls.Add(this.tabPageAddRoom);
            this.tabControlRoom.Controls.Add(this.tabPageSearchRoom);
            this.tabControlRoom.Location = new System.Drawing.Point(169, 100);
            this.tabControlRoom.Name = "tabControlRoom";
            this.tabControlRoom.SelectedIndex = 0;
            this.tabControlRoom.Size = new System.Drawing.Size(818, 368);
            this.tabControlRoom.TabIndex = 0;
            // 
            // tabPageAddRoom
            // 
            this.tabPageAddRoom.Controls.Add(this.textBoxId);
            this.tabPageAddRoom.Controls.Add(this.label1);
            this.tabPageAddRoom.Controls.Add(this.comboBoxFree);
            this.tabPageAddRoom.Controls.Add(this.buttonUpdate);
            this.tabPageAddRoom.Controls.Add(this.buttonDelete);
            this.tabPageAddRoom.Controls.Add(this.buttonClear);
            this.tabPageAddRoom.Controls.Add(this.buttonAdd);
            this.tabPageAddRoom.Controls.Add(this.label5);
            this.tabPageAddRoom.Controls.Add(this.textBoxRoomNo);
            this.tabPageAddRoom.Controls.Add(this.label4);
            this.tabPageAddRoom.Controls.Add(this.comboBoxType);
            this.tabPageAddRoom.Controls.Add(this.label3);
            this.tabPageAddRoom.Controls.Add(this.label2);
            this.tabPageAddRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddRoom.Name = "tabPageAddRoom";
            this.tabPageAddRoom.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageAddRoom.Size = new System.Drawing.Size(810, 342);
            this.tabPageAddRoom.TabIndex = 0;
            this.tabPageAddRoom.Text = "git";
            this.tabPageAddRoom.UseVisualStyleBackColor = true;
            this.tabPageAddRoom.Click += new System.EventHandler(this.tabPageAddRoom_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(147, 54);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(49, 20);
            this.textBoxId.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID :";
            // 
            // comboBoxFree
            // 
            this.comboBoxFree.FormattingEnabled = true;
            this.comboBoxFree.Location = new System.Drawing.Point(147, 206);
            this.comboBoxFree.Name = "comboBoxFree";
            this.comboBoxFree.Size = new System.Drawing.Size(173, 21);
            this.comboBoxFree.TabIndex = 12;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.LightCoral;
            this.buttonUpdate.Location = new System.Drawing.Point(423, 273);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(99, 39);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Location = new System.Drawing.Point(543, 273);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(99, 39);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonClear.Location = new System.Drawing.Point(302, 273);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(99, 39);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonAdd.Location = new System.Drawing.Point(186, 273);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(99, 39);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(143, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Free : ";
            // 
            // textBoxRoomNo
            // 
            this.textBoxRoomNo.Location = new System.Drawing.Point(485, 122);
            this.textBoxRoomNo.Name = "textBoxRoomNo";
            this.textBoxRoomNo.Size = new System.Drawing.Size(186, 20);
            this.textBoxRoomNo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(481, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Room No.:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(147, 121);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(173, 21);
            this.comboBoxType.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add room :";
            // 
            // tabPageSearchRoom
            // 
            this.tabPageSearchRoom.Controls.Add(this.buttonClearSearch);
            this.tabPageSearchRoom.Controls.Add(this.dataGridView1);
            this.tabPageSearchRoom.Controls.Add(this.textBoxRoom);
            this.tabPageSearchRoom.Controls.Add(this.label7);
            this.tabPageSearchRoom.Controls.Add(this.label6);
            this.tabPageSearchRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchRoom.Name = "tabPageSearchRoom";
            this.tabPageSearchRoom.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageSearchRoom.Size = new System.Drawing.Size(810, 342);
            this.tabPageSearchRoom.TabIndex = 1;
            this.tabPageSearchRoom.Text = "Search room";
            this.tabPageSearchRoom.UseVisualStyleBackColor = true;
            // 
            // buttonClearSearch
            // 
            this.buttonClearSearch.BackColor = System.Drawing.Color.LightCoral;
            this.buttonClearSearch.Location = new System.Drawing.Point(449, 70);
            this.buttonClearSearch.Name = "buttonClearSearch";
            this.buttonClearSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonClearSearch.TabIndex = 4;
            this.buttonClearSearch.Text = "Clear";
            this.buttonClearSearch.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(797, 215);
            this.dataGridView1.TabIndex = 3;
            // 
            // textBoxRoom
            // 
            this.textBoxRoom.Location = new System.Drawing.Point(215, 74);
            this.textBoxRoom.Name = "textBoxRoom";
            this.textBoxRoom.Size = new System.Drawing.Size(209, 20);
            this.textBoxRoom.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(211, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Room No.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(7, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Search room : ";
            // 
            // UserControlRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlRoom);
            this.Name = "UserControlRoom";
            this.Size = new System.Drawing.Size(1109, 529);
            this.Load += new System.EventHandler(this.UserControlRoom_Load);
            this.tabControlRoom.ResumeLayout(false);
            this.tabPageAddRoom.ResumeLayout(false);
            this.tabPageAddRoom.PerformLayout();
            this.tabPageSearchRoom.ResumeLayout(false);
            this.tabPageSearchRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlRoom;
        private System.Windows.Forms.TabPage tabPageAddRoom;
        private System.Windows.Forms.TabPage tabPageSearchRoom;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRoomNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxRoom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonClearSearch;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxFree;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label1;
    }
}
