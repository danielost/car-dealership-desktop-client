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
    public partial class ProfitChartForm : Form
    {
        public ProfitChartForm()
        {
            InitializeComponent();
        }

        private void ProfitChartForm_Load(object sender, EventArgs e)
        {
            profitChart.ChartAreas["ChartArea1"].BackColor = Color.Transparent;

            this.profitChart.ChartAreas[0].AxisX.LineColor = Color.White;
            this.profitChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            this.profitChart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;

            this.profitChart.ChartAreas[0].AxisY.LineColor = Color.White;
            this.profitChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
            this.profitChart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;

            DataTable profit;
            using (SqlConnection sqlconn = new SqlConnection(@"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True"))
            {
                sqlconn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT deal_date, SUM(car_price) AS Sum FROM cars JOIN sellings ON cars.VIN = sellings.VIN GROUP BY deal_date ORDER BY sum", sqlconn);
                profit = new DataTable();
                dataAdapter.Fill(profit);
                sqlconn.Close();
            }

            foreach (DataRow item in profit.Rows)
            {
                profitChart.Series["Day"].Points.AddXY(Convert.ToDateTime(item["deal_date"]).ToString("yyyy-MM-dd"), (int)item["Sum"]);
            }
        }
    }
}
