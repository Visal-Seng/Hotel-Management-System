namespace TermProjectWindow
{
    partial class UserControlReservation
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
            this.components = new System.ComponentModel.Container();
            this.tabControlReservation = new System.Windows.Forms.TabControl();
            this.tabPageAddReservation = new System.Windows.Forms.TabPage();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dateTimePickerCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxRoomNo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearchReservation = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxClientIdSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPageUpdateDeleteReservation = new System.Windows.Forms.TabPage();
            this.buttonClearUC = new System.Windows.Forms.Button();
            this.buttonCancelUC = new System.Windows.Forms.Button();
            this.buttonUpdateUC = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePickerCheckOutDateUC = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCheckInDateUC = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxClientIdUC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxRoomNoUC = new System.Windows.Forms.ComboBox();
            this.comboBoxRoomTypeUC = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControlReservation.SuspendLayout();
            this.tabPageAddReservation.SuspendLayout();
            this.tabPageSearchReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageUpdateDeleteReservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlReservation
            // 
            this.tabControlReservation.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlReservation.Controls.Add(this.tabPageAddReservation);
            this.tabControlReservation.Controls.Add(this.tabPageSearchReservation);
            this.tabControlReservation.Controls.Add(this.tabPageUpdateDeleteReservation);
            this.tabControlReservation.Location = new System.Drawing.Point(210, 163);
            this.tabControlReservation.Name = "tabControlReservation";
            this.tabControlReservation.SelectedIndex = 0;
            this.tabControlReservation.Size = new System.Drawing.Size(1083, 424);
            this.tabControlReservation.TabIndex = 0;
            // 
            // tabPageAddReservation
            // 
            this.tabPageAddReservation.Controls.Add(this.buttonClear);
            this.tabPageAddReservation.Controls.Add(this.buttonAdd);
            this.tabPageAddReservation.Controls.Add(this.dateTimePickerCheckOutDate);
            this.tabPageAddReservation.Controls.Add(this.dateTimePickerCheckInDate);
            this.tabPageAddReservation.Controls.Add(this.label6);
            this.tabPageAddReservation.Controls.Add(this.label5);
            this.tabPageAddReservation.Controls.Add(this.textBoxClientID);
            this.tabPageAddReservation.Controls.Add(this.label4);
            this.tabPageAddReservation.Controls.Add(this.comboBoxRoomNo);
            this.tabPageAddReservation.Controls.Add(this.label3);
            this.tabPageAddReservation.Controls.Add(this.comboBoxRoomType);
            this.tabPageAddReservation.Controls.Add(this.label2);
            this.tabPageAddReservation.Controls.Add(this.label1);
            this.tabPageAddReservation.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddReservation.Name = "tabPageAddReservation";
            this.tabPageAddReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddReservation.Size = new System.Drawing.Size(1075, 395);
            this.tabPageAddReservation.TabIndex = 0;
            this.tabPageAddReservation.Text = "Add reservation";
            this.tabPageAddReservation.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.LightCoral;
            this.buttonClear.Location = new System.Drawing.Point(290, 276);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonAdd.Location = new System.Drawing.Point(187, 276);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerCheckOutDate
            // 
            this.dateTimePickerCheckOutDate.Location = new System.Drawing.Point(608, 227);
            this.dateTimePickerCheckOutDate.Name = "dateTimePickerCheckOutDate";
            this.dateTimePickerCheckOutDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerCheckOutDate.TabIndex = 10;
            // 
            // dateTimePickerCheckInDate
            // 
            this.dateTimePickerCheckInDate.Location = new System.Drawing.Point(187, 227);
            this.dateTimePickerCheckInDate.Name = "dateTimePickerCheckInDate";
            this.dateTimePickerCheckInDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerCheckInDate.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(603, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Check out date : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(182, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Check in date : ";
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Location = new System.Drawing.Point(187, 157);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(178, 22);
            this.textBoxClientID.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Client ID : ";
            // 
            // comboBoxRoomNo
            // 
            this.comboBoxRoomNo.FormattingEnabled = true;
            this.comboBoxRoomNo.Location = new System.Drawing.Point(608, 84);
            this.comboBoxRoomNo.Name = "comboBoxRoomNo";
            this.comboBoxRoomNo.Size = new System.Drawing.Size(180, 24);
            this.comboBoxRoomNo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(605, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Room No.:";
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(185, 84);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(180, 24);
            this.comboBoxRoomType.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room type : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add reservation :";
            // 
            // tabPageSearchReservation
            // 
            this.tabPageSearchReservation.Controls.Add(this.dataGridView1);
            this.tabPageSearchReservation.Controls.Add(this.textBoxClientIdSearch);
            this.tabPageSearchReservation.Controls.Add(this.label8);
            this.tabPageSearchReservation.Controls.Add(this.label7);
            this.tabPageSearchReservation.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchReservation.Name = "tabPageSearchReservation";
            this.tabPageSearchReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchReservation.Size = new System.Drawing.Size(1075, 395);
            this.tabPageSearchReservation.TabIndex = 1;
            this.tabPageSearchReservation.Text = "Search reservation";
            this.tabPageSearchReservation.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(12, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1047, 273);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Room type";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Room No.";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Client ID";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Check in date";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Check out date";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // textBoxClientIdSearch
            // 
            this.textBoxClientIdSearch.Location = new System.Drawing.Point(242, 76);
            this.textBoxClientIdSearch.Name = "textBoxClientIdSearch";
            this.textBoxClientIdSearch.Size = new System.Drawing.Size(253, 22);
            this.textBoxClientIdSearch.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(237, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 26);
            this.label8.TabIndex = 1;
            this.label8.Text = "Client ID : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(7, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(253, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Search reservation : ";
            // 
            // tabPageUpdateDeleteReservation
            // 
            this.tabPageUpdateDeleteReservation.Controls.Add(this.buttonClearUC);
            this.tabPageUpdateDeleteReservation.Controls.Add(this.buttonCancelUC);
            this.tabPageUpdateDeleteReservation.Controls.Add(this.buttonUpdateUC);
            this.tabPageUpdateDeleteReservation.Controls.Add(this.label14);
            this.tabPageUpdateDeleteReservation.Controls.Add(this.dateTimePickerCheckOutDateUC);
            this.tabPageUpdateDeleteReservation.Controls.Add(this.dateTimePickerCheckInDateUC);
            this.tabPageUpdateDeleteReservation.Controls.Add(this.label13);
            this.tabPageUpdateDeleteReservation.Controls.Add(this.textBoxClientIdUC);
            this.tabPageUpdateDeleteReservation.Controls.Add(this.label12);
            this.tabPageUpdateDeleteReservation.Controls.Add(this.comboBoxRoomNoUC);
            this.tabPageUpdateDeleteReservation.Controls.Add(this.comboBoxRoomTypeUC);
            this.tabPageUpdateDeleteReservation.Controls.Add(this.label11);
            this.tabPageUpdateDeleteReservation.Controls.Add(this.label10);
            this.tabPageUpdateDeleteReservation.Controls.Add(this.label9);
            this.tabPageUpdateDeleteReservation.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateDeleteReservation.Name = "tabPageUpdateDeleteReservation";
            this.tabPageUpdateDeleteReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateDeleteReservation.Size = new System.Drawing.Size(1075, 395);
            this.tabPageUpdateDeleteReservation.TabIndex = 2;
            this.tabPageUpdateDeleteReservation.Text = "Update and  Cancel reservation";
            this.tabPageUpdateDeleteReservation.UseVisualStyleBackColor = true;
            // 
            // buttonClearUC
            // 
            this.buttonClearUC.Location = new System.Drawing.Point(459, 289);
            this.buttonClearUC.Name = "buttonClearUC";
            this.buttonClearUC.Size = new System.Drawing.Size(75, 23);
            this.buttonClearUC.TabIndex = 13;
            this.buttonClearUC.Text = "Clear";
            this.buttonClearUC.UseVisualStyleBackColor = true;
            // 
            // buttonCancelUC
            // 
            this.buttonCancelUC.BackColor = System.Drawing.Color.LightCoral;
            this.buttonCancelUC.Location = new System.Drawing.Point(368, 289);
            this.buttonCancelUC.Name = "buttonCancelUC";
            this.buttonCancelUC.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelUC.TabIndex = 12;
            this.buttonCancelUC.Text = "Cancel";
            this.buttonCancelUC.UseVisualStyleBackColor = false;
            // 
            // buttonUpdateUC
            // 
            this.buttonUpdateUC.BackColor = System.Drawing.Color.LightBlue;
            this.buttonUpdateUC.Location = new System.Drawing.Point(277, 289);
            this.buttonUpdateUC.Name = "buttonUpdateUC";
            this.buttonUpdateUC.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateUC.TabIndex = 11;
            this.buttonUpdateUC.Text = "Update";
            this.buttonUpdateUC.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(631, 217);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 16);
            this.label14.TabIndex = 10;
            this.label14.Text = "Check out date : ";
            // 
            // dateTimePickerCheckOutDateUC
            // 
            this.dateTimePickerCheckOutDateUC.Location = new System.Drawing.Point(634, 247);
            this.dateTimePickerCheckOutDateUC.Name = "dateTimePickerCheckOutDateUC";
            this.dateTimePickerCheckOutDateUC.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerCheckOutDateUC.TabIndex = 9;
            // 
            // dateTimePickerCheckInDateUC
            // 
            this.dateTimePickerCheckInDateUC.Location = new System.Drawing.Point(277, 247);
            this.dateTimePickerCheckInDateUC.Name = "dateTimePickerCheckInDateUC";
            this.dateTimePickerCheckInDateUC.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerCheckInDateUC.TabIndex = 8;
            this.dateTimePickerCheckInDateUC.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(274, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 16);
            this.label13.TabIndex = 7;
            this.label13.Text = "Check in date : ";
            // 
            // textBoxClientIdUC
            // 
            this.textBoxClientIdUC.Location = new System.Drawing.Point(277, 179);
            this.textBoxClientIdUC.Name = "textBoxClientIdUC";
            this.textBoxClientIdUC.Size = new System.Drawing.Size(100, 22);
            this.textBoxClientIdUC.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(274, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "Client ID :";
            // 
            // comboBoxRoomNoUC
            // 
            this.comboBoxRoomNoUC.FormattingEnabled = true;
            this.comboBoxRoomNoUC.Location = new System.Drawing.Point(634, 103);
            this.comboBoxRoomNoUC.Name = "comboBoxRoomNoUC";
            this.comboBoxRoomNoUC.Size = new System.Drawing.Size(121, 24);
            this.comboBoxRoomNoUC.TabIndex = 4;
            // 
            // comboBoxRoomTypeUC
            // 
            this.comboBoxRoomTypeUC.FormattingEnabled = true;
            this.comboBoxRoomTypeUC.Location = new System.Drawing.Point(277, 103);
            this.comboBoxRoomTypeUC.Name = "comboBoxRoomTypeUC";
            this.comboBoxRoomTypeUC.Size = new System.Drawing.Size(121, 24);
            this.comboBoxRoomTypeUC.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(631, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Room No.:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(274, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Room type : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(7, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(348, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Update and cancel reservation :";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1309, 300);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UserControlReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tabControlReservation);
            this.Name = "UserControlReservation";
            this.Size = new System.Drawing.Size(1479, 651);
            this.tabControlReservation.ResumeLayout(false);
            this.tabPageAddReservation.ResumeLayout(false);
            this.tabPageAddReservation.PerformLayout();
            this.tabPageSearchReservation.ResumeLayout(false);
            this.tabPageSearchReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageUpdateDeleteReservation.ResumeLayout(false);
            this.tabPageUpdateDeleteReservation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlReservation;
        private System.Windows.Forms.TabPage tabPageAddReservation;
        private System.Windows.Forms.TabPage tabPageSearchReservation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxRoomNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageUpdateDeleteReservation;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckOutDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckInDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxClientIdSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckOutDateUC;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckInDateUC;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxClientIdUC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxRoomNoUC;
        private System.Windows.Forms.ComboBox comboBoxRoomTypeUC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonClearUC;
        private System.Windows.Forms.Button buttonCancelUC;
        private System.Windows.Forms.Button buttonUpdateUC;
        private System.Windows.Forms.Label label14;
    }
}
