using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank3._2_1
{
    public partial class sell : Form
    {
        private Dictionary<string, int> month = new Dictionary<string, int>();
        private Dictionary<string, int> bgAmount = new Dictionary<string, int>();
        private Dictionary<string, int> bgCost = new Dictionary<string, int>();
        private List<string> list = new List<string>();

        public sell()
        {
            InitializeComponent();            
            loadBg();
            loadBgCost();
            loadMonth();
        }

        private void loadBgCost()
        {
            bgCost["AB+"] = 0;
            bgCost["AB-"] = 0;
            bgCost["A+"] = 0;
            bgCost["A-"] = 0;
            bgCost["B+"] = 0;
            bgCost["B-"] = 0;
            bgCost["O+"] = 0;
            bgCost["O-"] = 0;
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

        private void cancelLab_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int items;
        private void addPan_Click(object sender, EventArgs e)
        {
            if (bgCombo.Text != "")
            {
                if (amountText.Text != "")
                {
                    if (costText.Text != "")
                    {
                        items = bgAmount[bgCombo.Text] = Convert.ToInt32(amountText.Text);
                        bgCost[bgCombo.Text] = (Convert.ToInt32(amountText.Text)) * (Convert.ToInt32(costText.Text));
                        this.itemSlPan.Visible = true;
                    }
                }                
            }
            bgCombo.Text = "";
            amountText.Text = "";
            costText.Text = "";
        }

        connection con = new connection();

        private void doneLab_Click(object sender, EventArgs e)
        {
            con.clientInsert(nameText.Text, proText.Text, addText.Text, emText.Text, phText.Text, bgAmount["AB+"], bgAmount["AB-"], bgAmount["A+"], bgAmount["A-"], bgAmount["B+"], bgAmount["B-"], bgAmount["O+"], bgAmount["O-"], dateCombo1.Text + "-" + month[monthCombo1.Text] + "-" + yearCombo1.Text);
            for (int i = 0; i < list.Count; i++)
            {
                con.deleteItem(list[i]);
            }
            manageAccount();
            clearText();
            loadBg();
            this.Close();
        }

        private void manageAccount()
        {            
            if (bgCost["AB+"] != 0)
            {
                int id = checkBloodExistence("AB+", dateCombo1.Text + "-" + month[monthCombo1.Text] + "-" + yearCombo1.Text);
                if (id > 0)
                {
                    con.accountUpdate(id, bgAmount["AB+"], bgCost["AB+"]);
                }
                else
                {
                    con.accountInsert("AB+", bgAmount["AB+"], bgCost["AB+"], dateCombo1.Text + "-" + month[monthCombo1.Text] + "-" + yearCombo1.Text);
                }
            }
            if (bgCost["AB-"] != 0)
            {
                int id = checkBloodExistence("AB-", dateCombo1.Text + "-" + month[monthCombo1.Text] + "-" + yearCombo1.Text);
                if (id > 0)
                {
                    con.accountUpdate(id, bgAmount["AB-"], bgCost["AB-"]);
                }
                else
                {
                    con.accountInsert("AB-", bgAmount["AB-"], bgCost["AB-"], dateCombo1.Text + "-" + month[monthCombo1.Text] + "-" + yearCombo1.Text);
                }
            }
            if (bgCost["A+"] != 0)
            {
                int id = checkBloodExistence("A+", dateCombo1.Text + "-" + month[monthCombo1.Text] + "-" + yearCombo1.Text);
                if (id > 0)
                {
                    con.accountUpdate(id, bgAmount["A+"], bgCost["A+"]);
                }
                else
                {
                    con.accountInsert("A+", bgAmount["A+"], bgCost["A+"], dateCombo1.Text + "-" + month[monthCombo1.Text] + "-" + yearCombo1.Text);
                }
            }
            if (bgCost["A-"] != 0)
            {
                int id = checkBloodExistence("A-", dateCombo1.Text + "-" + month[monthCombo1.Text] + "-" + yearCombo1.Text);
                if (id > 0)
                {
                    con.accountUpdate(id, bgAmount["A-"], bgCost["A-"]);
                }
                else
                {
                    con.accountInsert("A-", bgAmount["A-"], bgCost["A-"], dateCombo1.Text + "-" + month[monthCombo1.Text] + "-" + yearCombo1.Text);
                }
            }
            if (bgCost["B+"] != 0)
            {
                int id = checkBloodExistence("B+", dateCombo1.Text + "-" + month[monthCombo1.Text] + "-" + yearCombo1.Text);
                if (id > 0)
                {
                    con.accountUpdate(id, bgAmount["B+"], bgCost["B+"]);
                }
                else
                {
                    con.accountInsert("B+", bgAmount["B+"], bgCost["B+"], dateCombo1.Text + "-" + month[monthCombo1.Text] + "-" + yearCombo1.Text);
                }
            }
            if (bgCost["B-"] != 0)
            {
                int id = checkBloodExistence("B-", dateCombo1.Text + "-" + month[monthCombo1.Text] + "-" + yearCombo1.Text);
                if (id > 0)
                {
                    con.accountUpdate(id, bgAmount["B-"], bgCost["B-"]);
                }
                else
                {
                    con.accountInsert("B-", bgAmount["B-"], bgCost["B-"], dateCombo1.Text + "-" + month[monthCombo1.Text] + "-" + yearCombo1.Text);
                }
            }
            if (bgCost["O+"] != 0)
            {
                int id = checkBloodExistence("O+", dateCombo1.Text + "-" + month[monthCombo1.Text] + "-" + yearCombo1.Text);
                if (id > 0)
                {
                    con.accountUpdate(id, bgAmount["O+"], bgCost["O+"]);
                }
                else
                {
                    con.accountInsert("O+", bgAmount["O+"], bgCost["O+"], dateCombo1.Text + "-" + month[monthCombo1.Text] + "-" + yearCombo1.Text);
                }
            }
            if (bgCost["O-"] != 0)
            {
                int id = checkBloodExistence("O-", dateCombo1.Text + "-" + month[monthCombo1.Text] + "-" + yearCombo1.Text);
                if (id > 0)
                {
                    con.accountUpdate(id, bgAmount["O-"], bgCost["O-"]);
                }
                else
                {
                    con.accountInsert("O-", bgAmount["O-"], bgCost["O-"], dateCombo1.Text + "-" + month[monthCombo1.Text] + "-" + yearCombo1.Text);
                }
            }
        }

        private int checkBloodExistence(string blood, string purDate)
        {
            int id = con.checkBlood(blood, purDate);            
            return id;
        }

        private void clearText()
        {
            nameText.Text = "";
            proText.Text = "";
            addText.Text = "";
            emText.Text = "";
            phText.Text = "";
            dateCombo1.Text = monthCombo1.Text = yearCombo1.Text = "";
            bgCombo.Text = "";
            amountText.Text = "";
            costText.Text = "";
        }

        private bool checkClientExistence()
        {
            DataSet ds = con.checkClient(nameText.Text, emText.Text, phText.Text);
            int id = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            if (id > 0) return true;
            else return false;
        }

        private int cnt = 0;

        private void slText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (slText.Text != "")
                {
                    cnt++;
                    list.Add(slText.Text);
                    slText.Text = "";
                    if (cnt == items)
                    {
                        cnt = 0;
                        this.itemSlPan.Visible = false;
                    }
                }                
            }            
        }

        private void deleteItem(string sl)
        {
            this.itemSlPan.Enabled = false;
            con.deleteItem(sl);
            this.itemSlPan.Enabled = true;
        }
    }
}
