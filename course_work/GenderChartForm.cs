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
    public partial class GenderChartForm : Form
    {
        public GenderChartForm()
        {
            InitializeComponent();
        }

        private void GenderChartForm_Load(object sender, EventArgs e)
        {
            
            //gender
            genderChart.ChartAreas["ChartArea1"].BackColor = Color.Transparent;

            genderChart.ChartAreas[0].AxisX.LineColor = Color.White;
            genderChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            genderChart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;

            genderChart.ChartAreas[0].AxisY.LineColor = Color.White;
            genderChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
            genderChart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;

            //male cars
            maleMakesChart.ChartAreas["ChartArea1"].BackColor = Color.Transparent;

            maleMakesChart.ChartAreas[0].AxisX.LineColor = Color.White;
            maleMakesChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            maleMakesChart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;

            maleMakesChart.ChartAreas[0].AxisY.LineColor = Color.White;
            maleMakesChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
            maleMakesChart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;

            //female cars
            femaleMakesChart.ChartAreas["ChartArea1"].BackColor = Color.Transparent;

            femaleMakesChart.ChartAreas[0].AxisX.LineColor = Color.White;
            femaleMakesChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            femaleMakesChart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;

            femaleMakesChart.ChartAreas[0].AxisY.LineColor = Color.White;
            femaleMakesChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
            femaleMakesChart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;

            DataTable genders;
            DataTable maleCars;
            DataTable femaleCars;
            using (SqlConnection sqlconn = new SqlConnection(@"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True"))
            {
                sqlconn.Open();

                SqlDataAdapter dataAdapterGen = new SqlDataAdapter("SELECT sex, COUNT(clients.client_id) AS amount FROM clients JOIN sellings ON clients.client_id = sellings.client_id GROUP BY sex", sqlconn);
                genders = new DataTable();
                dataAdapterGen.Fill(genders);

                SqlDataAdapter dataAdapterMale = new SqlDataAdapter("SELECT make, COUNT(cars.VIN) AS amount FROM cars JOIN sellings ON cars.VIN = sellings.VIN JOIN clients ON clients.client_id = sellings.client_id WHERE clients.sex = 'Male' GROUP BY make ORDER BY amount", sqlconn);
                maleCars = new DataTable();
                dataAdapterMale.Fill(maleCars);

                SqlDataAdapter dataAdapterFemale = new SqlDataAdapter("SELECT make, COUNT(cars.VIN) AS amount FROM cars JOIN sellings ON cars.VIN = sellings.VIN JOIN clients ON clients.client_id = sellings.client_id WHERE clients.sex = 'Female' GROUP BY make ORDER BY amount", sqlconn);
                femaleCars = new DataTable();
                dataAdapterFemale.Fill(femaleCars);

                sqlconn.Close();
            }

            foreach (DataRow item in genders.Rows)
            {
                genderChart.Series["Sex"].Points.AddXY(item["sex"].ToString(), (int)item["amount"]);
            }

            foreach (DataRow item in maleCars.Rows)
            {
                maleMakesChart.Series["carMake"].Points.AddXY(item["make"].ToString(), (int)item["amount"]);
            }

            foreach(DataRow item in femaleCars.Rows)
            {
                femaleMakesChart.Series["carMake"].Points.AddXY(item["make"].ToString(), (int)item["amount"]);
            }


        }
    }
}
