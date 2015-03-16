using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSELABMAN.VIEW
{
    public partial class VIEWUSER : Form
    {
        public VIEWUSER()
        {
            InitializeComponent();
        }

        private void button_USER_Click(object sender, EventArgs e)
        {
            USERREGIS frmREGIS = new USERREGIS();
            frmREGIS.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            USEREDIT frmEDIT = new USEREDIT();
            frmEDIT.Show();
        }
    }
}
