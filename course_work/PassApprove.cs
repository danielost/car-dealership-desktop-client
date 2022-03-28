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

namespace course_work
{
    public partial class PassApprove : Form
    {
        Profile profile;
        public PassApprove(Profile prof)
        {
            InitializeComponent();
            profile = prof;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sc = new SqlDataAdapter("SELECT * FROM clients WHERE client_id = @client_id AND password = @password", conn);
                sc.SelectCommand.Parameters.AddWithValue("@client_id", profile.user["client_id"].ToString());
                sc.SelectCommand.Parameters.AddWithValue("@password", textBox1.Text);
                DataTable user = new DataTable();
                sc.Fill(user);
                conn.Close();
                if (user.Rows.Count > 0)
                {
                    profile.showChange();
                    this.Close();
                    return;
                }
                MessageBox.Show("Wrong password");
            }
        }
    }
}
