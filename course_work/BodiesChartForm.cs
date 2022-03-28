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
    public partial class BodiesChartForm : Form
    {
        public BodiesChartForm()
        {
            InitializeComponent();
        }

        private void BodiesChartForm_Load(object sender, EventArgs e)
        {
            bodiesChart.ChartAreas["ChartArea1"].BackColor = Color.Transparent;

            this.bodiesChart.ChartAreas[0].AxisX.LineColor = Color.White;
            this.bodiesChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            bodiesChart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;

            bodiesChart.ChartAreas[0].AxisY.LineColor = Color.White;
            bodiesChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
            bodiesChart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;

            DataTable carBodies;
            using (SqlConnection sqlconn = new SqlConnection(@"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True"))
            {
                sqlconn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT type_name, COUNT(cars.VIN) AS amount FROM cars JOIN bodies ON cars.body_type_id = bodies.body_type_id JOIN sellings ON cars.VIN = sellings.VIN GROUP BY type_name ORDER BY amount", sqlconn);
                carBodies = new DataTable();
                dataAdapter.Fill(carBodies);
                sqlconn.Close();
            }

            foreach (DataRow item in carBodies.Rows)
            {
                bodiesChart.Series["bodyType"].Points.AddXY(item["type_name"].ToString(), (int)item["amount"]);
            }
        }
    }
}
