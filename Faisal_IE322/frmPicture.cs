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
    public partial class frmPicture : Form
    {
        public frmPicture()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnLoadimage_Click(object sender, EventArgs e)
        {
            PicTry.Image = Image.FromFile("C:\\Users\\F9ool\\OneDrive\\سطح المكتب\\Cukur.jpg");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnBack_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
