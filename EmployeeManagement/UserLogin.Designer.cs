namespace EmployeeManagement
{
    partial class UserLogin
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
            this.labelULUsername = new System.Windows.Forms.Label();
            this.txtULUsername = new System.Windows.Forms.TextBox();
            this.txtULPassword = new System.Windows.Forms.TextBox();
            this.labelULPassword = new System.Windows.Forms.Label();
            this.btnULLogin = new System.Windows.Forms.Button();
            this.btnULNur = new System.Windows.Forms.Button();
            this.btnULExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelULUsername
            // 
            this.labelULUsername.AutoSize = true;
            this.labelULUsername.Location = new System.Drawing.Point(419, 239);
            this.labelULUsername.Name = "labelULUsername";
            this.labelULUsername.Size = new System.Drawing.Size(88, 22);
            this.labelULUsername.TabIndex = 0;
            this.labelULUsername.Text = "Username";
            // 
            // txtULUsername
            // 
            this.txtULUsername.Location = new System.Drawing.Point(566, 236);
            this.txtULUsername.Name = "txtULUsername";
            this.txtULUsername.Size = new System.Drawing.Size(326, 30);
            this.txtULUsername.TabIndex = 1;
            // 
            // txtULPassword
            // 
            this.txtULPassword.Location = new System.Drawing.Point(566, 323);
            this.txtULPassword.Name = "txtULPassword";
            this.txtULPassword.PasswordChar = '*';
            this.txtULPassword.Size = new System.Drawing.Size(326, 30);
            this.txtULPassword.TabIndex = 3;
            // 
            // labelULPassword
            // 
            this.labelULPassword.AutoSize = true;
            this.labelULPassword.Location = new System.Drawing.Point(419, 326);
            this.labelULPassword.Name = "labelULPassword";
            this.labelULPassword.Size = new System.Drawing.Size(88, 22);
            this.labelULPassword.TabIndex = 2;
            this.labelULPassword.Text = "Password";
            // 
            // btnULLogin
            // 
            this.btnULLogin.Location = new System.Drawing.Point(566, 425);
            this.btnULLogin.Name = "btnULLogin";
            this.btnULLogin.Size = new System.Drawing.Size(94, 29);
            this.btnULLogin.TabIndex = 4;
            this.btnULLogin.Text = "Login";
            this.btnULLogin.UseVisualStyleBackColor = true;
            this.btnULLogin.Click += new System.EventHandler(this.btnULLogin_Click);
            // 
            // btnULNur
            // 
            this.btnULNur.Location = new System.Drawing.Point(647, 510);
            this.btnULNur.Name = "btnULNur";
            this.btnULNur.Size = new System.Drawing.Size(127, 52);
            this.btnULNur.TabIndex = 5;
            this.btnULNur.Text = "New User Click Here";
            this.btnULNur.UseVisualStyleBackColor = true;
            this.btnULNur.Click += new System.EventHandler(this.btnULNur_Click);
            // 
            // btnULExit
            // 
            this.btnULExit.Location = new System.Drawing.Point(752, 425);
            this.btnULExit.Name = "btnULExit";
            this.btnULExit.Size = new System.Drawing.Size(94, 29);
            this.btnULExit.TabIndex = 6;
            this.btnULExit.Text = "Exit";
            this.btnULExit.UseVisualStyleBackColor = true;
            this.btnULExit.Click += new System.EventHandler(this.btnULExit_Click);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnULExit);
            this.Controls.Add(this.btnULNur);
            this.Controls.Add(this.btnULLogin);
            this.Controls.Add(this.txtULPassword);
            this.Controls.Add(this.labelULPassword);
            this.Controls.Add(this.txtULUsername);
            this.Controls.Add(this.labelULUsername);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Management Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelULUsername;
        private TextBox txtULUsername;
        private TextBox txtULPassword;
        private Label labelULPassword;
        private Button btnULLogin;
        private Button btnULNur;
        private Button btnULExit;
    }
}