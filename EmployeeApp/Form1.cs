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


namespace EmployeeApp
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=INCEPSYS-SE\TEST;Initial Catalog=Employee;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Employees where Name = '" + nameTextBox.Text + " ' and Password = '" + passwordTextBox.Text + "'", connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Entry ss = new Entry();
                ss.Show();
              //  string currentUserId = Convert.ToString(Membership.GetUser().ProviderUserKey);
              //  MessageBox.Show(Environment.UserName);
            }
            else
            {
                MessageBox.Show("Please Check your Username & password");
            }
        }
    }
}
