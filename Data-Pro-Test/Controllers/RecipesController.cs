using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.Net;

namespace Data_Pro_Test.Controllers
{
    public class RecipesController : Controller
    {
        // GET: Recipes
        public ActionResult Index()
        {
            return View();
        }

        // GET: Recipes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Recipes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Recipes/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Recipes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Recipes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Recipes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Recipes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult sendEmail(string name, string phone, string email, string city)
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
