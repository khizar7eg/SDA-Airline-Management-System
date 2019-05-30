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
    public partial class changingfinances : Form
    {
        public changingfinances()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //
            if (dataGridView1.CurrentRow.DataGridView.CurrentCell.ColumnIndex != 0)
            {
                MessageBox.Show("Please select the ID of the airport you want to update!", "updating airport");
                return;
            }
            myincome ss = new myincome();
            ss.incomedescriptionka = textBox11.Text;
            ss.noocaproject = comboBox5.Text;
            ss.datekaincomeka = dateTimePicker3.Text;
            ss.xadigaincomekasoogalay = Convert.ToInt64(textBox10.Text).ToString();
            xidhiidhiye las = new xidhiidhiye();
            int INno = Convert.ToInt32(dataGridView1.CurrentCell.Value);
            if (INno != 0)
            {
                las.updateincome(INno, ss);
                dataGridView1.DataSource = las.LoadData("egalincomes");
                MessageBox.Show("updated successfuly!", "update airport");
            }
          
            //
        }

        private void changingfinances_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'competitionDataSet24.egalincomes' table. You can move, or remove it, as needed.
            this.egalincomesTableAdapter2.Fill(this.competitionDataSet24.egalincomes);
            // TODO: This line of code loads data into the 'competitionDataSet23.egalincomes' table. You can move, or remove it, as needed.
            this.egalincomesTableAdapter1.Fill(this.competitionDataSet23.egalincomes);
            // TODO: This line of code loads data into the 'competitionDataSet22.egalincomes' table. You can move, or remove it, as needed.
            this.egalincomesTableAdapter1.Fill(this.competitionDataSet22.egalincomes);//halkan eeeg
            // TODO: This line of code loads data into the 'competitionDataSet21.workingcapitalexpense' table. You can move, or remove it, as needed.
            this.workingcapitalexpenseTableAdapter1.Fill(this.competitionDataSet21.workingcapitalexpense);
            // TODO: This line of code loads data into the 'competitionDataSet20.EXPORTS' table. You can move, or remove it, as needed.
            this.eXPORTSTableAdapter.Fill(this.competitionDataSet20.EXPORTS);
            // TODO: This line of code loads data into the 'competitionDataSet19.workingcapitalexpense' table. You can move, or remove it, as needed.
            this.workingcapitalexpenseTableAdapter.Fill(this.competitionDataSet19.workingcapitalexpense);
            // TODO: This line of code loads data into the 'competitionDataSet18.egalincomes' table. You can move, or remove it, as needed.
            this.egalincomesTableAdapter.Fill(this.competitionDataSet18.egalincomes);

        }

        public int lastincome { get; set; }

        private void button15_Click(object sender, EventArgs e)
        {
            //
            if (dataGridView1.CurrentRow.DataGridView.CurrentCell.ColumnIndex != 0)
            {
                MessageBox.Show("Please select the INno of the income you want to delete!", "Incorrect format");
                return;
            }
            int INno = Convert.ToInt32(dataGridView1.CurrentCell.Value);
            if (INno != 0)
            {
                xidhiidhiye jagta = new xidhiidhiye();
               jagta.khadkakasaar (INno);

                dataGridView1.DataSource = jagta.LoadData("[egalincomes]");
                MessageBox.Show("Deleted successfuly!", "Delete income");
            }
            //
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //
            if (dataGridView1.CurrentRow.DataGridView.CurrentCell.ColumnIndex != 0)
            {
                MessageBox.Show("Please select the EXPNO of the expense you want to DELETE!", "Incorrect format");
                return;
            }
            int EXPNO = Convert.ToInt32(dataGridView1.CurrentCell.Value);
            if (EXPNO != 0)
            {
                xidhiidhiye aaa = new xidhiidhiye();
                aaa.masaxkharashka(EXPNO);
                dataGridView1.DataSource = aaa.LoadData("workingcapitalexpense");
                MessageBox.Show("Deleted successfuly!", "Delete arrival");
            }
            //
            //
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //
            workingexpenses updatekhlagalaay = new workingexpenses();
            if (dataGridView2.CurrentRow.DataGridView.CurrentCell.ColumnIndex != 0)
            {
                MessageBox.Show("Please select the ID of the employee you want to update!");
                return;
            }
            //savekhlagalay.expensinum = Convert.ToInt32(txtexpenseno.Text);
            updatekhlagalaay.amountigakhlagushqeeyay = Convert.ToInt64(txtamexpense.Text).ToString("C");
            updatekhlagalaay.expenstypekalagushaqeeyay = typecombo.Text;
            updatekhlagalaay.taariikhdakharashlagushaqeeyo = dateTimePicker2.Text;
            xidhiidhiye jj = new xidhiidhiye();
            int EXPNO = Convert.ToInt32(dataGridView2.CurrentCell.Value);
            if (EXPNO != 0)
            {
                jj.updategareekharashaadka(EXPNO, updatekhlagalaay);
                dataGridView2.DataSource = jj.LoadData("workingcapitalexpense");
                MessageBox.Show("updated successfuly!", "update employee");
            }
            //
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            if (dataGridView3.CurrentRow.DataGridView.CurrentCell.ColumnIndex != 0)
            {
                MessageBox.Show("Please select the ID of the exports you want to update!");
                return;
            }
            exporting_materials mm = new exporting_materials();
            mm.magacabadeecada = textBox1.Text;
            mm.shakhsigaleh = textBox9.Text;
            mm.cashuurtabaddeecada = int.Parse(textBox12.Text).ToString("C");
            mm.baaxadabadeecada = Convert.ToInt64(textBox13.Text).ToString();
            mm.dalkaykadhoofaysobaddeecadu = comboBox6.Text;
            mm.dalkayudhoofaysobaddeecadu = comboBox7.Text;
            mm.culayskabadeecada = int.Parse(textBox14.Text).ToString();
            mm.taariikhdabadeecada = dateTimePicker4.Text;
            xidhiidhiye ss = new xidhiidhiye();
            int ID = Convert.ToInt32(dataGridView3.CurrentCell.Value);
            if (ID != 0)
            {
                ss.updateabagaashka(ID, mm);
                dataGridView3.DataSource = ss.LoadData("EXPORTS");
                MessageBox.Show("updated successfuly!", "update exports");
            }
           
            //
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //
            if (dataGridView3.CurrentRow.DataGridView.CurrentCell.ColumnIndex != 0)
            {
                MessageBox.Show("Please select the ID of the exports you want to update!");
                return;
            }
            xidhiidhiye JJA = new xidhiidhiye();
            int ID = Convert.ToInt32(dataGridView3.CurrentCell.Value);
            if (ID != 0)
            {
               JJA.deletebagaashka (ID);
                dataGridView3.DataSource = JJA.LoadData("EXPORTS");
                MessageBox.Show("Deleted successfuly!", "Delete exports");
            }
            //

        }
    }
}
