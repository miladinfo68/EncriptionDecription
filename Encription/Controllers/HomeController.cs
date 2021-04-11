using Encription.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Encription.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var h= "EsSWxhhkcqfIvh4n1K83DOQynZmnoH3XvZo1APFl6/w=";
            var user = "admin";
            var hash = EncryptionClass.EncryptPass(user);
            var decrypt = EncryptionClass.DecryptPass(h);

            //JOPsUBHAck9T8bb96DGtLg ==
            byte[] base64HashesPassword = Convert.FromBase64String(h);
            string pass = EncryptionClass.DecryptRJ256(base64HashesPassword);

            var decrypt256 = EncryptionClass.EncryptRJ(h);      
            //DecryptRJ256
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


        //public  string EncryptPass(String PasswordPlainText)
        //{
        //    string plainText = PasswordPlainText.Trim();
        //    string cipherText = "";                 // encrypted text
        //    string passPhrase = "Pas5pr@se";        // can be any string
        //    string initVector = "@1B2c3D4e5F6g7H8"; // must be 16 bytes
        //    EncryptionClass ThisKey = new EncryptionClass(passPhrase, initVector);
        //    cipherText = ThisKey.Encrypt(plainText);
        //    return cipherText;

        //}
        //public  string DecryptPass(String CipherText)
        //{
        //    string plainText = "";
        //    string cipherText = CipherText;                 // encrypted text
        //    string passPhrase = "Pas5pr@se";        // can be any string
        //    string initVector = "@1B2c3D4e5F6g7H8"; // must be 16 bytes

        //    EncryptionClass ThisKey =   new EncryptionClass(passPhrase, initVector);
        //    plainText = ThisKey.Decrypt(cipherText);

        //    return plainText;

        //}
    }
}