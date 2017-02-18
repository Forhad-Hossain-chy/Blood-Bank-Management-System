using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Windows.Forms;
using System.Data;

namespace BloodBank3._2_1
{
    class connection
    {
        public void donorInsert(string name, string pro, string dob, string add, string em, string ph, string bg, string dod)
        {
            string conStr = "Data Source=XE;User ID=admin;Password=root;Unicode=True";
            OracleConnection con = new OracleConnection(conStr);
            con.Open();
            OracleCommand com = new OracleCommand("sp_donorInsert", con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add("sp_name", OracleType.VarChar).Value = name;
            com.Parameters.Add("sp_pro", OracleType.VarChar).Value = pro;
            com.Parameters.Add("sp_dob", OracleType.VarChar).Value = dob;
            com.Parameters.Add("sp_addr", OracleType.VarChar).Value = add;
            com.Parameters.Add("sp_email", OracleType.VarChar).Value = em;
            com.Parameters.Add("sp_phone", OracleType.VarChar).Value = ph;
            com.Parameters.Add("sp_bg", OracleType.VarChar).Value = bg;
            com.Parameters.Add("sp_dod", OracleType.VarChar).Value = dod;

            //string comStr = "insert into donor_info values('" + name + "', '" + pro + "', '" + dob + "', '" + add + "', '" + em + "', '" + ph + "', '" + bg + "', '" + dod + "')";
            //OracleCommand com = new OracleCommand(comStr, con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Inserted");
        }

        public void storageInsert(string bg, string roomNo, string sl, string dod)
        {
            string conStr = "Data Source=XE;User ID=admin;Password=root;Unicode=True";
            OracleConnection con = new OracleConnection(conStr);
            con.Open();

            OracleCommand com = new OracleCommand("sp_storageInsert", con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add("sp_bg", OracleType.VarChar).Value = bg;
            com.Parameters.Add("sp_roomNo", OracleType.VarChar).Value = roomNo;
            com.Parameters.Add("sp_sl", OracleType.VarChar).Value = sl;
            com.Parameters.Add("sp_dd", OracleType.VarChar).Value = dod;

            //string comStr = "insert into storage_info values('" + bg + "', '" + roomNo + "', '" + sl + "', '" + dod + "')";
            //OracleCommand com = new OracleCommand(comStr, con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Inserted");
        }

        public void clientInsert(string name, string pro, string add, string em, string ph, int abp, int abn, int ap, int an, int bp, int bn, int op, int on, string pd)
        {
            string conStr = "Data Source=XE;User ID=admin;Password=root;Unicode=True";
            OracleConnection con = new OracleConnection(conStr);
            con.Open();
            OracleCommand com = new OracleCommand("sp_clientInsert", con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add("sp_name", OracleType.VarChar).Value = name;
            com.Parameters.Add("sp_pro", OracleType.VarChar).Value = pro;
            com.Parameters.Add("sp_address", OracleType.VarChar).Value = add;
            com.Parameters.Add("sp_em", OracleType.VarChar).Value = em;
            com.Parameters.Add("sp_ph", OracleType.VarChar).Value = ph;
            com.Parameters.Add("sp_abpos", OracleType.Number).Value = abp;
            com.Parameters.Add("sp_abneg", OracleType.Number).Value = abn;
            com.Parameters.Add("sp_apos", OracleType.Number).Value = ap;
            com.Parameters.Add("sp_aneg", OracleType.Number).Value = an;
            com.Parameters.Add("sp_bpos", OracleType.Number).Value = bp;
            com.Parameters.Add("sp_bneg", OracleType.Number).Value = bn;
            com.Parameters.Add("sp_opos", OracleType.Number).Value = op;
            com.Parameters.Add("sp_oneg", OracleType.Number).Value = on;
            com.Parameters.Add("sp_pd", OracleType.VarChar).Value = pd;

            //string comStr = "insert into client_info values('" + name + "', '" + pro + "', '" + add + "', '" + em + "', '" + ph + "', '"+abp+"', '"+abn+"', '"+ap+"', '"+an+"', '"+bp+"', '"+bn+"', '"+op+"', '"+on+"', '" + pd + "')";
            //OracleCommand com = new OracleCommand(comStr, con);
            com.ExecuteNonQuery();
            con.Close();
            //MessageBox.Show("Data Inserted");
        }

        public void accountInsert(string blood, int amount, int price, string purDate)
        {
            string conStr = "Data Source=XE;User ID=admin;Password=root;Unicode=True";
            OracleConnection con = new OracleConnection(conStr);
            con.Open();
            OracleCommand com = new OracleCommand("sp_accountInsert", con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add("sp_blood", OracleType.VarChar).Value = blood;
            com.Parameters.Add("sp_amount", OracleType.Number).Value = amount;
            com.Parameters.Add("sp_price", OracleType.Number).Value = price;
            com.Parameters.Add("sp_sd", OracleType.VarChar).Value = purDate;

            //string comStr = "insert into account_info values('" + blood + "', '" + amount + "', '" + price + "', '" + purDate + "')";
            //OracleCommand com = new OracleCommand(comStr, con);
            com.ExecuteNonQuery();
            con.Close();
        }

        public void donorUpdate(int id, string name, string pro, string dob, string add, string em, string ph, string bg, string dod)
        {
            string conStr = "Data Source=XE;User ID=admin;Password=root;Unicode=True";
            OracleConnection con = new OracleConnection(conStr);
            con.Open();
            string comStr = "update donor_info set name = '" + name + "', pro = '" + pro + "', dob = '" + dob + "', addr = '" + add + "', email = '" + em + "', phone = '" + ph + "', bg = '" + bg + "', dod = '" + dod + "' where id = '"+id+"'";
            OracleCommand com = new OracleCommand(comStr, con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated");
        }

        public void storageUpdate(int id, string bg, string roomNo, string sl, string dod)
        {
            string conStr = "Data Source=XE;User ID=admin;Password=root;Unicode=True";
            OracleConnection con = new OracleConnection(conStr);
            con.Open();
            string comStr = "update storage_info set bg = '" + bg + "', roomNo = '" + roomNo + "', sl = '" + sl + "', dd = '" + dod + "' where id = '" + id + "'";
            OracleCommand com = new OracleCommand(comStr, con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated");
        }

        public void clientUpdate(int id, string name, string pro, string add, string em, string ph, int abp, int abn, int ap, int an, int bp, int bn, int op, int on, string pd)
        {
            string conStr = "Data Source=XE;User ID=admin;Password=root;Unicode=True";
            OracleConnection con = new OracleConnection(conStr);
            con.Open();
            string comStr = "update client_info set name = '" + name + "', pro = '" + pro + "', address = '" + add + "', em = '" + em + "', ph = '" + ph + "', abpos = '" + abp + "', abneg = '" + abn + "', apos = '" + ap + "', aneg = '" + an + "', bpos = '" + bp + "', bneg = '" + bn + "', opos = '" + op + "', oneg = '" + on + "', pd = '"+ pd +"' where id = '" + id + "' ";
            OracleCommand com = new OracleCommand(comStr, con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated");
        }

        public void accountUpdate(int id, int amount, int price)
        {
            string conStr = "Data Source=XE;User ID=admin;Password=root;Unicode=True";
            OracleConnection con = new OracleConnection(conStr);
            con.Open();
            string comStr = "update account_info set amount = amount + '" + amount + "', price = price + '" + price + "' where id = '" + id + "' ";
            OracleCommand com = new OracleCommand(comStr, con);
            com.ExecuteNonQuery();
            con.Close();            
        }

        public void donorDelete(int id)
        {
            string conStr = "Data Source=XE;User ID=admin;Password=root;Unicode=True";
            OracleConnection con = new OracleConnection(conStr);
            con.Open();
            string comStr = "Delete from donor_info where id = '"+id+"' ";
            OracleCommand com = new OracleCommand(comStr, con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted");
        }

        public void storageDelete(int id)
        {
            string conStr = "Data Source=XE;User ID=admin;Password=root;Unicode=True";
            OracleConnection con = new OracleConnection(conStr);
            con.Open();
            string comStr = "Delete from storage_info where id = '" + id + "' ";
            OracleCommand com = new OracleCommand(comStr, con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted");
        }

        public void clientDelete(int id)
        {
            string conStr = "Data Source=XE;User ID=admin;Password=root;Unicode=True";
            OracleConnection con = new OracleConnection(conStr);
            con.Open();
            string comStr = "Delete from client_info where id = '" + id + "' ";
            OracleCommand com = new OracleCommand(comStr, con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted");
        }

        public DataSet showData(int i)
        {
            string conStr = "Data Source=XE;User ID=admin;Password=root;Unicode=True";
            OracleConnection con = new OracleConnection(conStr);
            con.Open();
            string comStr = null;            
            if (i == 1) comStr = "select id as ID, name as Name, pro as Profession, dob as Date_of_Birth, addr as Address, email as Email, phone as Phone, bg as Blood_Group, dod as Date_of_Donation from donor_info";
            if (i == 2) comStr = "select id as ID, bg as Blood_Group, roomNo as Room_No, sl as Serial_No, dd as Donation_Date from storage_info";
            if (i == 3) comStr = "select id as ID, name as Name, pro as Profession, address as Address, em as Email, ph as Phone, abpos as ABpos, abneg as ABneg, apos as Apos, aneg as Aneg, bpos as Bpos, bneg as Bneg, opos as Opos, oneg as Oneg, pd as Purchase_Date from client_info";
            if (i == 4) comStr = "select id as ID, bg as Blood_Group, amount as Amount, price as Price, sd as Sell_Date from account_info";
            OracleCommand com = new OracleCommand(comStr, con);
            DataSet ds = new DataSet();
            OracleDataAdapter sda = new OracleDataAdapter(com);
            sda.Fill(ds);
            con.Close();
            return ds;
        }

        public DataSet getData(int i, int id)
        {
            string conStr = "Data Source=XE;User ID=admin;Password=root;Unicode=True";
            OracleConnection con = new OracleConnection(conStr);
            con.Open();
            string comStr = null;
            if (i == 1) comStr = "select * from donor_info where id = '"+id+"'";
            if (i == 2) comStr = "select * from storage_info where id = '"+id+"'";
            if (i == 3) comStr = "select * from client_info where id = '"+id+"'";
            OracleCommand com = new OracleCommand(comStr, con);
            DataSet ds = new DataSet();
            OracleDataAdapter sda = new OracleDataAdapter(com);
            sda.Fill(ds);
            con.Close();
            return ds;
        }

        public DataSet checkClient(string name, string em, string ph)
        {
            string conStr = "Data Source=XE;User ID=admin;Password=root;Unicode=True";
            OracleConnection con = new OracleConnection(conStr);
            con.Open();
            string comStr = null;
            comStr = "select * from client_info where name = '" + name + "' and em = '" + em + "' and ph = '" + ph + "'";
            OracleCommand com = new OracleCommand(comStr, con);
            DataSet ds = new DataSet();
            OracleDataAdapter sda = new OracleDataAdapter(com);
            sda.Fill(ds);
            con.Close();
            return ds;
        }

        public int checkBlood(string blood, string purDate)
        {
            string conStr = "Data Source=XE;User ID=admin;Password=root;Unicode=True";
            OracleConnection con = new OracleConnection(conStr);
            con.Open();

            OracleCommand com = new OracleCommand();

            com.Connection = con;
            com.CommandText = "fun_checkBlood";
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add("fun_blood", OracleType.VarChar).Value = blood;
            com.Parameters.Add("fun_purDate", OracleType.VarChar).Value = purDate;
            com.Parameters.Add("account_id", OracleType.Number);
            com.Parameters["account_id"].Direction = ParameterDirection.ReturnValue;

            com.ExecuteNonQuery();

            String idStr = Convert.ToString(com.Parameters["account_id"].Value);

            int id = Convert.ToInt32(idStr);

            return id;
        }

        public void deleteItem(string sl)
        {
            string conStr = "Data Source=XE;User ID=admin;Password=root;Unicode=True";
            OracleConnection con = new OracleConnection(conStr);
            con.Open();
            string comStr = "Delete from storage_info where sl = '" + sl + "' ";
            OracleCommand com = new OracleCommand(comStr, con);
            com.ExecuteNonQuery();
            con.Close();            
        }

        public int bloodCount(string blood)
        {
            int cnt = 0;
            string conStr = "Data Source=XE;User ID=admin;Password=root;Unicode=True";
            OracleConnection con = new OracleConnection(conStr);
            con.Open();
            string comStr = "select bg from storage_info where bg = '" + blood + "'";
            OracleCommand com = new OracleCommand(comStr, con);
            OracleDataReader sdr = com.ExecuteReader();
            while (sdr.Read())
            {
                cnt++;
            }
            con.Close();
            return cnt;            
        }        

        public bool varifyAdmin(string un, string pass)
        {            
            string conStr = "Data Source=XE;User ID=admin;Password=root;Unicode=True";
            OracleConnection con = new OracleConnection(conStr);
            con.Open();
            string comStr = "select * from admin_info where userName='" + un + "' and pass='" + pass + "'";
            OracleCommand com = new OracleCommand(comStr, con);
            OracleDataReader sdr = com.ExecuteReader();
            while (sdr.Read())
            {
                con.Close();
                return true;
            }            

            MessageBox.Show("Invalid Username/Password");
            con.Close();
            return false;
        }

        public DataSet Search(string comStr)
        {
            string conStr = "Data Source=XE;User ID=admin;Password=root;Unicode=True";
            OracleConnection con = new OracleConnection(conStr);
            con.Open();
            OracleCommand com = new OracleCommand(comStr, con);
            DataSet ds = new DataSet();
            OracleDataAdapter sda = new OracleDataAdapter(com);
            sda.Fill(ds);
            con.Close();
            return ds;
        }

        public DataSet storageSearch(string comStr)
        {
            string conStr = "Data Source=XE;User ID=admin;Password=root;Unicode=True";
            OracleConnection con = new OracleConnection(conStr);
            con.Open();
            OracleCommand com = new OracleCommand(comStr, con);
            DataSet ds = new DataSet();
            OracleDataAdapter sda = new OracleDataAdapter(com);
            sda.Fill(ds);
            con.Close();
            return ds;
        }

        public DataSet clientSearch(string comStr)
        {
            string conStr = "Data Source=XE;User ID=admin;Password=root;Unicode=True";
            OracleConnection con = new OracleConnection(conStr);
            con.Open();
            OracleCommand com = new OracleCommand(comStr, con);
            DataSet ds = new DataSet();
            OracleDataAdapter sda = new OracleDataAdapter(com);
            sda.Fill(ds);
            con.Close();
            return ds;
        }
    }
}
