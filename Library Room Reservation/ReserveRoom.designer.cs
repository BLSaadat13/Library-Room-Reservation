namespace Library_Room_Reservation
{
    partial class ReserveRoom
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnReserve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSelectedDT = new System.Windows.Forms.Label();
            this.listRoom = new System.Windows.Forms.ListBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(235, 189);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(189, 26);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check Availability";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(238, 67);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(247, 26);
            this.dtpDate.TabIndex = 3;
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(242, 339);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(167, 54);
            this.btnReserve.TabIndex = 5;
            this.btnReserve.Text = "Reserve room";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rooms Available";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(299, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "*Select room from the list shown on the left";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(428, 427);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 26);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Go back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.cboTime.Location = new System.Drawing.Point(239, 140);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(246, 26);
            this.cboTime.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Date and Time Selected:";
            // 
            // lblSelectedDT
            // 
            this.lblSelectedDT.AutoSize = true;
            this.lblSelectedDT.Location = new System.Drawing.Point(239, 256);
            this.lblSelectedDT.Name = "lblSelectedDT";
            this.lblSelectedDT.Size = new System.Drawing.Size(0, 18);
            this.lblSelectedDT.TabIndex = 14;
            // 
            // listRoom
            // 
            this.listRoom.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRoom.FormattingEnabled = true;
            this.listRoom.ItemHeight = 21;
            this.listRoom.Location = new System.Drawing.Point(24, 45);
            this.listRoom.Name = "listRoom";
            this.listRoom.Size = new System.Drawing.Size(153, 277);
            this.listRoom.TabIndex = 15;
            this.listRoom.SelectedIndexChanged += new System.EventHandler(this.listRoom_SelectedIndexChanged);
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(9, 24);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(0, 18);
            this.lblRoomType.TabIndex = 16;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(9, 76);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(0, 18);
            this.lblCapacity.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Room capacity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Room type:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblCapacity);
            this.panel1.Controls.Add(this.lblRoomType);
            this.panel1.Location = new System.Drawing.Point(24, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 104);
            this.panel1.TabIndex = 20;
            // 
            // ReserveRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 490);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listRoom);
            this.Controls.Add(this.lblSelectedDT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboTime);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnCheck);
            this.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ReserveRoom";
            this.Text = "Reserve Room";
            this.Load += new System.EventHandler(this.ReserveRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cboTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSelectedDT;
        private System.Windows.Forms.ListBox listRoom;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
    }
}