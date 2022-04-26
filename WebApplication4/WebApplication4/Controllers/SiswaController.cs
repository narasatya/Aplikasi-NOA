using WebApplication4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    [Authorize]
    public class SiswaController : Controller
    {
        // GET: Siswa
        public ActionResult Index()
        {
            List<Siswa> r;
            using (var s = new Model1())
            {
                r = s.Siswa.ToList();
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
            var model = new Siswa();
            TryUpdateModel<model>;
            using (var s = new Model1())
            {
                s.Siswa.Add(model);
                s.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}