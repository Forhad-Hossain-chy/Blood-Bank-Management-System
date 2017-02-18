namespace BloodBank3._2_1
{
    partial class dataGridViewBox
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchPan = new System.Windows.Forms.Panel();
            this.donorSearchPan = new System.Windows.Forms.Panel();
            this.nameLab1 = new System.Windows.Forms.Label();
            this.addLab1 = new System.Windows.Forms.Label();
            this.phLab1 = new System.Windows.Forms.Label();
            this.bgLab1 = new System.Windows.Forms.Label();
            this.nameText1 = new System.Windows.Forms.TextBox();
            this.addText1 = new System.Windows.Forms.TextBox();
            this.phText1 = new System.Windows.Forms.TextBox();
            this.bgCombo1 = new System.Windows.Forms.ComboBox();
            this.storageSearchPan = new System.Windows.Forms.Panel();
            this.bgCombo2 = new System.Windows.Forms.ComboBox();
            this.slText = new System.Windows.Forms.TextBox();
            this.bgLab2 = new System.Windows.Forms.Label();
            this.slLab = new System.Windows.Forms.Label();
            this.clientSearchPan = new System.Windows.Forms.Panel();
            this.phText2 = new System.Windows.Forms.TextBox();
            this.addText2 = new System.Windows.Forms.TextBox();
            this.nameText2 = new System.Windows.Forms.TextBox();
            this.phLab2 = new System.Windows.Forms.Label();
            this.addLab2 = new System.Windows.Forms.Label();
            this.nameLab2 = new System.Windows.Forms.Label();
            this.storageSearchButton = new System.Windows.Forms.Panel();
            this.clientSearchButton = new System.Windows.Forms.Panel();
            this.donorSearchButton = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.searchPan.SuspendLayout();
            this.donorSearchPan.SuspendLayout();
            this.storageSearchPan.SuspendLayout();
            this.clientSearchPan.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(757, 191);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // searchPan
            // 
            this.searchPan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchPan.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.searchPan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPan.Controls.Add(this.donorSearchPan);
            this.searchPan.Controls.Add(this.storageSearchPan);
            this.searchPan.Controls.Add(this.clientSearchPan);
            this.searchPan.Location = new System.Drawing.Point(3, 3);
            this.searchPan.Name = "searchPan";
            this.searchPan.Size = new System.Drawing.Size(757, 74);
            this.searchPan.TabIndex = 1;
            // 
            // donorSearchPan
            // 
            this.donorSearchPan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.donorSearchPan.BackColor = System.Drawing.SystemColors.Control;
            this.donorSearchPan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.donorSearchPan.Controls.Add(this.donorSearchButton);
            this.donorSearchPan.Controls.Add(this.bgCombo1);
            this.donorSearchPan.Controls.Add(this.phText1);
            this.donorSearchPan.Controls.Add(this.addText1);
            this.donorSearchPan.Controls.Add(this.nameText1);
            this.donorSearchPan.Controls.Add(this.bgLab1);
            this.donorSearchPan.Controls.Add(this.phLab1);
            this.donorSearchPan.Controls.Add(this.addLab1);
            this.donorSearchPan.Controls.Add(this.nameLab1);
            this.donorSearchPan.Location = new System.Drawing.Point(3, 3);
            this.donorSearchPan.Name = "donorSearchPan";
            this.donorSearchPan.Size = new System.Drawing.Size(749, 66);
            this.donorSearchPan.TabIndex = 0;
            this.donorSearchPan.Visible = false;
            // 
            // nameLab1
            // 
            this.nameLab1.AutoSize = true;
            this.nameLab1.Location = new System.Drawing.Point(3, 10);
            this.nameLab1.Name = "nameLab1";
            this.nameLab1.Size = new System.Drawing.Size(35, 13);
            this.nameLab1.TabIndex = 0;
            this.nameLab1.Text = "Name";
            // 
            // addLab1
            // 
            this.addLab1.AutoSize = true;
            this.addLab1.Location = new System.Drawing.Point(3, 39);
            this.addLab1.Name = "addLab1";
            this.addLab1.Size = new System.Drawing.Size(45, 13);
            this.addLab1.TabIndex = 1;
            this.addLab1.Text = "Address";
            // 
            // phLab1
            // 
            this.phLab1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phLab1.AutoSize = true;
            this.phLab1.Location = new System.Drawing.Point(356, 10);
            this.phLab1.Name = "phLab1";
            this.phLab1.Size = new System.Drawing.Size(55, 13);
            this.phLab1.TabIndex = 2;
            this.phLab1.Text = "Phone No";
            // 
            // bgLab1
            // 
            this.bgLab1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bgLab1.AutoSize = true;
            this.bgLab1.Location = new System.Drawing.Point(356, 39);
            this.bgLab1.Name = "bgLab1";
            this.bgLab1.Size = new System.Drawing.Size(66, 13);
            this.bgLab1.TabIndex = 3;
            this.bgLab1.Text = "Blood Group";
            // 
            // nameText1
            // 
            this.nameText1.Location = new System.Drawing.Point(54, 7);
            this.nameText1.Name = "nameText1";
            this.nameText1.Size = new System.Drawing.Size(292, 20);
            this.nameText1.TabIndex = 4;
            // 
            // addText1
            // 
            this.addText1.Location = new System.Drawing.Point(54, 36);
            this.addText1.Name = "addText1";
            this.addText1.Size = new System.Drawing.Size(292, 20);
            this.addText1.TabIndex = 5;
            // 
            // phText1
            // 
            this.phText1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phText1.Location = new System.Drawing.Point(421, 7);
            this.phText1.Name = "phText1";
            this.phText1.Size = new System.Drawing.Size(275, 20);
            this.phText1.TabIndex = 6;
            // 
            // bgCombo1
            // 
            this.bgCombo1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bgCombo1.FormattingEnabled = true;
            this.bgCombo1.Items.AddRange(new object[] {
            "AB+",
            "AB-",
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-"});
            this.bgCombo1.Location = new System.Drawing.Point(421, 35);
            this.bgCombo1.Name = "bgCombo1";
            this.bgCombo1.Size = new System.Drawing.Size(275, 21);
            this.bgCombo1.TabIndex = 7;
            // 
            // storageSearchPan
            // 
            this.storageSearchPan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.storageSearchPan.BackColor = System.Drawing.SystemColors.Control;
            this.storageSearchPan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.storageSearchPan.Controls.Add(this.storageSearchButton);
            this.storageSearchPan.Controls.Add(this.bgCombo2);
            this.storageSearchPan.Controls.Add(this.slText);
            this.storageSearchPan.Controls.Add(this.bgLab2);
            this.storageSearchPan.Controls.Add(this.slLab);
            this.storageSearchPan.Location = new System.Drawing.Point(3, 3);
            this.storageSearchPan.Name = "storageSearchPan";
            this.storageSearchPan.Size = new System.Drawing.Size(749, 66);
            this.storageSearchPan.TabIndex = 8;
            this.storageSearchPan.Visible = false;
            // 
            // bgCombo2
            // 
            this.bgCombo2.FormattingEnabled = true;
            this.bgCombo2.Items.AddRange(new object[] {
            "AB+",
            "AB-",
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-"});
            this.bgCombo2.Location = new System.Drawing.Point(75, 7);
            this.bgCombo2.Name = "bgCombo2";
            this.bgCombo2.Size = new System.Drawing.Size(275, 21);
            this.bgCombo2.TabIndex = 7;
            // 
            // slText
            // 
            this.slText.Location = new System.Drawing.Point(75, 36);
            this.slText.Name = "slText";
            this.slText.Size = new System.Drawing.Size(275, 20);
            this.slText.TabIndex = 5;
            // 
            // bgLab2
            // 
            this.bgLab2.AutoSize = true;
            this.bgLab2.Location = new System.Drawing.Point(3, 10);
            this.bgLab2.Name = "bgLab2";
            this.bgLab2.Size = new System.Drawing.Size(66, 13);
            this.bgLab2.TabIndex = 3;
            this.bgLab2.Text = "Blood Group";
            // 
            // slLab
            // 
            this.slLab.AutoSize = true;
            this.slLab.Location = new System.Drawing.Point(3, 39);
            this.slLab.Name = "slLab";
            this.slLab.Size = new System.Drawing.Size(50, 13);
            this.slLab.TabIndex = 1;
            this.slLab.Text = "Serial No";
            // 
            // clientSearchPan
            // 
            this.clientSearchPan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientSearchPan.BackColor = System.Drawing.SystemColors.Control;
            this.clientSearchPan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientSearchPan.Controls.Add(this.clientSearchButton);
            this.clientSearchPan.Controls.Add(this.phText2);
            this.clientSearchPan.Controls.Add(this.addText2);
            this.clientSearchPan.Controls.Add(this.nameText2);
            this.clientSearchPan.Controls.Add(this.phLab2);
            this.clientSearchPan.Controls.Add(this.addLab2);
            this.clientSearchPan.Controls.Add(this.nameLab2);
            this.clientSearchPan.Location = new System.Drawing.Point(3, 3);
            this.clientSearchPan.Name = "clientSearchPan";
            this.clientSearchPan.Size = new System.Drawing.Size(749, 66);
            this.clientSearchPan.TabIndex = 8;
            this.clientSearchPan.Visible = false;
            // 
            // phText2
            // 
            this.phText2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phText2.Location = new System.Drawing.Point(421, 7);
            this.phText2.Name = "phText2";
            this.phText2.Size = new System.Drawing.Size(275, 20);
            this.phText2.TabIndex = 6;
            // 
            // addText2
            // 
            this.addText2.Location = new System.Drawing.Point(54, 33);
            this.addText2.Name = "addText2";
            this.addText2.Size = new System.Drawing.Size(292, 20);
            this.addText2.TabIndex = 5;
            // 
            // nameText2
            // 
            this.nameText2.Location = new System.Drawing.Point(54, 7);
            this.nameText2.Name = "nameText2";
            this.nameText2.Size = new System.Drawing.Size(292, 20);
            this.nameText2.TabIndex = 4;
            // 
            // phLab2
            // 
            this.phLab2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phLab2.AutoSize = true;
            this.phLab2.Location = new System.Drawing.Point(356, 10);
            this.phLab2.Name = "phLab2";
            this.phLab2.Size = new System.Drawing.Size(55, 13);
            this.phLab2.TabIndex = 2;
            this.phLab2.Text = "Phone No";
            // 
            // addLab2
            // 
            this.addLab2.AutoSize = true;
            this.addLab2.Location = new System.Drawing.Point(3, 39);
            this.addLab2.Name = "addLab2";
            this.addLab2.Size = new System.Drawing.Size(45, 13);
            this.addLab2.TabIndex = 1;
            this.addLab2.Text = "Address";
            // 
            // nameLab2
            // 
            this.nameLab2.AutoSize = true;
            this.nameLab2.Location = new System.Drawing.Point(3, 10);
            this.nameLab2.Name = "nameLab2";
            this.nameLab2.Size = new System.Drawing.Size(35, 13);
            this.nameLab2.TabIndex = 0;
            this.nameLab2.Text = "Name";
            // 
            // storageSearchButton
            // 
            this.storageSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.storageSearchButton.BackColor = System.Drawing.Color.Transparent;
            this.storageSearchButton.BackgroundImage = global::BloodBank3._2_1.Properties.Resources.search1;
            this.storageSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.storageSearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.storageSearchButton.Location = new System.Drawing.Point(702, 7);
            this.storageSearchButton.Name = "storageSearchButton";
            this.storageSearchButton.Size = new System.Drawing.Size(42, 49);
            this.storageSearchButton.TabIndex = 9;
            this.storageSearchButton.Click += new System.EventHandler(this.storageSearchButton_Click);
            // 
            // clientSearchButton
            // 
            this.clientSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clientSearchButton.BackColor = System.Drawing.Color.Transparent;
            this.clientSearchButton.BackgroundImage = global::BloodBank3._2_1.Properties.Resources.search1;
            this.clientSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clientSearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientSearchButton.Location = new System.Drawing.Point(702, 7);
            this.clientSearchButton.Name = "clientSearchButton";
            this.clientSearchButton.Size = new System.Drawing.Size(42, 49);
            this.clientSearchButton.TabIndex = 9;
            this.clientSearchButton.Click += new System.EventHandler(this.clientSearchButton_Click);
            // 
            // donorSearchButton
            // 
            this.donorSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.donorSearchButton.BackColor = System.Drawing.Color.Transparent;
            this.donorSearchButton.BackgroundImage = global::BloodBank3._2_1.Properties.Resources.search1;
            this.donorSearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.donorSearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.donorSearchButton.Location = new System.Drawing.Point(702, 7);
            this.donorSearchButton.Name = "donorSearchButton";
            this.donorSearchButton.Size = new System.Drawing.Size(42, 49);
            this.donorSearchButton.TabIndex = 8;
            this.donorSearchButton.Click += new System.EventHandler(this.donorSearchButton_Click);
            // 
            // dataGridViewBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchPan);
            this.Controls.Add(this.dataGridView1);
            this.Name = "dataGridViewBox";
            this.Size = new System.Drawing.Size(763, 277);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.searchPan.ResumeLayout(false);
            this.donorSearchPan.ResumeLayout(false);
            this.donorSearchPan.PerformLayout();
            this.storageSearchPan.ResumeLayout(false);
            this.storageSearchPan.PerformLayout();
            this.clientSearchPan.ResumeLayout(false);
            this.clientSearchPan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel searchPan;
        private System.Windows.Forms.Panel donorSearchPan;
        private System.Windows.Forms.Panel storageSearchPan;
        private System.Windows.Forms.ComboBox bgCombo2;
        private System.Windows.Forms.TextBox slText;
        private System.Windows.Forms.Label bgLab2;
        private System.Windows.Forms.Label slLab;
        private System.Windows.Forms.ComboBox bgCombo1;
        private System.Windows.Forms.TextBox phText1;
        private System.Windows.Forms.TextBox addText1;
        private System.Windows.Forms.TextBox nameText1;
        private System.Windows.Forms.Label bgLab1;
        private System.Windows.Forms.Label phLab1;
        private System.Windows.Forms.Label addLab1;
        private System.Windows.Forms.Label nameLab1;
        private System.Windows.Forms.Panel clientSearchPan;
        private System.Windows.Forms.TextBox phText2;
        private System.Windows.Forms.TextBox addText2;
        private System.Windows.Forms.TextBox nameText2;
        private System.Windows.Forms.Label phLab2;
        private System.Windows.Forms.Label addLab2;
        private System.Windows.Forms.Label nameLab2;
        private System.Windows.Forms.Panel donorSearchButton;
        private System.Windows.Forms.Panel storageSearchButton;
        private System.Windows.Forms.Panel clientSearchButton;
    }
}
