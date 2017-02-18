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
    public partial class dataGridViewBox : UserControl
    {
        public dataGridViewBox()
        {
            InitializeComponent();            
        }

        private newDonor newD;
        private editDonor editD;
        private deleteDonor deleteD;
        private newStorage newS;
        private editStorage editS;
        private deleteStorage deleteS;
        private newClient newC;
        private editClient editC;
        private deleteClient deleteC;

        public void getObj(newDonor nd, editDonor ed, deleteDonor dd, newStorage ns, editStorage es, deleteStorage ds, newClient nc, editClient ec, deleteClient dc)
        {
            this.newD = nd;
            this.editD = ed;
            this.deleteD = dd;
            this.newS = ns;
            this.editS = es;
            this.deleteS = ds;
            this.newC = nc;
            this.editC = ec;
            this.deleteC = dc;
        }        

        private int pointer;

        public void getData(int i)
        {            
            this.pointer = i;
            if (pointer == 1)
            {
                hideAll();
                this.donorSearchPan.Visible = true;
            }
            if (pointer == 2)
            {
                hideAll();
                this.storageSearchPan.Visible = true;
            }
            if (pointer == 3)
            {
                hideAll();
                this.clientSearchPan.Visible = true;
            }
            if (pointer == 4)
            {
                hideAll();
            }
            connection con = new connection();            
            DataSet ds = con.showData(pointer);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void hideAll()
        {
            donorSearchPan.Visible = false;
            storageSearchPan.Visible = false;
            clientSearchPan.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (pointer == 1)
            {
                try
                {
                    int id = -1;
                    if (Convert.ToInt32(e.RowIndex.ToString()) > -1) id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    if (id > 0) loadInfo(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            if (pointer == 2)
            {
                try
                {
                    int id = -1;
                    if (Convert.ToInt32(e.RowIndex.ToString()) > -1) id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    if (id > 0) loadInfo(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            if (pointer == 3)
            {
                try
                {
                    int id = -1;
                    if (Convert.ToInt32(e.RowIndex.ToString()) > -1) id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    if (id > 0) loadInfo(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void loadInfo(int id)
        {
            connection con = new connection();
            DataSet ds = con.getData(pointer, id);            
            if (editD.Visible == true) editD.loadData(ds.Tables[0].Rows[0][0].ToString(), ds.Tables[0].Rows[0][1].ToString(), ds.Tables[0].Rows[0][2].ToString(), ds.Tables[0].Rows[0][3].ToString(), ds.Tables[0].Rows[0][4].ToString(), ds.Tables[0].Rows[0][5].ToString(), ds.Tables[0].Rows[0][6].ToString(), ds.Tables[0].Rows[0][7].ToString(), ds.Tables[0].Rows[0][8].ToString());
            if (deleteD.Visible == true) deleteD.loadData(ds.Tables[0].Rows[0][0].ToString(), ds.Tables[0].Rows[0][1].ToString(), ds.Tables[0].Rows[0][2].ToString(), ds.Tables[0].Rows[0][3].ToString(), ds.Tables[0].Rows[0][4].ToString(), ds.Tables[0].Rows[0][5].ToString(), ds.Tables[0].Rows[0][6].ToString(), ds.Tables[0].Rows[0][7].ToString(), ds.Tables[0].Rows[0][8].ToString());
            if (editS.Visible == true) editS.loadData(ds.Tables[0].Rows[0][0].ToString(), ds.Tables[0].Rows[0][1].ToString(), ds.Tables[0].Rows[0][2].ToString(), ds.Tables[0].Rows[0][3].ToString(), ds.Tables[0].Rows[0][4].ToString());
            if (deleteS.Visible == true) deleteS.loadData(ds.Tables[0].Rows[0][0].ToString(), ds.Tables[0].Rows[0][1].ToString(), ds.Tables[0].Rows[0][2].ToString(), ds.Tables[0].Rows[0][3].ToString(), ds.Tables[0].Rows[0][4].ToString());
            if (editC.Visible == true) editC.loadData(ds.Tables[0].Rows[0][0].ToString(), ds.Tables[0].Rows[0][1].ToString(), ds.Tables[0].Rows[0][2].ToString(), ds.Tables[0].Rows[0][3].ToString(), ds.Tables[0].Rows[0][4].ToString(), ds.Tables[0].Rows[0][5].ToString(), ds.Tables[0].Rows[0][6].ToString(), ds.Tables[0].Rows[0][7].ToString(), ds.Tables[0].Rows[0][8].ToString(), ds.Tables[0].Rows[0][9].ToString(), ds.Tables[0].Rows[0][10].ToString(), ds.Tables[0].Rows[0][11].ToString(), ds.Tables[0].Rows[0][12].ToString(), ds.Tables[0].Rows[0][13].ToString(), ds.Tables[0].Rows[0][14].ToString());
            if (deleteC.Visible == true) deleteC.loadData(ds.Tables[0].Rows[0][0].ToString(), ds.Tables[0].Rows[0][1].ToString(), ds.Tables[0].Rows[0][2].ToString(), ds.Tables[0].Rows[0][3].ToString(), ds.Tables[0].Rows[0][4].ToString(), ds.Tables[0].Rows[0][5].ToString(), ds.Tables[0].Rows[0][6].ToString(), ds.Tables[0].Rows[0][7].ToString(), ds.Tables[0].Rows[0][8].ToString(), ds.Tables[0].Rows[0][9].ToString(), ds.Tables[0].Rows[0][10].ToString(), ds.Tables[0].Rows[0][11].ToString(), ds.Tables[0].Rows[0][12].ToString(), ds.Tables[0].Rows[0][13].ToString(), ds.Tables[0].Rows[0][14].ToString());
        }

        private void donorSearchButton_Click(object sender, EventArgs e)
        {
            string qer = "";
            int cnt = 0;
            if (nameText1.Text != "")
            {                
                qer += "name like '%" + nameText1.Text + "%' ";
                cnt++;
            }
            if (addText1.Text != "")
            {
                if(cnt>0)
                {
                    qer += "and addr like '%" + addText1.Text + "%' ";
                }
                else{
                    qer += "addr like '%" + addText1.Text + "%' ";
                }
                cnt++;
            }
            if (phText1.Text != "")
            {
                if(cnt>0)
                {
                    qer += "and phone like '%" + phText1.Text + "%' ";
                }
                else
                {
                    qer += "phone like '%" + phText1.Text + "%' ";
                }
                cnt++;
            }
            if (bgCombo1.Text != "")
            {
                if(cnt>0)
                {
                    qer += "and bg = '" + bgCombo1.Text + "'";
                }
                else
                {
                    qer += "bg = '" + bgCombo1.Text + "'";
                }
                cnt++;
            }
            connection con = new connection();
            if (qer != "")
            {
                qer = "select id as ID, name as Name, pro as Profession, dob as Date_of_Birth,addr as Address, email as Email, phone as Phone, bg as Blood_Group, dod as Date_of_Donation from donor_info where " + qer;
                DataSet ds = con.Search(qer);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                qer = "select id as ID, name as Name, pro as Profession, dob as Date_of_Birth,addr as Address, email as Email, phone as Phone, bg as Blood_Group, dod as Date_of_Donation from donor_info";
                DataSet ds = con.Search(qer);
                dataGridView1.DataSource = ds.Tables[0];
            }
            nameText1.Text = "";
            addText1.Text = "";
            phText1.Text = "";
            bgCombo1.Text = "";
        }

        private void storageSearchButton_Click(object sender, EventArgs e)
        {
            string qer = "";
            int cnt = 0;
            if (bgCombo2.Text != "")
            {
                qer += "bg = '" + bgCombo2.Text + "' ";
                cnt++;
            }
            if (slText.Text != "")
            {
                if (cnt > 0)
                {
                    qer += "and sl like '%" + slText.Text + "%' ";
                }
                else
                {
                    qer += "sl like '%" + slText.Text + "%' ";
                }
                cnt++;
            }
            connection con = new connection();
            if (qer != "")
            {
                qer = "select id as ID, bg as Blood_Group, roomNo as Room_No, sl as Serial_No, dd as Donation_Date from storage_info where " + qer;
                DataSet ds = con.Search(qer);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                qer = "select id as ID, bg as Blood_Group, roomNo as Room_No, sl as Serial_No, dd as Donation_Date from storage_info";
                DataSet ds = con.Search(qer);
                dataGridView1.DataSource = ds.Tables[0];
            }
            bgCombo2.Text = "";
            slText.Text = "";
        }

        private void clientSearchButton_Click(object sender, EventArgs e)
        {
            string qer = "";
            int cnt = 0;
            if (nameText2.Text != "")
            {
                qer += "name like '%" + nameText2.Text + "%' ";
                cnt++;
            }
            if (addText2.Text != "")
            {
                if (cnt > 0)
                {
                    qer += "and address like '%" + addText2.Text + "%' ";
                }
                else
                {
                    qer += "address like '%" + addText2.Text + "%' ";
                }
                cnt++;
            }
            if (phText2.Text != "")
            {
                if (cnt > 0)
                {
                    qer += "and phone like '%" + phText2.Text + "%' ";
                }
                else
                {
                    qer += "phone like '%" + phText2.Text + "%' ";
                }
                cnt++;
            }
            connection con = new connection();
            if (qer != "")
            {
                qer = "select id as ID, name as Name, pro as Profession, address as Address, em as Email, ph as Phone, ABpos as AB_pos, ABneg as AB_neg, Apos as A_pos, Aneg as A_neg, Bpos as B_pos, Bneg as B_neg, Opos as O_pos, Oneg as O_neg, pd as Purchase_Date from client_info where " + qer;
                DataSet ds = con.Search(qer);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                qer = "select id as ID, name as Name, pro as Profession, address as Address, em as Email, ph as Phone, ABpos as AB_pos, ABneg as AB_neg, Apos as A_pos, Aneg as A_neg, Bpos as B_pos, Bneg as B_neg, Opos as O_pos, Oneg as O_neg, pd as Purchase_Date from client_info";
                DataSet ds = con.Search(qer);
                dataGridView1.DataSource = ds.Tables[0];
            }
            nameText2.Text = "";
            addText2.Text = "";
            phText2.Text = "";
        }        
    }
}
