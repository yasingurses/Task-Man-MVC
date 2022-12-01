using BusinessLayer.Repository;
using BusinessLayer.Valudation;
using DataAccesLayer.Concrete;
using DataAccesLayer.Repositories;
using EntityLayer.Concrete;
using EntityLayer.Enums;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using System.Data;
using System.Linq;

namespace FinalExam.Controllers
{
    public class GorevController : Controller
    {
        GorevMan gm = new GorevMan(new GorevRepo());
        private readonly IToastNotification _toastNotification;

        public GorevController(IToastNotification toastNotification)
        {
            _toastNotification = toastNotification;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Gorev()
        {
            var values = gm.Listing();
            return View(values);
        }
        public IActionResult Ekle()
        {
            return View();

        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Ekle(Gorevler gorev)
        {
            gm.Adding(gorev);
            return RedirectToAction("Gorev", "Gorev");
        }
        [HttpGet]
        public IActionResult Sil(int id)
        {
            using (Context c = new Context())
            {
                var result = c.Gorevlers.FirstOrDefault(o => o.GorevID == id);
                if (result.GorevDurumu!=Status.Oluştruldu.ToString())
                {
                    _toastNotification.AddErrorToastMessage("Sadece oluşturuldu durumuna sahşp görevler silinebilir");
                    return RedirectToAction("Gorev");
                }
                c.Gorevlers.Remove(result);
                c.SaveChanges();
            }

            return RedirectToAction("Gorev");

        }

        [HttpGet]
        public IActionResult Guncelle(int id)
        {
            using (Context c = new Context())
            {
                var result = c.Gorevlers.FirstOrDefault(o => o.GorevID == id);
                return View(result);
            }
        }

        [HttpPost]
        public IActionResult Guncelle(Gorevler gorev)
        {

            var result = gm.Updating(gorev);
            return RedirectToAction("Gorev", "Gorev");


        }
    }
}
