namespace Form1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            HomePage = new ListBox();
            btnBook = new Button();
            btnCancel = new Button();
            btnRequest = new Button();
            btnExit = new Button();
            btnSave = new Button();
            rbHome = new RadioButton();
            rbLogout = new RadioButton();
            rbManageProfile = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(20, 13);
            label1.Name = "label1";
            label1.Size = new Size(120, 28);
            label1.TabIndex = 0;
            label1.Text = "Home Page";
            // 
            // HomePage
            // 
            HomePage.FormattingEnabled = true;
            HomePage.Location = new Point(226, 80);
            HomePage.Name = "HomePage";
            HomePage.Size = new Size(720, 464);
            HomePage.TabIndex = 1;
            // 
            // btnBook
            // 
            btnBook.BackColor = SystemColors.ActiveCaption;
            btnBook.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBook.ForeColor = SystemColors.ButtonFace;
            btnBook.Location = new Point(468, 150);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(225, 63);
            btnBook.TabIndex = 2;
            btnBook.Text = "Book Appointment";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveCaption;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonFace;
            btnCancel.Location = new Point(468, 274);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(225, 67);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel Appointment";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnRequest
            // 
            btnRequest.BackColor = SystemColors.ActiveCaption;
            btnRequest.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRequest.ForeColor = SystemColors.ButtonFace;
            btnRequest.Location = new Point(468, 412);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(225, 63);
            btnRequest.TabIndex = 4;
            btnRequest.Text = "Request Ambulance";
            btnRequest.UseVisualStyleBackColor = false;
            btnRequest.Click += btnRequest_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ActiveCaption;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(698, 567);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(205, 43);
            btnExit.TabIndex = 5;
            btnExit.Text = "Cancel";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = SystemColors.ButtonFace;
            btnSave.Location = new Point(262, 567);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(205, 43);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save and Submit";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // rbHome
            // 
            rbHome.AutoSize = true;
            rbHome.BackColor = SystemColors.ActiveCaption;
            rbHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbHome.ForeColor = SystemColors.ButtonFace;
            rbHome.Location = new Point(1036, 29);
            rbHome.Name = "rbHome";
            rbHome.Size = new Size(72, 24);
            rbHome.TabIndex = 7;
            rbHome.TabStop = true;
            rbHome.Text = "Home";
            rbHome.UseVisualStyleBackColor = false;
            rbHome.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbLogout
            // 
            rbLogout.AutoSize = true;
            rbLogout.BackColor = SystemColors.ActiveCaption;
            rbLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbLogout.ForeColor = SystemColors.ButtonFace;
            rbLogout.Location = new Point(1036, 59);
            rbLogout.Name = "rbLogout";
            rbLogout.Size = new Size(80, 24);
            rbLogout.TabIndex = 8;
            rbLogout.TabStop = true;
            rbLogout.Text = "Logout";
            rbLogout.UseVisualStyleBackColor = false;
            rbLogout.CheckedChanged += rbButton2_CheckedChanged;
            // 
            // rbManageProfile
            // 
            rbManageProfile.AutoSize = true;
            rbManageProfile.BackColor = SystemColors.ActiveCaption;
            rbManageProfile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbManageProfile.ForeColor = SystemColors.ButtonFace;
            rbManageProfile.Location = new Point(1036, -1);
            rbManageProfile.Name = "rbManageProfile";
            rbManageProfile.Size = new Size(136, 24);
            rbManageProfile.TabIndex = 9;
            rbManageProfile.TabStop = true;
            rbManageProfile.Text = "Manage Profile";
            rbManageProfile.UseVisualStyleBackColor = false;
            rbManageProfile.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 658);
            Controls.Add(rbManageProfile);
            Controls.Add(rbLogout);
            Controls.Add(rbHome);
            Controls.Add(btnSave);
            Controls.Add(btnExit);
            Controls.Add(btnRequest);
            Controls.Add(btnCancel);
            Controls.Add(btnBook);
            Controls.Add(HomePage);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox HomePage;
        private Button btnBook;
        private Button btnCancel;
        private Button btnRequest;
        private Button btnExit;
        private Button btnSave;
        private RadioButton rbHome;
        private RadioButton rbLogout;
        private RadioButton rbManageProfile;
    }
}
