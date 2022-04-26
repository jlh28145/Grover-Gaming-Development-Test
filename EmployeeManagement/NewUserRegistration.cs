using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmployeeManagement
{
    public partial class NewUserRegistration : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\EmployeeManagement\EmployeeManagementDB.mdf;Integrated Security=True;Connect Timeout=30";
        public NewUserRegistration()
        {
            InitializeComponent();
        }

        private void NURConfirmPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnNURSubmit_Click(object sender, EventArgs e)
        {
            if (tbNURUsername.Text == "" || tbNURPassword.Text == "")
                MessageBox.Show("Neccesary Fields are empty");
            else if (tbNURPassword.Text != tbNURConfirmPassword.Text)
                MessageBox.Show("Password do not match");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@Username", tbNURUsername.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", tbNURPassword.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("New User Added");
                    Clear();

                }
            }
        }
        void Clear()
        {
            tbNURUsername.Text = tbNURPassword.Text = tbNURConfirmPassword.Text = "";
        }
    }
}
