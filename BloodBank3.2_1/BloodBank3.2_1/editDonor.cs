using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank3._2_1
{
    public partial class editDonor : UserControl
    {
        private Dictionary<string, int> month = new Dictionary<string, int>();
        private string[] m = { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        public editDonor()
        {
            InitializeComponent();
            loadMonth();
        }

        private void loadMonth()
        {
            month["January"] = 1;
            month["February"] = 2;
            month["March"] = 3;
            month["April"] = 4;
            month["May"] = 5;
            month["June"] = 6;
            month["July"] = 7;
            month["August"] = 8;
            month["September"] = 9;
            month["October"] = 10;
            month["November"] = 11;
            month["December"] = 12;
        }

        private dataGridViewBox dd;

        public void getObj(dataGridViewBox dd)
        {
            this.dd = dd;
        }

        private int id,di,mi;

        public void loadData(string id, string name, string pro, string dob, string add, string em, string ph, string bg, string dod)
        {
            this.id = Convert.ToInt32(id);
            nameText.Text = name;
            proText.Text = pro;            
            di = dob.IndexOf("-");            
            dateCombo1.Text = dob.Substring(0, di);
            mi = dob.LastIndexOf("-");            
            monthCombo1.Text = m[Convert.ToInt32(dob.Substring(di + 1, mi - di - 1))];
            yearCombo1.Text = dob.Substring(mi+1, 4);
            addText.Text = add;
            emText.Text = em;
            phText.Text = ph;
            bgCombo.Text = bg;
            di = dod.IndexOf("-");            
            dateCombo2.Text = dod.Substring(0, di);
            mi = dod.LastIndexOf("-");            
            monthCombo2.Text = m[Convert.ToInt32(dod.Substring(di + 1, mi - di - 1))];
            yearCombo2.Text = dod.Substring(mi + 1, 4);
            enableEdit();
        }

        public void enableEdit()
        {
            nameEdit.Visible = true;
            proEdit.Visible = true;
            dobEdit.Visible = true;
            addEdit.Visible = true;
            emEdit.Visible = true;
            phEdit.Visible = true;
            bgEdit.Visible = true;
            dodEdit.Visible = true;
        }

        public void disableEdit()
        {
            nameEdit.Visible = false;
            proEdit.Visible = false;
            dobEdit.Visible = false;
            addEdit.Visible = false;
            emEdit.Visible = false;
            phEdit.Visible = false;
            bgEdit.Visible = false;
            dodEdit.Visible = false;
        }        

        private void nameEdit_Click(object sender, EventArgs e)
        {
            nameText.Enabled = true;
        }

        private void proEdit_Click(object sender, EventArgs e)
        {
            proText.Enabled = true;
        }

        private void dobEdit_Click(object sender, EventArgs e)
        {
            dateCombo1.Enabled = monthCombo1.Enabled = yearCombo1.Enabled = true;
        }

        private void addEdit_Click(object sender, EventArgs e)
        {
            addText.Enabled = true;
        }        

        private void emEdit_Click(object sender, EventArgs e)
        {
            emText.Enabled = true;
        }

        private void phEdit_Click(object sender, EventArgs e)
        {
            phText.Enabled = true;
        }

        private void bgEdit_Click(object sender, EventArgs e)
        {
            bgCombo.Enabled = true;
        }

        private void dodEdit_Click(object sender, EventArgs e)
        {
            dateCombo2.Enabled = monthCombo2.Enabled = yearCombo2.Enabled = true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            connection con = new connection();
            con.donorUpdate(id,nameText.Text, proText.Text, dateCombo1.Text + "-" + month[monthCombo1.Text] + "-" + yearCombo1.Text, addText.Text, emText.Text, phText.Text, bgCombo.Text, dateCombo2.Text + "-" + month[monthCombo2.Text] + "-" + yearCombo2.Text);
            clearText();
            dd.getData(1);
        }

        public void clearText()
        {
            nameText.Text = "";
            proText.Text = "";
            dateCombo1.Text = dateCombo2.Text = "Date";
            monthCombo1.Text = monthCombo2.Text = "Month";
            yearCombo1.Text = yearCombo2.Text = "Year";
            addText.Text = "";
            emText.Text = "";
            phText.Text = "";
            bgCombo.Text = "";
        }        

        private void nameEdit_MouseHover(object sender, EventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void nameEdit_MouseLeave(object sender, EventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_12;
        }

        private void nameEdit_MouseDown(object sender, MouseEventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_121;
        }

        private void nameEdit_MouseUp(object sender, MouseEventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void proEdit_MouseDown(object sender, MouseEventArgs e)
        {
            this.proEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_121;
        }

        private void proEdit_MouseHover(object sender, EventArgs e)
        {
            this.proEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void proEdit_MouseLeave(object sender, EventArgs e)
        {
            this.proEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_12;
        }

        private void proEdit_MouseUp(object sender, MouseEventArgs e)
        {
            this.proEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void dobEdit_MouseDown(object sender, MouseEventArgs e)
        {
            this.dobEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_121;
        }

        private void dobEdit_MouseHover(object sender, EventArgs e)
        {
            this.dobEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void dobEdit_MouseLeave(object sender, EventArgs e)
        {
            this.dobEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_12;
        }

        private void dobEdit_MouseUp(object sender, MouseEventArgs e)
        {
            this.dobEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void addEdit_MouseDown(object sender, MouseEventArgs e)
        {
            this.addEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_121;
        }

        private void addEdit_MouseHover(object sender, EventArgs e)
        {
            this.addEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void addEdit_MouseLeave(object sender, EventArgs e)
        {
            this.addEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_12;
        }

        private void addEdit_MouseUp(object sender, MouseEventArgs e)
        {
            this.addEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void emEdit_MouseDown(object sender, MouseEventArgs e)
        {
            this.emEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_121;
        }

        private void emEdit_MouseHover(object sender, EventArgs e)
        {
            this.emEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void emEdit_MouseLeave(object sender, EventArgs e)
        {
            this.emEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_12;
        }

        private void emEdit_MouseUp(object sender, MouseEventArgs e)
        {
            this.emEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void phEdit_MouseDown(object sender, MouseEventArgs e)
        {
            this.phEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_121;
        }

        private void phEdit_MouseHover(object sender, EventArgs e)
        {
            this.phEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void phEdit_MouseLeave(object sender, EventArgs e)
        {
            this.phEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_12;
        }

        private void phEdit_MouseUp(object sender, MouseEventArgs e)
        {
            this.phEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void bgEdit_MouseDown(object sender, MouseEventArgs e)
        {
            this.bgEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_121;
        }

        private void bgEdit_MouseHover(object sender, EventArgs e)
        {
            this.bgEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void bgEdit_MouseLeave(object sender, EventArgs e)
        {
            this.bgEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_12;
        }

        private void bgEdit_MouseUp(object sender, MouseEventArgs e)
        {
            this.bgEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void dodEdit_MouseDown(object sender, MouseEventArgs e)
        {
            this.dodEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_121;
        }

        private void dodEdit_MouseHover(object sender, EventArgs e)
        {
            this.dodEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void dodEdit_MouseLeave(object sender, EventArgs e)
        {
            this.dodEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_12;
        }

        private void dodEdit_MouseUp(object sender, MouseEventArgs e)
        {
            this.dodEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }
    }
}
