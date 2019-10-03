using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Inghram_MIS_4200.DAL;
using Inghram_MIS_4200.Models;

namespace Inghram_MIS_4200.Controllers
{
    public class courseDetailsController : Controller
    {
        private Context db = new Context();

        // GET: courseDetails
        public ActionResult Index()
        {
            var courseDetails = db.courseDetails.Include(c => c.course).Include(c => c.student);
            return View(courseDetails.ToList());
        }

        // GET: courseDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            courseDetail courseDetail = db.courseDetails.Find(id);
            if (courseDetail == null)
            {
                return HttpNotFound();
            }
            return View(courseDetail);
        }

        // GET: courseDetails/Create
        public ActionResult Create()
        {
            ViewBag.courseID = new SelectList(db.course, "courseID", "courseName");
            ViewBag.studentID = new SelectList(db.student, "studentID", "firstName");
            return View();
        }

        // POST: courseDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "courseDetailID,courseDescription,courseTime,courseID,studentID")] courseDetail courseDetail)
        {
            if (ModelState.IsValid)
            {
                db.courseDetails.Add(courseDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.courseID = new SelectList(db.course, "courseID", "courseName", courseDetail.courseID);
            ViewBag.studentID = new SelectList(db.student, "studentID", "firstName", courseDetail.studentID);
            return View(courseDetail);
        }

        // GET: courseDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            courseDetail courseDetail = db.courseDetails.Find(id);
            if (courseDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.courseID = new SelectList(db.course, "courseID", "courseName", courseDetail.courseID);
            ViewBag.studentID = new SelectList(db.student, "studentID", "firstName", courseDetail.studentID);
            return View(courseDetail);
        }

        // POST: courseDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "courseDetailID,courseDescription,courseTime,courseID,studentID")] courseDetail courseDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.courseID = new SelectList(db.course, "courseID", "courseName", courseDetail.courseID);
            ViewBag.studentID = new SelectList(db.student, "studentID", "firstName", courseDetail.studentID);
            return View(courseDetail);
        }

        // GET: courseDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            courseDetail courseDetail = db.courseDetails.Find(id);
            if (courseDetail == null)
            {
                return HttpNotFound();
            }
            return View(courseDetail);
        }

        // POST: courseDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            courseDetail courseDetail = db.courseDetails.Find(id);
            db.courseDetails.Remove(courseDetail);
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
    }
}
