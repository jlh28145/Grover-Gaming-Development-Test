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
    public partial class UserLogin : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\EmployeeManagement\EmployeeManagementDB.mdf;Integrated Security=True;Connect Timeout=30";
        public UserLogin()
        {
            InitializeComponent();
        }

        private void btnULLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(connectionString);
            string query = "Select * from Users Where username = '" + txtULUsername.Text.Trim() + "' and password = '" + txtULPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count > 0)
            {
                EmployeeDashboard employeeDashboard = new EmployeeDashboard();
                this.Hide();
                employeeDashboard.Show();
            }
            else
            {
                MessageBox.Show("Check your username and password");
            }
        }

        private void btnULExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnULNur_Click(object sender, EventArgs e)
        {
            NewUserRegistration newUserRegistration = new NewUserRegistration();
            newUserRegistration.Show();
        }
    }
}