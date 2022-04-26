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
    public partial class EmployeeDashboard : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\EmployeeManagement\EmployeeManagementDB.mdf;Integrated Security=True;Connect Timeout=30");
        int EmployeeId = 0;
        public EmployeeDashboard()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEDSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                if (btnEDSave.Text == "Save")
                {
                    SqlCommand sqlCmd = new SqlCommand("EmployeeAddorEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Add");
                    sqlCmd.Parameters.AddWithValue("@EmployeeId", 0);
                    sqlCmd.Parameters.AddWithValue("@Name", tbEDName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@JobTitle", tbEDJobTitle.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@DateOfHire", dtpEDDoh.Value);
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Added Successfully");
                }
                else
                {
                    SqlCommand sqlCmd = new SqlCommand("EmployeeAddorEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                    sqlCmd.Parameters.AddWithValue("@EmployeeId", EmployeeId);
                    sqlCmd.Parameters.AddWithValue("@Name", tbEDName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@JobTitle", tbEDJobTitle.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@DateOfHire", dtpEDDoh.Value);
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Updated Successfully");
                }
                Reset();
                FillDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error: Save function not complete. Try again");
            }
            finally
            {
                sqlCon.Close();
            }
        }
        void FillDataGridView()
        {
            if(sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("EmployeeViewOrSearch", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("Name", tbEDSearch.Text.Trim());
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            dgvED.DataSource = dt;
            dgvED.Columns[0].Visible = false;
            sqlCon.Close();

        }

        void Reset()
        {
            tbEDName.Text = tbEDJobTitle.Text = "";
            dtpEDDoh.Value = DateTime.Now;
            btnEDSave.Text = "Save";
            EmployeeId = 0;
            btnEDDelete.Enabled = false;
        }

        private void btnEDSearch_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: Search function not complete. Try again");
            }
        }

        private void dgvED_DoubleClick(object sender, EventArgs e)
        {
            if(dgvED.CurrentRow.Index != -1)
            {
                EmployeeId = Convert.ToInt32(dgvED.CurrentRow.Cells[0].Value);
                tbEDName.Text = dgvED.CurrentRow.Cells[1].Value.ToString();
                tbEDJobTitle.Text = dgvED.CurrentRow.Cells[2].Value.ToString();
                dtpEDDoh.Value = (DateTime)dgvED.CurrentRow.Cells[3].Value;
                btnEDSave.Text = "Update";
                btnEDDelete.Enabled = true;
            }
        }

        private void btnEDReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void EmployeeDashboard_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeDashboard_Load(object sender, EventArgs e)
        {
            Reset();
            FillDataGridView();
        }

        private void btnEDDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                 SqlCommand sqlCmd = new SqlCommand("EmployeeDelete", sqlCon);
                 sqlCmd.CommandType = CommandType.StoredProcedure;
                 sqlCmd.Parameters.AddWithValue("@EmployeeId", EmployeeId);
                 sqlCmd.ExecuteNonQuery();
                 MessageBox.Show("Employee Deleted Successfully");
                Reset();
                FillDataGridView();

             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Deletion was Unsuccessfully. Try again");
            }
        }
    }
}
