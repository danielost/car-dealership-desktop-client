using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_work
{
    public partial class EditCarForm : Form
    {
        DataRow currCar;
        DataTable features;
        DataTable events;
        //DataTable selectedFeatures;
        string imgLocation;
        CheckBox[] checkBoxes;
        bool imgChanged;
        CarInfoForm parentForm; 
        public EditCarForm(DataRow carInfo, DataTable features, CarInfoForm cif)
        {
            InitializeComponent();
            parentForm = cif;
            imgChanged = false;
            currCar = carInfo;
            this.features = features;
            if (!(carInfo["car_photo"] is DBNull))
            {
                byte[] img = (byte[])(carInfo["car_photo"]);
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }
            checkBoxes = new CheckBox[] {
                leatherCheck,
                sunroofCheck,
                heatedSeatsCheck,
                backupCheck,
                navSysCheck,
                bluetoothCheck,
                remoteCheck,
                blindCheck,
                thirdCheck,
                appleCheck,
                acCheck
            };
            updateEvents();
            updateFeatures();
            updateCarInfo();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uploadPhotoBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                imgLocation = ofd.FileName.ToString();
                imgChanged = true;
            }
        }

        private void updateEvents()
        {
            
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT event_name, car_histories.event_id, his_date FROM cars JOIN car_histories ON cars.VIN = car_histories.VIN JOIN events ON events.event_id = car_histories.event_id WHERE cars.VIN = @VIN", conn);
                sda.SelectCommand.Parameters.AddWithValue("@VIN", currCar["VIN"].ToString());
                events = new DataTable();
                sda.Fill(events);
                conn.Close();
            }
            foreach (DataRow item in events.Rows)
            {
                eventsDataGridView.Rows.Add(item["event_name"].ToString(), Convert.ToDateTime(item["his_date"]).ToString("yyyy-MM-dd"));
            }
        }

        private void updateFeatures()
        {         
            foreach (DataRow item in features.Rows)
            {
                checkBoxes[Convert.ToInt32(item["feature_id"]) - 1].Checked = true;
            }
        }

        private void addEventBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //if (eventTypeComboBox.Text != "Road accident")
                //{
                //    events.Add(2, eventDateTimePicker.Value);
                //}
                //else
                //{
                //    events.Add(1, eventDateTimePicker.Value);
                //}
                eventsDataGridView.Rows.Add(eventTypeComboBox.Text, eventDateTimePicker.Value.ToString("yyyy/MM/dd"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (this.eventsDataGridView.SelectedRows.Count > 0)
            {
                //if (eventsDataGridView.SelectedRows[0].Cells[0].Value.ToString() == "Road accident")
                //{
                //    events.Remove(1);
                //}
                //else
                //{
                //    events.Remove(2);
                //}
                eventsDataGridView.Rows.RemoveAt(this.eventsDataGridView.SelectedRows[0].Index);
            }
        }

        private void updateCarInfo()
        {
            makeTextBox.Text = currCar["make"].ToString();
            modelTextBox.Text = currCar["model"].ToString();
            yearTimePicker.Value = Convert.ToDateTime(currCar["year"]);
            mileageTextBox.Text = currCar["mileage"].ToString();
            //
            capTextBox.Text = currCar["eng_cap"].ToString();
            engineComboBox.SelectedIndex = Convert.ToInt32(currCar["engine_id"]) - 1;
            bodyComboBox.SelectedIndex = Convert.ToInt32(currCar["body_type_id"]) - 1;
            colorTextBox.Text = currCar["color"].ToString();
            transTextBox.Text = currCar["transmission_name"].ToString();
            priceTextBox.Text = currCar["car_price"].ToString();
            descTextBox.Text = currCar["description"].ToString();
            powerTextBox.Text = currCar["power"].ToString();
        }

        private void EditCarForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'car_dealership_fullDataSet.bodies' table. You can move, or remove it, as needed.
            this.bodiesTableAdapter.Fill(this.car_dealership_fullDataSet.bodies);
            // TODO: This line of code loads data into the 'car_dealership_fullDataSet.engines' table. You can move, or remove it, as needed.
            this.enginesTableAdapter.Fill(this.car_dealership_fullDataSet.engines);
            // TODO: This line of code loads data into the 'car_dealership_fullDataSet.events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.car_dealership_fullDataSet.events);

        }

        private void addCarBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Update?", "Approval", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //to create a checker in the future
                bool checker = true;
                if (checker)
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True"))
                    {
                        try
                        {
                            conn.Open();
                            string query = "UPDATE cars SET make = @make, model = @model, year = @year, mileage = @mileage, eng_cap = @eng_cap," +
                            "eng_type = @eng_type, body_type_id = @body_type_id, color = @color, power = @power, description = @desc, car_price = @price, transmission_name = @trans";
                            if (imgChanged)
                            {
                                query += ", car_photo = @photo WHERE VIN = @vin";
                            }
                            else
                            {
                                query += " WHERE VIN = @vin";
                            }

                            SqlCommand cs = new SqlCommand(query, conn);

                            cs.Parameters.AddWithValue("@vin", currCar["VIN"].ToString());
                            cs.Parameters.AddWithValue("@make", makeTextBox.Text);
                            cs.Parameters.AddWithValue("@model", modelTextBox.Text);
                            cs.Parameters.AddWithValue("@year", yearTimePicker.Value);
                            cs.Parameters.AddWithValue("@mileage", mileageTextBox.Text);
                            cs.Parameters.AddWithValue("@eng_cap", capTextBox.Text);
                            //changed
                            cs.Parameters.AddWithValue("@eng_type", (engineComboBox.SelectedIndex + 1));
                            //changed
                            cs.Parameters.AddWithValue("@body_type_id", (bodyComboBox.SelectedIndex + 1));
                            cs.Parameters.AddWithValue("@color", colorTextBox.Text);
                            cs.Parameters.AddWithValue("@power", powerTextBox.Text);
                            cs.Parameters.AddWithValue("@desc", descTextBox.Text);
                            cs.Parameters.AddWithValue("@price", priceTextBox.Text);
                            cs.Parameters.AddWithValue("@trans", transTextBox.Text);

                            if (imgChanged)
                            {
                                byte[] images = null;
                                if (imgLocation != null)
                                {
                                    FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                                    BinaryReader brs = new BinaryReader(stream);
                                    images = brs.ReadBytes((int)stream.Length);
                                }
                                cs.Parameters.AddWithValue("@photo", images);
                            }
                            

                            cs.ExecuteNonQuery();

                            //events
                            SqlCommand delEvents = new SqlCommand("DELETE FROM car_histories WHERE VIN = @vin", conn);
                            delEvents.Parameters.AddWithValue("@vin", currCar["VIN"].ToString());
                            delEvents.ExecuteNonQuery();

                            SqlCommand csEvents = new SqlCommand("INSERT INTO car_histories (VIN, event_id, his_date) VALUES (@vin, @event_id, @date)", conn);
                            csEvents.Parameters.AddWithValue("@vin", currCar["VIN"].ToString());
                            csEvents.Parameters.AddWithValue("@event_id", 1);
                            csEvents.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                            foreach (DataGridViewRow row in eventsDataGridView.Rows)
                            {
                                if (row.Cells["EventCol"].Value != null && row.Cells["DateCol"].Value != null)
                                {
                                    if (row.Cells["EventCol"].Value.ToString() == "Road accident")
                                    {
                                        csEvents.Parameters["@event_id"].Value = 1;
                                    }
                                    else
                                    {
                                        csEvents.Parameters["@event_id"].Value = 2;
                                    }
                                    csEvents.Parameters["@date"].Value = row.Cells["DateCol"].Value;
                                    csEvents.ExecuteNonQuery();
                                }
                                
                            }

                            //features
                            SqlCommand delFeatures = new SqlCommand("DELETE FROM car_features WHERE VIN = @vin", conn);
                            delFeatures.Parameters.AddWithValue("@vin", currCar["VIN"].ToString());
                            delFeatures.ExecuteNonQuery();

                            SqlCommand csFeatures = new SqlCommand("INSERT INTO car_features (feature_id, VIN) VALUES (@feature_id, @VIN)", conn);
                            csFeatures.Parameters.AddWithValue("@VIN", currCar["VIN"].ToString());
                            csFeatures.Parameters.AddWithValue("@feature_id", 1);
                            for (int i = 0; i < checkBoxes.Length; i++)
                            {
                                if (checkBoxes[i].Checked)
                                {
                                    csFeatures.Parameters["@feature_id"].Value = (i + 1);
                                    csFeatures.ExecuteNonQuery();
                                }
                            }

                            conn.Close();
                            MessageBox.Show("Your car has been succesfully updated.\nHave a nice day!");
                            parentForm.updateCarInfo();
                            parentForm.updateFeatures();
                            parentForm.updateHistory();
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }
    }
}
