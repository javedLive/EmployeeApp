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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=INCEPSYS-SE\TEST;Initial Catalog=Employee;Integrated Security=True");
            connection.Open();

          
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select Receive,CallDial FROM USERS where Date ='" +reportDatePicker.Value.Date + "'", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            reportGridView.DataSource = dataTable;
            reportGridView.AutoGenerateColumns = false;
        }
    }
}
