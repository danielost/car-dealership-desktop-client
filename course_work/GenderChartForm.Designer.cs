
namespace course_work
{
    partial class GenderChartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.maleMakesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.femaleMakesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.genderChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.maleMakesChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.femaleMakesChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maleMakesChart
            // 
            this.maleMakesChart.BackColor = System.Drawing.Color.Transparent;
            this.maleMakesChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.maleMakesChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.maleMakesChart.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            chartArea1.Name = "ChartArea1";
            this.maleMakesChart.ChartAreas.Add(chartArea1);
            this.maleMakesChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.maleMakesChart.Legends.Add(legend1);
            this.maleMakesChart.Location = new System.Drawing.Point(0, 295);
            this.maleMakesChart.Name = "maleMakesChart";
            this.maleMakesChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "carMake";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.maleMakesChart.Series.Add(series1);
            this.maleMakesChart.Size = new System.Drawing.Size(871, 411);
            this.maleMakesChart.TabIndex = 5;
            this.maleMakesChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Title1";
            title1.Text = "The most popular car makes among males";
            this.maleMakesChart.Titles.Add(title1);
            // 
            // femaleMakesChart
            // 
            this.femaleMakesChart.BackColor = System.Drawing.Color.Transparent;
            this.femaleMakesChart.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.femaleMakesChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.femaleMakesChart.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            chartArea2.Name = "ChartArea1";
            this.femaleMakesChart.ChartAreas.Add(chartArea2);
            this.femaleMakesChart.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Name = "Legend1";
            this.femaleMakesChart.Legends.Add(legend2);
            this.femaleMakesChart.Location = new System.Drawing.Point(0, 0);
            this.femaleMakesChart.Name = "femaleMakesChart";
            this.femaleMakesChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series2.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series2.LabelBackColor = System.Drawing.Color.Transparent;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "carMake";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.femaleMakesChart.Series.Add(series2);
            this.femaleMakesChart.Size = new System.Drawing.Size(871, 295);
            this.femaleMakesChart.TabIndex = 6;
            this.femaleMakesChart.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.ForeColor = System.Drawing.Color.White;
            title2.Name = "Title1";
            title2.Text = "The most popular car makes among females";
            this.femaleMakesChart.Titles.Add(title2);
            // 
            // genderChart
            // 
            this.genderChart.BackColor = System.Drawing.Color.Transparent;
            this.genderChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.genderChart.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            chartArea3.Name = "ChartArea1";
            this.genderChart.ChartAreas.Add(chartArea3);
            this.genderChart.Dock = System.Windows.Forms.DockStyle.Left;
            legend3.Name = "Legend1";
            this.genderChart.Legends.Add(legend3);
            this.genderChart.Location = new System.Drawing.Point(0, 0);
            this.genderChart.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.genderChart.Name = "genderChart";
            this.genderChart.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.genderChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series3.LabelBackColor = System.Drawing.Color.Transparent;
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.Name = "Sex";
            this.genderChart.Series.Add(series3);
            this.genderChart.Size = new System.Drawing.Size(318, 706);
            this.genderChart.TabIndex = 7;
            this.genderChart.Text = "chart2";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title3.ForeColor = System.Drawing.Color.White;
            title3.Name = "Title1";
            title3.Text = "Sex comparison";
            this.genderChart.Titles.Add(title3);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.maleMakesChart);
            this.panel1.Controls.Add(this.femaleMakesChart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(318, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 706);
            this.panel1.TabIndex = 8;
            // 
            // GenderChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1189, 706);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.genderChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenderChartForm";
            this.Text = "GenderChartForm";
            this.Load += new System.EventHandler(this.GenderChartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maleMakesChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.femaleMakesChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart maleMakesChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart femaleMakesChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart genderChart;
        private System.Windows.Forms.Panel panel1;
    }
}