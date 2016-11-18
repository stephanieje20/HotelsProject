using System;
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
<<<<<<< HEAD
=======
        // GET: Posts/Create
        public ActionResult CreatePost(int? hotelId)
        {
            ViewBag.HotelID = new SelectList(db.Hotels, "ID", "Name", hotelId);
            ViewBag.UserID = new SelectList(db.Users, "ID", "FirstName");
            return View();
        }

        // POST: Posts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePost([Bind(Include = "ID,Title,DateUpload,Contents,Photo,Video,HotelID,UserID")] Post post)
        {
            post.DateUpload = DateTime.Now;
            if (ModelState.IsValid)
            {
                db.Posts.Add(post);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.HotelID = new SelectList(db.Hotels, "ID", "Name", post.HotelID);
            return View(post);
        }
>>>>>>> 159ef6201e9371ba71f3adad1b319fb522fe5e43
    }
}