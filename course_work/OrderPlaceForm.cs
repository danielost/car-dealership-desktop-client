using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_work
{
    public partial class OrderPlaceForm : Form
    {
        DataRow user;
        public OrderPlaceForm(DataRow user, string make, string model, int mileage, int priceFrom, int priceTo, DateTime dateFrom, DateTime dateTo)
        {
            InitializeComponent();
            this.user = user;
            makeTextBox.Text = make;
            modelTextBox.Text = model;
            maxMileage.Value = mileage;
            this.priceFrom.Text = priceFrom.ToString();
            this.priceTo.Text = priceFrom.ToString();
            this.yearFrom.Value = dateFrom;
            this.yearTo.Value = dateTo;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderPlaceForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void addCarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True"))
                {
                    conn.Open();
                    SqlCommand sc = new SqlCommand("INSERT INTO orders (client_id, make, model, color, price_from, price_to, mileage_to, year_from, year_to) VALUES (@client_id, @make, @model, @color, @price_from, @price_to, @mileage_to, @year_from, @year_to)", conn);
                    sc.Parameters.AddWithValue("@client_id", (int)user["client_id"]);
                    sc.Parameters.AddWithValue("@make", makeTextBox.Text);
                    sc.Parameters.AddWithValue("@model", modelTextBox.Text);
                    sc.Parameters.AddWithValue("@color", colorTextBox.Text);
                    sc.Parameters.AddWithValue("@price_from", priceFrom.Value);
                    sc.Parameters.AddWithValue("@price_to", priceTo.Value);
                    sc.Parameters.AddWithValue("@mileage_to", maxMileage.Value);
                    sc.Parameters.AddWithValue("@year_from", yearFrom.Value);
                    sc.Parameters.AddWithValue("@year_to", yearTo.Value);
                    sc.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("Success! Your order has been placed");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
