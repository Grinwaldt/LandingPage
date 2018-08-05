using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.Net;


namespace Data_Pro_Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult sendEmail(string name,string phone,string email,string city )
        {

            //string smtpAddress = "smtp.gmail.com";
            //int portNumber = 465;
            //bool enableSSL = true;

            //string emailFrom = "http://localhost:3456/";
            //string password = "";
            //string emailTo = "danielr@datapro.com";
            //string subject = "Hello from Gmail";
            //string body = name+""+phone+""+email+""+city;

            //using (MailMessage mail = new MailMessage())
            //{
            //    mail.From = new MailAddress(emailFrom);
            //    mail.To.Add(emailTo);
            //    mail.Subject = subject;
            //    mail.Body = body;
            //    mail.IsBodyHtml = true;

            //    using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
            //    {
            //        smtp.Credentials = new NetworkCredential(emailFrom, password);
            //        smtp.EnableSsl = enableSSL;
            //        smtp.Send(mail);
            //    }
            // }
            MailMessage mail = new MailMessage();
            mail.Subject = "Your Subject";
            mail.From = new MailAddress("100tzipora@gmail.com");
            mail.To.Add("100tzipora@gmail.com");
            mail.Body = "Hello! your mail content goes here...";
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            //NetworkCredential netCre = new NetworkCredential("SenderMailAddress", "SenderPassword");
            //smtp.Credentials = netCre;

            try
            {
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                // Handle exception here 

            }
            return Json(name);
        }
    }
}