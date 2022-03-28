using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work
{
    public class GetData
    {
        const string connectionString = @"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True";

        public DataTable GetDataTable(string query)
        {
            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlconn);
            //SELECT * FROM cars LEFT JOIN car_histories ON cars.VIN = car_histories.VIN JOIN engines ON cars.eng_type = engines.engine_id
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            sqlconn.Close();
            return dt;
        } 
    }
}
