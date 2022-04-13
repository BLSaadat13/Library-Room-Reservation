namespace Library_Room_Reservation
{
    partial class ViewRequest
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
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNewDT = new System.Windows.Forms.Label();
            this.lblNewRoom = new System.Windows.Forms.Label();
            this.lblOldDT = new System.Windows.Forms.Label();
            this.lblOldRoom = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Results of your request";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(373, 340);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 26);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Go back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Room reserved:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date and Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Room requested:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Date and time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Status:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblNewDT);
            this.panel1.Controls.Add(this.lblNewRoom);
            this.panel1.Controls.Add(this.lblOldDT);
            this.panel1.Controls.Add(this.lblOldRoom);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(32, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 234);
            this.panel1.TabIndex = 8;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(66, 196);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(15, 18);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "-";
            // 
            // lblNewDT
            // 
            this.lblNewDT.AutoSize = true;
            this.lblNewDT.Location = new System.Drawing.Point(131, 147);
            this.lblNewDT.Name = "lblNewDT";
            this.lblNewDT.Size = new System.Drawing.Size(15, 18);
            this.lblNewDT.TabIndex = 11;
            this.lblNewDT.Text = "-";
            // 
            // lblNewRoom
            // 
            this.lblNewRoom.AutoSize = true;
            this.lblNewRoom.Location = new System.Drawing.Point(131, 120);
            this.lblNewRoom.Name = "lblNewRoom";
            this.lblNewRoom.Size = new System.Drawing.Size(15, 18);
            this.lblNewRoom.TabIndex = 10;
            this.lblNewRoom.Text = "-";
            // 
            // lblOldDT
            // 
            this.lblOldDT.AutoSize = true;
            this.lblOldDT.Location = new System.Drawing.Point(131, 84);
            this.lblOldDT.Name = "lblOldDT";
            this.lblOldDT.Size = new System.Drawing.Size(15, 18);
            this.lblOldDT.TabIndex = 9;
            this.lblOldDT.Text = "-";
            // 
            // lblOldRoom
            // 
            this.lblOldRoom.AutoSize = true;
            this.lblOldRoom.Location = new System.Drawing.Point(131, 56);
            this.lblOldRoom.Name = "lblOldRoom";
            this.lblOldRoom.Size = new System.Drawing.Size(15, 18);
            this.lblOldRoom.TabIndex = 8;
            this.lblOldRoom.Text = "-";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(370, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 187);
            this.label8.TabIndex = 20;
            this.label8.Text = "*Request data will be removed when the reserved date has passed even when it is s" +
    "till pending OR when the given room is cancelled";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(131, 17);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(15, 18);
            this.lblId.TabIndex = 13;
            this.lblId.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "Request ID:";
            // 
            // ViewRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 396);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ViewRequest";
            this.Text = "ViewRequest";
            this.Load += new System.EventHandler(this.ViewRequest_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNewDT;
        private System.Windows.Forms.Label lblNewRoom;
        private System.Windows.Forms.Label lblOldDT;
        private System.Windows.Forms.Label lblOldRoom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label9;
    }
}