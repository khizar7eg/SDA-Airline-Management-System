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
    public partial class fromoutsiders : Form
    {
        public fromoutsiders()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comingpeaple jam = new comingpeaple();
            jam.arrivalnameka = txtname.Text;
            jam.addreskiisa = txtaddress.Text;
            jam.hoygiisa = cmbonationality.Text;
            jam.martigaliye = cmbohostcountry.Text;
            jam.ujeedaduuyimi = txtpurposes.Text;
            jam.noocapasportkiisa = txtpstype.Text;
            jam.pasportnumberka = int.Parse(txtpspno.Text).ToString();
            jam.cashuurtiisa = int.Parse(txttaxes.Text).ToString("C"); 
            jam.inlaeegay = cmbchecking.Text;
            jam.cimrigiisa = int.Parse(txtage.Text).ToString();
            jam.labordhedig = cmbogender.Text;
            jam.xiliguyimi = dateTimePicker1.Text;

            xidhiidhiye mamaafric = new xidhiidhiye();
            mamaafric.registerarrivals(jam);
            MessageBox.Show("thanks you have registered it", "Registered");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            outing mash = new outing();
            mash.magacatagaha = txtdeparturename.Text;
            mash.addreskatagaha = txtdepartureaddress.Text;
            mash.nationalitigatagaha = cmbnationalitydeparture.Text;
            mash.tocountrigatagaha = comboBox1.Text;
            mash.pasporttypekatagaha = comboBox2.Text;
            mash.passportnambarkatagaha = Convert.ToInt64(txtpassportno.Text).ToString();
            mash.cashuurtatagaha = int.Parse(txttaxamountadupture.Text).ToString("C");
            mash.checkingkatagaha = comboBox5.Text;
            mash.agekatagaha = int.Parse(txtdepartureage.Text).ToString();
            mash.genderkatagaha = comboBox4.Text;
            mash.datekatagaha = dateTimePicker2.Text;

            xidhiidhiye music = new xidhiidhiye();
            music.registeraduptures(mash);
            MessageBox.Show("you have registered the adupture", "registered adupture");
          
           

           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //
             if (radioButton1.Checked == true)
            {
                badbadalkadepartureka ss = new badbadalkadepartureka();
                ss.Show();
            }
            else
                if (radioButton2.Checked == true)
                {
                    changesof_arrival ss = new changesof_arrival();
                    ss.Show();
                }
            
                    else
                    {
                        MessageBox.Show("please select one of the above tables to get access", "wrong");
                    }
            //
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
                
           mymajor ss = new mymajor();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
