namespace Library_Room_Reservation
{
    partial class ChangeRoom
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.listRoom = new System.Windows.Forms.ListBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.lblSelectedDT = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRoom = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rooms that you have reserved";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.listRoom);
            this.panel1.Controls.Add(this.txtReason);
            this.panel1.Controls.Add(this.lblSelectedDT);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cboTime);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Location = new System.Drawing.Point(231, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 516);
            this.panel1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.lblCapacity);
            this.panel3.Controls.Add(this.lblRoomType);
            this.panel3.Location = new System.Drawing.Point(16, 385);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 104);
            this.panel3.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Room capacity:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "Room type:";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(9, 76);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(0, 18);
            this.lblCapacity.TabIndex = 17;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(9, 24);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(0, 18);
            this.lblRoomType.TabIndex = 16;
            // 
            // listRoom
            // 
            this.listRoom.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRoom.FormattingEnabled = true;
            this.listRoom.ItemHeight = 21;
            this.listRoom.Location = new System.Drawing.Point(16, 51);
            this.listRoom.Name = "listRoom";
            this.listRoom.Size = new System.Drawing.Size(153, 319);
            this.listRoom.TabIndex = 24;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(216, 264);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(244, 163);
            this.txtReason.TabIndex = 23;
            this.txtReason.Text = "Reason to change";
            // 
            // lblSelectedDT
            // 
            this.lblSelectedDT.AutoSize = true;
            this.lblSelectedDT.Location = new System.Drawing.Point(210, 192);
            this.lblSelectedDT.Name = "lblSelectedDT";
            this.lblSelectedDT.Size = new System.Drawing.Size(0, 18);
            this.lblSelectedDT.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "Selected Date and Time:";
            // 
            // cboTime
            // 
            this.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Items.AddRange(new object[] {
            "8:00 AM",
            "10:00 AM",
            "12:00 PM",
            "2:00 PM",
            "4:00 PM",
            "6:00 PM"});
            this.cboTime.Location = new System.Drawing.Point(213, 101);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(246, 26);
            this.cboTime.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "*Select room from the list";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Select Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Select Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Rooms Available";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(219, 444);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(171, 55);
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "Send change room request to Librarian";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(213, 40);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(247, 26);
            this.dtpDate.TabIndex = 13;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(213, 133);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(189, 26);
            this.btnCheck.TabIndex = 11;
            this.btnCheck.Text = "Check Availability";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(712, 545);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 26);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Go back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblRoom);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblDateTime);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(12, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 155);
            this.panel2.TabIndex = 23;
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(3, 37);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(43, 18);
            this.lblRoom.TabIndex = 19;
            this.lblRoom.Text = "None";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Date and Time";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(3, 104);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(43, 18);
            this.lblDateTime.TabIndex = 17;
            this.lblDateTime.Text = "None";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Room ID";
            // 
            // ChangeRoom
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(811, 581);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ChangeRoom";
            this.Text = "Request to change room";
            this.Load += new System.EventHandler(this.ChangeRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cboTime;
        private System.Windows.Forms.Label lblSelectedDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.ListBox listRoom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblRoomType;
    }
}