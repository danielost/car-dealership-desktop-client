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
    public partial class UnluckyCarMakesChart : Form
    {
        public UnluckyCarMakesChart()
        {
            InitializeComponent();
        }

        private void UnluckyCarMakesChart_Load(object sender, EventArgs e)
        {
            carMakesChart.ChartAreas["ChartArea1"].BackColor = Color.Transparent;

            this.carMakesChart.ChartAreas[0].AxisX.LineColor = Color.White;
            this.carMakesChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            this.carMakesChart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;

            this.carMakesChart.ChartAreas[0].AxisY.LineColor = Color.White;
            this.carMakesChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
            this.carMakesChart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;

            DataTable carMakes;
            using (SqlConnection sqlconn = new SqlConnection(@"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True"))
            {
                sqlconn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT make, COUNT(cars.VIN) as amount FROM cars JOIN car_histories ON cars.VIN = car_histories.VIN WHERE event_id = 1 GROUP BY make ORDER BY amount", sqlconn);
                carMakes = new DataTable();
                dataAdapter.Fill(carMakes);
                sqlconn.Close();
            }

            foreach (DataRow item in carMakes.Rows)
            {
                carMakesChart.Series["carMake"].Points.AddXY(item["make"].ToString(), (int)item["amount"]);
            }
        }
    }
}
