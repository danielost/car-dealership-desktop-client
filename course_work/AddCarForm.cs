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
    public partial class AddCarForm : Form
    {
        Dictionary<int, DateTime> events;
        string imgLocation;
        DataRow user;
        Main parentForm;
        CheckBox[] features;
        bool imgChanged;
        public AddCarForm(DataRow user, Main mn)
        {
            InitializeComponent();
            transTextBox.SelectedIndex = 0;
            parentForm = mn;
            this.user = user;
            events = new Dictionary<int, DateTime>();
            eventDateTimePicker.Value = DateTime.Now;
            yearTimePicker.Value = DateTime.Now;
            imgChanged = false;
            features = new CheckBox[] {
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

        private void AddCarForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'car_dealership_fullDataSet.engines' table. You can move, or remove it, as needed.
            this.enginesTableAdapter.Fill(this.car_dealership_fullDataSet.engines);
            // TODO: This line of code loads data into the 'car_dealership_fullDataSet.bodies' table. You can move, or remove it, as needed.
            this.bodiesTableAdapter.Fill(this.car_dealership_fullDataSet.bodies);
            // TODO: This line of code loads data into the 'car_dealership_fullDataSet.events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.car_dealership_fullDataSet.events);
        }

        private void addCarBtn_Click(object sender, EventArgs e)
        {


            if (checkFilling())
            {
                DialogResult dialogResult = MessageBox.Show("Add the car to the store so everybody can see it?", "Approval", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True"))
                    {
                        try
                        {
                            conn.Open();
                            SqlCommand cs = new SqlCommand("INSERT INTO cars VALUES (@vin, @make, @model, @year, @mileage, @seller_id, @plate, @eng_cap," +
                            "@eng_type, @body_type_id, @color, @power, @desc, @date_added, @price, @photo, @trans)", conn);

                            cs.Parameters.AddWithValue("@vin", vinTextBox.Text.ToUpper());
                            cs.Parameters.AddWithValue("@make", makeTextBox.Text);
                            cs.Parameters.AddWithValue("@model", modelTextBox.Text);
                            cs.Parameters.AddWithValue("@year", yearTimePicker.Value);
                            cs.Parameters.AddWithValue("@mileage", mileageTextBox.Text);
                            cs.Parameters.AddWithValue("@seller_id", user["client_id"]);
                            cs.Parameters.AddWithValue("@plate", plateTextBox.Text);
                            cs.Parameters.AddWithValue("@eng_cap", capTextBox.Text);
                            //changed
                            cs.Parameters.AddWithValue("@eng_type", (engineComboBox.SelectedIndex + 1));
                            //changed
                            cs.Parameters.AddWithValue("@body_type_id", (bodyComboBox.SelectedIndex + 1));
                            cs.Parameters.AddWithValue("@color", colorTextBox.Text);
                            cs.Parameters.AddWithValue("@power", powerTextBox.Text);
                            cs.Parameters.AddWithValue("@desc", descTextBox.Text);
                            cs.Parameters.AddWithValue("@date_added", DateTime.Now);
                            cs.Parameters.AddWithValue("@price", priceTextBox.Text);
                            cs.Parameters.AddWithValue("@trans", transTextBox.Text);

                            byte[] images = null;
                            if (imgLocation != null)
                            {
                                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                                BinaryReader brs = new BinaryReader(stream);
                                images = brs.ReadBytes((int)stream.Length);
                            }
                            cs.Parameters.AddWithValue("@photo", images);

                            cs.ExecuteNonQuery();

                            //events
                            SqlCommand csEvents = new SqlCommand("INSERT INTO car_histories (VIN, event_id, his_date) VALUES (@vin, @event_id, @date)", conn);
                            csEvents.Parameters.AddWithValue("@vin", vinTextBox.Text);
                            csEvents.Parameters.AddWithValue("@event_id", 1);
                            csEvents.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                            foreach (DataGridViewRow row in eventsDataGridView.Rows)
                            {
                                if (row.Cells["EventCol"].Value != null && row.Cells["DateCol"].Value != null) {
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
                                //More code here
                            }
                            //foreach (var item in events)
                            //{
                            //    csEvents.Parameters["@event_id"].Value = item.Key;
                            //    csEvents.Parameters["@date"].Value = item.Value.ToString("yyyy-MM-dd");
                            //    csEvents.ExecuteNonQuery();
                            //}

                            //features
                            SqlCommand csFeatures = new SqlCommand("INSERT INTO car_features (feature_id, VIN) VALUES (@feature_id, @VIN)", conn);
                            csFeatures.Parameters.AddWithValue("@VIN", vinTextBox.Text);
                            csFeatures.Parameters.AddWithValue("@feature_id", 1);
                            for (int i = 0; i < features.Length; i++)
                            {
                                if (features[i].Checked)
                                {
                                    csFeatures.Parameters["@feature_id"].Value = (i + 1);
                                    csFeatures.ExecuteNonQuery();
                                }
                            }

                            conn.Close();
                            MessageBox.Show("Your car has been succesfully added to the store.\nHave a nice day!");
                            parentForm.OpenChildForm(new Cars(parentForm));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                } 
            }
            else
            {
                MessageBox.Show("Please fill out each and every field and set a photo\n(Features, description and history are not necessary)", "Error");
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
                eventsDataGridView.Rows.Add(eventTypeComboBox.Text, eventDateTimePicker.Value.ToString("yyyy-MM-dd"));
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

        private bool checkFilling()
        {
            return imgChanged && makeTextBox.Text != "" && modelTextBox.Text != "" && mileageTextBox.Text != "" && capTextBox.Text != "" && colorTextBox.Text != "" && powerTextBox.Text != "" && priceTextBox.Text != "" && vinTextBox.Text != "" && plateTextBox.Text != "";
        }

        private void mileageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void capTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void powerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            const string src = "abcdefghijklmnopqrstuvwxyz0123456789";
            int length = 17;
            var sb = new StringBuilder();
            Random RNG = new Random();
            for (var i = 0; i < length; i++)
            {
                var c = src[RNG.Next(0, src.Length)];
                sb.Append(c);
            }
            vinTextBox.Text = sb.ToString().ToUpper();
        }
    }
}
