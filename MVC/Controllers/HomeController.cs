﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC.DAL;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private HotelsContext db = new HotelsContext();

        // GET: Posts
        public ActionResult Index()
        {
            return View(db.Hotels.ToList());
        }
        public ActionResult Management()
        {
            return View(db.Posts.ToList());
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult TooBad()
        {
            return View();
        }
        // GET: Hotels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hotel hotel = db.Hotels.Find(id);
            if (hotel == null)
            {
                return HttpNotFound();
            }
            return View(hotel);
        }
    }
}