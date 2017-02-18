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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();            
            insForm.getObj(donorData1);
            editForm1.getObj(donorData1);
            deleteForm1.getObj(donorData1);
            newStorage1.getObj(donorData1);
            editStorage1.getObj(donorData1);
            deleteStorage1.getObj(donorData1);
            newClient1.getObj(donorData1);
            editClient1.getObj(donorData1);
            deleteClient1.getObj(donorData1);
            donorData1.getObj(insForm, editForm1, deleteForm1,newStorage1,editStorage1,deleteStorage1,newClient1,editClient1,deleteClient1);
            bloodCount();
        }

        private void bloodCount()
        {
            connection con = new connection();
            abpCnt.Text = con.bloodCount("AB+").ToString();
            abnCnt.Text = con.bloodCount("AB-").ToString();
            apCnt.Text = con.bloodCount("A+").ToString();
            anCnt.Text = con.bloodCount("A-").ToString();
            bpCnt.Text = con.bloodCount("B+").ToString();
            bnCnt.Text = con.bloodCount("B-").ToString();
            opCnt.Text = con.bloodCount("O+").ToString();
            onCnt.Text = con.bloodCount("O-").ToString();
        }
        private void getData(int i)
        {
            donorData1.getData(i);
        }

        private void donButton_Click(object sender, EventArgs e)
        {            
            if (donPanel2.Visible == true)
            {
                donPanel2.Visible = false;
                this.strPanel1.Location = new System.Drawing.Point(12, 35);
                if (strPanel2.Visible == true) this.cliPanel1.Location = new System.Drawing.Point(12, 146);
                else this.cliPanel1.Location = new System.Drawing.Point(12, 53);                                
            }
            else
            {
                donPanel2.Visible = true;
                this.strPanel1.Location = new System.Drawing.Point(12, 108);
                if (strPanel2.Visible == true) this.cliPanel1.Location = new System.Drawing.Point(12, 219);
                else this.cliPanel1.Location = new System.Drawing.Point(12, 126);                
            }
            this.donorData1.Location = new System.Drawing.Point(0, 240);
            getData(1);            
        }        

        private void strButton_Click(object sender, EventArgs e)
        {
            if (strPanel2.Visible == true)
            {
                strPanel2.Visible = false;
                int x = strPanel1.Location.X;
                int y = strPanel1.Location.Y;
                this.cliPanel1.Location = new System.Drawing.Point(x, y+18);
            }
            else
            {
                strPanel2.Visible = true;
                int x = strPanel1.Location.X;
                int y = strPanel1.Location.Y;
                this.cliPanel1.Location = new System.Drawing.Point(x, y+111);                
            }
            this.donorData1.Location = new System.Drawing.Point(0, 240);
            getData(2);
        }         

        private void cliButton_Click(object sender, EventArgs e)
        {
            if (cliPanel2.Visible == true)
            {
                cliPanel2.Visible = false;                
            }
            else
            {
                cliPanel2.Visible = true;                
            }
            this.donorData1.Location = new System.Drawing.Point(0, 240);
            getData(3);
        }

        private void newDonorButton_Click(object sender, EventArgs e)
        {
            this.donorData1.Location = new System.Drawing.Point(0, 240);
            getData(1);
            hideAll();
            insForm.Visible = true;            
        }

        private void editDonorButton_Click(object sender, EventArgs e)
        {
            this.donorData1.Location = new System.Drawing.Point(0, 240);
            getData(1);
            hideAll();
            editForm1.Visible = true;
        }

        private void deleteDonorButton_Click(object sender, EventArgs e)
        {
            this.donorData1.Location = new System.Drawing.Point(0, 240);
            getData(1);
            hideAll();
            deleteForm1.Visible = true;
        }
      
        private void newStorageButton_Click(object sender, EventArgs e)
        {
            this.donorData1.Location = new System.Drawing.Point(0, 240);
            getData(2);
            hideAll();
            newStorage1.Visible = true;            
        }
       
        private void editStorageButton_Click(object sender, EventArgs e)
        {
            this.donorData1.Location = new System.Drawing.Point(0, 240);
            getData(2);
            hideAll();
            editStorage1.Visible = true;
        }

        private void deleteStorageButton_Click(object sender, EventArgs e)
        {
            this.donorData1.Location = new System.Drawing.Point(0, 240);
            getData(2);
            hideAll();
            deleteStorage1.Visible = true;
        }

        private void expiredBloodButton_Click(object sender, EventArgs e)
        {
            this.donorData1.Location = new System.Drawing.Point(0, 240);
            this.donorData1.Size = new System.Drawing.Size(672, 445);
            this.donorData1.Location = new System.Drawing.Point(0, 0);
            getData(2);            
            hideAll();
            //expiredBlood1.Visible = true;
        }

        private void newClientButton_Click(object sender, EventArgs e)
        {
            this.donorData1.Location = new System.Drawing.Point(0, 240);
            getData(3);
            hideAll();
            newClient1.Visible = true;
        }

        private void editClientButton_Click(object sender, EventArgs e)
        {
            this.donorData1.Location = new System.Drawing.Point(0, 240);
            getData(3);
            hideAll();
            editClient1.Visible = true;
        }

        private void deleteClientButton_Click(object sender, EventArgs e)
        {
            this.donorData1.Location = new System.Drawing.Point(0, 240);
            getData(3);
            hideAll();
            deleteClient1.Visible = true;
        }

        private void hideAll()
        {
            insForm.clearText();
            insForm.Visible = false;
            editForm1.clearText();
            editForm1.disableEdit();
            editForm1.Visible = false;
            deleteForm1.clearText();
            deleteForm1.Visible = false;
            newStorage1.clearText();
            newStorage1.Visible = false;
            editStorage1.clearText();
            editStorage1.disableEdit();
            editStorage1.Visible = false;
            deleteStorage1.clearText();
            deleteStorage1.Visible = false;
            expiredBlood1.clearText();
            expiredBlood1.Visible = false;
            newClient1.clearText();
            newClient1.Visible = false;
            editClient1.clearText();
            editClient1.disableEdit();
            editClient1.Visible = false;
            deleteClient1.clearText();
            deleteClient1.Visible = false;
        }

        private void sellPan_Click(object sender, EventArgs e)
        {
            this.donorData1.Location = new System.Drawing.Point(0, 240);
            sell sl = new sell();
            sl.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            hideAll();
            //this.donorData1.Size = new System.Drawing.Size(672, 445);
            //this.donorData1.Location = new System.Drawing.Point(0, 0);
            getData(4);
        }            
    }
}
