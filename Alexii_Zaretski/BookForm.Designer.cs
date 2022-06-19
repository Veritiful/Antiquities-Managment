namespace Alexii_Zaretski
{
    partial class BookForm
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
            this.peselMasked = new System.Windows.Forms.MaskedTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.yearNumeric = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.isAvailableCheck = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.priceNumeric = new System.Windows.Forms.NumericUpDown();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.hardCoverCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pagesNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.languageTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.browseBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.chaptersTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.fillBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagesNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // peselMasked
            // 
            this.peselMasked.Location = new System.Drawing.Point(85, 74);
            this.peselMasked.Mask = "00000000000";
            this.peselMasked.Name = "peselMasked";
            this.peselMasked.Size = new System.Drawing.Size(206, 20);
            this.peselMasked.TabIndex = 3;
            this.peselMasked.ValidatingType = typeof(int);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // yearNumeric
            // 
            this.yearNumeric.Location = new System.Drawing.Point(84, 24);
            this.yearNumeric.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.yearNumeric.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.yearNumeric.Name = "yearNumeric";
            this.yearNumeric.Size = new System.Drawing.Size(206, 20);
            this.yearNumeric.TabIndex = 1;
            this.yearNumeric.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(314, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(469, 212);
            this.listBox1.TabIndex = 98;
            // 
            // isAvailableCheck
            // 
            this.isAvailableCheck.AutoSize = true;
            this.isAvailableCheck.Location = new System.Drawing.Point(85, 207);
            this.isAvailableCheck.Name = "isAvailableCheck";
            this.isAvailableCheck.Size = new System.Drawing.Size(15, 14);
            this.isAvailableCheck.TabIndex = 9;
            this.isAvailableCheck.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 96;
            this.label12.Text = "Is Available:";
            // 
            // priceNumeric
            // 
            this.priceNumeric.Location = new System.Drawing.Point(84, 178);
            this.priceNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.priceNumeric.Name = "priceNumeric";
            this.priceNumeric.Size = new System.Drawing.Size(206, 20);
            this.priceNumeric.TabIndex = 8;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(84, 126);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(206, 20);
            this.emailTextBox.TabIndex = 5;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(191, 152);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(100, 20);
            this.countryTextBox.TabIndex = 7;
            this.countryTextBox.Text = "Contry";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(85, 152);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 6;
            this.cityTextBox.Text = "City";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(84, 50);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(206, 20);
            this.titleTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(85, 100);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(206, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 85;
            this.label9.Text = "Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 84;
            this.label8.Text = "Seller\'s E-mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 82;
            this.label7.Text = "Location:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 79;
            this.label6.Text = "Title:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "Seller\'s Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Year published:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Seller\'s Pesel:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(216, 411);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // hardCoverCheckBox
            // 
            this.hardCoverCheckBox.AutoSize = true;
            this.hardCoverCheckBox.Location = new System.Drawing.Point(272, 208);
            this.hardCoverCheckBox.Name = "hardCoverCheckBox";
            this.hardCoverCheckBox.Size = new System.Drawing.Size(15, 14);
            this.hardCoverCheckBox.TabIndex = 10;
            this.hardCoverCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "Hard Cover:";
            // 
            // pagesNumeric
            // 
            this.pagesNumeric.Location = new System.Drawing.Point(85, 228);
            this.pagesNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.pagesNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pagesNumeric.Name = "pagesNumeric";
            this.pagesNumeric.Size = new System.Drawing.Size(206, 20);
            this.pagesNumeric.TabIndex = 11;
            this.pagesNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-2, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 101;
            this.label4.Text = "Amount of pages:";
            // 
            // languageTextBox
            // 
            this.languageTextBox.Location = new System.Drawing.Point(84, 280);
            this.languageTextBox.Name = "languageTextBox";
            this.languageTextBox.Size = new System.Drawing.Size(206, 20);
            this.languageTextBox.TabIndex = 13;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Location = new System.Drawing.Point(85, 254);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(206, 20);
            this.authorTextBox.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 105;
            this.label10.Text = "Language:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 103;
            this.label11.Text = "Author:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(85, 305);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 14;
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(84, 331);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(201, 29);
            this.browseBtn.TabIndex = 15;
            this.browseBtn.Text = "Browse...";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1, 311);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 109;
            this.label13.Text = "Seller\'s birth:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1, 339);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 110;
            this.label14.Text = "Item photo:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(314, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 201);
            this.pictureBox1.TabIndex = 111;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1, 372);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 112;
            this.label15.Text = "Book chapters:";
            // 
            // chaptersTextBox
            // 
            this.chaptersTextBox.Location = new System.Drawing.Point(84, 369);
            this.chaptersTextBox.Name = "chaptersTextBox";
            this.chaptersTextBox.Size = new System.Drawing.Size(201, 20);
            this.chaptersTextBox.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1, 396);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 13);
            this.label16.TabIndex = 114;
            this.label16.Text = "(Separate by #)";
            // 
            // fillBtn
            // 
            this.fillBtn.Location = new System.Drawing.Point(135, 411);
            this.fillBtn.Name = "fillBtn";
            this.fillBtn.Size = new System.Drawing.Size(75, 23);
            this.fillBtn.TabIndex = 17;
            this.fillBtn.Text = "Fill";
            this.fillBtn.UseVisualStyleBackColor = true;
            this.fillBtn.Click += new System.EventHandler(this.fillBtn_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fillBtn);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.chaptersTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.languageTextBox);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pagesNumeric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hardCoverCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.peselMasked);
            this.Controls.Add(this.yearNumeric);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.isAvailableCheck);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.priceNumeric);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Name = "BookForm";
            this.Text = "BookForm";
            ((System.ComponentModel.ISupportInitialize)(this.yearNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagesNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox peselMasked;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown yearNumeric;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox isAvailableCheck;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown priceNumeric;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox hardCoverCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown pagesNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox languageTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox chaptersTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button fillBtn;
    }
}