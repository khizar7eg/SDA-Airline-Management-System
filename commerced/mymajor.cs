using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;


namespace commerced
{
    public partial class mymajor : Form
    {
        public mymajor()
        {
            InitializeComponent();
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //
            if (txtsearch.Text == "finance" || (txtsearch.Text == "FINANCE") || (txtsearch.Text == "1"))
            {
                financinterface ss = new financinterface();
                ss.Show();
            }
            else
                if (txtsearch.Text == "imigration" || (txtsearch.Text == "IMAGRATION") || (txtsearch.Text == "2"))
                {
                    fromoutsiders ss = new fromoutsiders();
                    ss.Show();
                }

                else
                    if (txtsearch.Text == "Internet" || (txtsearch.Text == "INTERNET") || (txtsearch.Text == "3"))
                    {

                        Emails ss = new Emails();
                        ss.Show();

                    }


                    else
                        if (txtsearch.Text == "INCOME" || (txtsearch.Text == "income") || (txtsearch.Text == "4"))
                        {
                            financinterface ss = new financinterface();
                            ss.Show();
                        }

                        else
                            if (txtsearch.Text == "egalinternationalincomes" || (txtsearch.Text == "EGALINTERNATIONALINCOMES") || (txtsearch.Text == "5"))
                            {
                                egalinternational ss = new egalinternational();
                                ss.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid data please try again", "wrong writting");
                            }

            //
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            register ss = new register();
            ss.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            egalinternational ss = new egalinternational();
            ss.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            financinterface jj = new financinterface();
            jj.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            fromoutsiders jj = new fromoutsiders();
            jj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            register ss = new register();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            egalinternational ss = new egalinternational();
            ss.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            financinterface jj = new financinterface();
            jj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Emails ss = new Emails();
            ss.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            fromoutsiders jj = new fromoutsiders();
            jj.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Firefox2015 ss = new Firefox2015();
            ss.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Emails ss = new Emails();
            ss.Show(); 
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("egal international airport");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            changingfinances ss = new changingfinances();
            ss.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aboutbox ss = new Aboutbox();
            ss.Show();
        }
    }
}
