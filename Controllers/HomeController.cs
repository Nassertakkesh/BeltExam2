using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Exam2.Models;

namespace Exam2.Controllers
{
    public class HomeController : Controller
    {

        private MyContext db;
     
        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            db = context;
        }
     
        [HttpGet("")]
        public IActionResult Register()
        {
            return View("Registration");
        }

        [HttpPost("home/CreateRegister")]
        public IActionResult CreateRegister(User newUser)
        {

            if (ModelState.IsValid)
            {
                bool isEmailTaken =
                    db.Users.Any(user => newUser.Email == user.Email);

                if (isEmailTaken)
                {
                    ModelState.AddModelError("Email", "Email Taken");
                }
            }

            if (ModelState.IsValid == false)
            {
                return View("Registration");
            }
            // No Errors
            // Hash pw
            PasswordHasher<User> hasher = new PasswordHasher<User>();
            newUser.Password = hasher.HashPassword(newUser, newUser.Password);

            db.Users.Add(newUser);
            db.SaveChanges();

            HttpContext.Session.SetInt32("UserId", newUser.UserId);
            return RedirectToAction("success");
        }

        [HttpPost("home/loggingIN")]
        public IActionResult loggingIN(LoginUser loginUser)
        {
            string genericError = "Invalid Credentials";

            if (ModelState.IsValid == false)
            {
                return View("Registration");
            }
            User dbUser = db.Users.FirstOrDefault(user => loginUser.LoginEmail == user.Email);
            if (dbUser == null)
            {
                ModelState.AddModelError("LoginEmail", genericError);
                return View("Registration");
            }
            // dbUser is not null
            // Convert LoginUser to User for PasswordVerification
            User viewUser = new User
            {
                Email = loginUser.LoginEmail,
                Password = loginUser.LoginPassword
            };
            PasswordHasher<User> hasher = new PasswordHasher<User>();
            PasswordVerificationResult passwordCheck =
                hasher.VerifyHashedPassword(viewUser, dbUser.Password, viewUser.Password);
            // failed pw match
            if (passwordCheck == 0)
            {
                ModelState.AddModelError("LoginEmail", genericError);
                return View("Registration");
            }
            HttpContext.Session.SetInt32("UserId", dbUser.UserId);
            return RedirectToAction("success");
        }
        [HttpGet("home/logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Register");
        }
   
   
        [HttpGet("success")]
        public IActionResult Success()
        {

               if (HttpContext.Session.GetInt32("UserId") == null){
            return Register();
            }
            else{
            ViewBag.allTheWeddings = db.Activity
            .Include (p =>p.Creator)
            .Include (p =>p.Attendees).ToList();

            ViewBag.UID =HttpContext.Session.GetInt32("UserId");

            ViewBag.ThisUser = db.Users.FirstOrDefault(u=>u.UserId == HttpContext.Session.GetInt32("UserId"));
            // ViewBag.TheGuestList = db.Guest
            // .Include (p => p.Attendees).ToList();
    

            ViewBag.TheGuestList2 = db.Users
            .Include (p => p.Events).ToList();
            

            return View();
            }
        }
        

///////////////////////////////////////////////////

        [HttpGet("home/AddNewActivity")]
        public IActionResult AddNewActivity()
        {
                        if (HttpContext.Session.GetInt32("UserId") == null){
            return Register();
            }
            else{
            ViewBag.Uid = HttpContext.Session.GetInt32("UserId");
            return View();
            }
        }

        [HttpPost("home/AddingActivity")]
        public IActionResult AddingActivity(Models.Activity NewActivity)
        {
              if (ModelState.IsValid == false)
            {
                return View("AddNewActivity");
            }
            else
            {
            int ? Uid = HttpContext.Session.GetInt32("UserId");
             NewActivity.Creator = db.Users.FirstOrDefault(p => p.UserId == Uid);
            db.Add(NewActivity);
            db.SaveChanges();
            return RedirectToAction("ActivityDetail", new {Id = NewActivity.ActivityId});
            }
        }

        [HttpGet("home/ActivityDetail/{id}")]
        public IActionResult ActivityDetail(int id)
        {
            if (HttpContext.Session.GetInt32("UserId") == null){
            return Register();
            }
            else{
            ViewBag.ActivityDetailsPageInfo = db.Activity
            .Include(Activity =>Activity.Creator)
            .Include(wed => wed.Attendees)
            .ThenInclude(p=>p.Attendees)
            .FirstOrDefault(W =>W.ActivityId == id);

            ViewBag.thisActivity = db.Activity
            .Include(Activity =>Activity.Creator)
            .Include(a => a.Attendees)
            .FirstOrDefault(W =>W.ActivityId == id);

            ViewBag.UID =HttpContext.Session.GetInt32("UserId");

            // ViewBag.WeddingDetailsGuestList = db.Guest
            // .Include(wed => wed.Attendees)
            // .ThenInclude(p=>p.UserId)
            // .FirstOrDefault(W =>W.WeddingId == id);


            return View();
        }
        }

        [HttpGet("home/DeleteActivity/{id}")]
        public IActionResult DeleteActivity(int id)
        {
            Models.Activity thisActivity = db.Activity
            .Include(Activity =>Activity.Creator)
            .FirstOrDefault(A =>A.ActivityId == id);
            db.Remove(thisActivity);
            db.SaveChanges();
            return RedirectToAction("Success");
        }

        [HttpGet("home/Join/{id}")]
        public IActionResult Join(int id)
        {
            int ? Uid = HttpContext.Session.GetInt32("UserId");
            Player NewPlayer = new Player();
            NewPlayer.UserId = (int)Uid;
            NewPlayer.ActivityId = id;
            db.Add(NewPlayer);
            db.SaveChanges();
            return RedirectToAction("Success");
        }

        [HttpGet("home/Leave/{id}")]
        public IActionResult Leave(int id)
        {
            Player thisPlayer = db.Players
            .FirstOrDefault(P =>P.PlayerId == id);
            db.Remove(thisPlayer);
            db.SaveChanges();
            return RedirectToAction("Success");
        }
    }
}

