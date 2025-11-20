using System;
using System.Windows.Forms;
using OrderingSystem.Exceptions;
using OrderingSystem.Model;
using OrderingSystem.Repository.Staff;
using OrderingSystem.Services;

namespace OrderingSystem.CashierApp.Layout
{
    public partial class ManagerLogin : Form
    {
        public ManagerLogin()
        {
            InitializeComponent();
        }



        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(user.Text) || string.IsNullOrWhiteSpace(pass.Text))
                {
                    throw new IncorrectCredentials("Incorrect Username or Password.");
                }
                StaffServices staffService = new StaffServices(new StaffRepository());
                StaffModel loginStaff = staffService.loginStaff(user.Text.Trim(), pass.Text.Trim());
                if (loginStaff != null)
                {
                    if (loginStaff.Status == StaffModel.StaffStatus.InActive)
                    {
                        MessageBox.Show("This staff is currently fired.", "Fired Staff", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        loginStaff = null;
                        return;
                    }
                    if (loginStaff.Role == StaffModel.StaffRole.Manager)
                        DialogResult = DialogResult.OK;
                    else
                        MessageBox.Show("This staff is not unauthorized.", "Unauthorized Staff", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    throw new IncorrectCredentials("Incorrect Username or Password.");
            }
            catch (IncorrectCredentials ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }
    }
}
