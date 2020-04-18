using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faisal_IE322
{
    public partial class frmRadio : Form
    {
        public frmRadio()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
                RdoRed2.ForeColor = Color.FromArgb(255, 0, 0);
            
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            
                RdoGreen2.ForeColor = Color.FromArgb(0, 255, 0);
            
        }

        private void RdoRed_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoRed.Checked == true)
                RdoRed.ForeColor = Color.FromArgb(255, 0, 0);
            else
                RdoRed.ForeColor = Color.FromArgb(0, 0, 0);
            
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void RdoGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoGreen.Checked == true)
                RdoGreen.ForeColor = Color.FromArgb(0, 255, 0);
            else
                RdoGreen.ForeColor = Color.FromArgb(0, 0, 0);
            
        }

        private void RdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoBlue.Checked == true)
                RdoBlue.ForeColor = Color.FromArgb(0, 0, 255);
            else
                RdoBlue.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RdoYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoYellow.Checked == true)
                RdoYellow.ForeColor = Color.FromArgb(255,255, 0);
            else
                RdoYellow.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            RdoRed.Checked = false;
            RdoBlue.Checked = false;
            RdoGreen.Checked = false;
            RdoYellow.Checked = false;
            RdoRed2.Checked = false;
            RdoBlue2.Checked = false;
            RdoGreen2.Checked = false;
            RdoYellow2.Checked = false;

            RdoBlue.ForeColor = Color.FromArgb(0, 0, 0);
            RdoRed.ForeColor = Color.FromArgb(0, 0, 0);
            RdoYellow.ForeColor = Color.FromArgb(0, 0, 0);
            RdoGreen.ForeColor = Color.FromArgb(0, 0, 0);
            RdoBlue2.ForeColor = Color.FromArgb(0, 0, 0);
            RdoRed2.ForeColor = Color.FromArgb(0, 0, 0);
            RdoYellow2.ForeColor = Color.FromArgb(0, 0, 0);
            RdoGreen2.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void RdoBlue2_CheckedChanged(object sender, EventArgs e)
        {
            
                RdoBlue2.ForeColor = Color.FromArgb(0, 0, 255);
           
        }

        private void RdoYellow2_CheckedChanged(object sender, EventArgs e)
        {
           
                RdoYellow2.ForeColor = Color.FromArgb(255, 255, 0);
           
        }
    }
}
