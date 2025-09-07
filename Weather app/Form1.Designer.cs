namespace Weather_app
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button4 = new Button();
            button1 = new Button();
            label11 = new Label();
            Countrytxtbox = new TextBox();
            panel1 = new Panel();
            label7 = new Label();
            label10 = new Label();
            label13 = new Label();
            lonlabel = new Label();
            latlabel = new Label();
            CountryLabel = new Label();
            labelsunset = new Label();
            labelsunrise = new Label();
            labelpressure = new Label();
            labelwindspeed = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            labeldetails = new Label();
            labelcondition = new Label();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            tempCel_lable = new Label();
            label1 = new Label();
            TempK_label = new Label();
            label2 = new Label();
            TempF_label = new Label();
            label8 = new Label();
            Dt_label = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Transparent;
            button4.Location = new Point(443, 5);
            button4.Name = "button4";
            button4.Size = new Size(34, 34);
            button4.TabIndex = 6;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(402, 5);
            button1.Name = "button1";
            button1.Size = new Size(35, 36);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 15F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(0, 4);
            label11.Name = "label11";
            label11.Size = new Size(122, 35);
            label11.TabIndex = 4;
            label11.Text = "Enter city:";
            // 
            // Countrytxtbox
            // 
            Countrytxtbox.BackColor = Color.FromArgb(167, 161, 179);
            Countrytxtbox.BorderStyle = BorderStyle.FixedSingle;
            Countrytxtbox.Font = new Font("Segoe UI", 13F);
            Countrytxtbox.ForeColor = Color.White;
            Countrytxtbox.Location = new Point(123, 5);
            Countrytxtbox.Name = "Countrytxtbox";
            Countrytxtbox.Size = new Size(268, 36);
            Countrytxtbox.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(lonlabel);
            panel1.Controls.Add(latlabel);
            panel1.Controls.Add(CountryLabel);
            panel1.Controls.Add(labelsunset);
            panel1.Controls.Add(labelsunrise);
            panel1.Controls.Add(labelpressure);
            panel1.Controls.Add(labelwindspeed);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(labeldetails);
            panel1.Controls.Add(labelcondition);
            panel1.Location = new Point(-2, 391);
            panel1.Name = "panel1";
            panel1.Size = new Size(994, 195);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(794, 21);
            label7.Name = "label7";
            label7.Size = new Size(75, 23);
            label7.TabIndex = 8;
            label7.Text = "Country:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(794, 93);
            label10.Name = "label10";
            label10.Size = new Size(37, 23);
            label10.TabIndex = 15;
            label10.Text = "Lat:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 10F);
            label13.ForeColor = Color.White;
            label13.Location = new Point(794, 56);
            label13.Name = "label13";
            label13.Size = new Size(38, 23);
            label13.TabIndex = 17;
            label13.Text = "lon:";
            // 
            // lonlabel
            // 
            lonlabel.AutoSize = true;
            lonlabel.BackColor = Color.Transparent;
            lonlabel.Font = new Font("Segoe UI", 10F);
            lonlabel.ForeColor = Color.White;
            lonlabel.Location = new Point(887, 93);
            lonlabel.Name = "lonlabel";
            lonlabel.Size = new Size(41, 23);
            lonlabel.TabIndex = 18;
            lonlabel.Text = "N/A";
            // 
            // latlabel
            // 
            latlabel.AutoSize = true;
            latlabel.BackColor = Color.Transparent;
            latlabel.Font = new Font("Segoe UI", 10F);
            latlabel.ForeColor = Color.White;
            latlabel.Location = new Point(887, 56);
            latlabel.Name = "latlabel";
            latlabel.Size = new Size(41, 23);
            latlabel.TabIndex = 16;
            latlabel.Text = "N/A";
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.BackColor = Color.Transparent;
            CountryLabel.Font = new Font("Segoe UI", 10F);
            CountryLabel.ForeColor = Color.White;
            CountryLabel.Location = new Point(887, 21);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(41, 23);
            CountryLabel.TabIndex = 14;
            CountryLabel.Text = "N/A";
            // 
            // labelsunset
            // 
            labelsunset.AutoSize = true;
            labelsunset.BackColor = Color.Transparent;
            labelsunset.Font = new Font("Segoe UI", 10F);
            labelsunset.ForeColor = SystemColors.ControlLightLight;
            labelsunset.Location = new Point(110, 126);
            labelsunset.Name = "labelsunset";
            labelsunset.Size = new Size(41, 23);
            labelsunset.TabIndex = 7;
            labelsunset.Text = "N/A";
            // 
            // labelsunrise
            // 
            labelsunrise.AutoSize = true;
            labelsunrise.BackColor = Color.Transparent;
            labelsunrise.Font = new Font("Segoe UI", 10F);
            labelsunrise.ForeColor = Color.White;
            labelsunrise.Location = new Point(110, 93);
            labelsunrise.Name = "labelsunrise";
            labelsunrise.Size = new Size(41, 23);
            labelsunrise.TabIndex = 6;
            labelsunrise.Text = "N/A";
            // 
            // labelpressure
            // 
            labelpressure.AutoSize = true;
            labelpressure.BackColor = Color.Transparent;
            labelpressure.Font = new Font("Segoe UI", 10F);
            labelpressure.ForeColor = Color.White;
            labelpressure.Location = new Point(279, 56);
            labelpressure.Name = "labelpressure";
            labelpressure.Size = new Size(41, 23);
            labelpressure.TabIndex = 5;
            labelpressure.Text = "N/A";
            // 
            // labelwindspeed
            // 
            labelwindspeed.AutoSize = true;
            labelwindspeed.BackColor = Color.Transparent;
            labelwindspeed.Font = new Font("Segoe UI", 10F);
            labelwindspeed.ForeColor = Color.White;
            labelwindspeed.Location = new Point(279, 21);
            labelwindspeed.Name = "labelwindspeed";
            labelwindspeed.Size = new Size(41, 23);
            labelwindspeed.TabIndex = 4;
            labelwindspeed.Text = "N/A";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(174, 56);
            label6.Name = "label6";
            label6.Size = new Size(78, 23);
            label6.TabIndex = 3;
            label6.Text = "Pressure:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(174, 21);
            label5.Name = "label5";
            label5.Size = new Size(99, 23);
            label5.TabIndex = 3;
            label5.Text = "Windspeed:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(29, 126);
            label4.Name = "label4";
            label4.Size = new Size(65, 23);
            label4.TabIndex = 2;
            label4.Text = "Sunset:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 93);
            label3.Name = "label3";
            label3.Size = new Size(69, 23);
            label3.TabIndex = 1;
            label3.Text = "Sunrise:";
            // 
            // labeldetails
            // 
            labeldetails.AutoSize = true;
            labeldetails.BackColor = Color.Transparent;
            labeldetails.Font = new Font("Segoe UI", 10F);
            labeldetails.ForeColor = Color.White;
            labeldetails.Location = new Point(29, 56);
            labeldetails.Name = "labeldetails";
            labeldetails.Size = new Size(61, 23);
            labeldetails.TabIndex = 1;
            labeldetails.Text = "Details";
            // 
            // labelcondition
            // 
            labelcondition.AutoSize = true;
            labelcondition.BackColor = Color.Transparent;
            labelcondition.Font = new Font("Segoe UI", 10F);
            labelcondition.ForeColor = SystemColors.ButtonHighlight;
            labelcondition.Location = new Point(29, 21);
            labelcondition.Name = "labelcondition";
            labelcondition.Size = new Size(85, 23);
            labelcondition.TabIndex = 0;
            labelcondition.Text = "Condition";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(Countrytxtbox);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(-2, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(994, 43);
            panel2.TabIndex = 2;
            panel2.MouseDown += Mousedown_event;
            panel2.MouseMove += Mousemove_event;
            panel2.MouseUp += Mouseup_event;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 11F);
            button3.Location = new Point(915, 0);
            button3.Name = "button3";
            button3.Size = new Size(41, 43);
            button3.TabIndex = 3;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(953, 0);
            button2.Name = "button2";
            button2.Size = new Size(41, 43);
            button2.TabIndex = 0;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // tempCel_lable
            // 
            tempCel_lable.AutoSize = true;
            tempCel_lable.BackColor = Color.Transparent;
            tempCel_lable.Font = new Font("Segoe UI", 30F);
            tempCel_lable.ForeColor = Color.White;
            tempCel_lable.Location = new Point(702, 80);
            tempCel_lable.Name = "tempCel_lable";
            tempCel_lable.Size = new Size(117, 67);
            tempCel_lable.TabIndex = 8;
            tempCel_lable.Text = "N/A";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(830, 89);
            label1.Name = "label1";
            label1.Size = new Size(54, 46);
            label1.TabIndex = 9;
            label1.Text = "°C";
            // 
            // TempK_label
            // 
            TempK_label.AutoSize = true;
            TempK_label.BackColor = Color.Transparent;
            TempK_label.Font = new Font("Segoe UI", 30F);
            TempK_label.ForeColor = Color.White;
            TempK_label.Location = new Point(702, 159);
            TempK_label.Name = "TempK_label";
            TempK_label.Size = new Size(117, 67);
            TempK_label.TabIndex = 10;
            TempK_label.Text = "N/A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(835, 168);
            label2.Name = "label2";
            label2.Size = new Size(53, 46);
            label2.TabIndex = 11;
            label2.Text = "°K";
            // 
            // TempF_label
            // 
            TempF_label.AutoSize = true;
            TempF_label.BackColor = Color.Transparent;
            TempF_label.Font = new Font("Segoe UI", 30F);
            TempF_label.ForeColor = Color.White;
            TempF_label.Location = new Point(702, 247);
            TempF_label.Name = "TempF_label";
            TempF_label.Size = new Size(117, 67);
            TempF_label.TabIndex = 12;
            TempF_label.Text = "N/A";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 20F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(834, 247);
            label8.Name = "label8";
            label8.Size = new Size(50, 46);
            label8.TabIndex = 13;
            label8.Text = "°F";
            // 
            // Dt_label
            // 
            Dt_label.AutoSize = true;
            Dt_label.BackColor = Color.Transparent;
            Dt_label.Font = new Font("Segoe UI", 40F);
            Dt_label.ForeColor = Color.White;
            Dt_label.Location = new Point(57, 159);
            Dt_label.Name = "Dt_label";
            Dt_label.Size = new Size(0, 89);
            Dt_label.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(885, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 139);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(991, 560);
            Controls.Add(pictureBox1);
            Controls.Add(Dt_label);
            Controls.Add(label8);
            Controls.Add(TempF_label);
            Controls.Add(label2);
            Controls.Add(TempK_label);
            Controls.Add(label1);
            Controls.Add(tempCel_lable);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label11;
        private TextBox Countrytxtbox;
        private Button button1;
        private Panel panel1;
        private Label labelsunset;
        private Label labelsunrise;
        private Label labelpressure;
        private Label labelwindspeed;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label labeldetails;
        private Label labelcondition;
        private Panel panel2;
        private Button button3;
        private Button button2;
        private Label tempCel_lable;
        private Label label1;
        private Label TempK_label;
        private Label label2;
        private Label TempF_label;
        private Label label8;
        private Label label7;
        private Label CountryLabel;
        private Label label10;
        private Label latlabel;
        private Label label13;
        private Label lonlabel;
        private Button button4;
        private Label Dt_label;
        private PictureBox pictureBox1;
    }
}
