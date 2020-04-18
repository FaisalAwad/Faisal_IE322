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
    public partial class frmCheckbox : Form
    {
        public frmCheckbox()
        {
            InitializeComponent();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (ChkCoffee.Checked == true)
            {
                msg = ChkCoffee.Text;
            }
            if(ChkDonut.Checked == true)
            {
                msg = msg + " " + ChkDonut.Text;
            }
            if (ChkBrownie.Checked == true)
            {
                msg = msg + " " + ChkBrownie.Text;
            }
            if (msg.Length > 0)
            {
                MessageBox.Show(msg + " ordered. ");
            }
            else
            {
                MessageBox.Show("Nothing ordered.");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmCheckbox_Load(object sender, EventArgs e)
        {

        }

        private void ChkCoffee_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
