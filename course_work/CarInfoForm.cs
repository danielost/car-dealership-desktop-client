using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_work
{
    public partial class CarInfoForm : Form
    {
        DataRow currCar;
        DataRow currUser;
        DataRow seller;
        Main parentForm;
        DataTable features;
        public CarInfoForm(DataRow carInfo, DataRow user, Main mn)
        {
            InitializeComponent();
            historyGridView.Visible = false;
            currCar = carInfo;
            currUser = user;
            parentForm = mn;
            accidentLabel.Visible = false;
            nameLabel.Text = Convert.ToDateTime(carInfo["year"]).ToString("yyyy") + " " + carInfo["make"] + " " + carInfo["model"];
            carNameLittle.Text = Convert.ToDateTime(carInfo["year"]).ToString("yyyy") + " " + carInfo["make"] + " " + carInfo["model"];
            priceUsdLabel.Text = "$" + numDesigner(Convert.ToInt32(carInfo["car_price"]));
            priceUahLabel.Text = "₴" + numDesigner(Convert.ToInt32(carInfo["car_price"]) * 27);
            mileageLabel.Text = $"{numDesigner(Convert.ToInt32(carInfo["mileage"]))} miles driven";
            milLabel.Text = numDesigner(Convert.ToInt32(carInfo["mileage"]));
            plateLabel.Text = carInfo["plate"].ToString();
            vinLabel.Text = carInfo["VIN"].ToString();
            descLabel.Text = carInfo["description"].ToString();
            if (descLabel.Text == "")
            {
                descLabel.Text = "No description given";
            }
            dateAddedLabel.Text = Convert.ToDateTime(carInfo["date_added"]).ToString("dd/M/yyyy");

            if (!(carInfo["event_id"] is DBNull))
            {
                if (Convert.ToInt32(carInfo["event_id"]) == 1)
                {
                    accidentLabel.Visible = true;
                }
            }

            if (Convert.ToInt32(currCar["seller_id"]) != Convert.ToInt32(currUser["client_id"]))
            {
                editBtn.Visible = false;
                deactivateBtn.Visible = false;
            }

            if ((int)currUser["client_id"] == (int)currCar["seller_id"])
            {
                iconButton1.Visible = false;
                seeHisBtn.Location = new Point(12, 336);
                historyGridView.Location = new Point(13, 367);
            }
            fillUserInfo();
            updateHistory();
            updateCarInfo();
            updateFeatures();
        }

        private string numDesigner(int number)
        {
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;

            nfi.CurrencyDecimalSeparator = ",";
            nfi.CurrencyGroupSeparator = ".";
            nfi.CurrencySymbol = "";
            nfi.NumberDecimalDigits = 0;
            return Convert.ToDecimal(number).ToString("C", nfi);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to buy this car?", "Approval", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True"))
                {
                    conn.Open();
                    SqlCommand sc = new SqlCommand("INSERT INTO sellings VALUES (@vin, @client_id, @deal_date)", conn);
                    sc.Parameters.AddWithValue("@vin", currCar["VIN"].ToString());
                    sc.Parameters.AddWithValue("@client_id", Convert.ToInt32(currUser["client_id"]));
                    sc.Parameters.AddWithValue("@deal_date", DateTime.Now.ToString("yyyy-MM-dd"));                   
                    sc.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("Congrats!\nYou've just bought a new car.");
                DialogResult recordDialog = MessageBox.Show("Do you want to print an invoice?", "Approval", MessageBoxButtons.YesNo);
                if (recordDialog == DialogResult.Yes)
                {
                    using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PFD file|*.pdf", ValidateNames = true })
                    {
                        DataTable currSelling;
                        using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True"))
                        {
                            conn.Open();
                            SqlDataAdapter sc = new SqlDataAdapter("SELECT * FROM sellings WHERE VIN = @vin", conn);
                            sc.SelectCommand.Parameters.AddWithValue("@vin", currCar["VIN"].ToString());
                            currSelling = new DataTable();
                            sc.Fill(currSelling);
                            conn.Close();
                        }
                        sfd.FileName = "invoice_" + currCar["VIN"].ToString();
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4);
                            try
                            {
                                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

                                iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 22, iTextSharp.text.Font.BOLD);

                                PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                                doc.Open();

                                Paragraph titolo = new iTextSharp.text.Paragraph("Invoice number " + currCar["VIN"].ToString(), font);
                                titolo.SpacingAfter = 20;
                                doc.Add(titolo);

                                Paragraph info = new Paragraph("This document says, that on " + Convert.ToDateTime(currSelling.Rows[0]["deal_date"]).ToString("yyyy/MM/dd") + " " + currUser["full_name"].ToString() + " bought " + currCar["make"].ToString() + " " + currCar["model"].ToString() + " from " + seller["full_name"].ToString());
                                info.SpacingAfter = 20;
                                doc.Add(info);

                                PdfPTable pdfTable = new PdfPTable(7);
                                pdfTable.WidthPercentage = 98;

                                pdfTable.AddCell("VIN");
                                pdfTable.AddCell("Make");
                                pdfTable.AddCell("Model");
                                pdfTable.AddCell("Price");
                                pdfTable.AddCell("Date of the deal");
                                pdfTable.AddCell("Seller");
                                pdfTable.AddCell("Buyer");

                                pdfTable.AddCell(currCar["VIN"].ToString());
                                pdfTable.AddCell(currCar["make"].ToString());
                                pdfTable.AddCell(currCar["model"].ToString());
                                pdfTable.AddCell(currCar["car_price"].ToString());
                                pdfTable.AddCell(currSelling.Rows[0]["deal_date"].ToString());
                                pdfTable.AddCell(seller["full_name"].ToString());
                                pdfTable.AddCell(currUser["full_name"].ToString());

                                pdfTable.SpacingAfter = 20;

                                doc.Add(pdfTable);

                                Paragraph ending = new Paragraph("Date of deal: " + Convert.ToDateTime(currSelling.Rows[0]["deal_date"]).ToString("yyyy/MM/dd"));
                                doc.Add(ending);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                doc.Close();
                                MessageBox.Show("Success!");
                            }
                        }
                    }
                }
                    this.Close();
            }
        }

        public void fillUserInfo()
        {
            using(SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM clients WHERE client_id = @client_id", conn);
                sda.SelectCommand.Parameters.AddWithValue("@client_id", currCar["seller_id"].ToString());
                DataTable dt = new DataTable();
                sda.Fill(dt);
                seller = dt.Rows[0];
                conn.Close();
            }
            sellerName.Text = seller["full_name"].ToString();
            addressLabel.Text = seller["address"].ToString();
            
            string num = seller["phone_num"].ToString();
            StringBuilder sb = new StringBuilder();
            sb.Append("(0");
            for (int i = 0; i < num.Length; i++)
            {
                if (i == 2)
                {
                    sb.Append(") ");
                }
                if (i == 5)
                {
                    sb.Append("-");
                }
                sb.Append(num[i]);
            }
            phoneLabel.Text = sb.ToString();
        }

        private void seeHisBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (historyGridView.Visible == true)
            {
                historyGridView.Visible = false;
                seeHisBtn.Text = "See car history";
            }
            else
            {
                historyGridView.Visible = true;
                seeHisBtn.Text = "Hide car history";
            }
        }

        public void updateHistory()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT event_name, his_date FROM cars JOIN car_histories ON cars.VIN = car_histories.VIN JOIN events ON events.event_id = car_histories.event_id WHERE cars.VIN = @VIN", conn);
                sda.SelectCommand.Parameters.AddWithValue("@VIN", currCar["VIN"].ToString());
                DataTable dt = new DataTable();
                sda.Fill(dt);
                historyGridView.DataSource = null;
                historyGridView.DataSource = dt;
                conn.Close();
            }
            paintGrid();
        }

        public void updateCarInfo()
        {
            DataRow carBrief;
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT car_photo, cars.body_type_id, [type_name], [power], eng_cap, engine_type, color, transmission_name, engine_id FROM cars JOIN bodies ON cars.body_type_id = bodies.body_type_id JOIN engines ON cars.eng_type = engines.engine_id WHERE cars.VIN = @VIN", conn);
                sda.SelectCommand.Parameters.AddWithValue("@VIN", currCar["VIN"].ToString());
                DataTable dt = new DataTable();
                sda.Fill(dt);
                carBrief = dt.Rows[0];
                conn.Close();
            }
            typeLabel.Text = carBrief["type_name"].ToString();
            engLabel.Text = carBrief["eng_cap"] + "L. " + carBrief["power"].ToString() + " HP" + "/ " + carBrief["engine_type"].ToString() + " - " + carBrief["transmission_name"].ToString();
            colorLabel.Text = carBrief["color"].ToString();
        
            if (!(carBrief["car_photo"] is DBNull))
            {
                byte[] img = (byte[])(carBrief["car_photo"]);
                MemoryStream ms = new MemoryStream(img);
                //pictureBox1.Image = System.Drawing.Image.FromStream(ms);
                fillPictureBox(pictureBox1, (Bitmap)System.Drawing.Image.FromStream(ms));
            }
        }

        public void updateFeatures()
        {
            
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True"))
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT feature_desc, car_features.feature_id FROM cars JOIN car_features ON cars.VIN = car_features.VIN JOIN features ON features.feature_id = car_features.feature_id WHERE cars.VIN = @VIN", conn);
                sda.SelectCommand.Parameters.AddWithValue("@VIN", currCar["VIN"].ToString());
                features = new DataTable();
                sda.Fill(features);
                conn.Close();
            }
            if (features.Rows.Count < 1)
            {
                featuresLabel.Visible = false;
            }
            featuresLayoutPanel.Controls.Clear();
            foreach(DataRow dr in features.Rows)
            {
                Label feature = new Label();
                feature.Text = dr["feature_desc"].ToString();
                feature.ForeColor = Color.Gainsboro;
                feature.BorderStyle = BorderStyle.FixedSingle;
                feature.TextAlign = ContentAlignment.MiddleCenter;
                featuresLayoutPanel.Controls.Add(feature);
            }
        }

        private void deactivateBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this vehicle?", "Approval", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True"))
                {
                    conn.Open();
                    SqlCommand sc = new SqlCommand("DELETE FROM cars WHERE cars.VIN = @VIN", conn);
                    sc.Parameters.AddWithValue("@VIN", currCar["VIN"].ToString());
                    sc.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("Success!");
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            EditCarForm ecf = new EditCarForm(currCar, features, this);

            ecf.TopLevel = false;
            ecf.FormBorderStyle = FormBorderStyle.None;
            ecf.Dock = DockStyle.Fill;
            parentForm.childFormPanel.Controls.Add(ecf);
            parentForm.childFormPanel.Tag = ecf;
            ecf.BringToFront();
            ecf.Show();
        }

        private void paintGrid()
        {
            foreach (DataGridViewRow row in historyGridView.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
                row.DefaultCellStyle.ForeColor = Color.Gainsboro;
            }
            historyGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            historyGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gainsboro;
            historyGridView.EnableHeadersVisualStyles = false;
        }

        static public void fillPictureBox(PictureBox pbox, Bitmap bmp)
        {
            bool source_is_wider = (float)bmp.Width / bmp.Height > (float)pbox.Width / pbox.Height;

            var resized = new Bitmap(pbox.Width, pbox.Height);
            var g = Graphics.FromImage(resized);
            var dest_rect = new System.Drawing.Rectangle(0, 0, pbox.Width, pbox.Height);
            System.Drawing.Rectangle src_rect;

            if (source_is_wider)
            {
                float size_ratio = (float)pbox.Height / bmp.Height;
                int sample_width = (int)(pbox.Width / size_ratio);
                src_rect = new System.Drawing.Rectangle((bmp.Width - sample_width) / 2, 0, sample_width, bmp.Height);
            }
            else
            {
                float size_ratio = (float)pbox.Width / bmp.Width;
                int sample_height = (int)(pbox.Height / size_ratio);
                src_rect = new System.Drawing.Rectangle(0, (bmp.Height - sample_height) / 2, bmp.Width, sample_height);
            }

            g.DrawImage(bmp, dest_rect, src_rect, GraphicsUnit.Pixel);
            g.Dispose();

            pbox.Image = resized;
        }
    }
}
