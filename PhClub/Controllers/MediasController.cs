using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PhClub.Models;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace PhClub.Controllers
{
    public class MediasController : Controller
    {
        private EventsContext db = new EventsContext();
        

        // GET: /Medias/
        public ActionResult Index()
        {

            return View(db.Medias.ToList());
        }

        // GET: /Medias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Media media = db.Medias.Find(id);
            if (media == null)
            {
                return HttpNotFound();
            }
            return View(media);
        }

        // GET: /Medias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Medias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,title,description,body,VideoLink, Source,tags, TagsEnum, NewsDate")] Media media, HttpPostedFileBase file, int id = 0)
        {

            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    file.SaveAs(HttpContext.Server.MapPath("~/Images/")
                                                          + file.FileName);
                    media.ImagePath = file.FileName;
                    
                }
                media.NewsDate = DateTime.Now;
                db.Medias.Add(media);
                db.SaveChanges();
                return RedirectToAction("Index");
            }


            return View(media);
        }

        // GET: /Medias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Media media = db.Medias.Find(id);
            if (media == null)
            {
                return HttpNotFound();
            }
            return View(media);
        }

        // POST: /Medias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,title,description,body,VideoLink, Source,tags,TagsEnum")] Media media)
        {
            if (ModelState.IsValid)
            {
                db.Entry(media).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(media);
        }

        // GET: /Medias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Media media = db.Medias.Find(id);
            if (media == null)
            {
                return HttpNotFound();
            }
            return View(media);
        }

        // POST: /Medias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Media media = db.Medias.Find(id);
            db.Medias.Remove(media);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Media(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Media @media = db.Medias.Find(id);
            if (@media == null)
            {
                return HttpNotFound();
            }
            return View(@media);
        }
        public ActionResult Video(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Video @video = db.Videos.Find(id);
            if (@video == null)
            {
                return HttpNotFound();
            }
            return View(@video);
        }
        public ActionResult SearchMedia(string searchString)
        {
            var result = db.Medias.ToList().Where(i => i.TagsEnum.ToString() == searchString);
            return View(result);
        }
        

        public ActionResult MediaMain()
        {           
            var model = new MediaViewModel();
           model.media = db.Medias.Take(10).ToList();
           return View(model.media.OrderByDescending(media => media.NewsDate));

        }

    }
}
