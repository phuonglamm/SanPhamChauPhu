using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SanPhamChauPhu.Controllers
{
    public class CommodityController : Controller
    {
        // GET: CommodityController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CommodityController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CommodityController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CommodityController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CommodityController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CommodityController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CommodityController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CommodityController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
