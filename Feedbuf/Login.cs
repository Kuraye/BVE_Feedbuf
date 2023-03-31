using System.Data.SqlClient;

namespace Feedbuf
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void UserTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBttn_Click(object sender, EventArgs e)
        {
            string username = UserTxtBx.Text;
            string password = PasswordTxtBx.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=MSI;Initial Catalog=Feedbuf;Integrated Security=True"))
                {
                    string sql = "SELECT COUNT(*) FROM Users WHERE Username=@userName AND Password=@password";
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@userName", UserTxtBx.Text);
                        command.Parameters.AddWithValue("@password", PasswordTxtBx.Text);
                        int result = (int)command.ExecuteScalar();
                                
                        if (result > 0)
                        {
                            Home home = new Home();
                            home.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password");
                        }

                    }
                }
            }
            catch (SqlException)
            {

                MessageBox.Show("fout in sql");
            }
        }

        private void RegisterBttn_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}