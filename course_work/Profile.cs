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
    public partial class Profile : Form
    {
        public DataRow user;
        Main parentForm;
        public Profile(DataRow user, Main main, int edit)
        {
            InitializeComponent();
            this.user = user;
            parentForm = main;
            uploadCars();
            nameLabel.ForeColor = Color.White;
            update();

            hideChange();
            if (edit == 1)
            {
                PassApprove pa = new PassApprove(this);
                pa.Show();
            }           
        }

        private void uploadCars()
        {
            DataTable cars;
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sc = new SqlDataAdapter("SELECT * FROM cars LEFT JOIN (SELECT car_histories.VIN, MIN(event_id) as event_id FROM car_histories GROUP BY car_histories.VIN) AS a ON cars.VIN = a.VIN JOIN engines ON cars.eng_type = engines.engine_id WHERE seller_id = @seller_id AND cars.VIN NOT IN (SELECT VIN FROM sellings)", conn);
                sc.SelectCommand.Parameters.AddWithValue("@seller_id", user["client_id"].ToString());
                cars = new DataTable();
                sc.Fill(cars);
                conn.Close();
            }
            foreach (DataRow row in cars.Rows)
            {
                CarThumbnail ct = new CarThumbnail(row, parentForm);
                flowLayoutPanel1.Controls.Add(ct);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PassApprove pa = new PassApprove(this);
            pa.Show();
        }

        private void hideChange()
        {
            groupBox1.Visible = false;
            nameChange.Visible = false;
            cellChange.Visible = false;
            sexChange.Visible = false;
            birthChange.Visible = false;
            addressChange.Visible = false;
            confirmBtn.Visible = false;
        }

        public void showChange()
        {
            groupBox1.Visible = true;
            nameChange.Visible = true;
            cellChange.Visible = true;
            sexChange.Visible = true;
            birthChange.Visible = true;
            addressChange.Visible = true;
            confirmBtn.Visible = true;

            nameChange.Text = user["full_name"].ToString();
            sexChange.Text = user["sex"].ToString();
            cellChange.Text = user["phone_num"].ToString();
            addressChange.Text = user["address"].ToString();
            birthChange.Value = Convert.ToDateTime(user["birthday"]);
            passwordChange.Text = user["password"].ToString();
            emailChange.Text = user["email"].ToString();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (nameChange.Text.Length > 2 && sexChange.Text.Length > 3 && cellChange.Text.Length == 9 && addressChange.Text.Length > 5 && emailChange.Text.Length > 10 && passwordChange.Text.Length >= 6)
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True"))
                {
                    conn.Open();
                    SqlCommand sc = new SqlCommand("UPDATE clients SET full_name = @full_name, phone_num = @num, sex = @sex, birthday = @birthday, address = @address, password = @password, email = @email WHERE client_id = @client_id", conn);
                    sc.Parameters.AddWithValue("@full_name", nameChange.Text);
                    sc.Parameters.AddWithValue("@num", Convert.ToInt32(cellChange.Text));
                    sc.Parameters.AddWithValue("@sex", sexChange.Text);
                    sc.Parameters.AddWithValue("@birthday", birthChange.Value);
                    sc.Parameters.AddWithValue("@address", addressChange.Text);
                    sc.Parameters.AddWithValue("@password", passwordChange.Text);
                    sc.Parameters.AddWithValue("@email", emailChange.Text);
                    sc.Parameters.AddWithValue("@client_id", Convert.ToInt32(idLabel.Text));

                    sc.ExecuteNonQuery();

                    conn.Close();
                }
                MessageBox.Show("Your info has been updated");
                hideChange();
                using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True"))
                {
                    conn.Open();
                    SqlDataAdapter sc = new SqlDataAdapter("SELECT * FROM clients WHERE client_id = @client_id", conn);
                    sc.SelectCommand.Parameters.AddWithValue("@client_id", user["client_id"].ToString());
                    DataTable temp = new DataTable();
                    sc.Fill(temp);
                    user = temp.Rows[0];
                    conn.Close();
                }
                update();
            } 
        }

        private void update()
        {
            nameLabel.Text = user["full_name"].ToString();
            idLabel.Text = user["client_id"].ToString();
            sexLabel.Text = user["sex"].ToString();
            string num = user["phone_num"].ToString();
            StringBuilder sb = new StringBuilder();
            sb.Append("+38(0");
            for (int i = 0; i < num.Length; i++)
            {
                if (i == 2)
                {
                    sb.Append(") ");
                }
                if (i == 5)
                {
                    sb.Append("-");
                }
                sb.Append(num[i]);
            }
            cellLabel.Text = sb.ToString();
            addressLabel.Text = user["address"].ToString();
            birthLabel.Text = Convert.ToDateTime(user["birthday"]).ToString("yyyy/MM/dd");

            refreshOrders();
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            int toDelete;
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                toDelete = (int)this.dataGridView1.SelectedRows[0].Cells[0].Value;
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);               

                using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True"))
                {
                    conn.Open();
                    SqlCommand sc = new SqlCommand("DELETE FROM orders WHERE order_id = @order_id", conn);
                    sc.Parameters.AddWithValue("@order_id", toDelete);
                    sc.ExecuteNonQuery();

                    conn.Close();
                }
                MessageBox.Show("Success");
            }                          
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            OrderPlaceForm opf = new OrderPlaceForm(user, "", "", 1000000, 700, 500000, Convert.ToDateTime("1980-12-12"), DateTime.Now);
            opf.Show();
            refreshOrders();
        }

        private void refreshOrders()
        {
            dataGridView1.DataSource = null;
            DataTable orders;
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sc = new SqlDataAdapter("SELECT * FROM orders WHERE client_id = @client_id", conn);
                sc.SelectCommand.Parameters.AddWithValue("@client_id", user["client_id"].ToString());
                orders = new DataTable();
                sc.Fill(orders);
                conn.Close();
            }
            //BindingSource SBind = new BindingSource();
            //SBind.DataSource = orders;
            
            dataGridView1.DataSource = orders;

            //dataGridView1.DataSource = SBind;
            dataGridView1.Refresh();
        }
    }
}
