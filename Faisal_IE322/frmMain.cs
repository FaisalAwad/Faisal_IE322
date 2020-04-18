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
    public partial class F_IE322 : Form
    {
        string username = "Faisal";
        string myPassword = "123456";
        int attempt = 1;
        int MaxAttempts = 3;
        private object LblUsername;

        public F_IE322()
        {
            InitializeComponent();
        }

        private void F_IE322_Load(object sender, EventArgs e)
        {
            BtnExit.Enabled = false;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            while (attempt <= MaxAttempts)
            {
                if (textBox1.Text != username)
                {
                    // username is incorrect
                    MessageBox.Show("Invalid username, " + (MaxAttempts - attempt) + " attempts remaining");
                    attempt++;
                    return;
                }
                else
                {   // username is correct
                    // so check password			
                    if (textBox2.Text != myPassword)
                    {
                        // Incorrect password
                        attempt++;
                        MessageBox.Show("Incorrect password," + (MaxAttempts - attempt) + " attempts remaining");
                        return;
                    }
                    else
                    {
                        //Both are correct
                        attempt = 1; // reset the number of attempts
                        MessageBox.Show("Login successful");



                        BtnLogin.Text = "Logout";
                        // this.Width = 1600;
                        break; // come out of while loop
                    }//endif

                }//endif
            }//end while

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnManufacturingcell_Click(object sender, EventArgs e)
        {

        }

        private void BtnRadio_Click(object sender, EventArgs e)
        {
            frmRadio frm = new frmRadio();
            frm.ShowDialog();
        }

        private void BtnCheckbox_Click(object sender, EventArgs e)
        {
            frmCheckbox frm = new frmCheckbox();
            frm.ShowDialog();
        }

        private void BtnCombo_Click(object sender, EventArgs e)
        {
            frmCombo frm = new frmCombo();
            frm.ShowDialog();
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            frmRandom frm = new frmRandom();
            frm.ShowDialog();
        }

        private void BtnRandomCom_Click(object sender, EventArgs e)
        {
            frmRandomCombo frm = new frmRandomCombo();
            frm.ShowDialog();
        }

        private void BtnPicturebox_Click(object sender, EventArgs e)
        {
            frmPicture frm = new frmPicture();
            frm.ShowDialog();
        }
    }
}
