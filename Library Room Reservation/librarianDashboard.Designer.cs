
namespace Library_Room_Reservation
{
    partial class librarianDashboard
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnRequest = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(400, 371);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 31);
            this.btnLogout.TabIndex = 26;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(261, 84);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(179, 109);
            this.btnReport.TabIndex = 24;
            this.btnReport.Text = "View Reservation Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(27, 84);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(194, 109);
            this.btnRequest.TabIndex = 22;
            this.btnRequest.Text = "View Change Room Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(24, 29);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(133, 18);
            this.lblWelcome.TabIndex = 21;
            this.lblWelcome.Text = "Welcome Librarian";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(27, 220);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(194, 109);
            this.btnCreate.TabIndex = 27;
            this.btnCreate.Text = "Create new librarian account";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(261, 220);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(179, 109);
            this.btnEditProfile.TabIndex = 28;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // librarianDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 423);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.lblWelcome);
            this.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "librarianDashboard";
            this.Text = "Librarian Dashboard";
            this.Load += new System.EventHandler(this.librarianDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnEditProfile;
    }
}