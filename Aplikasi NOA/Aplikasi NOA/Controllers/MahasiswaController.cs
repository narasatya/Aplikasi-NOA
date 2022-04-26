using Aplikasi_NOA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aplikasi_NOA.Controllers
{
    [Authorize]
    public class MahasiswaController : Controller
    {
        // GET: Mahasiswa
        public ActionResult Index()
        {
            //Mengambil Data Dari Tabel Mahasiswa
            List<Mahasiswa> r;
            using (var s = new MahasiswaDBEntities())
            {
                r = s.Mahasiswa.ToList();
            }
            return View(r);
        }


        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post()
        {
            var model = new Mahasiswa();
            TryUpdateModel(model);
            using (var s = new MahasiswaDBEntities())
            {
                s.Mahasiswa.Add(model);
                s.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult index()
        {
            List<Mahasiswa> r;
            using (var s = new MahasiswaDBEntities())
            {
                r = s.Mahasiswa.ToList();
            }
            return View(r);
        }

        [HttpGet]
        [ActionName("Edit")]
        public ActionResult Edit_Get(string nim)
        {
            var model = new Mahasiswa();
            TryUpdateModel(model);
            using (var s = new MahasiswaDBEntities())
            {
                model = s.Mahasiswa.Where(x => x.NIM == nim).FirstOrDefault();
            }
            return View(model);
        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post(string nim)
        {
            var model = new Mahasiswa();
            TryUpdateModel(model);
            using (var s = new MahasiswaDBEntities())
            {
                var m = s.Mahasiswa.Where(x => x.NIM == nim).FirstOrDefault();
                TryUpdateModel(m);
                s.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(string nim)
        {
            var model = new Mahasiswa();
            TryUpdateModel(model);
            using (var s = new MahasiswaDBEntities())
            {
                model = s.Mahasiswa.FirstOrDefault(x => x.NIM == nim);
            }
            return View(model);
        }

        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Delete_Post(string nim)
        {
            var model = new Mahasiswa();
            TryUpdateModel(model);
            using (var s = new MahasiswaDBEntities())
            {
                var m = s.Mahasiswa.FirstOrDefault(x => x.NIM == nim);
                TryUpdateModel(m);
                s.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details1(string nim)
        {
            var model = new Mahasiswa();
            TryUpdateModel(model);
            using (var s = new MahasiswaDBEntities())
            {
                model = s.Mahasiswa.FirstOrDefault(x => x.NIM == nim);
            }
            return View(model);
        }

        [HttpGet]
        [ActionName("Delete")]
        public ActionResult Delete_Get(string nim)
        {
            var model = new Mahasiswa();
            TryUpdateModel(model);
            using (var s = new MahasiswaDBEntities())
            {
                model = s.Mahasiswa.FirstOrDefault(x => x.NIM == nim);
            }
            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult Delete_Post2(string nim)
        {
            var model = new Mahasiswa();
            TryUpdateModel(model);
            using (var s = new MahasiswaDBEntities())
            {
                var m = s.Mahasiswa.Remove(s.Mahasiswa.FirstOrDefault(x => x.NIM == nim));
                TryUpdateModel(m);
                s.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}