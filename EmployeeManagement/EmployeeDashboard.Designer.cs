namespace EmployeeManagement
{
    partial class EmployeeDashboard
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
            this.lblEDName = new System.Windows.Forms.Label();
            this.lblEDJobTitle = new System.Windows.Forms.Label();
            this.lblEDDoh = new System.Windows.Forms.Label();
            this.tbEDName = new System.Windows.Forms.TextBox();
            this.tbEDJobTitle = new System.Windows.Forms.TextBox();
            this.btnEDSave = new System.Windows.Forms.Button();
            this.btnEDDelete = new System.Windows.Forms.Button();
            this.btnEDReset = new System.Windows.Forms.Button();
            this.dtpEDDoh = new System.Windows.Forms.DateTimePicker();
            this.dgvED = new System.Windows.Forms.DataGridView();
            this.tbEDSearch = new System.Windows.Forms.TextBox();
            this.btnEDSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvED)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEDName
            // 
            this.lblEDName.AutoSize = true;
            this.lblEDName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEDName.Location = new System.Drawing.Point(104, 76);
            this.lblEDName.Name = "lblEDName";
            this.lblEDName.Size = new System.Drawing.Size(53, 21);
            this.lblEDName.TabIndex = 0;
            this.lblEDName.Text = "Name";
            // 
            // lblEDJobTitle
            // 
            this.lblEDJobTitle.AutoSize = true;
            this.lblEDJobTitle.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEDJobTitle.Location = new System.Drawing.Point(81, 132);
            this.lblEDJobTitle.Name = "lblEDJobTitle";
            this.lblEDJobTitle.Size = new System.Drawing.Size(74, 21);
            this.lblEDJobTitle.TabIndex = 1;
            this.lblEDJobTitle.Text = "Job Title";
            // 
            // lblEDDoh
            // 
            this.lblEDDoh.AutoSize = true;
            this.lblEDDoh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEDDoh.Location = new System.Drawing.Point(48, 188);
            this.lblEDDoh.Name = "lblEDDoh";
            this.lblEDDoh.Size = new System.Drawing.Size(105, 21);
            this.lblEDDoh.TabIndex = 2;
            this.lblEDDoh.Text = "Date Of Hire";
            this.lblEDDoh.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbEDName
            // 
            this.tbEDName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEDName.Location = new System.Drawing.Point(221, 66);
            this.tbEDName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEDName.Name = "tbEDName";
            this.tbEDName.Size = new System.Drawing.Size(219, 32);
            this.tbEDName.TabIndex = 3;
            // 
            // tbEDJobTitle
            // 
            this.tbEDJobTitle.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEDJobTitle.Location = new System.Drawing.Point(221, 122);
            this.tbEDJobTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEDJobTitle.Name = "tbEDJobTitle";
            this.tbEDJobTitle.Size = new System.Drawing.Size(219, 32);
            this.tbEDJobTitle.TabIndex = 4;
            // 
            // btnEDSave
            // 
            this.btnEDSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEDSave.Location = new System.Drawing.Point(132, 260);
            this.btnEDSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEDSave.Name = "btnEDSave";
            this.btnEDSave.Size = new System.Drawing.Size(98, 32);
            this.btnEDSave.TabIndex = 6;
            this.btnEDSave.Text = "Save";
            this.btnEDSave.UseVisualStyleBackColor = true;
            this.btnEDSave.Click += new System.EventHandler(this.btnEDSave_Click);
            // 
            // btnEDDelete
            // 
            this.btnEDDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEDDelete.Location = new System.Drawing.Point(239, 260);
            this.btnEDDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEDDelete.Name = "btnEDDelete";
            this.btnEDDelete.Size = new System.Drawing.Size(98, 32);
            this.btnEDDelete.TabIndex = 7;
            this.btnEDDelete.Text = "Delete";
            this.btnEDDelete.UseVisualStyleBackColor = true;
            this.btnEDDelete.Click += new System.EventHandler(this.btnEDDelete_Click);
            // 
            // btnEDReset
            // 
            this.btnEDReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEDReset.Location = new System.Drawing.Point(342, 260);
            this.btnEDReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEDReset.Name = "btnEDReset";
            this.btnEDReset.Size = new System.Drawing.Size(98, 32);
            this.btnEDReset.TabIndex = 8;
            this.btnEDReset.Text = "Reset";
            this.btnEDReset.UseVisualStyleBackColor = true;
            this.btnEDReset.Click += new System.EventHandler(this.btnEDReset_Click);
            // 
            // dtpEDDoh
            // 
            this.dtpEDDoh.CustomFormat = "";
            this.dtpEDDoh.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpEDDoh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEDDoh.Location = new System.Drawing.Point(221, 181);
            this.dtpEDDoh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEDDoh.MinDate = new System.DateTime(2003, 1, 1, 0, 0, 0, 0);
            this.dtpEDDoh.Name = "dtpEDDoh";
            this.dtpEDDoh.Size = new System.Drawing.Size(219, 32);
            this.dtpEDDoh.TabIndex = 9;
            // 
            // dgvED
            // 
            this.dgvED.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvED.Location = new System.Drawing.Point(542, 109);
            this.dgvED.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvED.Name = "dgvED";
            this.dgvED.ReadOnly = true;
            this.dgvED.RowHeadersWidth = 51;
            this.dgvED.RowTemplate.Height = 29;
            this.dgvED.Size = new System.Drawing.Size(602, 400);
            this.dgvED.TabIndex = 10;
            this.dgvED.DoubleClick += new System.EventHandler(this.dgvED_DoubleClick);
            // 
            // tbEDSearch
            // 
            this.tbEDSearch.Location = new System.Drawing.Point(542, 65);
            this.tbEDSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEDSearch.Name = "tbEDSearch";
            this.tbEDSearch.Size = new System.Drawing.Size(518, 23);
            this.tbEDSearch.TabIndex = 11;
            // 
            // btnEDSearch
            // 
            this.btnEDSearch.Location = new System.Drawing.Point(1080, 64);
            this.btnEDSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEDSearch.Name = "btnEDSearch";
            this.btnEDSearch.Size = new System.Drawing.Size(82, 22);
            this.btnEDSearch.TabIndex = 12;
            this.btnEDSearch.Text = "Search";
            this.btnEDSearch.UseVisualStyleBackColor = true;
            this.btnEDSearch.Click += new System.EventHandler(this.btnEDSearch_Click);
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 562);
            this.Controls.Add(this.btnEDSearch);
            this.Controls.Add(this.tbEDSearch);
            this.Controls.Add(this.dgvED);
            this.Controls.Add(this.dtpEDDoh);
            this.Controls.Add(this.btnEDReset);
            this.Controls.Add(this.btnEDDelete);
            this.Controls.Add(this.btnEDSave);
            this.Controls.Add(this.tbEDJobTitle);
            this.Controls.Add(this.tbEDName);
            this.Controls.Add(this.lblEDDoh);
            this.Controls.Add(this.lblEDJobTitle);
            this.Controls.Add(this.lblEDName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeDashboard";
            this.Text = "Employee Dashboard";
            this.Load += new System.EventHandler(this.EmployeeDashboard_Load);
            this.Click += new System.EventHandler(this.EmployeeDashboard_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvED)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEDName;
        private Label lblEDJobTitle;
        private Label lblEDDoh;
        private TextBox tbEDName;
        private TextBox tbEDJobTitle;
        private Button btnEDSave;
        private Button btnEDDelete;
        private Button btnEDReset;
        private DateTimePicker dtpEDDoh;
        private DataGridView dgvED;
        private TextBox tbEDSearch;
        private Button btnEDSearch;
    }
}