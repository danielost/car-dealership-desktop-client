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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_work
{
    public partial class RecordForm : Form
    {
        DataTable dealDates;
        DataRow currUser;
        int sum;
        public RecordForm(DataRow user)
        {
            InitializeComponent();
            currUser = user;
            dateTimePicker2.Value = DateTime.Now;
            sumLabel.Visible = false;
        }

        private void loadData(DateTime dateFrom, DateTime dateTo)
        {
            using (SqlConnection sqlconn = new SqlConnection(@"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True"))
            {
                sqlconn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT cars.VIN, make, model, car_price, deal_date, clients.client_id, full_name, email FROM cars JOIN sellings ON cars.VIN = sellings.VIN JOIN clients ON sellings.client_id = clients.client_id WHERE deal_date BETWEEN @date_from AND @date_to ORDER BY deal_date", sqlconn);
                SqlDataAdapter sumComm = new SqlDataAdapter("SELECT SUM(car_price) FROM cars JOIN sellings ON cars.VIN = sellings.VIN WHERE deal_date BETWEEN @date_from AND @date_to", sqlconn);
                sumComm.SelectCommand.Parameters.AddWithValue("@date_from", dateFrom);
                sumComm.SelectCommand.Parameters.AddWithValue("@date_to", dateTo);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@date_from", dateFrom);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@date_to", dateTo);
                DataTable sumTable = new DataTable();
                sumComm.Fill(sumTable);
                sum = 0;
                if (!(sumTable.Rows[0][0] is DBNull))
                {
                    sum = (int)sumTable.Rows[0][0];
                } 
                sumLabel.Text = "Sum: $" + numDesigner(sum);
                sumLabel.Visible = true;
                dealDates = new DataTable();
                dataAdapter.Fill(dealDates);
                sqlconn.Close();
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dealDates;
            paintGrid();
        }

        private void loadAllData()
        {
            using (SqlConnection sqlconn = new SqlConnection(@"Data Source=.;Initial Catalog=car_dealership_full;Integrated Security=True"))
            {
                sqlconn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT cars.VIN, make, model, car_price, deal_date, clients.client_id, full_name, email FROM cars JOIN sellings ON cars.VIN = sellings.VIN JOIN clients ON sellings.client_id = clients.client_id ORDER BY deal_date", sqlconn);
                SqlDataAdapter sumComm = new SqlDataAdapter("SELECT SUM(car_price) FROM cars JOIN sellings ON cars.VIN = sellings.VIN", sqlconn);
                DataTable sumTable = new DataTable();
                sumComm.Fill(sumTable);
                sum = (int)sumTable.Rows[0][0];
                sumLabel.Text = "Sum: $" + numDesigner(sum);
                sumLabel.Visible = true;
                dealDates = new DataTable();
                dataAdapter.Fill(dealDates);
                sqlconn.Close();              
            }
            dataGridView1.DataSource = dealDates;
            dateTimePicker1.Value = (DateTime)dealDates.Rows[0]["deal_date"];
            dateTimePicker2.Value = (DateTime)dealDates.Rows[dealDates.Rows.Count - 1]["deal_date"];
            paintGrid();
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

        private void paintGrid()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(18,18,18);
                row.DefaultCellStyle.ForeColor = Color.Gainsboro;
            }
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gainsboro;
            dataGridView1.EnableHeadersVisualStyles = false;
        }

        private void RecordForm_Load(object sender, EventArgs e)
        {
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            loadData(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null || dataGridView1.Rows.Count <= 1)
            {
                MessageBox.Show("You can't save an empty record");
                return;
            }
            using(SaveFileDialog sfd = new SaveFileDialog() { Filter = "PFD file|*.pdf", ValidateNames = true})               
            {
                sfd.FileName = "record_for_" + Convert.ToDateTime(dateTimePicker1.Value).ToString("yyyy-MM-dd") + "_" + Convert.ToDateTime(dateTimePicker2.Value).ToString("yyyy-MM-dd");
                if(sfd.ShowDialog() == DialogResult.OK) 
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4);
                    try
                    {
                        BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                        iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 22, iTextSharp.text.Font.NORMAL);

                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();

                        Paragraph titolo = new iTextSharp.text.Paragraph("Sales record for " + Convert.ToDateTime(dateTimePicker1.Value).ToString("yyyy/MM/dd") + " - " + Convert.ToDateTime(dateTimePicker2.Value).ToString("yyyy/MM/dd"), font);
                        titolo.Alignment = iTextSharp.text.Element.ALIGN_CENTER;

                        titolo.SpacingAfter = 20;
                        doc.Add(titolo);

                        PdfPTable pdfTable = new PdfPTable(8);
                        pdfTable.WidthPercentage = 98;

                        pdfTable.AddCell("VIN");
                        pdfTable.AddCell("Make");
                        pdfTable.AddCell("Model");
                        pdfTable.AddCell("Price");
                        pdfTable.AddCell("Date of the deal");
                        pdfTable.AddCell("Buyer_id");
                        pdfTable.AddCell("Name");
                        pdfTable.AddCell("E-mail");
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            if (row.Cells != null)
                            {
                                foreach (DataGridViewCell celli in row.Cells)
                                {        
                                    if (celli.Value != null)
                                    {
                                        if (celli.ColumnIndex == 4)
                                        {
                                            celli.Value = Convert.ToDateTime(celli.Value).ToString("yyyy/MM/dd");
                                        }
                                        pdfTable.AddCell(celli.Value.ToString());
                                    }                                                             
                                }
                            }                                                     
                        }
                        doc.Add(pdfTable);
                        doc.Add(new iTextSharp.text.Paragraph(sumLabel.Text));
                        doc.Add(new iTextSharp.text.Paragraph("Created by " + currUser["full_name"].ToString() + " on " + DateTime.Now));
                    }
                    catch(Exception ex)
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

        private void iconButton3_Click(object sender, EventArgs e)
        {
            loadAllData();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                DateTime temp = dateTimePicker1.Value;
                dateTimePicker1.Value = dateTimePicker2.Value;
                dateTimePicker2.Value = temp;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                DateTime temp = dateTimePicker1.Value;
                dateTimePicker1.Value = dateTimePicker2.Value;
                dateTimePicker2.Value = temp;
            }
        }
    }
}
