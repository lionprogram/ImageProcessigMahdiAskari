namespace ImageProcessigMahdiAskari
{
    partial class Form1
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.GrayToBinary = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.ConvertToBinery = new System.Windows.Forms.Button();
            this.counterTrackBar = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.changeRedToBlue = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.BinaryPic = new System.Windows.Forms.PictureBox();
            this.GrayPicBox = new System.Windows.Forms.PictureBox();
            this.selectGray = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.horFlip = new System.Windows.Forms.Button();
            this.vertFlip = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.GrayToBinary.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BinaryPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrayPicBox)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.GrayToBinary);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(930, 627);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // GrayToBinary
            // 
            this.GrayToBinary.Controls.Add(this.tabPage2);
            this.GrayToBinary.Controls.Add(this.tabPage1);
            this.GrayToBinary.Location = new System.Drawing.Point(3, 3);
            this.GrayToBinary.Name = "GrayToBinary";
            this.GrayToBinary.SelectedIndex = 0;
            this.GrayToBinary.Size = new System.Drawing.Size(937, 624);
            this.GrayToBinary.TabIndex = 0;
            this.GrayToBinary.Tag = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl1);
            this.tabPage2.Controls.Add(this.BinaryPic);
            this.tabPage2.Controls.Add(this.GrayPicBox);
            this.tabPage2.Controls.Add(this.selectGray);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(929, 598);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "پردازش تصویر";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(3, 497);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(873, 105);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.ConvertToBinery);
            this.tabPage3.Controls.Add(this.counterTrackBar);
            this.tabPage3.Controls.Add(this.trackBar1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(865, 79);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "GrayToBinary";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "سطح آستانه";
            // 
            // ConvertToBinery
            // 
            this.ConvertToBinery.Location = new System.Drawing.Point(730, 6);
            this.ConvertToBinery.Name = "ConvertToBinery";
            this.ConvertToBinery.Size = new System.Drawing.Size(129, 41);
            this.ConvertToBinery.TabIndex = 6;
            this.ConvertToBinery.Text = "تبدیل به باینری";
            this.ConvertToBinery.UseVisualStyleBackColor = true;
            this.ConvertToBinery.Click += new System.EventHandler(this.ConvertToBinery_Click);
            // 
            // counterTrackBar
            // 
            this.counterTrackBar.AutoSize = true;
            this.counterTrackBar.Location = new System.Drawing.Point(23, 3);
            this.counterTrackBar.Name = "counterTrackBar";
            this.counterTrackBar.Size = new System.Drawing.Size(0, 13);
            this.counterTrackBar.TabIndex = 9;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(17, 23);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(339, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Value = 128;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.comboBox1);
            this.tabPage4.Controls.Add(this.changeRedToBlue);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(865, 79);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "ChangeColor";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "انتخاب رنگ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "RED TO BLUE",
            "RED TO GREEN",
            "GREEN TO BLUE"});
            this.comboBox1.Location = new System.Drawing.Point(115, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // changeRedToBlue
            // 
            this.changeRedToBlue.Location = new System.Drawing.Point(652, 6);
            this.changeRedToBlue.Name = "changeRedToBlue";
            this.changeRedToBlue.Size = new System.Drawing.Size(205, 23);
            this.changeRedToBlue.TabIndex = 0;
            this.changeRedToBlue.Text = "تغییر رنگ";
            this.changeRedToBlue.UseVisualStyleBackColor = true;
            this.changeRedToBlue.Click += new System.EventHandler(this.changeRedToBlue_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(865, 79);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Triangular bottom";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "تبدیل پایین مثلثی تصویر به خاکستری";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BinaryPic
            // 
            this.BinaryPic.BackColor = System.Drawing.Color.Gray;
            this.BinaryPic.Location = new System.Drawing.Point(462, 41);
            this.BinaryPic.Name = "BinaryPic";
            this.BinaryPic.Size = new System.Drawing.Size(450, 450);
            this.BinaryPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BinaryPic.TabIndex = 5;
            this.BinaryPic.TabStop = false;
            // 
            // GrayPicBox
            // 
            this.GrayPicBox.BackColor = System.Drawing.Color.DimGray;
            this.GrayPicBox.Location = new System.Drawing.Point(6, 41);
            this.GrayPicBox.Name = "GrayPicBox";
            this.GrayPicBox.Size = new System.Drawing.Size(450, 450);
            this.GrayPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GrayPicBox.TabIndex = 4;
            this.GrayPicBox.TabStop = false;
            // 
            // selectGray
            // 
            this.selectGray.Location = new System.Drawing.Point(6, 12);
            this.selectGray.Name = "selectGray";
            this.selectGray.Size = new System.Drawing.Size(75, 23);
            this.selectGray.TabIndex = 3;
            this.selectGray.Text = "انتخاب";
            this.selectGray.UseVisualStyleBackColor = true;
            this.selectGray.Click += new System.EventHandler(this.selectGray_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("2  Koodak", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(87, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "لطفا تصویر خاکستری خود را انتخاب کنید:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1106, 598);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "About";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MRT_Poster_8", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(592, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 26);
            this.label7.TabIndex = 4;
            this.label7.Text = "دکتر بابک نریمان جهان";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MRT_Poster_8", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(781, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "استاد";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MRT_Poster_8", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(741, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "طراحی و ارائه";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MRT_Poster_8", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(633, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "مهدی عسکری";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MRT_Poster_8", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(741, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "پروژه درس پردازش تصویر";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.vertFlip);
            this.tabPage6.Controls.Add(this.horFlip);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(865, 79);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Flip";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // horFlip
            // 
            this.horFlip.Location = new System.Drawing.Point(784, 6);
            this.horFlip.Name = "horFlip";
            this.horFlip.Size = new System.Drawing.Size(75, 36);
            this.horFlip.TabIndex = 0;
            this.horFlip.Text = "Flip عمودی";
            this.horFlip.UseVisualStyleBackColor = true;
            this.horFlip.Click += new System.EventHandler(this.horFlip_Click);
            // 
            // vertFlip
            // 
            this.vertFlip.Location = new System.Drawing.Point(700, 6);
            this.vertFlip.Name = "vertFlip";
            this.vertFlip.Size = new System.Drawing.Size(78, 36);
            this.vertFlip.TabIndex = 1;
            this.vertFlip.Text = "Flip افقی";
            this.vertFlip.UseVisualStyleBackColor = true;
            this.vertFlip.Click += new System.EventHandler(this.vertFlip_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 627);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.GrayToBinary.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BinaryPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrayPicBox)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl GrayToBinary;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox BinaryPic;
        private System.Windows.Forms.PictureBox GrayPicBox;
        private System.Windows.Forms.Button selectGray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button ConvertToBinery;
        private System.Windows.Forms.Label counterTrackBar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button changeRedToBlue;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button vertFlip;
        private System.Windows.Forms.Button horFlip;
    }
}

