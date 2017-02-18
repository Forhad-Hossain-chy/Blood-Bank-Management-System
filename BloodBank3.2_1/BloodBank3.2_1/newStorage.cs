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
    public partial class newStorage : UserControl
    {
        private Dictionary<string, int> month = new Dictionary<string, int>();

        public newStorage()
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

        private void doneButton_Click(object sender, EventArgs e)
        {
            connection con = new connection();
            con.storageInsert(bgCombo.Text, roomText.Text, slText.Text, dateCombo1.Text + "-" + month[monthCombo1.Text] + "-" + yearCombo1.Text);
            clearText();
            dd.getData(2);
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
    }
}
