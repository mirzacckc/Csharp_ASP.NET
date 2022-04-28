using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace ders_16032022
{
    public class MailGonder
    {
        public bool Gonder(string konu, string icerik, string toeposta)
        {
            string epostam = "eposta@gmail.com";
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress(epostam);
           
            ePosta.To.Add(toeposta);
            
            //ePosta.Attachments.Add(new Attachment(@"C:\deneme-upload.jpg"));
            
            ePosta.Subject = konu;
            
            ePosta.Body = icerik;
           
            SmtpClient smtp = new SmtpClient();
            
            smtp.Credentials = new System.Net.NetworkCredential(epostam, "sifre");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            object userState = ePosta;
            bool kontrol = true;
            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                //System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }
            return kontrol;
        }
    }
}