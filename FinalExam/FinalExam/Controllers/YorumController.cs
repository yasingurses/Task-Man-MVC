using BusinessLayer.Repository;
using DataAccesLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace FinalExam.Controllers
{
    public class YorumController : Controller
    {
        YorumMan ym = new YorumMan(new YorumRepo());
        private readonly IToastNotification _toastNotification;

        public YorumController(IToastNotification toastNotification)
        {
            _toastNotification = toastNotification;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Ekle(int gorevId)
        {
            ViewBag.gorevid = gorevId;
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Yorum yorum)
        {
            ym.Adding(yorum);
            return View();
        }
        public IActionResult Yorumlar(int gorevId)
        {
            ViewBag.gorevid = gorevId;
            var result = ym.GetByGorevId(gorevId);
            return View(result);
        }
    }
}
