namespace TVP_projekat1
{
    partial class FrmReservation
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
            this.cbRoom = new System.Windows.Forms.ComboBox();
            this.cbGuest = new System.Windows.Forms.ComboBox();
            this.txtDayStart = new System.Windows.Forms.TextBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.txtDayEnd = new System.Windows.Forms.TextBox();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbResType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbRoom
            // 
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.Location = new System.Drawing.Point(74, 38);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(121, 24);
            this.cbRoom.TabIndex = 0;
            this.cbRoom.SelectedIndexChanged += new System.EventHandler(this.cbRoom_SelectedIndexChanged);
            // 
            // cbGuest
            // 
            this.cbGuest.FormattingEnabled = true;
            this.cbGuest.Location = new System.Drawing.Point(74, 68);
            this.cbGuest.Name = "cbGuest";
            this.cbGuest.Size = new System.Drawing.Size(121, 24);
            this.cbGuest.TabIndex = 1;
            this.cbGuest.SelectedIndexChanged += new System.EventHandler(this.cbGuest_SelectedIndexChanged);
            // 
            // txtDayStart
            // 
            this.txtDayStart.Enabled = false;
            this.txtDayStart.Location = new System.Drawing.Point(74, 98);
            this.txtDayStart.Name = "txtDayStart";
            this.txtDayStart.Size = new System.Drawing.Size(95, 22);
            this.txtDayStart.TabIndex = 2;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(175, 98);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(20, 22);
            this.dateTimePickerStart.TabIndex = 3;
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePickerStart_ValueChanged);
            // 
            // txtDayEnd
            // 
            this.txtDayEnd.Enabled = false;
            this.txtDayEnd.Location = new System.Drawing.Point(74, 126);
            this.txtDayEnd.Name = "txtDayEnd";
            this.txtDayEnd.Size = new System.Drawing.Size(95, 22);
            this.txtDayEnd.TabIndex = 4;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(175, 126);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(19, 22);
            this.dateTimePickerEnd.TabIndex = 5;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.Location = new System.Drawing.Point(74, 184);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(120, 22);
            this.txtTotalPrice.TabIndex = 6;
            this.txtTotalPrice.TextChanged += new System.EventHandler(this.txtTotalPrice_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1086, 196);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbResType
            // 
            this.cbResType.FormattingEnabled = true;
            this.cbResType.Items.AddRange(new object[] {
            "Pansion",
            "Polu-pansion",
            "Samo Dorucak"});
            this.cbResType.Location = new System.Drawing.Point(74, 154);
            this.cbResType.Name = "cbResType";
            this.cbResType.Size = new System.Drawing.Size(121, 24);
            this.cbResType.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Room:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Guest";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "End:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Price:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 66);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(429, 140);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(674, 66);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(435, 140);
            this.textBox2.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Informacije o sobi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(671, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "informacije o Gostu";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(74, 250);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 48);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add Reservation";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(218, 250);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 48);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(365, 250);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 47);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pansion",
            "Polu-pansion",
            "Samo Dorucak"});
            this.comboBox1.Location = new System.Drawing.Point(602, 250);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FrmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 547);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbResType);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.txtDayEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.txtDayStart);
            this.Controls.Add(this.cbGuest);
            this.Controls.Add(this.cbRoom);
            this.Name = "FrmReservation";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.FrmReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRoom;
        private System.Windows.Forms.ComboBox cbGuest;
        private System.Windows.Forms.TextBox txtDayStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.TextBox txtDayEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbResType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}