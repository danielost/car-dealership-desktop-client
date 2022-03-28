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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace course_work
{
    public partial class Main : Form
    {
        public DataRow user;
        DataTable orders;
        DataTable ordersId;
        DataTable vins;
        DataTable filter;
        public Main(DataRow user)
        {
            InitializeComponent();
            this.user = user; 
            customizeDesign();
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            notifyBtn.Visible = false;
            orderCheck();
            OpenChildForm(new Cars(this));
        }

        #region SideBarFunctions
        private void customizeDesign()
        {
            carsBtnDropdown.Visible = false;
            statBtnDropdown.Visible = false;
            profileBtnDropdown.Visible = false;
        }

        private void hideSubMenu()
        {
            if (carsBtnDropdown.Visible == true)
            {
                carsBtnDropdown.Visible = false;
            }
            if (statBtnDropdown.Visible == true)
            {
                statBtnDropdown.Visible = false;
            }
            if (profileBtnDropdown.Visible == true)
            {
                profileBtnDropdown.Visible = false;
            }
        }

        private void showSubMenu(Panel subPanel)
        {
            if (subPanel.Visible == false)
            {
                hideSubMenu();
                subPanel.Visible = true;
            }
            else
            {
                subPanel.Visible = false;
            }
        }

        Form currentChildForm = null;
        public void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            currWindow.Text = childForm.Text;
        }

        private void orderCheck()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sc = new SqlDataAdapter("SELECT * FROM cars WHERE make IN (SELECT make FROM orders WHERE client_id = @client_id) AND model IN (SELECT model FROM orders WHERE client_id = @client_id) AND color IN (SELECT color FROM orders WHERE client_id = @client_id) AND seller_id != @client_id AND cars.VIN NOT IN (SELECT VIN FROM sellings)", conn);
                sc.SelectCommand.Parameters.AddWithValue("@client_id", user["client_id"].ToString());
                orders = new DataTable();
                sc.Fill(orders);

                SqlDataAdapter scFilter = new SqlDataAdapter("SELECT * FROM orders WHERE client_id = 1", conn);
                scFilter.SelectCommand.Parameters.AddWithValue("@client_id", user["client_id"].ToString());
                filter = new DataTable();
                scFilter.Fill(filter);
                conn.Close();
            }

            vins = new DataTable();
            vins.Columns.Add("VIN");
            ordersId = new DataTable();
            ordersId.Columns.Add("order_id");

            foreach (DataRow order in orders.Rows)
            {
                bool check = false;
                foreach (DataRow filter in filter.Rows)
                {
                    if ((int)order["car_price"] >= (int)filter["price_from"] && (int)order["car_price"] <= (int)filter["price_to"] && (DateTime)order["year"] >= (DateTime)filter["year_from"] && (DateTime)order["year"] <= (DateTime)filter["year_to"] && (int)order["mileage"] <= (int)filter["mileage_to"])
                    {
                        check = true;
                        ordersId.Rows.Add(filter["order_id"]);
                    }
                }
                if (check)
                {
                    vins.Rows.Add(order["VIN"]);
                    notifyBtn.Visible = true;
                }
            }


            //using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True"))
            //{
            //    conn.Open();
            //    SqlDataAdapter sc = new SqlDataAdapter("SELECT * FROM orders WHERE client_id = @client_id", conn);
            //    sc.SelectCommand.Parameters.AddWithValue("@client_id", user["client_id"].ToString());
            //    orders = new DataTable();
            //    sc.Fill(orders);
            //    conn.Close();
            //}
            //if (orders.Rows.Count > 0)
            //{
            //    res = new DataTable();
            //    res.Columns.Add("VIN");
            //    using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True"))
            //    {

            //        conn.Open();
            //        SqlDataAdapter sc = new SqlDataAdapter("SELECT VIN, make, model, color, year, car_price, mileage FROM cars WHERE cars.VIN NOT IN (SELECT VIN FROM sellings) AND seller_id != @client_id", conn);
            //        sc.SelectCommand.Parameters.AddWithValue("@client_id", Convert.ToInt32(orders.Rows[0]["client_id"]));

            //        foreach (DataRow order in orders.Rows)
            //        {
            //            //sc.SelectCommand.Parameters.AddWithValue("@client_id", Convert.ToInt32(orders.Rows[0]["client_id"]));
            //            sc.SelectCommand.Parameters["@client_id"].Value = Convert.ToInt32(order["client_id"]);

            //            cars = new DataTable();
            //            sc.Fill(cars);
            //            foreach (DataRow car in cars.Rows)
            //            {
            //                if (car["make"].ToString() == order["make"].ToString() && car["model"].ToString() == order["model"].ToString() && car["color"].ToString() == order["color"].ToString() && DateTime.Compare(Convert.ToDateTime(car["year"]), Convert.ToDateTime(order["year_to"])) > 0 && DateTime.Compare(Convert.ToDateTime(car["year"]), Convert.ToDateTime(order["year_from"])) > 0 && Convert.ToInt32(car["car_price"]) >= Convert.ToInt32(order["price_from"]) && Convert.ToInt32(car["car_price"]) <= Convert.ToInt32(order["price_to"]) && Convert.ToInt32(car["mileage"]) <= Convert.ToInt32(order["mileage_to"]))
            //                {
            //                    res.Rows.Add(car["VIN"].ToString());
            //                }
            //            }
            //        }
            //        conn.Close();

            //        if (res.Rows.Count > 0)
            //        {
            //            notifyBtn.Visible = true;
            //        }
            //    }
            //}
        }

        #endregion

        #region SideBarBtns
        #region MainBtns
        private void homeBtn_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            currWindow.Text = "Home";
        }

        private void carsBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(carsBtnDropdown);
        }

        private void statisticsBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(statBtnDropdown);
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            showSubMenu(profileBtnDropdown);
        }


        #endregion
        #region SubBtns
        #region CarSubs
        private void seeAllCarsBtn_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Cars cf = new Cars(this);
            OpenChildForm(cf);
        }
        private void seeUsedCarsBtn_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void seeNewCarsBtn_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion
        #region StatsBtns
        private void popularBodiesBtn_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            OpenChildForm(new BodiesChartForm());
        }

        private void profitDaysBtn_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            OpenChildForm(new ProfitChartForm());
        }

        private void unluckyMakesBtn_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            OpenChildForm(new UnluckyCarMakesChart());
        }

        private void gendersBtn_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            OpenChildForm(new GenderChartForm());
        }

        private void sellingsRecordBtn_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            OpenChildForm(new RecordForm(user));

        }
        #endregion
        #region ProfileBtns

        private void seeProfileBtn_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            OpenChildForm(new Profile(user, this, 0));
        }

        private void editProfileBtn_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            OpenChildForm(new Profile(user, this, 1));
        }

        #endregion

        #endregion
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AuthForm af = new AuthForm();
            af.Show();
        }
        #endregion

        #region ConrolsResize
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam); 
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }




        #endregion

        private void notifyBtn_Click(object sender, EventArgs e)
        {
            OrderedCars oc = new OrderedCars(vins, user, this);
            OpenChildForm(oc);
            notifyBtn.Visible = false;

            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand sc = new SqlCommand("DELETE FROM orders WHERE order_id = @order_id", conn);
                sc.Parameters.AddWithValue("@order_id", 0);

                foreach (DataRow row in ordersId.Rows)
                {
                    sc.Parameters["@order_id"].Value = row["order_id"].ToString();
                    sc.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HelpForm());
        }
    }
}

