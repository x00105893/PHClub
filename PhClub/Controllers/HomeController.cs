using PhClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;


namespace PhClub.Controllers
{
    public class HomeController : Controller
    {	// создаем контекст данных
        EventsContext db = new EventsContext();
       

        public ActionResult Index()
        {

            // получаем из бд все объекты Event
            IEnumerable<Event> events = db.Events;
            // передаем все объекты в динамическое свойство Events в ViewBag
            ViewBag.Events = events;

            
            // возвращаем представление
            return View();

        }
        public ActionResult EventsMain()
        {

            // получаем из бд все объекты Event
            IEnumerable<Event> events = db.Events;
            // передаем все объекты в динамическое свойство Events в ViewBag
            ViewBag.Events = events;


            // возвращаем представление
            return View();

        }
       
        public ActionResult Event(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        [Authorize]
        public ActionResult Management()
        {

            ViewBag.Message = "Your Management page.";
            return View();
        }
   

    }
    }
