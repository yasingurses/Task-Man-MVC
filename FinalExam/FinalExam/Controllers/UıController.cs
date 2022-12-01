using BusinessLayer.Repository;
using DataAccesLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace FinalExam.Controllers
{
    public class UıController : Controller
    {
        YorumMan ym = new YorumMan(new YorumRepo());
        GorevMan gm = new GorevMan(new GorevRepo());
        public IActionResult Index()
        {
            var result = gm.Listing();
            return View(result);
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
        public IActionResult Olusturulan()
        {
            var result = gm.Listing();
            return View(result);
        }
        public IActionResult Devam()
        {
            var result = gm.Listing();
            return View(result);
        }
        public IActionResult Bitmis()
        {
            var result = gm.Listing();
            return View(result);
        }
    }
}
