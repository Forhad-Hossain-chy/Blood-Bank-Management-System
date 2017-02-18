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
    public partial class editClient : UserControl
    {
        private Dictionary<string, int> month = new Dictionary<string, int>();
        private string[] m = { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        public editClient()
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

        public void loadData(string id, string name, string pro, string add, string em, string ph, string abp, string abn, string ap, string an, string bp, string bn, string op, string on, string pd)
        {
            this.id = Convert.ToInt32(id);
            nameText.Text = name;
            proText.Text = pro;
            addText.Text = add;
            emText.Text = em;
            phText.Text = ph;
            di = pd.IndexOf("-");
            dateCombo1.Text = pd.Substring(0, di);
            mi = pd.LastIndexOf("-");
            monthCombo1.Text = m[Convert.ToInt32(pd.Substring(di + 1, mi - di - 1))];
            yearCombo1.Text = pd.Substring(mi + 1, 4);
            amountText1.Text = abp;
            amountText2.Text = abn;
            amountText3.Text = ap;
            amountText4.Text = an;
            amountText5.Text = bp;
            amountText6.Text = bn;
            amountText7.Text = op;
            amountText8.Text = bn;
            enableEdit();
        }

        public void enableEdit()
        {
            nameEdit.Visible = true;
            proEdit.Visible = true;            
            addEdit.Visible = true;
            emEdit.Visible = true;
            phEdit.Visible = true;
            pdEdit.Visible = true;            
            amountEdit.Visible = true;
        }

        public void disableEdit()
        {
            nameEdit.Visible = false;
            proEdit.Visible = false;            
            addEdit.Visible = false;
            emEdit.Visible = false;
            phEdit.Visible = false;
            pdEdit.Visible = false;            
            amountEdit.Visible = false;
        }        

        private void nameEdit_Click(object sender, EventArgs e)
        {
            nameText.Enabled = true;
        }

        private void proEdit_Click(object sender, EventArgs e)
        {
            proText.Enabled = true;
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

        private void pdEdit_Click(object sender, EventArgs e)
        {
            dateCombo1.Enabled = monthCombo1.Enabled = yearCombo1.Enabled = true;
        }

        private void bgEdit_Click(object sender, EventArgs e)
        {            
        }

        private void amountEdit_Click(object sender, EventArgs e)
        {
            amountText1.Enabled = true;
            amountText2.Enabled = true;
            amountText3.Enabled = true;
            amountText4.Enabled = true;
            amountText5.Enabled = true;
            amountText6.Enabled = true;
            amountText7.Enabled = true;
            amountText8.Enabled = true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            connection con = new connection();
            con.clientUpdate(id, nameText.Text, proText.Text, addText.Text, emText.Text, phText.Text, Convert.ToInt32(amountText1.Text), Convert.ToInt32(amountText2.Text), Convert.ToInt32(amountText3.Text), Convert.ToInt32(amountText4.Text), Convert.ToInt32(amountText5.Text), Convert.ToInt32(amountText6.Text), Convert.ToInt32(amountText7.Text), Convert.ToInt32(amountText8.Text), dateCombo1.Text + "-" + month[monthCombo1.Text] + "-" + yearCombo1.Text);
            clearText();
            dd.getData(3);
        }

        public void clearText()
        {
            nameText.Text = "";
            proText.Text = "";
            addText.Text = "";
            emText.Text = "";
            phText.Text = "";
            dateCombo1.Text = "Date";
            monthCombo1.Text = "Month";
            yearCombo1.Text = "Year";                                    
            amountText1.Text = "";
            amountText2.Text = "";
            amountText3.Text = "";
            amountText4.Text = "";
            amountText5.Text = "";
            amountText6.Text = "";
            amountText7.Text = "";
            amountText8.Text = "";
        }

        private void nameEdit_MouseDown(object sender, MouseEventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_121;
        }

        private void nameEdit_MouseHover(object sender, EventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void nameEdit_MouseLeave(object sender, EventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_12;
        }

        private void nameEdit_MouseUp(object sender, MouseEventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void proEdit_MouseDown(object sender, MouseEventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_121;
        }

        private void proEdit_MouseHover(object sender, EventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void proEdit_MouseLeave(object sender, EventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_12;
        }

        private void proEdit_MouseUp(object sender, MouseEventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void addEdit_MouseDown(object sender, MouseEventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_121;
        }

        private void addEdit_MouseHover(object sender, EventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void addEdit_MouseLeave(object sender, EventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_12;
        }

        private void addEdit_MouseUp(object sender, MouseEventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void emEdit_MouseDown(object sender, MouseEventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_121;
        }

        private void emEdit_MouseHover(object sender, EventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void emEdit_MouseLeave(object sender, EventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_12;
        }

        private void emEdit_MouseUp(object sender, MouseEventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void phEdit_MouseDown(object sender, MouseEventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_121;
        }

        private void phEdit_MouseHover(object sender, EventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void phEdit_MouseLeave(object sender, EventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_12;
        }

        private void phEdit_MouseUp(object sender, MouseEventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void pdEdit_MouseDown(object sender, MouseEventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_121;
        }

        private void pdEdit_MouseHover(object sender, EventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void pdEdit_MouseLeave(object sender, EventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_12;
        }

        private void pdEdit_MouseUp(object sender, MouseEventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void bgEdit_MouseDown(object sender, MouseEventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_121;
        }

        private void bgEdit_MouseHover(object sender, EventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void bgEdit_MouseLeave(object sender, EventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_12;
        }

        private void bgEdit_MouseUp(object sender, MouseEventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void amountEdit_MouseDown(object sender, MouseEventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_121;
        }

        private void amountEdit_MouseHover(object sender, EventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }

        private void amountEdit_MouseLeave(object sender, EventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_12;
        }

        private void amountEdit_MouseUp(object sender, MouseEventArgs e)
        {
            this.nameEdit.Image = global::BloodBank3._2_1.Properties.Resources.edit16_1;
        }
    }
}
