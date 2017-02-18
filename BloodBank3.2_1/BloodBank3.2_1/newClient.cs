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
    public partial class newClient : UserControl
    {
        private Dictionary<string, int> month = new Dictionary<string, int>();
        private Dictionary<string, int> bgAmount = new Dictionary<string, int>();

        public newClient()
        {
            InitializeComponent();
            loadBg();
            loadMonth();                        
        }

        private void loadBg()
        {
            bgAmount["AB+"] = 0;
            bgAmount["AB-"] = 0;
            bgAmount["A+"] = 0;
            bgAmount["A-"] = 0;
            bgAmount["B+"] = 0;
            bgAmount["B-"] = 0;
            bgAmount["O+"] = 0;
            bgAmount["O-"] = 0;
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

        private void insButton_Click(object sender, EventArgs e)
        {
            connection con = new connection();
            con.clientInsert(nameText.Text, proText.Text, addText.Text, emText.Text, phText.Text, bgAmount["AB+"], bgAmount["AB-"], bgAmount["A+"], bgAmount["A-"], bgAmount["B+"], bgAmount["B-"], bgAmount["O+"], bgAmount["O-"], dateCombo1.Text + "-" + month[monthCombo1.Text] + "-" + yearCombo1.Text);
            clearText();
            loadBg();
            dd.getData(3);
        }

        public void clearText()
        {
            nameText.Text = "";
            proText.Text = "";
            addText.Text = "";
            emText.Text = "";
            phText.Text = "";
            dateCombo1.Text  = "Date";
            monthCombo1.Text = "Month";
            yearCombo1.Text = "Year";
            bgCombo.Text = "";
            amountText.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (bgCombo.Text != "")
            {
                if (amountText.Text == "")
                {
                    bgAmount[bgCombo.Text] = 0;
                }
                else
                {
                    bgAmount[bgCombo.Text] = Convert.ToInt32(amountText.Text);
                }
            }
            bgCombo.Text = "";
            amountText.Text = "";
        }
    }
}
