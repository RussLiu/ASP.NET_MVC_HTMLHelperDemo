﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTMLHelperDemo.Models;

namespace HTMLHelperDemo.Controllers
{
    public class HelperController : Controller
    {
        // GET: Helper
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string id, string password)
        {
            ViewBag.id = id;
            ViewBag.password = password;
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Member member)
        {
            return View(member);
        }
    }
}