using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace commerced
{
    public partial class register : Form
    {
        xidhiidhiye obj1 = new xidhiidhiye();
        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'competitionDataSet17.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.competitionDataSet17.employee);
            dataGridView1.DataSource = obj1.LoadData("employee");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=RIDWAN\SABOWANAAG;Initial Catalog=competition;Integrated Security=True");

            //SqlDataAdapter ss = new SqlDataAdapter("SELECT * FROM employee where ID = '" + textBox1.Text + "'", con);
            //DataTable dt = new DataTable();
            //ss.Fill(dt);
            //textBox2.Text = dt.Rows[0][1].ToString();
            //textBox3.Text = dt.Rows[0][2].ToString();
            //textBox4.Text = dt.Rows[0][3].ToString();
            //textBox5.Text = dt.Rows[0][4].ToString();
            //textBox6.Text = dt.Rows[0][5].ToString();
            //textBox7.Text = dt.Rows[0][6].ToString();
            //dateTimePicker1.Text = dt.Rows[0][7].ToString();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();

            //xidhiidhiye data = new xidhiidhiye();
            //dataGridView1.DataSource = data.LoadData();

            //dhamaadka cordkaygu waa kor.
        }

        private void button4_Click(object sender, EventArgs e)
        {//the following code is updating the database.
            //SqlConnection con = new SqlConnection("sda");
            //sda.Update(dtshow);

            //if (dataGridView1.CurrentRow.DataGridView.CurrentCell.ColumnIndex != 0)
            //{
            //    MessageBox.Show("Please select the ID of the employee you want to update!");
            //    return;
            //}
            //employee lastsave = new employee();
            //lastsave.magaca = textBox2.Text;
            //lastsave.ciwanka = textBox3.Text;
            //lastsave.mobilka = textBox4.Text;
            //lastsave.mushaharka = textBox5.Text;
            //lastsave.shaqada = comboBox2.Text; ;
            //lastsave.nooca = comboBox1.Text;
            //lastsave.ciwinterta = textBox1.Text;
            //lastsave.Taariikhda = dateTimePicker1.Text;
            //xidhiidhiye resaveemployee = new xidhiidhiye();
            //int id = Convert.ToInt32(dataGridView1.CurrentCell.Value);
            //if (id != 0)
            //{
            //    obj1.dibubadal(id, lastsave);
            //    dataGridView1.DataSource = obj1.LoadData("employee");
            //    MessageBox.Show("updated successfuly!", "update employee");
            //}
            ////dhamaad




        }

        private void button5_Click(object sender, EventArgs e)
        {
            //    employee newEmployee = new employee();
            //    // 
            //    newEmployee.magaca = textBox2.Text;
            //    newEmployee.ciwanka = textBox3.Text;
            //    newEmployee.mobilka = textBox4.Text;
            //    newEmployee.mushaharka = textBox5.Text;
            //    newEmployee.nooca = comboBox1.Text;
            //    newEmployee.shaqada = comboBox2.Text;
            //    newEmployee.ciwinterta = textBox1.Text;
            //    newEmployee.Taariikhda = dateTimePicker1.Text;
            //    //kaliya halka hoose waxa kabilaabmaya koodhka sawirgalinta 

            ////    int i = 0;
            ////    SqlCommand cmd = new SqlCommand("INSERT INTO product(productname,quantity,price,productpic) VALUES('" +txtproductname.Text + "','" + txtquantity.Text +"','" + txtprice.Text + "', @productpic)",cn);
            ////    MemoryStream stream = new MemoryStream();
            ////    pb1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            ////     byte [] pic = stream.ToArray();
            ////    cmd.Parameters.AddWithValue("@productpic", pic);

            ////    if(i > 0)
            ////    {
            ////       MessageBox.Show( "success insert" + i);
            ////    }
            ////    cn.Close();
            ////}


            //    //
            //    xidhiidhiye saveEmployee = new xidhiidhiye();
            //    saveEmployee.diwaangaliemployee(newEmployee);
            //    dataGridView1.DataSource = saveEmployee.LoadData("employee");
            //    MessageBox.Show("you have registered successfully", "registered");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.CurrentRow.DataGridView.CurrentCell.ColumnIndex != 0)
            //{
            //    MessageBox.Show("Please select the ID of the employee you want to delete!", "Incorrect format");
            //    return;
            //}
            //int id = Convert.ToInt32(dataGridView1.CurrentCell.Value);
            //if (id != 0)
            //{
            //    obj1.masax(id);
            //    dataGridView1.DataSource = obj1.LoadData("[employee]");
            //    MessageBox.Show("Deleted successfuly!", "Delete employee");
            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //kkk

            //kk

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //
            //opb1.Filter = "jpg|*.jpg";
            //DialogResult res = opb1.ShowDialog();
            //if (res == DialogResult.OK)
            //{
            //    pb1.Image = Image.FromFile(opb1.FileName);


            //}

            //
        }

        private void button8_Click(object sender, EventArgs e)
        {



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow.DataGridView.CurrentCell.ColumnIndex != 0)
            {
                MessageBox.Show("Please select the ID of the employee you want to delete!", "Incorrect format");
                return;
            }
            int id = Convert.ToInt32(dataGridView1.CurrentCell.Value);
            if (id != 0)
            {
                obj1.masax(id);
                dataGridView1.DataSource = obj1.LoadData("[employee]");
                MessageBox.Show("Deleted successfuly!", "Delete employee");
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //
            if (dataGridView1.CurrentRow.DataGridView.CurrentCell.ColumnIndex != 0)
            {
                MessageBox.Show("Please select the ID of the employee you want to update!", "incorrect format");
                return;
            }
            //else
            //if (textBox6.Text == "")
            //{
            //    MessageBox.Show("please insert the name of employee", "missing name");
            //    textBox2.Focus();
            //}
            //else
            //    if (textBox7.Text == "")
            //    {
            //        MessageBox.Show("please insert the address", "Missing data", MessageBoxButtons.OKCancel);
            //        textBox3.Focus();
            //    }//
            //    else
            //        if (textBox9.Text == "")
            //        {
            //            MessageBox.Show("please insert the Telephone", "Missing data", MessageBoxButtons.OKCancel);
            //            textBox3.Focus();
            //        }
            //        //
            //        else
            //            if (textBox8.Text == "")
            //            {
            //                MessageBox.Show("pease insert the salary", "missing data");
            //                textBox8.Focus();
            //            }
            //            else
            //                if (textBox5.Text == "")
            //                {
            //                    MessageBox.Show("pease insert the salary of employee", "missing data");
            //                    textBox5.Focus();
            //                }
            //                else
            //                    if (comboBox3.Text == "")
            //                    {
            //                        MessageBox.Show("pease insert your job", "missing data");
            //                        comboBox3.Focus();
            //                    }
            //                    else
            //                        if (comboBox5.Text == "")
            //                        {
            //                            MessageBox.Show("pease insert the your gender", "missing data");
            //                            comboBox2.Focus();
            //                        }
            //                        else
            //                            if (dateTimePicker2.Text == "")
            //                            {
            //                                MessageBox.Show("pease insert the date you joined the job", "missing data");
            //                                dateTimePicker1.Focus();
            //                            }
            else
            {
                employee lastsave = new employee();
                lastsave.magaca = textBox2.Text;
                lastsave.ciwanka = textBox3.Text;
                lastsave.mobilka = textBox4.Text.ToString();
                lastsave.mushaharka = decimal.Parse(textBox5.Text).ToString("C");
                lastsave.shaqada = comboBox2.Text; ;
                lastsave.nooca = comboBox1.Text;
                lastsave.ciwinterta = comboBox8.Text;
                lastsave.dalkashaqaalaha = comboBox6.Text;
                lastsave.xaafadashaqaalaha = textBox12.Text;
                lastsave.Taariikhda = dateTimePicker1.Text;
                xidhiidhiye resaveemployee = new xidhiidhiye();
                int id = Convert.ToInt32(dataGridView1.CurrentCell.Value);
                if (id != 0)
                {
                    obj1.dibubadal(id, lastsave);
                    dataGridView1.DataSource = obj1.LoadData("employee");
                    MessageBox.Show("updated successfuly!", "update employee");
                }
            }

            //
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            //employee newEmployee = new employee();
            //// 
            //if (textBox2.Text == "")
            //{
            //    MessageBox.Show("please insert the name of employee", "missing name");
            //    textBox2.Focus();
            //}
            //else
            //    if (textBox3.Text == "")
            //    {
            //        MessageBox.Show("please insert the address", "Missing data", MessageBoxButtons.OKCancel);
            //        textBox3.Focus();
            //    }//
            //    else
            //        if (textBox4.Text == "")
            //        {
            //            MessageBox.Show("please insert the Telephone", "Missing data", MessageBoxButtons.OKCancel);
            //            textBox3.Focus();
            //        }
            //        //
            //        else
            //            if (textBox1.Text == "")
            //            {
            //                MessageBox.Show("pease insert the address", "missing data");
            //                textBox1.Focus();
            //            }
            //            else
            //                if (textBox5.Text == "")
            //                {
            //                    MessageBox.Show("pease insert the salary of employee", "missing data");
            //                    textBox5.Focus();
            //                }
            //                else
            //                    if (comboBox1.Text == "")
            //                    {
            //                        MessageBox.Show("pease insert your geder type", "missing data");
            //                        comboBox1.Focus();
            //                    }
            //                    else
            //                        if (comboBox2.Text == "")
            //                        {
            //                            MessageBox.Show("pease insert the your job", "missing data");
            //                            comboBox2.Focus();
            //                        }
            //                        else
            //                            if (dateTimePicker1.Text == "")
            //                            {
            //                                MessageBox.Show("pease insert the date you joined the job", "missing data");
            //                                dateTimePicker1.Focus();
            //                            }
            //                            else
            //                            {

            //                                newEmployee.magaca = textBox2.Text;
            //                                newEmployee.ciwanka = textBox3.Text;
            //                                newEmployee.mobilka = textBox4.Text;
            //                                newEmployee.mushaharka = textBox5.Text;
            //                                newEmployee.nooca = comboBox1.Text;
            //                                newEmployee.shaqada = comboBox2.Text;
            //                                newEmployee.ciwinterta = textBox1.Text;
            //                                newEmployee.Taariikhda = dateTimePicker1.Text;

            //                                xidhiidhiye saveEmployee = new xidhiidhiye();
            //                                saveEmployee.diwaangaliemployee(newEmployee);
            //                                dataGridView1.DataSource = saveEmployee.LoadData("employee");
            //                                MessageBox.Show("you have registered successfully", "registered");
            //                            }
            //
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employee newEmployee = new employee();
            //// 
            //if (textBox2.Text == "")
            //{
            //    MessageBox.Show("please insert the name of employee", "missing name");
            //    textBox2.Focus();
            //}
            //else
            //    if (textBox3.Text == "")
            //    {
            //        MessageBox.Show("please insert the address", "Missing data", MessageBoxButtons.OKCancel);
            //        textBox3.Focus();
            //    }//
            //    else
            //        if (textBox4.Text == "")
            //        {
            //            MessageBox.Show("please insert the Telephone", "Missing data", MessageBoxButtons.OKCancel);
            //            textBox3.Focus();
            //        }
            //        //
            //        else
            //            if (textBox1.Text == "")
            //            {
            //                MessageBox.Show("pease insert the address", "missing data");
            //                textBox1.Focus();
            //            }
            //            else
            //                if (textBox5.Text == "")
            //                {
            //                    MessageBox.Show("pease insert the salary of employee", "missing data");
            //                    textBox5.Focus();
            //                }
            //                else
            //                    if (comboBox1.Text == "")
            //                    {
            //                        MessageBox.Show("pease insert your geder type", "missing data");
            //                        comboBox1.Focus();
            //                    }
            //                    else
            //                        if (comboBox2.Text == "")
            //                        {
            //                            MessageBox.Show("pease insert the your job", "missing data");
            //                            comboBox2.Focus();
            //                        }
            //                        else
            //                            if (dateTimePicker1.Text == "")
            //                            {
            //                                MessageBox.Show("pease insert the date you joined the job", "missing data");
            //                                dateTimePicker1.Focus();
            //                            }
            //                            else
            //                            {

            //                                newEmployee.magaca = textBox2.Text;
            //                                newEmployee.ciwanka = textBox3.Text;
            //                                newEmployee.mobilka = textBox4.Text;
            //                                newEmployee.mushaharka = textBox5.Text;
            //                                newEmployee.nooca = comboBox1.Text;
            //                                newEmployee.shaqada = comboBox2.Text;
            //                                newEmployee.ciwinterta = textBox1.Text;
            //                                newEmployee.Taariikhda = dateTimePicker1.Text;

            //                                xidhiidhiye saveEmployee = new xidhiidhiye();
            //                                saveEmployee.diwaangaliemployee(newEmployee);
            //                                dataGridView1.DataSource = saveEmployee.LoadData("employee");
            //                                MessageBox.Show("you have registered successfully", "registered");
            //                            }
            //
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            if (dataGridView1.CurrentRow.DataGridView.CurrentCell.ColumnIndex != 0)
            {
                MessageBox.Show("Please select the ID of the employee you want to delete!", "Incorrect format");
                return;
            }
            int id = Convert.ToInt32(dataGridView1.CurrentCell.Value);
            if (id != 0)
            {
                obj1.masax(id);
                dataGridView1.DataSource = obj1.LoadData("[employee]");
                MessageBox.Show("Deleted successfuly!", "Delete employee");
            }
            //
        }

        private void saveToolStripButton_Click_1(object sender, EventArgs e)
        {
            //employee newEmployee = new employee();
            //// 
            //if (textBox2.Text == "")
            //{
            //    MessageBox.Show("please insert the name of employee", "missing name");
            //    textBox2.Focus();
            //}
            //else
            //    if (textBox3.Text == "")
            //    {
            //        MessageBox.Show("please insert the address", "Missing data", MessageBoxButtons.OKCancel);
            //        textBox3.Focus();
            //    }//
            //    else
            //        if (textBox4.Text == "")
            //        {
            //            MessageBox.Show("please insert the Telephone", "Missing data", MessageBoxButtons.OKCancel);
            //            textBox3.Focus();
            //        }
            //        //
            //        else
            //            if (textBox1.Text == "")
            //            {
            //                MessageBox.Show("pease insert the address", "missing data");
            //                textBox1.Focus();
            //            }
            //            else
            //                if (textBox5.Text == "")
            //                {
            //                    MessageBox.Show("pease insert the salary of employee", "missing data");
            //                    textBox5.Focus();
            //                }
            //                else
            //                    if (comboBox1.Text == "")
            //                    {
            //                        MessageBox.Show("pease insert your geder type", "missing data");
            //                        comboBox1.Focus();
            //                    }
            //                    else
            //                        if (comboBox2.Text == "")
            //                        {
            //                            MessageBox.Show("pease insert the your job", "missing data");
            //                            comboBox2.Focus();
            //                        }
            //                        else
            //                            if (dateTimePicker1.Text == "")
            //                            {
            //                                MessageBox.Show("pease insert the date you joined the job", "missing data");
            //                                dateTimePicker1.Focus();
            //                            }
            //                            else
            //                            {

            //                                newEmployee.magaca = textBox2.Text;
            //                                newEmployee.ciwanka = textBox3.Text;
            //                                newEmployee.mobilka = textBox4.Text;
            //                                newEmployee.mushaharka = textBox5.Text;
            //                                newEmployee.nooca = comboBox1.Text;
            //                                newEmployee.shaqada = comboBox2.Text;
            //                                newEmployee.ciwinterta = textBox1.Text;
            //                                newEmployee.Taariikhda = dateTimePicker1.Text;

            //                                xidhiidhiye saveEmployee = new xidhiidhiye();
            //                                saveEmployee.diwaangaliemployee(newEmployee);
            //                                dataGridView1.DataSource = saveEmployee.LoadData("employee");
            //                                MessageBox.Show("you have registered successfully", "registered");
            //                            }
            //
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            //if (dataGridView1.CurrentRow.DataGridView.CurrentCell.ColumnIndex != 0)
            //{
            //    MessageBox.Show("Please select the ID of the employee you want to update!");
            //    return;
            //}
            //employee lastsave = new employee();
            //lastsave.magaca = textBox2.Text;
            //lastsave.ciwanka = textBox3.Text;
            //lastsave.mobilka = textBox4.Text;
            //lastsave.mushaharka = textBox5.Text;
            //lastsave.shaqada = comboBox2.Text; ;
            //lastsave.nooca = comboBox1.Text;
            //lastsave.ciwinterta = textBox1.Text;
            //lastsave.Taariikhda = dateTimePicker1.Text;
            //xidhiidhiye resaveemployee = new xidhiidhiye();
            //int id = Convert.ToInt32(dataGridView1.CurrentCell.Value);
            //if (id != 0)
            //{
            //    obj1.dibubadal(id, lastsave);
            //    dataGridView1.DataSource = obj1.LoadData("employee");
            //    MessageBox.Show("updated successfuly!", "update employee");
            //}
            //
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //
            employee newEmployee = new employee();
            //// 
            //if (textBox6.Text == "")
            //{
            //    MessageBox.Show("please insert the name of employee", "missing name");
            //    textBox2.Focus();
            //}
            //else
            //    if (textBox7.Text == "")
            //    {
            //        MessageBox.Show("please insert the address", "Missing data", MessageBoxButtons.OKCancel);
            //        textBox3.Focus();
            //    }//
            //    else
            //        if (textBox9.Text == "")
            //        {
            //            MessageBox.Show("please insert the Telephone", "Missing data", MessageBoxButtons.OKCancel);
            //            textBox3.Focus();
            //        }
            //        //
            //        else
            //            if (textBox8.Text == "")
            //            {
            //                MessageBox.Show("pease insert the salary", "missing data");
            //                textBox8.Focus();
            //            }
            //            else
            //                if (textBox5.Text == "")
            //                {
            //                    MessageBox.Show("pease insert the salary of employee", "missing data");
            //                    textBox5.Focus();
            //                }
            //                else
            //                    if (comboBox3.Text == "")
            //                    {
            //                        MessageBox.Show("pease insert your job", "missing data");
            //                        comboBox3.Focus();
            //                    }
            //                    else
            //                        if (comboBox5.Text == "")
            //                        {
            //                            MessageBox.Show("pease insert the your gender", "missing data");
            //                            comboBox2.Focus();
            //                        }
            //                        else
            //                            if (dateTimePicker2.Text == "")
            //                            {
            //                                MessageBox.Show("pease insert the date you joined the job", "missing data");
            //                                dateTimePicker1.Focus();
            //                            }
            //                            else
            //                            {

            newEmployee.magaca = textBox6.Text;
            newEmployee.ciwanka = textBox7.Text;
            newEmployee.mobilka = textBox9.Text.ToString();
            newEmployee.mushaharka = decimal.Parse(textBox8.Text).ToString("C");
            newEmployee.shaqada = comboBox3.Text;
            newEmployee.nooca = comboBox5.Text;
            newEmployee.ciwinterta = comboBox7.Text;
            newEmployee.dalkashaqaalaha = comboBox4.Text;
            newEmployee.xaafadashaqaalaha = textBox11.Text;
            newEmployee.Taariikhda = dateTimePicker2.Text;

            xidhiidhiye saveEmployee = new xidhiidhiye();
            saveEmployee.diwaangaliemployee(newEmployee);
            dataGridView2.DataSource = saveEmployee.LoadData("employee");
            MessageBox.Show("you have registered successfully", "registered");
        }
    }
}

        //private void button2_Click_1(object sender, EventArgs e)
        //{
        
        //}
        //    ////
        //}

        //private void button2_Click_1(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void button3_Click_1(object sender, EventArgs e)
        //{
        //    this.Close();
        //}        
    //}

