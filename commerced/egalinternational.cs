using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace commerced
{

    public partial class egalinternational : Form
        
    {
        xidhiidhiye kasaar = new xidhiidhiye();
        xidhiidhiye gain = new xidhiidhiye();
        public egalinternational()
        {
            InitializeComponent();
        }

        private void egalinternational_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'competitionDataSet10.myairport' table. You can move, or remove it, as needed.
            //this.myairportTableAdapter.Fill(this.competitionDataSet10.myairport);
            //// TODO: This line of code loads data into the 'competitionDataSet9.International_airport' table. You can move, or remove it, as needed.
            //this.international_airportTableAdapter3.Fill(this.competitionDataSet9.International_airport);
            //// TODO: This line of code loads data into the 'competitionDataSet5.International_airport' table. You can move, or remove it, as needed.
            //this.international_airportTableAdapter2.Fill(this.competitionDataSet5.International_airport);
            //// TODO: This line of code loads data into the 'competitionDataSet4.International_airport' table. You can move, or remove it, as needed.
            //this.international_airportTableAdapter1.Fill(this.competitionDataSet4.International_airport);
            ////// TODO: This line of code loads data into the 'competitionDataSet3.International_airport' table. You can move, or remove it, as needed.
            ////this.international_airportTableAdapter.Fill(this.competitionDataSet3.International_airport);
            ////// TODO: This line of code loads data into the 'competitionDataSet2.Airports' table. You can move, or remove it, as needed.
            ////this.airportsTableAdapter1.Fill(this.competitionDataSet2.Airports);
            ////// TODO: This line of code loads data into the 'competitionDataSet1.Airports' table. You can move, or remove it, as needed.
            ////this.airportsTableAdapter.Fill(this.competitionDataSet1.Airports);
            dataGridView1.DataSource = kasaar.LoadData("[myairport]");

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hairport love = new Hairport();

            love.magacairiportka = textBox2.Text;
            love.goobtairiportka = textBox3.Text;
            love.tiradashaqaalaha = textBox4.Text;
            love.tiradadiyaaradaha = textBox5.Text;
            love.tiradatraffee = textBox6.Text;
            love.mamulkairiportka = textBox7.Text;
            love.sanadkalajoogo = textBox1.Text;
            love.Tladhisay = dateTimePicker1.Text;

            xidhiidhiye saved = new xidhiidhiye();
            saved.diwangaliaiport(love);
            dataGridView1.DataSource = saved.LoadData("[myairport]");
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //
            if (dataGridView1.CurrentRow.DataGridView.CurrentCell.ColumnIndex != 0)
            {
                MessageBox.Show("Please select the ID of the airport you want to update!", "updating airport");
                return;
            }
            Hairport resave = new Hairport();

            resave.magacairiportka = textBox2.Text;
            resave.goobtairiportka = textBox3.Text;
            resave.tiradashaqaalaha = textBox4.Text;
            resave.tiradadiyaaradaha = textBox5.Text;
            resave.tiradatraffee = textBox6.Text;
            resave.mamulkairiportka = textBox7.Text;
            resave.sanadkalajoogo = textBox1.Text;
            resave.Tladhisay = dateTimePicker1.Text;
            xidhiidhiye resaveemployee = new xidhiidhiye();
            int id = Convert.ToInt32(dataGridView1.CurrentCell.Value);
            if (id != 0)
            {
                gain.changedata(id, resave);
                dataGridView1.DataSource = gain.LoadData("myairport");
                MessageBox.Show("updated successfuly!", "update airport");
            }
            //
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ////

            //if (dataGridView1.CurrentRow.DataGridView.CurrentCell.ColumnIndex != 0)
            //{
            //    MessageBox.Show("Please select the ID of the Airport you want to delete!", "Incorrect format");
            //    return;
            //}
            //int id = Convert.ToInt32(dataGridView1.CurrentCell.Value);
            //if (id != 0)
            //{
            //    kasaar.deletegareeiriboodhka(id);

            //    dataGridView1.DataSource = kasaar.LoadData("[myairport]");
            ////    MessageBox.Show("Deleted successfuly!", "Delete airport");
            //}
            //
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //
            if (textBox2.Text == "")
            {
                MessageBox.Show("please insert the name of employee", "missing name");
                textBox2.Focus();
            }
            else
                if (textBox3.Text == "")
                {
                    MessageBox.Show("please insert the address", "Missing data", MessageBoxButtons.OKCancel);
                    textBox3.Focus();
                }//
                else
                    if (textBox4.Text == "")
                    {
                        MessageBox.Show("please insert the Number of employees", "Missing data", MessageBoxButtons.OKCancel);
                        textBox3.Focus();
                    }
                    //
                    else
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("pease insert the year", "missing data");
                            textBox1.Focus();
                        }
                        else
                            if (textBox5.Text == "")
                            {
                                MessageBox.Show("pease insert Number of airplanes", "missing data");
                                textBox5.Focus();
                            }
                            else
                                if (textBox6.Text == "")
                                {
                                    MessageBox.Show("pease insert Number of Trafic", "missing data");
                                    textBox6.Focus();
                                }
                                else
                                    if (textBox7.Text == "")
                                    {
                                        MessageBox.Show("pease insert the manager", "missing data");
                                        textBox7.Focus();
                                    }
                                    else
                                        if (dateTimePicker1.Text == "")
                                        {
                                            MessageBox.Show("pease insert the date created airport", "missing data");
                                            dateTimePicker1.Focus();
                                        }
                                        else
                                        {
                                            //
                                            Hairport love = new Hairport();

                                            love.magacairiportka = textBox2.Text;
                                            love.goobtairiportka = textBox3.Text;
                                            love.tiradashaqaalaha = textBox4.Text;
                                            love.tiradadiyaaradaha = textBox5.Text;
                                            love.tiradatraffee = textBox6.Text;
                                            love.mamulkairiportka = textBox7.Text;
                                            love.sanadkalajoogo = textBox1.Text;
                                            love.Tladhisay = dateTimePicker1.Text;

                                            xidhiidhiye saved = new xidhiidhiye();
                                            saved.diwangaliaiport(love);
                                            dataGridView1.DataSource = saved.LoadData("[myairport]");
                                        }
            //
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //

            if (dataGridView1.CurrentRow.DataGridView.CurrentCell.ColumnIndex != 0)
            {
                MessageBox.Show("Please select the ID of the Airport you want to delete!", "Incorrect format");
                return;
            }
            int id = Convert.ToInt32(dataGridView1.CurrentCell.Value);
            if (id != 0)
            {
                kasaar.deletegareeiriboodhka(id);

                dataGridView1.DataSource = kasaar.LoadData("[myairport]");
                MessageBox.Show("Deleted successfuly!", "Delete airport");
            }
            //
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //
            if (dataGridView1.CurrentRow.DataGridView.CurrentCell.ColumnIndex != 0)
            {
                MessageBox.Show("Please select the ID of the airport you want to update!", "updating airport");
                return;
            }
            Hairport resave = new Hairport();
            if (textBox2.Text == "")
            {
                MessageBox.Show("please insert the name of employee", "missing name");
                textBox2.Focus();
            }
            else
                if (textBox3.Text == "")
                {
                    MessageBox.Show("please insert the address", "Missing data", MessageBoxButtons.OKCancel);
                    textBox3.Focus();
                }//
                else
                    if (textBox4.Text == "")
                    {
                        MessageBox.Show("please insert the Number of employees", "Missing data", MessageBoxButtons.OKCancel);
                        textBox3.Focus();
                    }
                    //
                    else
                        if (textBox1.Text == "")
                        {
                            MessageBox.Show("pease insert the year", "missing data");
                            textBox1.Focus();
                        }
                        else
                            if (textBox5.Text == "")
                            {
                                MessageBox.Show("pease insert Number of airplanes", "missing data");
                                textBox5.Focus();
                            }
                            else
                                if (textBox6.Text == "")
                                {
                                    MessageBox.Show("pease insert Number of Trafic", "missing data");
                                    textBox6.Focus();
                                }
                                else
                                    if (textBox7.Text == "")
                                    {
                                        MessageBox.Show("pease insert the manager", "missing data");
                                        textBox7.Focus();
                                    }
                                    else
                                        if (dateTimePicker1.Text == "")
                                        {
                                            MessageBox.Show("pease insert the date created airport", "missing data");
                                            dateTimePicker1.Focus();
                                        }
                                        else
                                        {

            resave.magacairiportka = textBox2.Text;
            resave.goobtairiportka = textBox3.Text;
            resave.tiradashaqaalaha = textBox4.Text;
            resave.tiradadiyaaradaha = textBox5.Text;
            resave.tiradatraffee = textBox6.Text;
            resave.mamulkairiportka = textBox7.Text;
            resave.sanadkalajoogo = textBox1.Text;
            resave.Tladhisay = dateTimePicker1.Text;
            xidhiidhiye resaveemployee = new xidhiidhiye();
            int id = Convert.ToInt32(dataGridView1.CurrentCell.Value);
            if (id != 0)
            {
                gain.changedata(id, resave);
                dataGridView1.DataSource = gain.LoadData("myairport");
                MessageBox.Show("updated successfuly!", "update airport");
            }
            }
            //
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            financinterface ss = new financinterface();
            ss.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 jj = new Form2();
            jj.Show();
        }
    }
}
