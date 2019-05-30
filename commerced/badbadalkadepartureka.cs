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
    public partial class badbadalkadepartureka : Form
    {
        public badbadalkadepartureka()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            if (datagridviewofupdatedeparture.CurrentRow.DataGridView.CurrentCell.ColumnIndex != 0)
            {
                MessageBox.Show("Please select the ID of the departure you want to update!");
                return;
            }
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
            xidhiidhiye mm = new xidhiidhiye();
            int Dep_ID = Convert.ToInt32(datagridviewofupdatedeparture.CurrentCell.Value);
            if (Dep_ID != 0)
            {
                mm.updateaduptures(Dep_ID, mash);
                datagridviewofupdatedeparture.DataSource = mm.LoadData("Departure");
                MessageBox.Show("updated successfuly!", "update Departure");
            }
            
            //
        }

        private void badbadalkadepartureka_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'competitionDataSet13.Departure' table. You can move, or remove it, as needed.
            this.departureTableAdapter.Fill(this.competitionDataSet13.Departure);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //
            xidhiidhiye jackarta = new xidhiidhiye();

            if (datagridviewofupdatedeparture.CurrentRow.DataGridView.CurrentCell.ColumnIndex != 0)
            {
                MessageBox.Show("Please select the ID of the departure you want to delete!", "Incorrect format");
                return;
            }
            int id = Convert.ToInt32(datagridviewofupdatedeparture.CurrentCell.Value);
            if (id != 0)
            {
                jackarta.masaxarrivalpeaple(id);
                datagridviewofupdatedeparture.DataSource = jackarta.LoadData("[Departure]");
                MessageBox.Show("Deleted successfuly!", "Delete employee");
            }
            //
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //
            if (datagridviewofupdatedeparture.CurrentRow.DataGridView.CurrentCell.ColumnIndex != 0)
            {
                MessageBox.Show("Please select the ID of the departure you want to update!");
                return;
            }
           
            outing mash = new outing();
            
            mash.magacatagaha = txtdeparturename.Text;
            mash.addreskatagaha = txtdepartureaddress.Text;
            mash.nationalitigatagaha = cmbnationalitydeparture.Text;
            mash.tocountrigatagaha = comboBox1.Text;
            mash.pasporttypekatagaha = comboBox2.Text;
            mash.passportnambarkatagaha = int.Parse(txtpassportno.Text).ToString();
            mash.cashuurtatagaha = int.Parse(txttaxamountadupture.Text).ToString("C");
            mash.checkingkatagaha = comboBox5.Text;
            mash.agekatagaha = int.Parse(txtdepartureage.Text).ToString();
            mash.genderkatagaha = comboBox4.Text;
            mash.datekatagaha = dateTimePicker2.Text;
            xidhiidhiye mm = new xidhiidhiye();
            int Dep_ID = Convert.ToInt32(datagridviewofupdatedeparture.CurrentCell.Value);
            if (Dep_ID != 0)
            {
                mm.updateaduptures(Dep_ID, mash);
                datagridviewofupdatedeparture.DataSource = mm.LoadData("Departure");
                MessageBox.Show("updated successfuly!", "update Departure");
            }

            //
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //
            xidhiidhiye jackarta = new xidhiidhiye();

            if (datagridviewofupdatedeparture.CurrentRow.DataGridView.CurrentCell.ColumnIndex != 0)
            {
                MessageBox.Show("Please select the ID of the departure you want to delete!", "Incorrect format");
                return;
            }
            int id = Convert.ToInt32(datagridviewofupdatedeparture.CurrentCell.Value);
            if (id != 0)
            {
                jackarta.masaxarrivalpeaple(id);
                datagridviewofupdatedeparture.DataSource = jackarta.LoadData("[Departure]");
                MessageBox.Show("Deleted successfuly!", "Delete employee");
            }
            //
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
