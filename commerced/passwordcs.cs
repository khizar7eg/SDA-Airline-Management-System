using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace commerced
{
    public partial class passwordcs : Form
    {
        public passwordcs()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ////this is a notivication if username or password is less than 4 characteristics .
            //if ((txtusername.Text == "") || (txtpassword.Text == ""))
            //{
            //    MessageBox.Show("username and password are empty please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
            //else
                if (txtusername.Text == "")
                {
                    MessageBox.Show("please insert your email address to get access", "Error username");
                    txtusername.BackColor = Color.YellowGreen;
                }
                else
                    if (txtpassword.Text == "")
                    {
                        MessageBox.Show("please enter your password address", "Incorrect password");
                        txtpassword.BackColor = Color.Yellow;
                    }

                    else
                        if ((txtusername.Text == "group3") && (txtpassword.Text == "12345"))
                        {
                            this.Hide();
                           mymajor ss = new mymajor();
                            ss.Show();

                        }


                        else
                        {
                            MessageBox.Show("unfortunately your email address or password are not correct please try again", "Invalid Data", MessageBoxButtons.OKCancel);
                            txtusername.Focus();
                            txtpassword.Text = "";
                            txtusername.Text = "";
                        }
          

           
           
            //be fore this only.
          
        }
    }
}
