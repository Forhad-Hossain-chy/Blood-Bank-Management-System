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
    public partial class deleteStorage : UserControl
    {
        private string[] m = { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        public deleteStorage()
        {
            InitializeComponent();
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
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            connection con = new connection();
            con.storageDelete(id);
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
