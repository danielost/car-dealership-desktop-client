
namespace course_work
{
    partial class CarInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarInfoForm));
            this.nameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.priceUsdLabel = new System.Windows.Forms.Label();
            this.priceUahLabel = new System.Windows.Forms.Label();
            this.vinLabel = new System.Windows.Forms.Label();
            this.plateLabel = new System.Windows.Forms.Label();
            this.dateAddedLabel = new FontAwesome.Sharp.IconButton();
            this.accidentLabel = new FontAwesome.Sharp.IconButton();
            this.mileageLabel = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.exitBtn = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.sellerName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.addressLabel = new System.Windows.Forms.Label();
            this.seeHisBtn = new System.Windows.Forms.LinkLabel();
            this.historyGridView = new System.Windows.Forms.DataGridView();
            this.carNameLittle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.milLabel = new System.Windows.Forms.Label();
            this.engLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.RichTextBox();
            this.featuresLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.featuresLabel = new System.Windows.Forms.Label();
            this.editBtn = new FontAwesome.Sharp.IconButton();
            this.deactivateBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.nameLabel.Location = new System.Drawing.Point(16, 38);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(302, 42);
            this.nameLabel.TabIndex = 14;
            this.nameLabel.Text = "Car name + Year";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(273, 82);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(556, 361);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // priceUsdLabel
            // 
            this.priceUsdLabel.AutoSize = true;
            this.priceUsdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceUsdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            this.priceUsdLabel.Location = new System.Drawing.Point(16, 82);
            this.priceUsdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceUsdLabel.Name = "priceUsdLabel";
            this.priceUsdLabel.Size = new System.Drawing.Size(133, 31);
            this.priceUsdLabel.TabIndex = 2;
            this.priceUsdLabel.Text = "PriceUsd";
            // 
            // priceUahLabel
            // 
            this.priceUahLabel.AutoSize = true;
            this.priceUahLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceUahLabel.ForeColor = System.Drawing.Color.White;
            this.priceUahLabel.Location = new System.Drawing.Point(19, 115);
            this.priceUahLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceUahLabel.Name = "priceUahLabel";
            this.priceUahLabel.Size = new System.Drawing.Size(49, 20);
            this.priceUahLabel.TabIndex = 13;
            this.priceUahLabel.Text = "Desc";
            this.priceUahLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // vinLabel
            // 
            this.vinLabel.AutoSize = true;
            this.vinLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vinLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.vinLabel.Location = new System.Drawing.Point(451, 624);
            this.vinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vinLabel.Name = "vinLabel";
            this.vinLabel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vinLabel.Size = new System.Drawing.Size(137, 27);
            this.vinLabel.TabIndex = 19;
            this.vinLabel.Text = "a4fs3fg7f8d15fg62";
            // 
            // plateLabel
            // 
            this.plateLabel.AutoSize = true;
            this.plateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plateLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.plateLabel.Location = new System.Drawing.Point(451, 593);
            this.plateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.plateLabel.Name = "plateLabel";
            this.plateLabel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plateLabel.Size = new System.Drawing.Size(86, 27);
            this.plateLabel.TabIndex = 18;
            this.plateLabel.Text = "AX7777AX";
            // 
            // dateAddedLabel
            // 
            this.dateAddedLabel.FlatAppearance.BorderSize = 0;
            this.dateAddedLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateAddedLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.dateAddedLabel.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.dateAddedLabel.IconColor = System.Drawing.Color.IndianRed;
            this.dateAddedLabel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dateAddedLabel.IconSize = 22;
            this.dateAddedLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateAddedLabel.Location = new System.Drawing.Point(845, 82);
            this.dateAddedLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateAddedLabel.Name = "dateAddedLabel";
            this.dateAddedLabel.Size = new System.Drawing.Size(184, 37);
            this.dateAddedLabel.TabIndex = 21;
            this.dateAddedLabel.Text = "Date added";
            this.dateAddedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateAddedLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dateAddedLabel.UseVisualStyleBackColor = true;
            // 
            // accidentLabel
            // 
            this.accidentLabel.FlatAppearance.BorderSize = 0;
            this.accidentLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accidentLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.accidentLabel.IconChar = FontAwesome.Sharp.IconChar.CarCrash;
            this.accidentLabel.IconColor = System.Drawing.Color.IndianRed;
            this.accidentLabel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.accidentLabel.IconSize = 22;
            this.accidentLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accidentLabel.Location = new System.Drawing.Point(845, 116);
            this.accidentLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accidentLabel.Name = "accidentLabel";
            this.accidentLabel.Size = new System.Drawing.Size(187, 37);
            this.accidentLabel.TabIndex = 20;
            this.accidentLabel.Text = "Been in accident";
            this.accidentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accidentLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.accidentLabel.UseVisualStyleBackColor = true;
            // 
            // mileageLabel
            // 
            this.mileageLabel.FlatAppearance.BorderSize = 0;
            this.mileageLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mileageLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.mileageLabel.IconChar = FontAwesome.Sharp.IconChar.TachometerAlt;
            this.mileageLabel.IconColor = System.Drawing.Color.IndianRed;
            this.mileageLabel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mileageLabel.IconSize = 22;
            this.mileageLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mileageLabel.Location = new System.Drawing.Point(16, 164);
            this.mileageLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mileageLabel.Name = "mileageLabel";
            this.mileageLabel.Size = new System.Drawing.Size(269, 28);
            this.mileageLabel.TabIndex = 15;
            this.mileageLabel.Text = "mileage";
            this.mileageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mileageLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mileageLabel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(19, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "(Price including VAT)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.exitBtn.Location = new System.Drawing.Point(-5, -1);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.exitBtn.Size = new System.Drawing.Size(164, 39);
            this.exitBtn.TabIndex = 24;
            this.exitBtn.Text = "Back to cars";
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 28;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(16, 334);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(237, 42);
            this.iconButton1.TabIndex = 25;
            this.iconButton1.Text = "Buy";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // sellerName
            // 
            this.sellerName.AutoSize = true;
            this.sellerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sellerName.ForeColor = System.Drawing.Color.White;
            this.sellerName.Location = new System.Drawing.Point(9, 27);
            this.sellerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sellerName.Name = "sellerName";
            this.sellerName.Size = new System.Drawing.Size(53, 20);
            this.sellerName.TabIndex = 26;
            this.sellerName.Text = "Name";
            this.sellerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.phoneLabel);
            this.groupBox1.Controls.Add(this.addressLabel);
            this.groupBox1.Controls.Add(this.sellerName);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(17, 201);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(237, 126);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seller Info";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLabel.ForeColor = System.Drawing.Color.White;
            this.phoneLabel.Location = new System.Drawing.Point(9, 71);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(53, 20);
            this.phoneLabel.TabIndex = 29;
            this.phoneLabel.Text = "Name";
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Gainsboro;
            this.linkLabel1.Location = new System.Drawing.Point(8, 92);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(180, 24);
            this.linkLabel1.TabIndex = 28;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "See all seller\'s offers";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressLabel.ForeColor = System.Drawing.Color.White;
            this.addressLabel.Location = new System.Drawing.Point(9, 49);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(53, 20);
            this.addressLabel.TabIndex = 27;
            this.addressLabel.Text = "Name";
            this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // seeHisBtn
            // 
            this.seeHisBtn.AutoSize = true;
            this.seeHisBtn.BackColor = System.Drawing.Color.Transparent;
            this.seeHisBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seeHisBtn.LinkColor = System.Drawing.Color.Gainsboro;
            this.seeHisBtn.Location = new System.Drawing.Point(16, 383);
            this.seeHisBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.seeHisBtn.Name = "seeHisBtn";
            this.seeHisBtn.Size = new System.Drawing.Size(134, 24);
            this.seeHisBtn.TabIndex = 30;
            this.seeHisBtn.TabStop = true;
            this.seeHisBtn.Text = "See car history";
            this.seeHisBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.seeHisBtn_LinkClicked);
            // 
            // historyGridView
            // 
            this.historyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyGridView.Location = new System.Drawing.Point(17, 409);
            this.historyGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.historyGridView.Name = "historyGridView";
            this.historyGridView.ReadOnly = true;
            this.historyGridView.RowHeadersWidth = 51;
            this.historyGridView.Size = new System.Drawing.Size(237, 319);
            this.historyGridView.TabIndex = 31;
            // 
            // carNameLittle
            // 
            this.carNameLittle.AutoSize = true;
            this.carNameLittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carNameLittle.ForeColor = System.Drawing.Color.Gainsboro;
            this.carNameLittle.Location = new System.Drawing.Point(273, 448);
            this.carNameLittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.carNameLittle.Name = "carNameLittle";
            this.carNameLittle.Size = new System.Drawing.Size(194, 29);
            this.carNameLittle.TabIndex = 32;
            this.carNameLittle.Text = "Car name + Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(275, 485);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(275, 513);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Mileage";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(275, 542);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Engine";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(275, 569);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Color";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(275, 599);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "License plate";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(275, 630);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "VIN code";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLabel.ForeColor = System.Drawing.Color.White;
            this.typeLabel.Location = new System.Drawing.Point(451, 485);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(45, 20);
            this.typeLabel.TabIndex = 38;
            this.typeLabel.Text = "Type";
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // milLabel
            // 
            this.milLabel.AutoSize = true;
            this.milLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.milLabel.ForeColor = System.Drawing.Color.White;
            this.milLabel.Location = new System.Drawing.Point(451, 513);
            this.milLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.milLabel.Name = "milLabel";
            this.milLabel.Size = new System.Drawing.Size(45, 20);
            this.milLabel.TabIndex = 39;
            this.milLabel.Text = "Type";
            this.milLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // engLabel
            // 
            this.engLabel.AutoSize = true;
            this.engLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.engLabel.ForeColor = System.Drawing.Color.White;
            this.engLabel.Location = new System.Drawing.Point(451, 542);
            this.engLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.engLabel.Name = "engLabel";
            this.engLabel.Size = new System.Drawing.Size(45, 20);
            this.engLabel.TabIndex = 40;
            this.engLabel.Text = "Type";
            this.engLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorLabel.ForeColor = System.Drawing.Color.White;
            this.colorLabel.Location = new System.Drawing.Point(451, 569);
            this.colorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(45, 20);
            this.colorLabel.TabIndex = 41;
            this.colorLabel.Text = "Type";
            this.colorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // descLabel
            // 
            this.descLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.descLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.descLabel.Location = new System.Drawing.Point(273, 672);
            this.descLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descLabel.Name = "descLabel";
            this.descLabel.ReadOnly = true;
            this.descLabel.Size = new System.Drawing.Size(839, 55);
            this.descLabel.TabIndex = 42;
            this.descLabel.Text = "";
            // 
            // featuresLayoutPanel
            // 
            this.featuresLayoutPanel.Location = new System.Drawing.Point(847, 182);
            this.featuresLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.featuresLayoutPanel.Name = "featuresLayoutPanel";
            this.featuresLayoutPanel.Size = new System.Drawing.Size(265, 450);
            this.featuresLayoutPanel.TabIndex = 43;
            // 
            // featuresLabel
            // 
            this.featuresLabel.AutoSize = true;
            this.featuresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.featuresLabel.ForeColor = System.Drawing.Color.White;
            this.featuresLabel.Location = new System.Drawing.Point(849, 155);
            this.featuresLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.featuresLabel.Name = "featuresLabel";
            this.featuresLabel.Size = new System.Drawing.Size(146, 20);
            this.featuresLabel.TabIndex = 44;
            this.featuresLabel.Text = "Highlited features:";
            this.featuresLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // editBtn
            // 
            this.editBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.editBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.editBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.editBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editBtn.IconSize = 23;
            this.editBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editBtn.Location = new System.Drawing.Point(909, -1);
            this.editBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editBtn.Name = "editBtn";
            this.editBtn.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.editBtn.Size = new System.Drawing.Size(105, 39);
            this.editBtn.TabIndex = 45;
            this.editBtn.Text = "Edit";
            this.editBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deactivateBtn
            // 
            this.deactivateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deactivateBtn.FlatAppearance.BorderSize = 0;
            this.deactivateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.deactivateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deactivateBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.deactivateBtn.IconChar = FontAwesome.Sharp.IconChar.SkullCrossbones;
            this.deactivateBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.deactivateBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deactivateBtn.IconSize = 23;
            this.deactivateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deactivateBtn.Location = new System.Drawing.Point(992, -1);
            this.deactivateBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deactivateBtn.Name = "deactivateBtn";
            this.deactivateBtn.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.deactivateBtn.Size = new System.Drawing.Size(136, 39);
            this.deactivateBtn.TabIndex = 46;
            this.deactivateBtn.Text = "Deactivate";
            this.deactivateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deactivateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deactivateBtn.UseVisualStyleBackColor = true;
            this.deactivateBtn.Click += new System.EventHandler(this.deactivateBtn_Click);
            // 
            // CarInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1127, 740);
            this.Controls.Add(this.deactivateBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.featuresLabel);
            this.Controls.Add(this.featuresLayoutPanel);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.engLabel);
            this.Controls.Add(this.milLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.carNameLittle);
            this.Controls.Add(this.historyGridView);
            this.Controls.Add(this.seeHisBtn);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceUsdLabel);
            this.Controls.Add(this.priceUahLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.vinLabel);
            this.Controls.Add(this.plateLabel);
            this.Controls.Add(this.dateAddedLabel);
            this.Controls.Add(this.accidentLabel);
            this.Controls.Add(this.mileageLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CarInfoForm";
            this.Text = "CarInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label priceUsdLabel;
        private System.Windows.Forms.Label priceUahLabel;
        private System.Windows.Forms.Label vinLabel;
        private System.Windows.Forms.Label plateLabel;
        private FontAwesome.Sharp.IconButton dateAddedLabel;
        private FontAwesome.Sharp.IconButton accidentLabel;
        private FontAwesome.Sharp.IconButton mileageLabel;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton exitBtn;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label sellerName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.LinkLabel seeHisBtn;
        private System.Windows.Forms.DataGridView historyGridView;
        private System.Windows.Forms.Label carNameLittle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label milLabel;
        private System.Windows.Forms.Label engLabel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.RichTextBox descLabel;
        private System.Windows.Forms.FlowLayoutPanel featuresLayoutPanel;
        private System.Windows.Forms.Label featuresLabel;
        private FontAwesome.Sharp.IconButton editBtn;
        private FontAwesome.Sharp.IconButton deactivateBtn;
    }
}