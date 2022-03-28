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
    public partial class OrderedCars : Form
    {
        DataTable vins;
        DataRow user;
        Main parentForm;
        public OrderedCars(DataTable vins, DataRow user, Main mn)
        {
            InitializeComponent();
            parentForm = mn;
            this.vins = vins;
            this.user = user;
            Fill();
        }

        private void Fill()
        {
            DataTable cars;
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sc = new SqlDataAdapter("SELECT * FROM cars LEFT JOIN (SELECT car_histories.VIN, MIN(event_id) as event_id FROM car_histories GROUP BY car_histories.VIN) AS a ON cars.VIN = a.VIN JOIN engines ON cars.eng_type = engines.engine_id WHERE cars.VIN NOT IN (SELECT sellings.VIN FROM sellings) AND seller_id != @client_id", conn);
                sc.SelectCommand.Parameters.AddWithValue("@client_id", Convert.ToInt32(user["client_id"]));
                
                cars = new DataTable();
                sc.Fill(cars);
                conn.Close();
            }
            foreach (DataRow car in cars.Rows)
            {
                foreach (DataRow carVin in vins.Rows)
                {
                    if (car["VIN"].ToString() == carVin["VIN"].ToString())
                    {
                        CarThumbnail ct = new CarThumbnail(car, parentForm);
                        flowLayoutPanel1.Controls.Add(ct);
                    }
                }
            }
        }
    }
}
