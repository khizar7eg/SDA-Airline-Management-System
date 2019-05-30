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
    public partial class changesof_arrival : Form
    {
        public changesof_arrival()
        {
            InitializeComponent();
        }

        private void changesof_arrival_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'competitionDataSet14.Arivalpeaple' table. You can move, or remove it, as needed.
            this.arivalpeapleTableAdapter.Fill(this.competitionDataSet14.Arivalpeaple);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            if (dataGridViewarrivalpeaple.CurrentRow.DataGridView.CurrentCell.ColumnIndex != 0)
            {
                MessageBox.Show("Please select the ID of the employee you want to update!");
                return;
            }
            comingpeaple jam = new comingpeaple();
            jam.arrivalnameka = txtname.Text;
            jam.addreskiisa = txtaddress.Text;
            jam.hoygiisa = cmbonationality.Text;
            jam.martigaliye = cmbohostcountry.Text;
            jam.ujeedaduuyimi = txtpurposes.Text;
            jam.noocapasportkiisa = txtpstype.Text;
            jam.pasportnumberka = int.Parse(txtpspno.Text).ToString();
            jam.cashuurtiisa = int.Parse(txttaxes.Text).ToString();
            jam.inlaeegay = cmbchecking.Text;
            jam.cimrigiisa = int.Parse(txtage.Text).ToString();
            jam.labordhedig = cmbogender.Text;
            jam.xiliguyimi = dateTimePicker1.Text;
            xidhiidhiye jj = new xidhiidhiye();
            int Ar_ID = Convert.ToInt32(dataGridViewarrivalpeaple.CurrentCell.Value);
            if (Ar_ID != 0)
            {
                jj.updatearrivals(Ar_ID, jam);
                dataGridViewarrivalpeaple.DataSource = jj.LoadData("Arivalpeaple");
                MessageBox.Show("updated successfuly!", "update employee");
            }
            //
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //
            if (dataGridViewarrivalpeaple.CurrentRow.DataGridView.CurrentCell.ColumnIndex != 0)
            {
                MessageBox.Show("Please select the ID of the arrival you want to delete!", "Incorrect format");
                return;
            }
            int Ar_ID = Convert.ToInt32(dataGridViewarrivalpeaple.CurrentCell.Value);
            if (Ar_ID != 0)
            {
                xidhiidhiye aaa = new xidhiidhiye();
                aaa.masaxarrivalpeaple(Ar_ID);
                dataGridViewarrivalpeaple.DataSource = aaa.LoadData("Arivalpeaple");
                MessageBox.Show("Deleted successfuly!", "Delete arrival");
            }
            //
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
