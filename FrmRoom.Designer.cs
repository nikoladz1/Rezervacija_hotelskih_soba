namespace TVP_projekat1
{
    partial class FrmRoom
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
            this.numRoomNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numBeds = new System.Windows.Forms.NumericUpDown();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numPriceOff = new System.Windows.Forms.NumericUpDown();
            this.numDays = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numRoomNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // numRoomNumber
            // 
            this.numRoomNumber.Location = new System.Drawing.Point(129, 47);
            this.numRoomNumber.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numRoomNumber.Name = "numRoomNumber";
            this.numRoomNumber.Size = new System.Drawing.Size(120, 22);
            this.numRoomNumber.TabIndex = 0;
            this.numRoomNumber.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room number";
            // 
            // numBeds
            // 
            this.numBeds.Location = new System.Drawing.Point(129, 94);
            this.numBeds.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numBeds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBeds.Name = "numBeds";
            this.numBeds.Size = new System.Drawing.Size(120, 22);
            this.numBeds.TabIndex = 2;
            this.numBeds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbRoomType
            // 
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Items.AddRange(new object[] {
            "Standard",
            "Lux"});
            this.cbRoomType.Location = new System.Drawing.Point(129, 133);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(121, 24);
            this.cbRoomType.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Beds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Room type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price off in %:";
            // 
            // numPriceOff
            // 
            this.numPriceOff.Location = new System.Drawing.Point(129, 220);
            this.numPriceOff.Name = "numPriceOff";
            this.numPriceOff.Size = new System.Drawing.Size(120, 22);
            this.numPriceOff.TabIndex = 9;
            // 
            // numDays
            // 
            this.numDays.Location = new System.Drawing.Point(129, 265);
            this.numDays.Name = "numDays";
            this.numDays.Size = new System.Drawing.Size(120, 22);
            this.numDays.TabIndex = 10;
            this.numDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Minimum days:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(29, 326);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add room";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(29, 355);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(29, 384);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(314, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(702, 234);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(129, 182);
            this.numPrice.Maximum = new decimal(new int[] {
            25000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(120, 22);
            this.numPrice.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(976, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numDays);
            this.Controls.Add(this.numPriceOff);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbRoomType);
            this.Controls.Add(this.numBeds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numRoomNumber);
            this.Name = "FrmRoom";
            this.Text = "FrmRoom";
            ((System.ComponentModel.ISupportInitialize)(this.numRoomNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBeds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numRoomNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numBeds;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numPriceOff;
        private System.Windows.Forms.NumericUpDown numDays;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Button button1;
    }
}