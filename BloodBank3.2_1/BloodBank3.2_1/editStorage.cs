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
    public partial class editStorage : UserControl
    {
        private Dictionary<string, int> month = new Dictionary<string, int>();
        private string[] m = { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        public editStorage()
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

        private int id, di, mi;

        public void loadData(string id, string bg, string roomNo, string sl, string dd)
        {
            this.id = Convert.ToInt32(id);
            bgCombo.Text = bg;
            roomText.Text = roomNo;
            slText.Text = sl;
            di = dd.IndexOf("-");
            dateCombo1.Text = dd.Substring(0, di);
            mi = dd.LastIndexOf("-");
            monthCombo1.Text = m[Convert.ToInt32(dd.Substring(di + 1, mi - di - 1))];
            yearCombo1.Text = dd.Substring(mi + 1, 4);            
            enableEdit();
        }

        public void enableEdit()
        {
            bgEdit.Visible = true;
            roomEdit.Visible = true;
            slEdit.Visible = true;
            ddEdit.Visible = true;
        }

        public void disableEdit()
        {
            bgEdit.Visible = false;
            roomEdit.Visible = false;
            slEdit.Visible = false;
            ddEdit.Visible = false;
        }        

        private void bgEdit_MouseHover(object sender, EventArgs e)
        {
            this.bgEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void bgEdit_MouseLeave(object sender, EventArgs e)
        {
            this.bgEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_12;
        }

        private void bgEdit_MouseDown(object sender, MouseEventArgs e)
        {
            this.bgEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_121;
        }

        private void bgEdit_MouseUp(object sender, MouseEventArgs e)
        {
            this.bgEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void roomEdit_MouseDown(object sender, MouseEventArgs e)
        {
            this.roomEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_121;
        }

        private void roomEdit_MouseHover(object sender, EventArgs e)
        {
            this.roomEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void roomEdit_MouseLeave(object sender, EventArgs e)
        {
            this.roomEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_12;
        }

        private void roomEdit_MouseUp(object sender, MouseEventArgs e)
        {
            this.roomEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void slEdit_MouseDown(object sender, MouseEventArgs e)
        {
            this.slEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_121;
        }

        private void slEdit_MouseHover(object sender, EventArgs e)
        {
            this.slEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void slEdit_MouseLeave(object sender, EventArgs e)
        {
            this.slEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_12;
        }

        private void slEdit_MouseUp(object sender, MouseEventArgs e)
        {
            this.slEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void ddEdit_MouseDown(object sender, MouseEventArgs e)
        {
            this.ddEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_121;
        }

        private void ddEdit_MouseHover(object sender, EventArgs e)
        {
            this.ddEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void ddEdit_MouseLeave(object sender, EventArgs e)
        {
            this.ddEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_12;
        }

        private void ddEdit_MouseUp(object sender, MouseEventArgs e)
        {
            this.ddEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        public void clearText()
        {
            bgCombo.Text = "";
            roomText.Text = "";
            slText.Text = "";
            dateCombo1.Text = "Date";
            monthCombo1.Text = "Month";
            yearCombo1.Text = "Year";
        }        

        private void bgEdit_Click(object sender, EventArgs e)
        {
            bgCombo.Enabled = true;            
        }

        private void roomEdit_Click(object sender, EventArgs e)
        {
            roomText.Enabled = true;
        }

        private void slEdit_Click(object sender, EventArgs e)
        {
            slText.Enabled = true;
        }

        private void ddEdit_Click(object sender, EventArgs e)
        {
            dateCombo1.Enabled = true;
            monthCombo1.Enabled = true;
            yearCombo1.Enabled = true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            connection con = new connection();
            con.storageUpdate(id, bgCombo.Text, roomText.Text, slText.Text, dateCombo1.Text + "-" + month[monthCombo1.Text] + "-" + yearCombo1.Text);
            clearText();
            dd.getData(2);
        }
    }
}
