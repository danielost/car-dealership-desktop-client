
namespace course_work
{
    partial class CarThumbnail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarThumbnail));
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceUsdLabel = new System.Windows.Forms.Label();
            this.plateLabel = new System.Windows.Forms.Label();
            this.vinLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.priceUahLabel = new System.Windows.Forms.Label();
            this.dateAddedLabel = new FontAwesome.Sharp.IconButton();
            this.accidentLabel = new FontAwesome.Sharp.IconButton();
            this.transLabel = new FontAwesome.Sharp.IconButton();
            this.fuelLabel = new FontAwesome.Sharp.IconButton();
            this.mileageLabel = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.nameLabel.Location = new System.Drawing.Point(335, 4);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(194, 29);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Car name + Year";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            this.nameLabel.MouseEnter += new System.EventHandler(this.nameLabel_MouseEnter);
            this.nameLabel.MouseLeave += new System.EventHandler(this.nameLabel_MouseLeave);
            // 
            // priceUsdLabel
            // 
            this.priceUsdLabel.AutoSize = true;
            this.priceUsdLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.priceUsdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceUsdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            this.priceUsdLabel.Location = new System.Drawing.Point(0, 0);
            this.priceUsdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceUsdLabel.Name = "priceUsdLabel";
            this.priceUsdLabel.Size = new System.Drawing.Size(99, 25);
            this.priceUsdLabel.TabIndex = 2;
            this.priceUsdLabel.Text = "PriceUsd";
            // 
            // plateLabel
            // 
            this.plateLabel.AutoSize = true;
            this.plateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plateLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.plateLabel.Location = new System.Drawing.Point(4, 5);
            this.plateLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.plateLabel.Name = "plateLabel";
            this.plateLabel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plateLabel.Size = new System.Drawing.Size(86, 27);
            this.plateLabel.TabIndex = 7;
            this.plateLabel.Text = "AX7777AX";
            // 
            // vinLabel
            // 
            this.vinLabel.AutoSize = true;
            this.vinLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vinLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.vinLabel.Location = new System.Drawing.Point(98, 5);
            this.vinLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 4);
            this.vinLabel.Name = "vinLabel";
            this.vinLabel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vinLabel.Size = new System.Drawing.Size(164, 27);
            this.vinLabel.TabIndex = 8;
            this.vinLabel.Text = "A4FS3FG7F8D15FG62";
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.descLabel.Location = new System.Drawing.Point(333, 154);
            this.descLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(40, 17);
            this.descLabel.TabIndex = 11;
            this.descLabel.Text = "Desc";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.priceUahLabel);
            this.panel1.Controls.Add(this.priceUsdLabel);
            this.panel1.Location = new System.Drawing.Point(333, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 30);
            this.panel1.TabIndex = 12;
            // 
            // priceUahLabel
            // 
            this.priceUahLabel.AutoSize = true;
            this.priceUahLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.priceUahLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.priceUahLabel.Location = new System.Drawing.Point(99, 0);
            this.priceUahLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceUahLabel.Name = "priceUahLabel";
            this.priceUahLabel.Padding = new System.Windows.Forms.Padding(27, 2, 0, 0);
            this.priceUahLabel.Size = new System.Drawing.Size(67, 19);
            this.priceUahLabel.TabIndex = 13;
            this.priceUahLabel.Text = "Desc";
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
            this.dateAddedLabel.Location = new System.Drawing.Point(330, 173);
            this.dateAddedLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateAddedLabel.Name = "dateAddedLabel";
            this.dateAddedLabel.Size = new System.Drawing.Size(160, 37);
            this.dateAddedLabel.TabIndex = 10;
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
            this.accidentLabel.Location = new System.Drawing.Point(270, 0);
            this.accidentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.accidentLabel.Name = "accidentLabel";
            this.accidentLabel.Size = new System.Drawing.Size(205, 41);
            this.accidentLabel.TabIndex = 9;
            this.accidentLabel.Text = "Been in accident";
            this.accidentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accidentLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.accidentLabel.UseVisualStyleBackColor = true;
            // 
            // transLabel
            // 
            this.transLabel.FlatAppearance.BorderSize = 0;
            this.transLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.transLabel.IconChar = FontAwesome.Sharp.IconChar.GitAlt;
            this.transLabel.IconColor = System.Drawing.Color.IndianRed;
            this.transLabel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.transLabel.IconSize = 22;
            this.transLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transLabel.Location = new System.Drawing.Point(464, 86);
            this.transLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.transLabel.Name = "transLabel";
            this.transLabel.Size = new System.Drawing.Size(161, 28);
            this.transLabel.TabIndex = 6;
            this.transLabel.Text = "eng";
            this.transLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.transLabel.UseVisualStyleBackColor = true;
            // 
            // fuelLabel
            // 
            this.fuelLabel.FlatAppearance.BorderSize = 0;
            this.fuelLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fuelLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.fuelLabel.IconChar = FontAwesome.Sharp.IconChar.GasPump;
            this.fuelLabel.IconColor = System.Drawing.Color.IndianRed;
            this.fuelLabel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.fuelLabel.IconSize = 22;
            this.fuelLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fuelLabel.Location = new System.Drawing.Point(332, 86);
            this.fuelLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fuelLabel.Name = "fuelLabel";
            this.fuelLabel.Size = new System.Drawing.Size(100, 28);
            this.fuelLabel.TabIndex = 5;
            this.fuelLabel.Text = "eng";
            this.fuelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fuelLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.fuelLabel.UseVisualStyleBackColor = true;
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
            this.mileageLabel.Location = new System.Drawing.Point(332, 59);
            this.mileageLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mileageLabel.Name = "mileageLabel";
            this.mileageLabel.Size = new System.Drawing.Size(179, 28);
            this.mileageLabel.TabIndex = 4;
            this.mileageLabel.Text = "mileage";
            this.mileageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mileageLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mileageLabel.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.plateLabel);
            this.flowLayoutPanel2.Controls.Add(this.vinLabel);
            this.flowLayoutPanel2.Controls.Add(this.accidentLabel);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(333, 114);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(547, 36);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // CarThumbnail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.dateAddedLabel);
            this.Controls.Add(this.transLabel);
            this.Controls.Add(this.fuelLabel);
            this.Controls.Add(this.mileageLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.Name = "CarThumbnail";
            this.Size = new System.Drawing.Size(825, 209);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceUsdLabel;
        private FontAwesome.Sharp.IconButton mileageLabel;
        private FontAwesome.Sharp.IconButton fuelLabel;
        private FontAwesome.Sharp.IconButton transLabel;
        private System.Windows.Forms.Label plateLabel;
        private System.Windows.Forms.Label vinLabel;
        private FontAwesome.Sharp.IconButton accidentLabel;
        private FontAwesome.Sharp.IconButton dateAddedLabel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label priceUahLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}
