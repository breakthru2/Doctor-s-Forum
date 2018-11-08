using Doctor_Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Doctor_Forum.Controllers
{
    public class ChatController : Controller
    {
        // GET: Chat
        private ApplicationDbContext _context;
        public ChatController()
        {
            _context = new ApplicationDbContext();
        }        
        public ActionResult Index()
        {
            var users = _context.Users.ToList();
            return View(users);
        }
    }
}