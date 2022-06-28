namespace TVP_projekat1
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGuestOpen = new System.Windows.Forms.Button();
            this.btnRoomOpen = new System.Windows.Forms.Button();
            this.btnReservationOpen = new System.Windows.Forms.Button();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserSurname = new System.Windows.Forms.TextBox();
            this.txtUserUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserType = new System.Windows.Forms.TextBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuestOpen
            // 
            this.btnGuestOpen.Location = new System.Drawing.Point(12, 23);
            this.btnGuestOpen.Name = "btnGuestOpen";
            this.btnGuestOpen.Size = new System.Drawing.Size(124, 34);
            this.btnGuestOpen.TabIndex = 0;
            this.btnGuestOpen.Text = "Edit Guests";
            this.btnGuestOpen.UseVisualStyleBackColor = true;
            this.btnGuestOpen.Click += new System.EventHandler(this.btnGuestOpen_Click);
            // 
            // btnRoomOpen
            // 
            this.btnRoomOpen.Location = new System.Drawing.Point(151, 23);
            this.btnRoomOpen.Name = "btnRoomOpen";
            this.btnRoomOpen.Size = new System.Drawing.Size(124, 34);
            this.btnRoomOpen.TabIndex = 0;
            this.btnRoomOpen.Text = "Edit Rooms";
            this.btnRoomOpen.UseVisualStyleBackColor = true;
            this.btnRoomOpen.Click += new System.EventHandler(this.btnRoomOpen_Click);
            // 
            // btnReservationOpen
            // 
            this.btnReservationOpen.Location = new System.Drawing.Point(293, 23);
            this.btnReservationOpen.Name = "btnReservationOpen";
            this.btnReservationOpen.Size = new System.Drawing.Size(124, 34);
            this.btnReservationOpen.TabIndex = 0;
            this.btnReservationOpen.Text = "Edit Reservations";
            this.btnReservationOpen.UseVisualStyleBackColor = true;
            this.btnReservationOpen.Click += new System.EventHandler(this.btnReservationOpen_Click);
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AutoGenerateColumns = false;
            this.dgvUser.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dgvUser.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.userBindingSource, "Name", true));
            this.dgvUser.DataSource = this.userBindingSource;
            this.dgvUser.Location = new System.Drawing.Point(12, 95);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.RowTemplate.Height = 24;
            this.dgvUser.Size = new System.Drawing.Size(728, 230);
            this.dgvUser.TabIndex = 1;
            this.dgvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellContentClick);
            this.dgvUser.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvUser_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Users:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(103, 359);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(139, 22);
            this.txtUserName.TabIndex = 4;
            // 
            // txtUserSurname
            // 
            this.txtUserSurname.Location = new System.Drawing.Point(103, 390);
            this.txtUserSurname.Name = "txtUserSurname";
            this.txtUserSurname.Size = new System.Drawing.Size(139, 22);
            this.txtUserSurname.TabIndex = 4;
            // 
            // txtUserUsername
            // 
            this.txtUserUsername.Location = new System.Drawing.Point(103, 421);
            this.txtUserUsername.Name = "txtUserUsername";
            this.txtUserUsername.Size = new System.Drawing.Size(139, 22);
            this.txtUserUsername.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username";
            // 
            // txtUserType
            // 
            this.txtUserType.Location = new System.Drawing.Point(358, 390);
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.Size = new System.Drawing.Size(139, 22);
            this.txtUserType.TabIndex = 9;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(358, 359);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(139, 22);
            this.txtUserPassword.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Password";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(550, 348);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 50);
            this.btnAddUser.TabIndex = 11;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(645, 348);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 50);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(550, 404);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 46);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(645, 404);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 46);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "User_Id";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "User_Id";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(TVP_projekat1.Models.User);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(988, 536);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtUserType);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUserUsername);
            this.Controls.Add(this.txtUserSurname);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvUser);
            this.Controls.Add(this.btnReservationOpen);
            this.Controls.Add(this.btnRoomOpen);
            this.Controls.Add(this.btnGuestOpen);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuestOpen;
        private System.Windows.Forms.Button btnRoomOpen;
        private System.Windows.Forms.Button btnReservationOpen;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserSurname;
        private System.Windows.Forms.TextBox txtUserUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserType;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDelete;
    }
}