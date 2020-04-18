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
    public partial class frmRandomCombo : Form
    {
        public frmRandomCombo()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnGenerate2_Click(object sender, EventArgs e)
        {
            CmbRandom2.ResetText();
            CmbRandom2.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < r.Next(1,50)-1; i++)
            {
                CmbRandom2.Items.Add(r.Next(100, 999));
            }
        }

        private void BtnGenerate1_Click(object sender, EventArgs e)
        {
            CmbRandom1.ResetText();
            CmbRandom1.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < r.Next(1, 500) - 1; i++)
            {
                CmbRandom1.Items.Add(r.Next(100, 999));
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnReset2_Click(object sender, EventArgs e)
        {

        }
    }
}
