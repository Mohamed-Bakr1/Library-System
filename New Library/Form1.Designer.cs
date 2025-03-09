using System.Windows.Forms;

namespace New_Library
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.filter = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.srch_lbl = new System.Windows.Forms.Label();
            this.search_bx = new System.Windows.Forms.TextBox();
            this.rate_lbl = new System.Windows.Forms.Label();
            this.topic_lbl = new System.Windows.Forms.Label();
            this.date_lbl = new System.Windows.Forms.Label();
            this.lang_lbl = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.namelbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = global::New_Library.Properties.Resources.WhatsApp_Image_2023_12_20_at_02_56_59_6fca18f2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.filter);
            this.panel1.Controls.Add(this.search_btn);
            this.panel1.Controls.Add(this.srch_lbl);
            this.panel1.Controls.Add(this.search_bx);
            this.panel1.Controls.Add(this.rate_lbl);
            this.panel1.Controls.Add(this.topic_lbl);
            this.panel1.Controls.Add(this.date_lbl);
            this.panel1.Controls.Add(this.lang_lbl);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.namelbl);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2052, 501);
            this.panel1.TabIndex = 0;
            // 
            // filter
            // 
            this.filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.filter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filter.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter.ForeColor = System.Drawing.Color.White;
            this.filter.Location = new System.Drawing.Point(972, 388);
            this.filter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(92, 43);
            this.filter.TabIndex = 12;
            this.filter.Text = "filter";
            this.filter.UseVisualStyleBackColor = false;
            this.filter.Click += new System.EventHandler(this.filter_Click1);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.Black;
            this.search_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.search_btn.Location = new System.Drawing.Point(1075, 108);
            this.search_btn.Margin = new System.Windows.Forms.Padding(0);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(93, 42);
            this.search_btn.TabIndex = 11;
            this.search_btn.Text = "🔍";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // srch_lbl
            // 
            this.srch_lbl.BackColor = System.Drawing.Color.Transparent;
            this.srch_lbl.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srch_lbl.ForeColor = System.Drawing.Color.Tan;
            this.srch_lbl.Location = new System.Drawing.Point(933, 46);
            this.srch_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.srch_lbl.Name = "srch_lbl";
            this.srch_lbl.Size = new System.Drawing.Size(164, 57);
            this.srch_lbl.TabIndex = 10;
            this.srch_lbl.Text = "Search";
            // 
            // search_bx
            // 
            this.search_bx.BackColor = System.Drawing.SystemColors.Window;
            this.search_bx.Location = new System.Drawing.Point(857, 110);
            this.search_bx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search_bx.Multiline = true;
            this.search_bx.Name = "search_bx";
            this.search_bx.Size = new System.Drawing.Size(220, 38);
            this.search_bx.TabIndex = 9;
            // 
            // rate_lbl
            // 
            this.rate_lbl.AutoSize = true;
            this.rate_lbl.BackColor = System.Drawing.Color.Transparent;
            this.rate_lbl.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rate_lbl.ForeColor = System.Drawing.Color.White;
            this.rate_lbl.Location = new System.Drawing.Point(1511, 225);
            this.rate_lbl.Name = "rate_lbl";
            this.rate_lbl.Size = new System.Drawing.Size(69, 49);
            this.rate_lbl.TabIndex = 8;
            this.rate_lbl.Text = "Rate";
            // 
            // topic_lbl
            // 
            this.topic_lbl.AutoSize = true;
            this.topic_lbl.BackColor = System.Drawing.Color.Transparent;
            this.topic_lbl.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topic_lbl.ForeColor = System.Drawing.Color.White;
            this.topic_lbl.Location = new System.Drawing.Point(767, 225);
            this.topic_lbl.Name = "topic_lbl";
            this.topic_lbl.Size = new System.Drawing.Size(82, 49);
            this.topic_lbl.TabIndex = 7;
            this.topic_lbl.Text = "Topic";
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.BackColor = System.Drawing.Color.Transparent;
            this.date_lbl.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lbl.ForeColor = System.Drawing.Color.White;
            this.date_lbl.Location = new System.Drawing.Point(1147, 225);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(154, 49);
            this.date_lbl.TabIndex = 6;
            this.date_lbl.Text = "Release Date";
            // 
            // lang_lbl
            // 
            this.lang_lbl.AutoSize = true;
            this.lang_lbl.BackColor = System.Drawing.Color.Transparent;
            this.lang_lbl.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lang_lbl.ForeColor = System.Drawing.Color.White;
            this.lang_lbl.Location = new System.Drawing.Point(437, 225);
            this.lang_lbl.Name = "lang_lbl";
            this.lang_lbl.Size = new System.Drawing.Size(121, 49);
            this.lang_lbl.TabIndex = 5;
            this.lang_lbl.Text = "Language";
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.Ivory;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox4.Location = new System.Drawing.Point(1467, 278);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(167, 24);
            this.comboBox4.TabIndex = 4;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.Ivory;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "2005-2010",
            "2010-2015",
            "2015-2020"});
            this.comboBox3.Location = new System.Drawing.Point(1144, 278);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(167, 24);
            this.comboBox3.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.Ivory;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Science and Nature",
            "Fantasy",
            "Romance"});
            this.comboBox2.Location = new System.Drawing.Point(725, 278);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(167, 24);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Ivory;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "English",
            "Arabic"});
            this.comboBox1.Location = new System.Drawing.Point(412, 278);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.BackColor = System.Drawing.Color.Transparent;
            this.namelbl.Font = new System.Drawing.Font("Edwardian Script ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.ForeColor = System.Drawing.Color.Orange;
            this.namelbl.Location = new System.Drawing.Point(3, 9);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(359, 94);
            this.namelbl.TabIndex = 0;
            this.namelbl.Text = "My Library";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(90, 527);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1873, 382);
            this.panel2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1871, 922);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private Panel panel1;
        private Label rate_lbl;
        private Label topic_lbl;
        private Label date_lbl;
        private Label lang_lbl;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label namelbl;
        private Button search_btn;
        private Label srch_lbl;
        private TextBox search_bx;
        private Button filter;

        #endregion

        private Panel panel2;
    }
}