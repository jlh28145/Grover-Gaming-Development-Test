namespace EmployeeManagement
{
    partial class NewUserRegistration
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
            this.lblNURUsername = new System.Windows.Forms.Label();
            this.tbNURUsername = new System.Windows.Forms.TextBox();
            this.tbNURPassword = new System.Windows.Forms.TextBox();
            this.lblNURPassword = new System.Windows.Forms.Label();
            this.tbNURConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblNURConfirmPassword = new System.Windows.Forms.Label();
            this.btnNURSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNURUsername
            // 
            this.lblNURUsername.AutoSize = true;
            this.lblNURUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNURUsername.Location = new System.Drawing.Point(117, 79);
            this.lblNURUsername.Name = "lblNURUsername";
            this.lblNURUsername.Size = new System.Drawing.Size(70, 19);
            this.lblNURUsername.TabIndex = 0;
            this.lblNURUsername.Text = "Username";
            // 
            // tbNURUsername
            // 
            this.tbNURUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNURUsername.Location = new System.Drawing.Point(272, 76);
            this.tbNURUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNURUsername.Name = "tbNURUsername";
            this.tbNURUsername.Size = new System.Drawing.Size(218, 26);
            this.tbNURUsername.TabIndex = 1;
            // 
            // tbNURPassword
            // 
            this.tbNURPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNURPassword.Location = new System.Drawing.Point(272, 130);
            this.tbNURPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNURPassword.Name = "tbNURPassword";
            this.tbNURPassword.PasswordChar = '*';
            this.tbNURPassword.Size = new System.Drawing.Size(218, 26);
            this.tbNURPassword.TabIndex = 3;
            // 
            // lblNURPassword
            // 
            this.lblNURPassword.AutoSize = true;
            this.lblNURPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNURPassword.Location = new System.Drawing.Point(117, 135);
            this.lblNURPassword.Name = "lblNURPassword";
            this.lblNURPassword.Size = new System.Drawing.Size(69, 19);
            this.lblNURPassword.TabIndex = 2;
            this.lblNURPassword.Text = "Password";
            // 
            // tbNURConfirmPassword
            // 
            this.tbNURConfirmPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNURConfirmPassword.Location = new System.Drawing.Point(272, 181);
            this.tbNURConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNURConfirmPassword.Name = "tbNURConfirmPassword";
            this.tbNURConfirmPassword.PasswordChar = '*';
            this.tbNURConfirmPassword.Size = new System.Drawing.Size(218, 26);
            this.tbNURConfirmPassword.TabIndex = 5;
            // 
            // lblNURConfirmPassword
            // 
            this.lblNURConfirmPassword.AutoSize = true;
            this.lblNURConfirmPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNURConfirmPassword.Location = new System.Drawing.Point(72, 186);
            this.lblNURConfirmPassword.Name = "lblNURConfirmPassword";
            this.lblNURConfirmPassword.Size = new System.Drawing.Size(122, 19);
            this.lblNURConfirmPassword.TabIndex = 4;
            this.lblNURConfirmPassword.Text = "Confirm Password";
            this.lblNURConfirmPassword.Click += new System.EventHandler(this.NURConfirmPassword_Click);
            // 
            // btnNURSubmit
            // 
            this.btnNURSubmit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNURSubmit.Location = new System.Drawing.Point(305, 253);
            this.btnNURSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNURSubmit.Name = "btnNURSubmit";
            this.btnNURSubmit.Size = new System.Drawing.Size(82, 32);
            this.btnNURSubmit.TabIndex = 6;
            this.btnNURSubmit.Text = "Submit";
            this.btnNURSubmit.UseVisualStyleBackColor = true;
            this.btnNURSubmit.Click += new System.EventHandler(this.btnNURSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(495, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(495, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "*";
            // 
            // NewUserRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNURSubmit);
            this.Controls.Add(this.tbNURConfirmPassword);
            this.Controls.Add(this.lblNURConfirmPassword);
            this.Controls.Add(this.tbNURPassword);
            this.Controls.Add(this.lblNURPassword);
            this.Controls.Add(this.tbNURUsername);
            this.Controls.Add(this.lblNURUsername);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewUserRegistration";
            this.Text = "New User Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNURUsername;
        private TextBox tbNURUsername;
        private TextBox tbNURPassword;
        private Label lblNURPassword;
        private TextBox tbNURConfirmPassword;
        private Label lblNURConfirmPassword;
        private Button btnNURSubmit;
        private Label label1;
        private Label label2;
    }
}