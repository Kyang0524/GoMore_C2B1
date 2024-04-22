using GoMore_C2B1.DataContext;
using GoMore_C2B1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoMore_C2B1.Controllers
{
    public class ScheduleController : Controller
    {
        private ApplicationDbContext LinkFile_ = new ApplicationDbContext();
        // GET: Schedule
        public ActionResult Info()
        {
            return View();
        }
        public ActionResult Display()
        {   
            return View();
        }
        public ActionResult LinkFile()
        {
            List<ModelNameDB> modelNameDBs = LinkFile_.ModelNames.ToList();
            ViewBag.models = modelNameDBs;
            return View();
        }
        [HttpPost]
        public ActionResult LinkFile(HttpPostedFileBase UnitFile,string Tag,string MainModel)
        {
            LinkFileModel dB = new LinkFileModel();
            Random generator = new Random();
            string ID = generator.Next(0, 1000000).ToString("D6");
            string Url = MainModel + "/" + UnitFile.FileName;
            string UnitFileName = UnitFile.FileName.Split('.')[0];
            string FileType = UnitFile.FileName.Split('.')[1];

            dB.ID = ID;
            dB.Url = Url;
            dB.UnitFileName = UnitFileName;
            dB.Tag = Tag;
            dB.MainModel = MainModel;
            dB.FileType = FileType;
            LinkFile_.LinkFiles.Add(dB);
            LinkFile_.SaveChanges();

            return RedirectToAction("LinkFile","Schedule");
        }
        public ActionResult Search()
        {
            return View();
        }
        public ActionResult Status()
        {
            return View();
        }
    }
}