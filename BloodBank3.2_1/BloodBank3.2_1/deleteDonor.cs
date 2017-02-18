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
    public partial class deleteDonor : UserControl
    {
        private string[] m = { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        public deleteDonor()
        {
            InitializeComponent();
        }

        private dataGridViewBox dd;

        public void getObj(dataGridViewBox dd)
        {
            this.dd = dd;
        }

        private int id, di, mi;

        public void loadData(string id, string name, string pro, string dob, string add, string em, string ph, string bg, string dod)
        {
            this.id = Convert.ToInt32(id);
            nameText.Text = name;
            proText.Text = pro;
            di = dob.IndexOf("-");
            dateCombo1.Text = dob.Substring(0, di);
            mi = dob.LastIndexOf("-");
            monthCombo1.Text = m[Convert.ToInt32(dob.Substring(di + 1, mi - di - 1))];
            yearCombo1.Text = dob.Substring(mi + 1, 4);
            addText.Text = add;
            emText.Text = em;
            phText.Text = ph;
            bgCombo.Text = bg;
            di = dod.IndexOf("-");
            dateCombo2.Text = dod.Substring(0, di);
            mi = dod.LastIndexOf("-");
            monthCombo2.Text = m[Convert.ToInt32(dod.Substring(di + 1, mi - di - 1))];
            yearCombo2.Text = dod.Substring(mi + 1, 4);            
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            connection con = new connection();
            con.donorDelete(id);
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
    }
}
