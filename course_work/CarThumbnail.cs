using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_work
{
    public partial class CarThumbnail : UserControl
    {
        DataRow currCar;
        Main parentForm;
        public CarThumbnail(DataRow carInfo, Main main)
        {
            InitializeComponent();
            currCar = carInfo;
            parentForm = main;
            accidentLabel.Visible = false;
            nameLabel.Text = Convert.ToDateTime(carInfo["year"]).ToString("yyyy") + " " + carInfo["make"] + " " + carInfo["model"];
            priceUsdLabel.Text = "$" + numDesigner(Convert.ToInt32(carInfo["car_price"]));
            priceUahLabel.Text = "₴" + numDesigner(Convert.ToInt32(carInfo["car_price"]) * 27);
            mileageLabel.Text = numDesigner(Convert.ToInt32(carInfo["mileage"]));
            fuelLabel.Text = carInfo["engine_type"].ToString();
            transLabel.Text = carInfo["transmission_name"].ToString();
            plateLabel.Text = carInfo["plate"].ToString();
            vinLabel.Text = carInfo["VIN"].ToString();
            string[] desc = carInfo["description"].ToString().Split(' ');
            descLabel.Text = " ";
            for (int i = 0; i < 6 && i < desc.Length; i++)
            {
                descLabel.Text += desc[i];
                if (i != 5 && i != desc.Length - 1)
                {
                    descLabel.Text += " ";
                }
            }
            descLabel.Text += "...";
            //descLabel.Text = carInfo["description"].ToString();
            dateAddedLabel.Text = Convert.ToDateTime(carInfo["date_added"]).ToString("dd/M/yyyy");
            if (!(carInfo["event_id"] is DBNull))
            {
                if (Convert.ToInt32(carInfo["event_id"]) == 1)
                {
                    accidentLabel.Visible = true;
                }               
            }

            
            if (!(carInfo["car_photo"] is DBNull))
            {
                byte[] img = (byte[])(carInfo["car_photo"]);
                MemoryStream ms = new MemoryStream(img);
                //pictureBox1.Image = Image.FromStream(ms);
                fillPictureBox(pictureBox1, (Bitmap)Image.FromStream(ms));
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //parentForm.OpenChildForm(new CarInfoForm(currCar));
            CarInfoForm childForm = new CarInfoForm(currCar, parentForm.user, parentForm);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            parentForm.childFormPanel.Controls.Add(childForm);
            parentForm.childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //parentForm.currWindow.Text = childForm.Text;
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {
            parentForm.OpenChildForm(new CarInfoForm(currCar, parentForm.user, parentForm));
        }

        private void nameLabel_MouseEnter(object sender, EventArgs e)
        {
            nameLabel.ForeColor = Color.White;
        }

        private void nameLabel_MouseLeave(object sender, EventArgs e)
        {
            nameLabel.ForeColor = Color.Gainsboro;
        }

        static public void fillPictureBox(PictureBox pbox, Bitmap bmp)
        {
            bool source_is_wider = (float)bmp.Width / bmp.Height > (float)pbox.Width / pbox.Height;

            var resized = new Bitmap(pbox.Width, pbox.Height);
            var g = Graphics.FromImage(resized);
            var dest_rect = new Rectangle(0, 0, pbox.Width, pbox.Height);
            Rectangle src_rect;

            if (source_is_wider)
            {
                float size_ratio = (float)pbox.Height / bmp.Height;
                int sample_width = (int)(pbox.Width / size_ratio);
                src_rect = new Rectangle((bmp.Width - sample_width) / 2, 0, sample_width, bmp.Height);
            }
            else
            {
                float size_ratio = (float)pbox.Width / bmp.Width;
                int sample_height = (int)(pbox.Height / size_ratio);
                src_rect = new Rectangle(0, (bmp.Height - sample_height) / 2, bmp.Width, sample_height);
            }

            g.DrawImage(bmp, dest_rect, src_rect, GraphicsUnit.Pixel);
            g.Dispose();

            pbox.Image = resized;
        }
    }
}
