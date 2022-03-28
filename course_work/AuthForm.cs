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
    public partial class AuthForm : Form
    {
        const string connectionString = @"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True";
        public AuthForm()
        {
            InitializeComponent();          
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (passTextBox.UseSystemPasswordChar == true)
            {
                passTextBox.UseSystemPasswordChar = false;
                iconButton3.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else
            {
                passTextBox.UseSystemPasswordChar = true;
                iconButton3.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand sc = new SqlCommand("SELECT * FROM clients WHERE email = @email AND password = @password", conn);
                sc.Parameters.AddWithValue("@email", mailTextBox.Text);
                sc.Parameters.AddWithValue("@password", passTextBox.Text);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("NO");
                }
                else
                {
                    this.Hide();
                    Main mn = new Main(dt.Rows[0]);
                    mn.Show();
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand sc = new SqlCommand("SELECT * FROM clients WHERE email = @email AND password = @password", conn);
                sc.Parameters.AddWithValue("@email", "kjude@gmail.com");
                sc.Parameters.AddWithValue("@password", "qwerty");
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                this.Hide();
                Main mn = new Main(dt.Rows[0]);
                mn.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm suf = new SignUpForm();
            suf.Show();
            this.Hide();
        }
    }
}
