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
    public partial class deleteClient : UserControl
    {
        private string[] m = { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        public deleteClient()
        {
            InitializeComponent();
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
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            connection con = new connection();
            con.clientDelete(id);
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
    }
}
