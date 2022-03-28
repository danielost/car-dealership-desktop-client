using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_work
{
    public partial class Cars : Form
    {
        GetData gd;
        DataTable cars;
        Main parentForm;
        CheckBox[] checkBoxes;
        int panWidth;
        public Cars(Main mn)
        {
            InitializeComponent();
            parentForm = mn;
            filtersPanel.Visible = false;
            gd = new GetData();
            panWidth = filterBtnPanel.Width + 30;
            checkBoxes = new CheckBox[]
            {
                sedanCheckBox,
                coupeCheckBox,
                sportsCheckBox,
                wagonCheckBox,
                hatchCheckBox,
                convertCheckBox,
                cuvCheckBox,
                minivanCheckBox,
                pickupCheckBox,
                suvCheckBox
            };
        }

        private void FillCatalog(string query)
        {
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();
            }
            cars = gd.GetDataTable(query);
            for (int i = 0; i < cars.Rows.Count; i++)
            {
                if(!allCheckBox.Checked)
                {
                    bool check = false;
                    for (int j = 0; j < checkBoxes.Length; j++)
                    {
                        if (checkBoxes[j].Checked && Convert.ToInt32(cars.Rows[i]["body_type_id"]) == j + 1)
                        {
                            check = true;
                        }
                    }
                    if (!check)
                    {
                        continue;
                    }
                }
                CarThumbnail ct = new CarThumbnail(cars.Rows[i], parentForm);
                flowLayoutPanel1.Controls.Add(ct);
            }
            if (flowLayoutPanel1.Controls.Count < 1)
            {
                flowLayoutPanel1.Controls.Add(noDataLabel);
            }
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            filtersPanel.Visible = true;
            toHidePanel.Visible = false;
            filterBtnPanel.Size = new Size(22, filterBtnPanel.Height);
        }

        private void hideFiltersBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            filtersPanel.Visible = false;
            toHidePanel.Visible = true;
            filterBtnPanel.Size = new Size(panWidth, filterBtnPanel.Height);
        }

        private void addCarBtn_Click(object sender, EventArgs e)
        {
            parentForm.OpenChildForm(new AddCarForm(parentForm.user, parentForm));
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortUpdate(comboBox6.SelectedIndex);
        }

        private void sortUpdate(int index)
        {
            switch (index)
            {
                case 0:
                    FillCatalog("SELECT * FROM cars LEFT JOIN (SELECT car_histories.VIN, MIN(event_id) as event_id FROM car_histories GROUP BY car_histories.VIN) AS a ON cars.VIN = a.VIN JOIN engines ON cars.eng_type = engines.engine_id WHERE cars.VIN NOT IN (SELECT sellings.VIN FROM sellings) AND cars.mileage <= " + maxMileage.Value + " AND cars.car_price BETWEEN " + priceFrom.Value + " AND " + priceTo.Value + " AND cars.year BETWEEN '" + yearFrom.Value + "' AND '" + yearTo.Value + "' AND cars.make LIKE '%" + makeTextBox.Text + "%' AND cars.model LIKE '%" + modelTextBox.Text + "%'");
                    break;
                case 1:
                    FillCatalog("SELECT * FROM cars LEFT JOIN (SELECT car_histories.VIN, MIN(event_id) as event_id FROM car_histories GROUP BY car_histories.VIN) AS a ON cars.VIN = a.VIN JOIN engines ON cars.eng_type = engines.engine_id WHERE cars.VIN NOT IN (SELECT sellings.VIN FROM sellings) AND cars.mileage <= " + maxMileage.Value + " AND cars.car_price BETWEEN " + priceFrom.Value + " AND " + priceTo.Value + " AND cars.year BETWEEN '" + yearFrom.Value + "' AND '" + yearTo.Value + "' AND cars.make LIKE '%" + makeTextBox.Text + "%' AND cars.model LIKE '%" + modelTextBox.Text + "%' ORDER BY date_added DESC");
                    break;
                case 2:
                    FillCatalog("SELECT * FROM cars LEFT JOIN (SELECT car_histories.VIN, MIN(event_id) as event_id FROM car_histories GROUP BY car_histories.VIN) AS a ON cars.VIN = a.VIN JOIN engines ON cars.eng_type = engines.engine_id WHERE cars.VIN NOT IN (SELECT sellings.VIN FROM sellings) AND cars.mileage <= " + maxMileage.Value + " AND cars.car_price BETWEEN " + priceFrom.Value + " AND " + priceTo.Value + " AND cars.year BETWEEN '" + yearFrom.Value + "' AND '" + yearTo.Value + "' AND cars.make LIKE '%" + makeTextBox.Text + "%' AND cars.model LIKE '%" + modelTextBox.Text + "%' ORDER BY car_price");
                    break;
                case 3:
                    FillCatalog("SELECT * FROM cars LEFT JOIN (SELECT car_histories.VIN, MIN(event_id) as event_id FROM car_histories GROUP BY car_histories.VIN) AS a ON cars.VIN = a.VIN JOIN engines ON cars.eng_type = engines.engine_id WHERE cars.VIN NOT IN (SELECT sellings.VIN FROM sellings) AND cars.mileage <= " + maxMileage.Value + " AND cars.car_price BETWEEN " + priceFrom.Value + " AND " + priceTo.Value + " AND cars.year BETWEEN '" + yearFrom.Value + "' AND '" + yearTo.Value + "' AND cars.make LIKE '%" + makeTextBox.Text + "%' AND cars.model LIKE '%" + modelTextBox.Text + "%' ORDER BY car_price DESC");
                    break;
                case 4:
                    FillCatalog("SELECT * FROM cars LEFT JOIN (SELECT car_histories.VIN, MIN(event_id) as event_id FROM car_histories GROUP BY car_histories.VIN) AS a ON cars.VIN = a.VIN JOIN engines ON cars.eng_type = engines.engine_id WHERE cars.VIN NOT IN (SELECT sellings.VIN FROM sellings) AND cars.mileage <= " + maxMileage.Value + " AND cars.car_price BETWEEN " + priceFrom.Value + " AND " + priceTo.Value + " AND cars.year BETWEEN '" + yearFrom.Value + "' AND '" + yearTo.Value + "' AND cars.make LIKE '%" + makeTextBox.Text + "%' AND cars.model LIKE '%" + modelTextBox.Text + "%' ORDER BY mileage");
                    break;
                case 5:
                    FillCatalog("SELECT * FROM cars LEFT JOIN (SELECT car_histories.VIN, MIN(event_id) as event_id FROM car_histories GROUP BY car_histories.VIN) AS a ON cars.VIN = a.VIN JOIN engines ON cars.eng_type = engines.engine_id WHERE cars.VIN NOT IN (SELECT sellings.VIN FROM sellings) AND cars.mileage <= " + maxMileage.Value + " AND cars.car_price BETWEEN " + priceFrom.Value + " AND " + priceTo.Value + " AND cars.year BETWEEN '" + yearFrom.Value + "' AND '" + yearTo.Value + "' AND cars.make LIKE '%" + makeTextBox.Text + "%' AND cars.model LIKE '%" + modelTextBox.Text + "%' ORDER BY mileage DESC");
                    break;
                case 6:
                    FillCatalog("SELECT * FROM cars LEFT JOIN (SELECT car_histories.VIN, MIN(event_id) as event_id FROM car_histories GROUP BY car_histories.VIN) AS a ON cars.VIN = a.VIN JOIN engines ON cars.eng_type = engines.engine_id WHERE cars.VIN NOT IN (SELECT sellings.VIN FROM sellings) AND cars.mileage <= " + maxMileage.Value + " AND cars.car_price BETWEEN " + priceFrom.Value + " AND " + priceTo.Value + " AND cars.year BETWEEN '" + yearFrom.Value + "' AND '" + yearTo.Value + "' AND cars.make LIKE '%" + makeTextBox.Text + "%' AND cars.model LIKE '%" + modelTextBox.Text + "%' ORDER BY year");
                    break;
                case 7:
                    FillCatalog("SELECT * FROM cars LEFT JOIN (SELECT car_histories.VIN, MIN(event_id) as event_id FROM car_histories GROUP BY car_histories.VIN) AS a ON cars.VIN = a.VIN JOIN engines ON cars.eng_type = engines.engine_id WHERE cars.VIN NOT IN (SELECT sellings.VIN FROM sellings) AND cars.mileage <= " + maxMileage.Value + " AND cars.car_price BETWEEN " + priceFrom.Value + " AND " + priceTo.Value + " AND cars.year BETWEEN '" + yearFrom.Value + "' AND '" + yearTo.Value + "' AND cars.make LIKE '%" + makeTextBox.Text + "%' AND cars.model LIKE '%" + modelTextBox.Text + "%' ORDER BY year DESC");
                    break;
                default:
                    break;
            }
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            try
            {
                sortUpdate(comboBox6.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void allCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (allCheckBox.Checked == true)
            {
                uncheckAll();
            }          
        }

        private void uncheckAll()
        {
            allCheckBox.Checked = true;
            foreach (var item in checkBoxes)
            {
                item.Checked = false;
            }
        }

        private void sedanCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sedanCheckBox.Checked == true)
            {
                allCheckBox.Checked = false;
            }
        }

        private void coupeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (coupeCheckBox.Checked == true)
            {
                allCheckBox.Checked = false;
            }
        }

        private void sportsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sportsCheckBox.Checked == true)
            {
                allCheckBox.Checked = false;
            }
        }

        private void wagonCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (wagonCheckBox.Checked == true)
            {
                allCheckBox.Checked = false;
            }
        }

        private void hatchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hatchCheckBox.Checked == true)
            {
                allCheckBox.Checked = false;
            }
        }

        private void convertCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (convertCheckBox.Checked == true)
            {
                allCheckBox.Checked = false;
            }
        }

        private void cuvCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cuvCheckBox.Checked == true)
            {
                allCheckBox.Checked = false;
            }
        }

        private void minivanCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (minivanCheckBox.Checked == true)
            {
                allCheckBox.Checked = false;
            }
        }

        private void pickupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pickupCheckBox.Checked == true)
            {
                allCheckBox.Checked = false;
            }
        }

        private void suvCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (suvCheckBox.Checked == true)
            {
                allCheckBox.Checked = false;
            }          
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            sortUpdate(comboBox6.SelectedIndex);
        }

        private void resetBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            priceFrom.Value = 700;
            priceTo.Value = 499999;
            yearFrom.Value = Convert.ToDateTime("1980/01/01");
            yearTo.Value = Convert.ToDateTime("2022/01/01");
            maxMileage.Value = 1000000;
            makeTextBox.Text = "";
            modelTextBox.Text = "";
            uncheckAll();
            sortUpdate(comboBox6.SelectedIndex);
            filtersPanel.Visible = false;
            toHidePanel.Visible = true;
            filterBtnPanel.Size = new Size(panWidth, filterBtnPanel.Height);
        }

        private void comboBox6_DropDown(object sender, EventArgs e)
        {
            var senderComboBox = (ComboBox)sender;
            int width = senderComboBox.DropDownWidth;
            Graphics g = senderComboBox.CreateGraphics();
            Font font = senderComboBox.Font;

            int vertScrollBarWidth = (senderComboBox.Items.Count > senderComboBox.MaxDropDownItems)
                    ? SystemInformation.VerticalScrollBarWidth : 0;

            var itemsList = senderComboBox.Items.Cast<object>().Select(item => item.ToString());

            foreach (string s in itemsList)
            {
                int newWidth = (int)g.MeasureString(s, font).Width + vertScrollBarWidth;

                if (width < newWidth)
                {
                    width = newWidth;
                }
            }

            senderComboBox.DropDownWidth = width;
        }

        private void noDataLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OrderPlaceForm opf = new OrderPlaceForm(parentForm.user, makeTextBox.Text, modelTextBox.Text, (int)maxMileage.Value, (int)priceFrom.Value, (int)priceTo.Value, yearFrom.Value, yearTo.Value); ;
            opf.Show();
        }

        private void priceFrom_ValueChanged(object sender, EventArgs e)
        {
            if (priceFrom.Value > priceTo.Value)
            {
                int temp = (int)priceTo.Value;
                priceTo.Value = priceFrom.Value;
                priceFrom.Value = temp;
            }
        }

        private void priceTo_ValueChanged(object sender, EventArgs e)
        {
            if (priceFrom.Value > priceTo.Value)
            {
                int temp = (int)priceTo.Value;
                priceTo.Value = priceFrom.Value;
                priceFrom.Value = temp;
            }
        }

        private void yearFrom_ValueChanged(object sender, EventArgs e)
        {
            if (yearTo.Value < yearFrom.Value)
            {
                DateTime temp = yearFrom.Value;
                yearFrom.Value = yearTo.Value;
                yearTo.Value = temp;
            }          
        }

        private void yearTo_ValueChanged(object sender, EventArgs e)
        {
            if (yearTo.Value < yearFrom.Value)
            {
                DateTime temp = yearFrom.Value;
                yearFrom.Value = yearTo.Value;
                yearTo.Value = temp;
            }
        }
    }
}
