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
    public partial class expiredBlood : UserControl
    {
        public expiredBlood()
        {
            InitializeComponent();
        }

        public void clearText()
        {
            totText.Text = "";
            abpText.Text = "";
            abnText.Text = "";
            apText.Text = "";
            anText.Text = "";
            bpText.Text = "";
            bnText.Text = "";
            opText.Text = "";
            onText.Text = "";
        }
    }
}
