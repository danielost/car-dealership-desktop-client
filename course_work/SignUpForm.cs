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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AuthForm af = new AuthForm();
            af.Show();
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

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (passTextBox.Text == confPassTextBox.Text)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True"))
                    {
                        conn.Open();
                        SqlCommand sc = new SqlCommand("INSERT INTO clients (full_name, phone_num, sex, birthday, address, password, email) VALUES (@full_name, @phone_num, @sex, @birthday, @address, @password, @email)", conn);
                        sc.Parameters.AddWithValue("@full_name", nameTextBox.Text);
                        sc.Parameters.AddWithValue("@phone_num", cellTextBox.Text);
                        sc.Parameters.AddWithValue("@sex", sexComboBox.Text);
                        sc.Parameters.AddWithValue("@birthday", birthDateTimePicker.Value);
                        sc.Parameters.AddWithValue("@address", addressTextBox.Text);
                        sc.Parameters.AddWithValue("@email", mailTextBox.Text);
                        sc.Parameters.AddWithValue("@password", passTextBox.Text);

                        sc.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Account created.\nPlease sign in.");
                        this.Close();
                        AuthForm af = new AuthForm();
                        af.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Passwords don't match");
            }
        }
    }
}
