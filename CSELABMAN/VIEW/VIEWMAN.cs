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
    public partial class VIEWMAN : Form
    {
        public VIEWMAN()
        {
            InitializeComponent();
        }

        private void button_BORROW_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this, "Function is under construction!", "Mượn thiết bị", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MANBORROW frmBORROW = new MANBORROW();
            frmBORROW.Show();
        }

        private void button_RETURN_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this, "Function is under construction!", "Trả thiết bị", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MANRETURN frmRETURN = new MANRETURN();
            frmRETURN.Show();
        }
    }
}
