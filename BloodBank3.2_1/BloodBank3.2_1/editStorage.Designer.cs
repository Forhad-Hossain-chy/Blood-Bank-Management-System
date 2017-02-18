namespace BloodBank3._2_1
{
    partial class editStorage
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
            this.slText = new System.Windows.Forms.TextBox();
            this.roomText = new System.Windows.Forms.TextBox();
            this.slLab = new System.Windows.Forms.Label();
            this.roomLab = new System.Windows.Forms.Label();
            this.bgLab = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bgCombo = new System.Windows.Forms.ComboBox();
            this.slEdit = new System.Windows.Forms.Label();
            this.ddEdit = new System.Windows.Forms.Label();
            this.roomEdit = new System.Windows.Forms.Label();
            this.bgEdit = new System.Windows.Forms.Label();
            this.yearCombo1 = new System.Windows.Forms.ComboBox();
            this.monthCombo1 = new System.Windows.Forms.ComboBox();
            this.dateCombo1 = new System.Windows.Forms.ComboBox();
            this.ddLab = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // slText
            // 
            this.slText.Enabled = false;
            this.slText.Location = new System.Drawing.Point(93, 74);
            this.slText.Name = "slText";
            this.slText.Size = new System.Drawing.Size(184, 20);
            this.slText.TabIndex = 11;
            // 
            // roomText
            // 
            this.roomText.Enabled = false;
            this.roomText.Location = new System.Drawing.Point(93, 45);
            this.roomText.Name = "roomText";
            this.roomText.Size = new System.Drawing.Size(184, 20);
            this.roomText.TabIndex = 10;
            // 
            // slLab
            // 
            this.slLab.AutoSize = true;
            this.slLab.Location = new System.Drawing.Point(13, 78);
            this.slLab.Name = "slLab";
            this.slLab.Size = new System.Drawing.Size(50, 13);
            this.slLab.TabIndex = 4;
            this.slLab.Text = "Serial No";
            // 
            // roomLab
            // 
            this.roomLab.AutoSize = true;
            this.roomLab.Location = new System.Drawing.Point(13, 48);
            this.roomLab.Name = "roomLab";
            this.roomLab.Size = new System.Drawing.Size(52, 13);
            this.roomLab.TabIndex = 2;
            this.roomLab.Text = "Room No";
            // 
            // bgLab
            // 
            this.bgLab.AutoSize = true;
            this.bgLab.Location = new System.Drawing.Point(13, 20);
            this.bgLab.Name = "bgLab";
            this.bgLab.Size = new System.Drawing.Size(66, 13);
            this.bgLab.TabIndex = 1;
            this.bgLab.Text = "Blood Group";
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Location = new System.Drawing.Point(558, 197);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bgCombo);
            this.panel1.Controls.Add(this.slEdit);
            this.panel1.Controls.Add(this.ddEdit);
            this.panel1.Controls.Add(this.roomEdit);
            this.panel1.Controls.Add(this.bgEdit);
            this.panel1.Controls.Add(this.yearCombo1);
            this.panel1.Controls.Add(this.monthCombo1);
            this.panel1.Controls.Add(this.dateCombo1);
            this.panel1.Controls.Add(this.slText);
            this.panel1.Controls.Add(this.roomText);
            this.panel1.Controls.Add(this.slLab);
            this.panel1.Controls.Add(this.ddLab);
            this.panel1.Controls.Add(this.roomLab);
            this.panel1.Controls.Add(this.bgLab);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 225);
            this.panel1.TabIndex = 2;
            // 
            // bgCombo
            // 
            this.bgCombo.Enabled = false;
            this.bgCombo.FormattingEnabled = true;
            this.bgCombo.Items.AddRange(new object[] {
            "AB+",
            "AB-",
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-"});
            this.bgCombo.Location = new System.Drawing.Point(93, 17);
            this.bgCombo.Name = "bgCombo";
            this.bgCombo.Size = new System.Drawing.Size(184, 21);
            this.bgCombo.TabIndex = 27;
            // 
            // slEdit
            // 
            this.slEdit.AutoSize = true;
            this.slEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_12;
            this.slEdit.Location = new System.Drawing.Point(283, 78);
            this.slEdit.Name = "slEdit";
            this.slEdit.Size = new System.Drawing.Size(16, 13);
            this.slEdit.TabIndex = 26;
            this.slEdit.Text = "   ";
            this.slEdit.Visible = false;
            this.slEdit.Click += new System.EventHandler(this.slEdit_Click);
            this.slEdit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.slEdit_MouseDown);
            this.slEdit.MouseLeave += new System.EventHandler(this.slEdit_MouseLeave);
            this.slEdit.MouseHover += new System.EventHandler(this.slEdit_MouseHover);
            this.slEdit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.slEdit_MouseUp);
            // 
            // ddEdit
            // 
            this.ddEdit.AutoSize = true;
            this.ddEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_12;
            this.ddEdit.Location = new System.Drawing.Point(283, 107);
            this.ddEdit.Name = "ddEdit";
            this.ddEdit.Size = new System.Drawing.Size(16, 13);
            this.ddEdit.TabIndex = 25;
            this.ddEdit.Text = "   ";
            this.ddEdit.Visible = false;
            this.ddEdit.Click += new System.EventHandler(this.ddEdit_Click);
            this.ddEdit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ddEdit_MouseDown);
            this.ddEdit.MouseLeave += new System.EventHandler(this.ddEdit_MouseLeave);
            this.ddEdit.MouseHover += new System.EventHandler(this.ddEdit_MouseHover);
            this.ddEdit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ddEdit_MouseUp);
            // 
            // roomEdit
            // 
            this.roomEdit.AutoSize = true;
            this.roomEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roomEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_12;
            this.roomEdit.Location = new System.Drawing.Point(283, 49);
            this.roomEdit.Name = "roomEdit";
            this.roomEdit.Size = new System.Drawing.Size(16, 13);
            this.roomEdit.TabIndex = 24;
            this.roomEdit.Text = "   ";
            this.roomEdit.Visible = false;
            this.roomEdit.Click += new System.EventHandler(this.roomEdit_Click);
            this.roomEdit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.roomEdit_MouseDown);
            this.roomEdit.MouseLeave += new System.EventHandler(this.roomEdit_MouseLeave);
            this.roomEdit.MouseHover += new System.EventHandler(this.roomEdit_MouseHover);
            this.roomEdit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.roomEdit_MouseUp);
            // 
            // bgEdit
            // 
            this.bgEdit.AutoSize = true;
            this.bgEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bgEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_12;
            this.bgEdit.Location = new System.Drawing.Point(283, 20);
            this.bgEdit.Name = "bgEdit";
            this.bgEdit.Size = new System.Drawing.Size(16, 13);
            this.bgEdit.TabIndex = 23;
            this.bgEdit.Text = "   ";
            this.bgEdit.Visible = false;
            this.bgEdit.Click += new System.EventHandler(this.bgEdit_Click);
            this.bgEdit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bgEdit_MouseDown);
            this.bgEdit.MouseLeave += new System.EventHandler(this.bgEdit_MouseLeave);
            this.bgEdit.MouseHover += new System.EventHandler(this.bgEdit_MouseHover);
            this.bgEdit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bgEdit_MouseUp);
            // 
            // yearCombo1
            // 
            this.yearCombo1.Enabled = false;
            this.yearCombo1.FormattingEnabled = true;
            this.yearCombo1.Items.AddRange(new object[] {
            "1864",
            "1865",
            "1866",
            "1867",
            "1868",
            "1869",
            "1870",
            "1871",
            "1872",
            "1873",
            "1874",
            "1875",
            "1876",
            "1877",
            "1878",
            "1879",
            "1880",
            "1881",
            "1882",
            "1883",
            "1884",
            "1885",
            "1886",
            "1887",
            "1888",
            "1889",
            "1890",
            "1891",
            "1892",
            "1893",
            "1894",
            "1895",
            "1896",
            "1897",
            "1898",
            "1899",
            "1900",
            "1901",
            "1902",
            "1903",
            "1904",
            "1905",
            "1906",
            "1907",
            "1908",
            "1909",
            "1910",
            "1911",
            "1912",
            "1913",
            "1914",
            "1915",
            "1916",
            "1917",
            "1918",
            "1919",
            "1920",
            "1921",
            "1922",
            "1923",
            "1924",
            "1925",
            "1926",
            "1927",
            "1928",
            "1929",
            "1930",
            "1931",
            "1932",
            "1933",
            "1934",
            "1935",
            "1936",
            "1937",
            "1938",
            "1939",
            "1940",
            "1941",
            "1942",
            "1943",
            "1944",
            "1945",
            "1946",
            "1947",
            "1948",
            "1949",
            "1950",
            "1951",
            "1952",
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014"});
            this.yearCombo1.Location = new System.Drawing.Point(222, 102);
            this.yearCombo1.Name = "yearCombo1";
            this.yearCombo1.Size = new System.Drawing.Size(55, 21);
            this.yearCombo1.TabIndex = 19;
            this.yearCombo1.Text = "Year";
            // 
            // monthCombo1
            // 
            this.monthCombo1.Enabled = false;
            this.monthCombo1.FormattingEnabled = true;
            this.monthCombo1.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthCombo1.Location = new System.Drawing.Point(144, 102);
            this.monthCombo1.Name = "monthCombo1";
            this.monthCombo1.Size = new System.Drawing.Size(72, 21);
            this.monthCombo1.TabIndex = 18;
            this.monthCombo1.Text = "Month";
            // 
            // dateCombo1
            // 
            this.dateCombo1.Enabled = false;
            this.dateCombo1.FormattingEnabled = true;
            this.dateCombo1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dateCombo1.Location = new System.Drawing.Point(93, 102);
            this.dateCombo1.Name = "dateCombo1";
            this.dateCombo1.Size = new System.Drawing.Size(45, 21);
            this.dateCombo1.TabIndex = 17;
            this.dateCombo1.Text = "Date";
            // 
            // ddLab
            // 
            this.ddLab.AutoSize = true;
            this.ddLab.Location = new System.Drawing.Point(13, 106);
            this.ddLab.Name = "ddLab";
            this.ddLab.Size = new System.Drawing.Size(76, 13);
            this.ddLab.TabIndex = 3;
            this.ddLab.Text = "Donation Date";
            // 
            // editStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "editStorage";
            this.Size = new System.Drawing.Size(652, 238);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label roomEdit;
        private System.Windows.Forms.Label bgEdit;
        private System.Windows.Forms.TextBox slText;
        private System.Windows.Forms.TextBox roomText;
        private System.Windows.Forms.Label slLab;
        private System.Windows.Forms.Label roomLab;
        private System.Windows.Forms.Label bgLab;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label slEdit;
        private System.Windows.Forms.Label ddEdit;
        private System.Windows.Forms.ComboBox yearCombo1;
        private System.Windows.Forms.ComboBox monthCombo1;
        private System.Windows.Forms.ComboBox dateCombo1;
        private System.Windows.Forms.Label ddLab;
        private System.Windows.Forms.ComboBox bgCombo;
    }
}
