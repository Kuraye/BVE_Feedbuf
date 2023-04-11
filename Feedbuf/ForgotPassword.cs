using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feedbuf
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void ReturnBttn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void Btn_EditPassword_Click(object sender, EventArgs e)
        {
            string studentNumber = FP_txbStudentNumber.Text;
            string newPassword = FP_txbPassword1.Text;
            string newPassword2 = FP_txbPassword2.Text;

            try
            {
                if (newPassword == newPassword2)
                {
                    using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Feedbuf;Integrated Security=True"))
                    {
                        string sql = "UPDATE Users SET Password = @newPassword WHERE Username = @studentNumber";
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@newPassword", newPassword);
                            command.Parameters.AddWithValue("@studentNumber", studentNumber);

                            int rowsAffected = command.ExecuteNonQuery();


                            if (rowsAffected == 1)
                            {
                                MessageBox.Show("Password updated successfully!");
                            }
                            else
                            {
                                MessageBox.Show("Failed to update password.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Password is not the same");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

    }
}

