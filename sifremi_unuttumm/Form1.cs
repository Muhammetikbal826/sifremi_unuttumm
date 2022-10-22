using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using System.Net.Mail;

namespace sifremi_unuttumm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlbaglantisi bgln = new sqlbaglantisi();
            SqlCommand komut = new SqlCommand("Select * From Bilgi3 Where kullanici_adi='" + textBox1.Text.ToString() +
                "' and eposta='" + textBox2.Text.ToString() + "'", bgln.baglanti());

            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                try
                {
                    if (bgln.baglanti().State == ConnectionState.Closed)
                    {
                        bgln.baglanti().Open();
                    }
                    SmtpClient smtpserver = new SmtpClient();
                    MailMessage mail = new MailMessage();
                    String tarih = DateTime.Now.ToLongDateString();
                    String mailadresin = ("muhammetikbal827@gmail.com");
                    String sifre = (" rjtaejqyedumuwyi");
                    String smptservr = "smpt.gmail.com";
                    String kime = (oku["eposta"].ToString());
                    String konu = ("şifre hatırlatma maili");
                    String yaz = ("Sayın," + oku["ad_soyad"].ToString() + "\n" + "Bizden" + tarih + "tarihinde şifre hatırlatma talebinde bulundunuz" + "\n" +
                        "parolanızı:" + oku["şifre"].ToString() + "\n iyi günler");
                    smtpserver.Credentials = new NetworkCredential(mailadresin, sifre);
                    smtpserver.Port = 587;
                    smtpserver.Host = smptservr;
                    smtpserver.EnableSsl = true;
                    mail.From = new MailAddress(mailadresin);
                    mail.To.Add(kime);
                    mail.Subject = konu;
                    mail.Body = yaz;
                    smtpserver.Send(mail);
                    DialogResult bilgi = new DialogResult();
                    bilgi = MessageBox.Show("girmiş olduğunuz bilgiler uyuşuyor. şifreniz mail adresinize gönderilmiştir");
                    this.Hide();
                }
                catch(Exception Hata)
                {
                    MessageBox.Show("mail gönderme hatası", Hata.Message);
                }

              }}

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

        
        

        }
    



           
    

