
namespace course_work
{
    partial class Cars
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
            this.filtersPanel = new System.Windows.Forms.Panel();
            this.resetBtn = new System.Windows.Forms.LinkLabel();
            this.yearTo = new System.Windows.Forms.DateTimePicker();
            this.yearFrom = new System.Windows.Forms.DateTimePicker();
            this.allCheckBox = new System.Windows.Forms.CheckBox();
            this.suvCheckBox = new System.Windows.Forms.CheckBox();
            this.cuvCheckBox = new System.Windows.Forms.CheckBox();
            this.minivanCheckBox = new System.Windows.Forms.CheckBox();
            this.pickupCheckBox = new System.Windows.Forms.CheckBox();
            this.sportsCheckBox = new System.Windows.Forms.CheckBox();
            this.wagonCheckBox = new System.Windows.Forms.CheckBox();
            this.coupeCheckBox = new System.Windows.Forms.CheckBox();
            this.convertCheckBox = new System.Windows.Forms.CheckBox();
            this.hatchCheckBox = new System.Windows.Forms.CheckBox();
            this.sedanCheckBox = new System.Windows.Forms.CheckBox();
            this.maxMileage = new System.Windows.Forms.NumericUpDown();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.priceTo = new System.Windows.Forms.NumericUpDown();
            this.priceFrom = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.hideFiltersBtn = new System.Windows.Forms.LinkLabel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.filterBtn = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.noDataLabel = new System.Windows.Forms.LinkLabel();
            this.filterBtnPanel = new System.Windows.Forms.Panel();
            this.toHidePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.addCarBtn = new FontAwesome.Sharp.IconButton();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.filtersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxMileage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceFrom)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.filterBtnPanel.SuspendLayout();
            this.toHidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // filtersPanel
            // 
            this.filtersPanel.BackColor = System.Drawing.Color.Black;
            this.filtersPanel.Controls.Add(this.resetBtn);
            this.filtersPanel.Controls.Add(this.yearTo);
            this.filtersPanel.Controls.Add(this.yearFrom);
            this.filtersPanel.Controls.Add(this.allCheckBox);
            this.filtersPanel.Controls.Add(this.suvCheckBox);
            this.filtersPanel.Controls.Add(this.cuvCheckBox);
            this.filtersPanel.Controls.Add(this.minivanCheckBox);
            this.filtersPanel.Controls.Add(this.pickupCheckBox);
            this.filtersPanel.Controls.Add(this.sportsCheckBox);
            this.filtersPanel.Controls.Add(this.wagonCheckBox);
            this.filtersPanel.Controls.Add(this.coupeCheckBox);
            this.filtersPanel.Controls.Add(this.convertCheckBox);
            this.filtersPanel.Controls.Add(this.hatchCheckBox);
            this.filtersPanel.Controls.Add(this.sedanCheckBox);
            this.filtersPanel.Controls.Add(this.maxMileage);
            this.filtersPanel.Controls.Add(this.modelTextBox);
            this.filtersPanel.Controls.Add(this.makeTextBox);
            this.filtersPanel.Controls.Add(this.label4);
            this.filtersPanel.Controls.Add(this.label5);
            this.filtersPanel.Controls.Add(this.priceTo);
            this.filtersPanel.Controls.Add(this.priceFrom);
            this.filtersPanel.Controls.Add(this.label3);
            this.filtersPanel.Controls.Add(this.label2);
            this.filtersPanel.Controls.Add(this.iconButton1);
            this.filtersPanel.Controls.Add(this.hideFiltersBtn);
            this.filtersPanel.Controls.Add(this.iconButton2);
            this.filtersPanel.Controls.Add(this.iconButton4);
            this.filtersPanel.Controls.Add(this.iconButton5);
            this.filtersPanel.Controls.Add(this.iconButton3);
            this.filtersPanel.Controls.Add(this.iconButton6);
            this.filtersPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.filtersPanel.Location = new System.Drawing.Point(803, 0);
            this.filtersPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filtersPanel.Name = "filtersPanel";
            this.filtersPanel.Size = new System.Drawing.Size(324, 740);
            this.filtersPanel.TabIndex = 3;
            // 
            // resetBtn
            // 
            this.resetBtn.AutoSize = true;
            this.resetBtn.LinkColor = System.Drawing.Color.Gainsboro;
            this.resetBtn.Location = new System.Drawing.Point(100, 6);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(83, 17);
            this.resetBtn.TabIndex = 66;
            this.resetBtn.TabStop = true;
            this.resetBtn.Text = "Reset filters";
            this.resetBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.resetBtn_LinkClicked);
            // 
            // yearTo
            // 
            this.yearTo.CustomFormat = "yyyy-MM-dd";
            this.yearTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.yearTo.Location = new System.Drawing.Point(169, 142);
            this.yearTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearTo.MaxDate = new System.DateTime(2022, 2, 2, 0, 0, 0, 0);
            this.yearTo.MinDate = new System.DateTime(1950, 2, 2, 0, 0, 0, 0);
            this.yearTo.Name = "yearTo";
            this.yearTo.Size = new System.Drawing.Size(137, 29);
            this.yearTo.TabIndex = 65;
            this.yearTo.ValueChanged += new System.EventHandler(this.yearTo_ValueChanged);
            // 
            // yearFrom
            // 
            this.yearFrom.CustomFormat = "yyyy-MM-dd";
            this.yearFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.yearFrom.Location = new System.Drawing.Point(12, 142);
            this.yearFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearFrom.MaxDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.yearFrom.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.yearFrom.Name = "yearFrom";
            this.yearFrom.Size = new System.Drawing.Size(147, 29);
            this.yearFrom.TabIndex = 64;
            this.yearFrom.Value = new System.DateTime(1980, 11, 30, 16, 20, 0, 0);
            this.yearFrom.ValueChanged += new System.EventHandler(this.yearFrom_ValueChanged);
            // 
            // allCheckBox
            // 
            this.allCheckBox.AutoSize = true;
            this.allCheckBox.Checked = true;
            this.allCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allCheckBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.allCheckBox.Location = new System.Drawing.Point(12, 346);
            this.allCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.allCheckBox.Name = "allCheckBox";
            this.allCheckBox.Size = new System.Drawing.Size(100, 24);
            this.allCheckBox.TabIndex = 61;
            this.allCheckBox.Text = "Select all";
            this.allCheckBox.UseVisualStyleBackColor = true;
            this.allCheckBox.CheckedChanged += new System.EventHandler(this.allCheckBox_CheckedChanged);
            // 
            // suvCheckBox
            // 
            this.suvCheckBox.AutoSize = true;
            this.suvCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.suvCheckBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.suvCheckBox.Location = new System.Drawing.Point(181, 463);
            this.suvCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.suvCheckBox.Name = "suvCheckBox";
            this.suvCheckBox.Size = new System.Drawing.Size(65, 24);
            this.suvCheckBox.TabIndex = 60;
            this.suvCheckBox.Text = "SUV";
            this.suvCheckBox.UseVisualStyleBackColor = true;
            this.suvCheckBox.CheckedChanged += new System.EventHandler(this.suvCheckBox_CheckedChanged);
            // 
            // cuvCheckBox
            // 
            this.cuvCheckBox.AutoSize = true;
            this.cuvCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cuvCheckBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.cuvCheckBox.Location = new System.Drawing.Point(181, 375);
            this.cuvCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cuvCheckBox.Name = "cuvCheckBox";
            this.cuvCheckBox.Size = new System.Drawing.Size(66, 24);
            this.cuvCheckBox.TabIndex = 58;
            this.cuvCheckBox.Text = "CUV";
            this.cuvCheckBox.UseVisualStyleBackColor = true;
            this.cuvCheckBox.CheckedChanged += new System.EventHandler(this.cuvCheckBox_CheckedChanged);
            // 
            // minivanCheckBox
            // 
            this.minivanCheckBox.AutoSize = true;
            this.minivanCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minivanCheckBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.minivanCheckBox.Location = new System.Drawing.Point(181, 405);
            this.minivanCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minivanCheckBox.Name = "minivanCheckBox";
            this.minivanCheckBox.Size = new System.Drawing.Size(88, 24);
            this.minivanCheckBox.TabIndex = 57;
            this.minivanCheckBox.Text = "Minivan";
            this.minivanCheckBox.UseVisualStyleBackColor = true;
            this.minivanCheckBox.CheckedChanged += new System.EventHandler(this.minivanCheckBox_CheckedChanged);
            // 
            // pickupCheckBox
            // 
            this.pickupCheckBox.AutoSize = true;
            this.pickupCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pickupCheckBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.pickupCheckBox.Location = new System.Drawing.Point(181, 434);
            this.pickupCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pickupCheckBox.Name = "pickupCheckBox";
            this.pickupCheckBox.Size = new System.Drawing.Size(128, 24);
            this.pickupCheckBox.TabIndex = 56;
            this.pickupCheckBox.Text = "Pickup Truck";
            this.pickupCheckBox.UseVisualStyleBackColor = true;
            this.pickupCheckBox.CheckedChanged += new System.EventHandler(this.pickupCheckBox_CheckedChanged);
            // 
            // sportsCheckBox
            // 
            this.sportsCheckBox.AutoSize = true;
            this.sportsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sportsCheckBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.sportsCheckBox.Location = new System.Drawing.Point(12, 434);
            this.sportsCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sportsCheckBox.Name = "sportsCheckBox";
            this.sportsCheckBox.Size = new System.Drawing.Size(112, 24);
            this.sportsCheckBox.TabIndex = 55;
            this.sportsCheckBox.Text = "Sports Car";
            this.sportsCheckBox.UseVisualStyleBackColor = true;
            this.sportsCheckBox.CheckedChanged += new System.EventHandler(this.sportsCheckBox_CheckedChanged);
            // 
            // wagonCheckBox
            // 
            this.wagonCheckBox.AutoSize = true;
            this.wagonCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wagonCheckBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.wagonCheckBox.Location = new System.Drawing.Point(12, 463);
            this.wagonCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wagonCheckBox.Name = "wagonCheckBox";
            this.wagonCheckBox.Size = new System.Drawing.Size(140, 24);
            this.wagonCheckBox.TabIndex = 54;
            this.wagonCheckBox.Text = "Station Wagon";
            this.wagonCheckBox.UseVisualStyleBackColor = true;
            this.wagonCheckBox.CheckedChanged += new System.EventHandler(this.wagonCheckBox_CheckedChanged);
            // 
            // coupeCheckBox
            // 
            this.coupeCheckBox.AutoSize = true;
            this.coupeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coupeCheckBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.coupeCheckBox.Location = new System.Drawing.Point(12, 405);
            this.coupeCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.coupeCheckBox.Name = "coupeCheckBox";
            this.coupeCheckBox.Size = new System.Drawing.Size(79, 24);
            this.coupeCheckBox.TabIndex = 53;
            this.coupeCheckBox.Text = "Coupe";
            this.coupeCheckBox.UseVisualStyleBackColor = true;
            this.coupeCheckBox.CheckedChanged += new System.EventHandler(this.coupeCheckBox_CheckedChanged);
            // 
            // convertCheckBox
            // 
            this.convertCheckBox.AutoSize = true;
            this.convertCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.convertCheckBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.convertCheckBox.Location = new System.Drawing.Point(181, 346);
            this.convertCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.convertCheckBox.Name = "convertCheckBox";
            this.convertCheckBox.Size = new System.Drawing.Size(115, 24);
            this.convertCheckBox.TabIndex = 52;
            this.convertCheckBox.Text = "Convertible";
            this.convertCheckBox.UseVisualStyleBackColor = true;
            this.convertCheckBox.CheckedChanged += new System.EventHandler(this.convertCheckBox_CheckedChanged);
            // 
            // hatchCheckBox
            // 
            this.hatchCheckBox.AutoSize = true;
            this.hatchCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hatchCheckBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.hatchCheckBox.Location = new System.Drawing.Point(12, 495);
            this.hatchCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hatchCheckBox.Name = "hatchCheckBox";
            this.hatchCheckBox.Size = new System.Drawing.Size(111, 24);
            this.hatchCheckBox.TabIndex = 51;
            this.hatchCheckBox.Text = "Hatchback";
            this.hatchCheckBox.UseVisualStyleBackColor = true;
            this.hatchCheckBox.CheckedChanged += new System.EventHandler(this.hatchCheckBox_CheckedChanged);
            // 
            // sedanCheckBox
            // 
            this.sedanCheckBox.AutoSize = true;
            this.sedanCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sedanCheckBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.sedanCheckBox.Location = new System.Drawing.Point(12, 375);
            this.sedanCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sedanCheckBox.Name = "sedanCheckBox";
            this.sedanCheckBox.Size = new System.Drawing.Size(78, 24);
            this.sedanCheckBox.TabIndex = 50;
            this.sedanCheckBox.Text = "Sedan";
            this.sedanCheckBox.UseVisualStyleBackColor = true;
            this.sedanCheckBox.CheckedChanged += new System.EventHandler(this.sedanCheckBox_CheckedChanged);
            // 
            // maxMileage
            // 
            this.maxMileage.BackColor = System.Drawing.Color.Black;
            this.maxMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxMileage.ForeColor = System.Drawing.Color.White;
            this.maxMileage.Location = new System.Drawing.Point(12, 309);
            this.maxMileage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maxMileage.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.maxMileage.Name = "maxMileage";
            this.maxMileage.Size = new System.Drawing.Size(145, 29);
            this.maxMileage.TabIndex = 33;
            this.maxMileage.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // modelTextBox
            // 
            this.modelTextBox.BackColor = System.Drawing.Color.Black;
            this.modelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modelTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.modelTextBox.Location = new System.Drawing.Point(12, 247);
            this.modelTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(295, 29);
            this.modelTextBox.TabIndex = 31;
            // 
            // makeTextBox
            // 
            this.makeTextBox.BackColor = System.Drawing.Color.Black;
            this.makeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.makeTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.makeTextBox.Location = new System.Drawing.Point(12, 192);
            this.makeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(295, 29);
            this.makeTextBox.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(169, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "To:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(8, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "From:";
            // 
            // priceTo
            // 
            this.priceTo.BackColor = System.Drawing.Color.Black;
            this.priceTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTo.ForeColor = System.Drawing.Color.White;
            this.priceTo.Location = new System.Drawing.Point(169, 69);
            this.priceTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.priceTo.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.priceTo.Minimum = new decimal(new int[] {
            701,
            0,
            0,
            0});
            this.priceTo.Name = "priceTo";
            this.priceTo.Size = new System.Drawing.Size(139, 29);
            this.priceTo.TabIndex = 20;
            this.priceTo.Value = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.priceTo.ValueChanged += new System.EventHandler(this.priceTo_ValueChanged);
            // 
            // priceFrom
            // 
            this.priceFrom.BackColor = System.Drawing.Color.Black;
            this.priceFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceFrom.ForeColor = System.Drawing.Color.White;
            this.priceFrom.Location = new System.Drawing.Point(12, 69);
            this.priceFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.priceFrom.Maximum = new decimal(new int[] {
            499999,
            0,
            0,
            0});
            this.priceFrom.Minimum = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.priceFrom.Name = "priceFrom";
            this.priceFrom.Size = new System.Drawing.Size(148, 29);
            this.priceFrom.TabIndex = 18;
            this.priceFrom.Value = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.priceFrom.ValueChanged += new System.EventHandler(this.priceFrom_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(169, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "From:";
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 18;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(3, 26);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(97, 37);
            this.iconButton1.TabIndex = 18;
            this.iconButton1.Text = "Price";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // hideFiltersBtn
            // 
            this.hideFiltersBtn.AutoSize = true;
            this.hideFiltersBtn.LinkColor = System.Drawing.Color.Gainsboro;
            this.hideFiltersBtn.Location = new System.Drawing.Point(11, 6);
            this.hideFiltersBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hideFiltersBtn.Name = "hideFiltersBtn";
            this.hideFiltersBtn.Size = new System.Drawing.Size(75, 17);
            this.hideFiltersBtn.TabIndex = 16;
            this.hideFiltersBtn.TabStop = true;
            this.hideFiltersBtn.Text = "Hide filters";
            this.hideFiltersBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.hideFiltersBtn_LinkClicked);
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 24;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(12, 527);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(108, 37);
            this.iconButton2.TabIndex = 10;
            this.iconButton2.Text = "Search";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Diaspora;
            this.iconButton4.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 18;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(8, 164);
            this.iconButton4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(97, 37);
            this.iconButton4.TabIndex = 27;
            this.iconButton4.Text = "Make";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton5
            // 
            this.iconButton5.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Diaspora;
            this.iconButton5.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 18;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(8, 219);
            this.iconButton5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(97, 37);
            this.iconButton5.TabIndex = 29;
            this.iconButton5.Text = "Model";
            this.iconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.iconButton3.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 18;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(4, 97);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(97, 37);
            this.iconButton3.TabIndex = 23;
            this.iconButton3.Text = "Year";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // iconButton6
            // 
            this.iconButton6.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Road;
            this.iconButton6.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 18;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(8, 276);
            this.iconButton6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(152, 37);
            this.iconButton6.TabIndex = 32;
            this.iconButton6.Text = "Max mileage";
            this.iconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton6.UseVisualStyleBackColor = true;
            // 
            // filterBtn
            // 
            this.filterBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.filterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.filterBtn.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.filterBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.filterBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.filterBtn.IconSize = 24;
            this.filterBtn.Location = new System.Drawing.Point(4, 15);
            this.filterBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(108, 37);
            this.filterBtn.TabIndex = 2;
            this.filterBtn.Text = "Filters";
            this.filterBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.flowLayoutPanel1.Controls.Add(this.noDataLabel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(803, 740);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // noDataLabel
            // 
            this.noDataLabel.AutoSize = true;
            this.noDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noDataLabel.LinkColor = System.Drawing.Color.Gainsboro;
            this.noDataLabel.Location = new System.Drawing.Point(40, 37);
            this.noDataLabel.Margin = new System.Windows.Forms.Padding(40, 37, 40, 37);
            this.noDataLabel.Name = "noDataLabel";
            this.noDataLabel.Size = new System.Drawing.Size(523, 31);
            this.noDataLabel.TabIndex = 67;
            this.noDataLabel.TabStop = true;
            this.noDataLabel.Text = "No data found, click here to place an order";
            this.noDataLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.noDataLabel_LinkClicked);
            // 
            // filterBtnPanel
            // 
            this.filterBtnPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.filterBtnPanel.Controls.Add(this.toHidePanel);
            this.filterBtnPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.filterBtnPanel.Location = new System.Drawing.Point(668, 0);
            this.filterBtnPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filterBtnPanel.Name = "filterBtnPanel";
            this.filterBtnPanel.Size = new System.Drawing.Size(135, 740);
            this.filterBtnPanel.TabIndex = 6;
            // 
            // toHidePanel
            // 
            this.toHidePanel.Controls.Add(this.filterBtn);
            this.toHidePanel.Controls.Add(this.label1);
            this.toHidePanel.Controls.Add(this.addCarBtn);
            this.toHidePanel.Controls.Add(this.comboBox6);
            this.toHidePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toHidePanel.Location = new System.Drawing.Point(0, 0);
            this.toHidePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toHidePanel.Name = "toHidePanel";
            this.toHidePanel.Size = new System.Drawing.Size(135, 377);
            this.toHidePanel.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(0, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sort by";
            // 
            // addCarBtn
            // 
            this.addCarBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.addCarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCarBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.addCarBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addCarBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.addCarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addCarBtn.IconSize = 24;
            this.addCarBtn.Location = new System.Drawing.Point(4, 60);
            this.addCarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addCarBtn.Name = "addCarBtn";
            this.addCarBtn.Size = new System.Drawing.Size(108, 37);
            this.addCarBtn.TabIndex = 3;
            this.addCarBtn.Text = "Add";
            this.addCarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addCarBtn.UseVisualStyleBackColor = true;
            this.addCarBtn.Click += new System.EventHandler(this.addCarBtn_Click);
            // 
            // comboBox6
            // 
            this.comboBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.comboBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox6.ForeColor = System.Drawing.Color.Gainsboro;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Default",
            "Date added",
            "Price: Low - High",
            "Price: High - Low",
            "Mileage: Low - High",
            "Mileage: High - Low",
            "Production year: Older - Newer",
            "Production year: Newer - Older"});
            this.comboBox6.Location = new System.Drawing.Point(4, 123);
            this.comboBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(107, 24);
            this.comboBox6.TabIndex = 0;
            this.comboBox6.Text = "Default";
            this.comboBox6.DropDown += new System.EventHandler(this.comboBox6_DropDown);
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1127, 740);
            this.Controls.Add(this.filterBtnPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.filtersPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Cars";
            this.Text = "CarsForm";
            this.Load += new System.EventHandler(this.Cars_Load);
            this.filtersPanel.ResumeLayout(false);
            this.filtersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxMileage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceFrom)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.filterBtnPanel.ResumeLayout(false);
            this.toHidePanel.ResumeLayout(false);
            this.toHidePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton filterBtn;
        private System.Windows.Forms.Panel filtersPanel;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel filterBtnPanel;
        private System.Windows.Forms.LinkLabel hideFiltersBtn;
        private FontAwesome.Sharp.IconButton addCarBtn;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel toHidePanel;
        private System.Windows.Forms.NumericUpDown priceTo;
        private System.Windows.Forms.NumericUpDown priceFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.NumericUpDown maxMileage;
        private FontAwesome.Sharp.IconButton iconButton6;
        private System.Windows.Forms.CheckBox suvCheckBox;
        private System.Windows.Forms.CheckBox cuvCheckBox;
        private System.Windows.Forms.CheckBox minivanCheckBox;
        private System.Windows.Forms.CheckBox pickupCheckBox;
        private System.Windows.Forms.CheckBox sportsCheckBox;
        private System.Windows.Forms.CheckBox wagonCheckBox;
        private System.Windows.Forms.CheckBox coupeCheckBox;
        private System.Windows.Forms.CheckBox convertCheckBox;
        private System.Windows.Forms.CheckBox hatchCheckBox;
        private System.Windows.Forms.CheckBox sedanCheckBox;
        private System.Windows.Forms.CheckBox allCheckBox;
        private System.Windows.Forms.DateTimePicker yearTo;
        private System.Windows.Forms.DateTimePicker yearFrom;
        private System.Windows.Forms.LinkLabel resetBtn;
        private System.Windows.Forms.LinkLabel noDataLabel;
    }
}