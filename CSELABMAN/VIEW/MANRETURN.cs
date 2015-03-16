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
    public partial class MANRETURN : Form
    {
        public MANRETURN()
        {
            InitializeComponent();
        }

        private void but_checkUSER_Click(object sender, EventArgs e)
        {

        }

        private void but_OpenPort_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_RFID_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_RFID.Checked)
            {
                textBox_UserName.Enabled = false;
                textBox_DEVName.Enabled = false;
                textBox_RFIDUser.Enabled = true;
                textBox_RFIDDEV.Enabled = true;
            }
            else
            {
                textBox_RFIDUser.Enabled = false;
                textBox_RFIDDEV.Enabled = false;
                textBox_UserName.Enabled = true;
                textBox_DEVName.Enabled = true;
            }
        }

        private void checkBox_User_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_User.Checked)
            {
                textBox_RFIDDEV.Enabled = false;
                textBox_DEVName.Enabled = false;
                textBox_RFIDUser.Enabled = true;
                textBox_UserName.Enabled = true;
            }
            else
            {
                textBox_RFIDUser.Enabled = false;
                textBox_UserName.Enabled = false;
                textBox_RFIDDEV.Enabled = true;
                textBox_DEVName.Enabled = true;
            }
        }
    }
}
