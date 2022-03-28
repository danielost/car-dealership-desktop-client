using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace course_work
{
    public static class FillChart
    { 
        public static Chart Fill(Chart chart, string query)
        {
            DataTable dt;
            using (SqlConnection sqlconn = new SqlConnection(@"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True"))
            {
                sqlconn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT type_name, COUNT(VIN) AS amount FROM cars JOIN bodies ON cars.body_type_id = bodies.body_type_id GROUP BY type_name", sqlconn);
                dt = new DataTable();
                dataAdapter.Fill(dt);
                sqlconn.Close();
            }

            foreach (DataRow item in dt.Rows)
            {
                chart.Series[0].Points.AddXY(item[0].ToString(), (int)item[1]);
            }
            return chart;
        }
    }
}
