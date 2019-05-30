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
    public partial class financinterface : Form
    {
        public financinterface()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            airportincome ss = new airportincome();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            //
            myincome savedakhli = new myincome();
            savedakhli.incomedescriptionka = textBox11.Text;
            savedakhli.noocaproject = comboBox5.Text;
            savedakhli.datekaincomeka = dateTimePicker3.Text;
            savedakhli.xadigaincomekasoogalay = Convert.ToInt64(textBox10.Text).ToString("C");
            //savedakhli.incomenumber = int.Parse(textBox9.Text);
            xidhiidhiye dakhligaxaree = new xidhiidhiye();
            dakhligaxaree.insertincome(savedakhli);
            MessageBox.Show("you have registered your income", "you winned", MessageBoxButtons.OK);
            //
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox11.Text = "";
            textBox10.Text = "";
            dateTimePicker1.Text = "";
            comboBox5.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //
            workingexpenses savekhlagalay = new workingexpenses();
            //savekhlagalay.expensinum = Convert.ToInt32(txtexpenseno.Text);
            savekhlagalay.amountigakhlagushqeeyay = Convert.ToInt64(txtamexpense.Text).ToString("C");
            savekhlagalay.expenstypekalagushaqeeyay = typecombo.Text;
            savekhlagalay.taariikhdakharashlagushaqeeyo = dateTimePicker2.Text;
            xidhiidhiye internalexpesis = new xidhiidhiye();
            internalexpesis.galikharashadkayaga(savekhlagalay);
            MessageBox.Show("we have registered your expenses", "registered expenses");
            //
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
            txtamexpense.Text = "";
            typecombo.Text = "";
            dateTimePicker2.Text = "";
        }

        private void financinterface_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          salaryexpenses ss = new salaryexpenses();
          // 
          if (comboBox1.Text == "")
          {
              MessageBox.Show("please insert the salary for the month", "missing data");
              comboBox1.Focus();
          }
          else
              if (comboBox3.Text == "")
              {
                  MessageBox.Show("please insert the year", "Missing data", MessageBoxButtons.OKCancel);
                  comboBox3.Focus();
              }//
              else
                  if (comboBox2.Text == "")
                  {
                      MessageBox.Show("please insert the job", "Missing data", MessageBoxButtons.OKCancel);
                      textBox3.Focus();
                  }
                  //
                  else
                      if (dateTimePicker1.Text == "")
                      {
                          MessageBox.Show("pease insert the date", "missing data");
                          dateTimePicker1.Focus();
                      }
                      else
                          if (textBox2.Text == "")
                          {
                              MessageBox.Show("pease insert the employee name", "missing data");
                              textBox2.Focus();
                          }
                          else
                              if (comboBox4.Text == "")
                              {
                                  MessageBox.Show("pease insert at data", "missing data");
                                  comboBox4.Focus();
                              }
                              else
                                  if (textBox3.Text == "")
                                  {
                                      MessageBox.Show("pease insert the Basic salary", "missing data");
                                      textBox3.Focus();
                                  }
                                  else
                                      if (textBox4.Text == "")
                                      {
                                          MessageBox.Show("pease insert hours for work", "missing data");
                                          textBox4.Focus();
                                      }
                                      
                                      else
                                      {
                                          //kkk
                                          ss.bishashaqada = comboBox1.Text;
                                          ss.sanadkushaqeeyay = comboBox3.Text;
                                          ss.Takhasuskiisashaqo = comboBox2.Text;
                                          ss.xiligulacagtahelay = dateTimePicker1.Text;
                                          ss.magacashaqaalaha = textBox2.Text;
                                          ss.intuqaaibahaa = comboBox4.Text;
                                          ss.lacagtuqaato = Convert.ToDecimal(textBox3.Text).ToString("C");
                                          ss.Hraga = Convert.ToInt32(textBox4.Text).ToString();

                                          ss.specialalowensiga = Convert.ToInt64(textBox5.Text).ToString();
                                          ss.intuqaaibahaa = (comboBox4.Text);

                                          iskugeekalajar guul = new iskugeekalajar();
                                          decimal num1, num2, Hrs, result;
                                          num1 = decimal.Parse(textBox3.Text);
                                          num2 = decimal.Parse(textBox5.Text);
                                          Hrs = decimal.Parse(textBox4.Text);
                                          result = num1 + num2;
                                          //textBox7.Text = f.ToString("somaliland");
                                          textBox6.Text = result.ToString("c");

                                          ss.allgidi = textBox6.Text;
                                          ss.Netsalariga = textBox7.Text;
                                          xidhiidhiye jack = new xidhiidhiye();
                                          jack.givethesalary(ss);
                                          MessageBox.Show("you have registered employee salary", "Registered well");
                                          // kkk
                                          //ss.allgidi = Convert.ToInt32(textBox6.Text);
                                          //ss.Netsalariga = Convert.ToInt32(textBox7.Text);
                                      }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            exporting_materials mm = new exporting_materials();
            mm.magacabadeecada = textBox1.Text;
            mm.shakhsigaleh = textBox9.Text;
            mm.cashuurtabaddeecada = int.Parse(textBox12.Text).ToString("C");
            mm.baaxadabadeecada =Convert.ToInt64(textBox13.Text).ToString();
            mm.dalkaykadhoofaysobaddeecadu = comboBox6.Text;
            mm.dalkayudhoofaysobaddeecadu = comboBox7.Text;
            mm.culayskabadeecada = Convert.ToInt64(textBox14.Text).ToString("kg");
            mm.taariikhdabadeecada = dateTimePicker4.Text;
            xidhiidhiye rozaria = new xidhiidhiye();
            rozaria.registerabagaashka(mm);
            MessageBox.Show("yes you have registerede", "registered material");

                
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            changingfinances mm = new changingfinances();
            mm.Show();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //changingfinances ss = new changingfinances();
            //ss.Show();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
