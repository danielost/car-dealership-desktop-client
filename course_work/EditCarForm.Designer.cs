
namespace course_work
{
    partial class EditCarForm
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
            this.components = new System.ComponentModel.Container();
            this.eventTypeComboBox = new System.Windows.Forms.ComboBox();
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_dealership_fullDataSet = new course_work.car_dealership_fullDataSet();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.descTextBox = new System.Windows.Forms.RichTextBox();
            this.powerTextBox = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.addEventBtn = new FontAwesome.Sharp.IconButton();
            this.eventsDataGridView = new System.Windows.Forms.DataGridView();
            this.EventCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.capTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mileageTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yearTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.eventDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bluetoothCheck = new System.Windows.Forms.CheckBox();
            this.acCheck = new System.Windows.Forms.CheckBox();
            this.navSysCheck = new System.Windows.Forms.CheckBox();
            this.appleCheck = new System.Windows.Forms.CheckBox();
            this.thirdCheck = new System.Windows.Forms.CheckBox();
            this.blindCheck = new System.Windows.Forms.CheckBox();
            this.remoteCheck = new System.Windows.Forms.CheckBox();
            this.backupCheck = new System.Windows.Forms.CheckBox();
            this.heatedSeatsCheck = new System.Windows.Forms.CheckBox();
            this.sunroofCheck = new System.Windows.Forms.CheckBox();
            this.leatherCheck = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.transTextBox = new System.Windows.Forms.TextBox();
            this.bodyComboBox = new System.Windows.Forms.ComboBox();
            this.engineComboBox = new System.Windows.Forms.ComboBox();
            this.addCarBtn = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitBtn = new FontAwesome.Sharp.IconButton();
            this.uploadPhotoBtn = new FontAwesome.Sharp.IconButton();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventsTableAdapter = new course_work.car_dealership_fullDataSetTableAdapters.eventsTableAdapter();
            this.enginesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enginesTableAdapter = new course_work.car_dealership_fullDataSetTableAdapters.enginesTableAdapter();
            this.bodiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bodiesTableAdapter = new course_work.car_dealership_fullDataSetTableAdapters.bodiesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_dealership_fullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enginesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // eventTypeComboBox
            // 
            this.eventTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.eventTypeComboBox.DataSource = this.eventsBindingSource;
            this.eventTypeComboBox.DisplayMember = "event_name";
            this.eventTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eventTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventTypeComboBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.eventTypeComboBox.FormattingEnabled = true;
            this.eventTypeComboBox.Location = new System.Drawing.Point(10, 39);
            this.eventTypeComboBox.Name = "eventTypeComboBox";
            this.eventTypeComboBox.Size = new System.Drawing.Size(166, 26);
            this.eventTypeComboBox.TabIndex = 32;
            // 
            // eventsBindingSource
            // 
            this.eventsBindingSource.DataMember = "events";
            this.eventsBindingSource.DataSource = this.car_dealership_fullDataSet;
            // 
            // car_dealership_fullDataSet
            // 
            this.car_dealership_fullDataSet.DataSetName = "car_dealership_fullDataSet";
            this.car_dealership_fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.Gainsboro;
            this.label17.Location = new System.Drawing.Point(6, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 20);
            this.label17.TabIndex = 30;
            this.label17.Text = "Date";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.Gainsboro;
            this.label16.Location = new System.Drawing.Point(6, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 20);
            this.label16.TabIndex = 28;
            this.label16.Text = "Type";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.Gainsboro;
            this.label15.Location = new System.Drawing.Point(295, 310);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 20);
            this.label15.TabIndex = 31;
            this.label15.Text = "Description";
            // 
            // descTextBox
            // 
            this.descTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.descTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.descTextBox.Location = new System.Drawing.Point(299, 332);
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(507, 72);
            this.descTextBox.TabIndex = 30;
            this.descTextBox.Text = "";
            // 
            // powerTextBox
            // 
            this.powerTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.powerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.powerTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.powerTextBox.Location = new System.Drawing.Point(12, 525);
            this.powerTextBox.Name = "powerTextBox";
            this.powerTextBox.Size = new System.Drawing.Size(118, 24);
            this.powerTextBox.TabIndex = 29;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(402, 122);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(113, 33);
            this.iconButton1.TabIndex = 37;
            this.iconButton1.Text = "Delete event";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // addEventBtn
            // 
            this.addEventBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEventBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.addEventBtn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addEventBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.addEventBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addEventBtn.IconSize = 25;
            this.addEventBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEventBtn.Location = new System.Drawing.Point(402, 81);
            this.addEventBtn.Name = "addEventBtn";
            this.addEventBtn.Size = new System.Drawing.Size(113, 33);
            this.addEventBtn.TabIndex = 36;
            this.addEventBtn.Text = "Add event";
            this.addEventBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEventBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addEventBtn.UseVisualStyleBackColor = true;
            this.addEventBtn.Click += new System.EventHandler(this.addEventBtn_Click);
            // 
            // eventsDataGridView
            // 
            this.eventsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.eventsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventCol,
            this.DateCol});
            this.eventsDataGridView.Location = new System.Drawing.Point(533, 81);
            this.eventsDataGridView.Name = "eventsDataGridView";
            this.eventsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eventsDataGridView.Size = new System.Drawing.Size(273, 208);
            this.eventsDataGridView.TabIndex = 30;
            // 
            // EventCol
            // 
            this.EventCol.HeaderText = "Event";
            this.EventCol.Name = "EventCol";
            // 
            // DateCol
            // 
            this.DateCol.HeaderText = "Date";
            this.DateCol.Name = "DateCol";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.Gainsboro;
            this.label14.Location = new System.Drawing.Point(8, 502);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "Power";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(143, 502);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Transmission";
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.priceTextBox.Location = new System.Drawing.Point(13, 574);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(118, 24);
            this.priceTextBox.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            this.label9.Location = new System.Drawing.Point(8, 552);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Price";
            // 
            // colorTextBox
            // 
            this.colorTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.colorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.colorTextBox.Location = new System.Drawing.Point(146, 477);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(118, 24);
            this.colorTextBox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(142, 454);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(143, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Engine type";
            // 
            // capTextBox
            // 
            this.capTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.capTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.capTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.capTextBox.Location = new System.Drawing.Point(13, 429);
            this.capTextBox.Name = "capTextBox";
            this.capTextBox.Size = new System.Drawing.Size(118, 24);
            this.capTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(9, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Engine capacity";
            // 
            // mileageTextBox
            // 
            this.mileageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.mileageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mileageTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.mileageTextBox.Location = new System.Drawing.Point(146, 380);
            this.mileageTextBox.Name = "mileageTextBox";
            this.mileageTextBox.Size = new System.Drawing.Size(118, 24);
            this.mileageTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(142, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mileage";
            // 
            // yearTimePicker
            // 
            this.yearTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.yearTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.yearTimePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.yearTimePicker.CalendarTitleForeColor = System.Drawing.Color.Gainsboro;
            this.yearTimePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.yearTimePicker.CustomFormat = "yyyy/MM/dd";
            this.yearTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.yearTimePicker.Location = new System.Drawing.Point(12, 380);
            this.yearTimePicker.Name = "yearTimePicker";
            this.yearTimePicker.Size = new System.Drawing.Size(118, 24);
            this.yearTimePicker.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(8, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Year";
            // 
            // modelTextBox
            // 
            this.modelTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.modelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modelTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.modelTextBox.Location = new System.Drawing.Point(146, 333);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(118, 24);
            this.modelTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(142, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Model";
            // 
            // makeTextBox
            // 
            this.makeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.makeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.makeTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.makeTextBox.Location = new System.Drawing.Point(12, 333);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(118, 24);
            this.makeTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(8, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Make";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(8, 454);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Body type";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.eventDateTimePicker);
            this.groupBox1.Controls.Add(this.eventTypeComboBox);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(316, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 128);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Events";
            // 
            // eventDateTimePicker
            // 
            this.eventDateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.eventDateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.eventDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.eventDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.Gainsboro;
            this.eventDateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.eventDateTimePicker.CustomFormat = "yyyy/MM/dd";
            this.eventDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.eventDateTimePicker.Location = new System.Drawing.Point(10, 89);
            this.eventDateTimePicker.Name = "eventDateTimePicker";
            this.eventDateTimePicker.Size = new System.Drawing.Size(166, 24);
            this.eventDateTimePicker.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::course_work.Properties.Resources.Sans_titre_2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.bluetoothCheck);
            this.panel1.Controls.Add(this.acCheck);
            this.panel1.Controls.Add(this.navSysCheck);
            this.panel1.Controls.Add(this.appleCheck);
            this.panel1.Controls.Add(this.thirdCheck);
            this.panel1.Controls.Add(this.blindCheck);
            this.panel1.Controls.Add(this.remoteCheck);
            this.panel1.Controls.Add(this.backupCheck);
            this.panel1.Controls.Add(this.heatedSeatsCheck);
            this.panel1.Controls.Add(this.sunroofCheck);
            this.panel1.Controls.Add(this.leatherCheck);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.transTextBox);
            this.panel1.Controls.Add(this.bodyComboBox);
            this.panel1.Controls.Add(this.engineComboBox);
            this.panel1.Controls.Add(this.addCarBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.descTextBox);
            this.panel1.Controls.Add(this.powerTextBox);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.priceTextBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.colorTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.capTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.mileageTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.yearTimePicker);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.modelTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.makeTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 740);
            this.panel1.TabIndex = 1;
            // 
            // bluetoothCheck
            // 
            this.bluetoothCheck.AutoSize = true;
            this.bluetoothCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bluetoothCheck.ForeColor = System.Drawing.Color.Gainsboro;
            this.bluetoothCheck.Location = new System.Drawing.Point(662, 456);
            this.bluetoothCheck.Name = "bluetoothCheck";
            this.bluetoothCheck.Size = new System.Drawing.Size(83, 20);
            this.bluetoothCheck.TabIndex = 49;
            this.bluetoothCheck.Text = "Bluetooth";
            this.bluetoothCheck.UseVisualStyleBackColor = true;
            // 
            // acCheck
            // 
            this.acCheck.AutoSize = true;
            this.acCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.acCheck.ForeColor = System.Drawing.Color.Gainsboro;
            this.acCheck.Location = new System.Drawing.Point(662, 479);
            this.acCheck.Name = "acCheck";
            this.acCheck.Size = new System.Drawing.Size(49, 20);
            this.acCheck.TabIndex = 48;
            this.acCheck.Text = "A/C";
            this.acCheck.UseVisualStyleBackColor = true;
            // 
            // navSysCheck
            // 
            this.navSysCheck.AutoSize = true;
            this.navSysCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.navSysCheck.ForeColor = System.Drawing.Color.Gainsboro;
            this.navSysCheck.Location = new System.Drawing.Point(452, 481);
            this.navSysCheck.Name = "navSysCheck";
            this.navSysCheck.Size = new System.Drawing.Size(138, 20);
            this.navSysCheck.TabIndex = 47;
            this.navSysCheck.Text = "Navigation system";
            this.navSysCheck.UseVisualStyleBackColor = true;
            // 
            // appleCheck
            // 
            this.appleCheck.AutoSize = true;
            this.appleCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.appleCheck.ForeColor = System.Drawing.Color.Gainsboro;
            this.appleCheck.Location = new System.Drawing.Point(452, 504);
            this.appleCheck.Name = "appleCheck";
            this.appleCheck.Size = new System.Drawing.Size(195, 20);
            this.appleCheck.TabIndex = 46;
            this.appleCheck.Text = "Apple CarPlay/Android Auto";
            this.appleCheck.UseVisualStyleBackColor = true;
            // 
            // thirdCheck
            // 
            this.thirdCheck.AutoSize = true;
            this.thirdCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirdCheck.ForeColor = System.Drawing.Color.Gainsboro;
            this.thirdCheck.Location = new System.Drawing.Point(662, 433);
            this.thirdCheck.Name = "thirdCheck";
            this.thirdCheck.Size = new System.Drawing.Size(130, 20);
            this.thirdCheck.TabIndex = 45;
            this.thirdCheck.Text = "Third-row seating";
            this.thirdCheck.UseVisualStyleBackColor = true;
            // 
            // blindCheck
            // 
            this.blindCheck.AutoSize = true;
            this.blindCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blindCheck.ForeColor = System.Drawing.Color.Gainsboro;
            this.blindCheck.Location = new System.Drawing.Point(298, 481);
            this.blindCheck.Name = "blindCheck";
            this.blindCheck.Size = new System.Drawing.Size(151, 20);
            this.blindCheck.TabIndex = 44;
            this.blindCheck.Text = "Blind spot monitoring";
            this.blindCheck.UseVisualStyleBackColor = true;
            // 
            // remoteCheck
            // 
            this.remoteCheck.AutoSize = true;
            this.remoteCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remoteCheck.ForeColor = System.Drawing.Color.Gainsboro;
            this.remoteCheck.Location = new System.Drawing.Point(298, 504);
            this.remoteCheck.Name = "remoteCheck";
            this.remoteCheck.Size = new System.Drawing.Size(103, 20);
            this.remoteCheck.TabIndex = 43;
            this.remoteCheck.Text = "Remote start";
            this.remoteCheck.UseVisualStyleBackColor = true;
            // 
            // backupCheck
            // 
            this.backupCheck.AutoSize = true;
            this.backupCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backupCheck.ForeColor = System.Drawing.Color.Gainsboro;
            this.backupCheck.Location = new System.Drawing.Point(298, 457);
            this.backupCheck.Name = "backupCheck";
            this.backupCheck.Size = new System.Drawing.Size(122, 20);
            this.backupCheck.TabIndex = 42;
            this.backupCheck.Text = "Backup camera";
            this.backupCheck.UseVisualStyleBackColor = true;
            // 
            // heatedSeatsCheck
            // 
            this.heatedSeatsCheck.AutoSize = true;
            this.heatedSeatsCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heatedSeatsCheck.ForeColor = System.Drawing.Color.Gainsboro;
            this.heatedSeatsCheck.Location = new System.Drawing.Point(452, 457);
            this.heatedSeatsCheck.Name = "heatedSeatsCheck";
            this.heatedSeatsCheck.Size = new System.Drawing.Size(108, 20);
            this.heatedSeatsCheck.TabIndex = 41;
            this.heatedSeatsCheck.Text = "Heated seats";
            this.heatedSeatsCheck.UseVisualStyleBackColor = true;
            // 
            // sunroofCheck
            // 
            this.sunroofCheck.AutoSize = true;
            this.sunroofCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sunroofCheck.ForeColor = System.Drawing.Color.Gainsboro;
            this.sunroofCheck.Location = new System.Drawing.Point(452, 431);
            this.sunroofCheck.Name = "sunroofCheck";
            this.sunroofCheck.Size = new System.Drawing.Size(134, 20);
            this.sunroofCheck.TabIndex = 40;
            this.sunroofCheck.Text = "Sunroof/moonroof";
            this.sunroofCheck.UseVisualStyleBackColor = true;
            // 
            // leatherCheck
            // 
            this.leatherCheck.AutoSize = true;
            this.leatherCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leatherCheck.ForeColor = System.Drawing.Color.Gainsboro;
            this.leatherCheck.Location = new System.Drawing.Point(298, 433);
            this.leatherCheck.Name = "leatherCheck";
            this.leatherCheck.Size = new System.Drawing.Size(108, 20);
            this.leatherCheck.TabIndex = 39;
            this.leatherCheck.Text = "Leather seats";
            this.leatherCheck.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(296, 407);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 20);
            this.label10.TabIndex = 38;
            this.label10.Text = "Select features";
            // 
            // transTextBox
            // 
            this.transTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.transTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transTextBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.transTextBox.Location = new System.Drawing.Point(146, 525);
            this.transTextBox.Name = "transTextBox";
            this.transTextBox.Size = new System.Drawing.Size(118, 24);
            this.transTextBox.TabIndex = 37;
            // 
            // bodyComboBox
            // 
            this.bodyComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Sedan",
            "Coupe",
            "Sports Car",
            "Station Wagon",
            "Hatchback",
            "Convertible",
            "CUV",
            "Minivan",
            "Pickup Truck",
            "SUV"});
            this.bodyComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.bodyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bodyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bodyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bodyComboBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.bodyComboBox.FormattingEnabled = true;
            this.bodyComboBox.Items.AddRange(new object[] {
            "Sedan",
            "Coupe",
            "Sports Car",
            "Station Wagon",
            "Hatchback",
            "Convertible",
            "CUV",
            "Minivan",
            "Pickup Truck",
            "SUV"});
            this.bodyComboBox.Location = new System.Drawing.Point(13, 475);
            this.bodyComboBox.Name = "bodyComboBox";
            this.bodyComboBox.Size = new System.Drawing.Size(118, 26);
            this.bodyComboBox.TabIndex = 34;
            // 
            // engineComboBox
            // 
            this.engineComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.engineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.engineComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.engineComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.engineComboBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.engineComboBox.FormattingEnabled = true;
            this.engineComboBox.Items.AddRange(new object[] {
            "Gas",
            "Electric",
            "Hybrid"});
            this.engineComboBox.Location = new System.Drawing.Point(146, 427);
            this.engineComboBox.Name = "engineComboBox";
            this.engineComboBox.Size = new System.Drawing.Size(118, 26);
            this.engineComboBox.TabIndex = 33;
            // 
            // addCarBtn
            // 
            this.addCarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCarBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.addCarBtn.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.addCarBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.addCarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addCarBtn.IconSize = 33;
            this.addCarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCarBtn.Location = new System.Drawing.Point(294, 542);
            this.addCarBtn.Name = "addCarBtn";
            this.addCarBtn.Size = new System.Drawing.Size(154, 46);
            this.addCarBtn.TabIndex = 31;
            this.addCarBtn.Text = "Update";
            this.addCarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addCarBtn.UseVisualStyleBackColor = true;
            this.addCarBtn.Click += new System.EventHandler(this.addCarBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.exitBtn);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.addEventBtn);
            this.panel2.Controls.Add(this.eventsDataGridView);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.uploadPhotoBtn);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1127, 298);
            this.panel2.TabIndex = 32;
            // 
            // exitBtn
            // 
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.exitBtn.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.exitBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.exitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitBtn.IconSize = 33;
            this.exitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.Location = new System.Drawing.Point(-4, -1);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.exitBtn.Size = new System.Drawing.Size(123, 32);
            this.exitBtn.TabIndex = 50;
            this.exitBtn.Text = "Back to car";
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // uploadPhotoBtn
            // 
            this.uploadPhotoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadPhotoBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.uploadPhotoBtn.IconChar = FontAwesome.Sharp.IconChar.Camera;
            this.uploadPhotoBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.uploadPhotoBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.uploadPhotoBtn.IconSize = 33;
            this.uploadPhotoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uploadPhotoBtn.Location = new System.Drawing.Point(13, 252);
            this.uploadPhotoBtn.Name = "uploadPhotoBtn";
            this.uploadPhotoBtn.Size = new System.Drawing.Size(147, 37);
            this.uploadPhotoBtn.TabIndex = 7;
            this.uploadPhotoBtn.Text = "Upload a photo";
            this.uploadPhotoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uploadPhotoBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.uploadPhotoBtn.UseVisualStyleBackColor = true;
            this.uploadPhotoBtn.Click += new System.EventHandler(this.uploadPhotoBtn_Click);
            // 
            // eventsTableAdapter
            // 
            this.eventsTableAdapter.ClearBeforeFill = true;
            // 
            // enginesBindingSource
            // 
            this.enginesBindingSource.DataMember = "engines";
            this.enginesBindingSource.DataSource = this.car_dealership_fullDataSet;
            // 
            // enginesTableAdapter
            // 
            this.enginesTableAdapter.ClearBeforeFill = true;
            // 
            // bodiesBindingSource
            // 
            this.bodiesBindingSource.DataMember = "bodies";
            this.bodiesBindingSource.DataSource = this.car_dealership_fullDataSet;
            // 
            // bodiesTableAdapter
            // 
            this.bodiesTableAdapter.ClearBeforeFill = true;
            // 
            // EditCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1127, 740);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditCarForm";
            this.Text = "EditCarForm";
            this.Load += new System.EventHandler(this.EditCarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_dealership_fullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enginesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox eventTypeComboBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox descTextBox;
        private System.Windows.Forms.TextBox powerTextBox;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton addEventBtn;
        private System.Windows.Forms.DataGridView eventsDataGridView;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox capTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mileageTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker yearTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker eventDateTimePicker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox bluetoothCheck;
        private System.Windows.Forms.CheckBox acCheck;
        private System.Windows.Forms.CheckBox navSysCheck;
        private System.Windows.Forms.CheckBox appleCheck;
        private System.Windows.Forms.CheckBox thirdCheck;
        private System.Windows.Forms.CheckBox blindCheck;
        private System.Windows.Forms.CheckBox remoteCheck;
        private System.Windows.Forms.CheckBox backupCheck;
        private System.Windows.Forms.CheckBox heatedSeatsCheck;
        private System.Windows.Forms.CheckBox sunroofCheck;
        private System.Windows.Forms.CheckBox leatherCheck;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox transTextBox;
        private System.Windows.Forms.ComboBox bodyComboBox;
        private System.Windows.Forms.ComboBox engineComboBox;
        private FontAwesome.Sharp.IconButton addCarBtn;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton uploadPhotoBtn;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private FontAwesome.Sharp.IconButton exitBtn;
        private car_dealership_fullDataSet car_dealership_fullDataSet;
        private System.Windows.Forms.BindingSource eventsBindingSource;
        private car_dealership_fullDataSetTableAdapters.eventsTableAdapter eventsTableAdapter;
        private System.Windows.Forms.BindingSource enginesBindingSource;
        private car_dealership_fullDataSetTableAdapters.enginesTableAdapter enginesTableAdapter;
        private System.Windows.Forms.BindingSource bodiesBindingSource;
        private car_dealership_fullDataSetTableAdapters.bodiesTableAdapter bodiesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCol;
    }
}