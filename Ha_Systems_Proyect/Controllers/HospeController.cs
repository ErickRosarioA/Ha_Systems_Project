﻿using System.Web.Mvc;

namespace Ha_Systems_Proyect.Controllers
{
    public class HospeController : Controller
    {
        // GET: Hospe
        public ActionResult Hospedaje()
        {

            var userCredential = Session["Data_User"];
            ViewBag.Credential = userCredential;
            if (userCredential == null)
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}