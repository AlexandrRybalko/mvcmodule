using MVCmodule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCmodule.Controllers
{
    public class GoodsController : Controller
    {
        private readonly List<GoodsModel> _goods = new List<GoodsModel> { 
            new GoodsModel { Id = 1, Title = "Bread", CategoryId = 1, Price = 12, DeliveryDate = DateTime.Now},
            new GoodsModel { Id = 2, Title = "Butter", CategoryId = 1, Price = 20, DeliveryDate = DateTime.Now},
            new GoodsModel { Id = 3, Title = "Water", CategoryId = 2, Price = 18, DeliveryDate = DateTime.Now},
            new GoodsModel { Id = 4, Title = "Juice", CategoryId = 2, Price = 25, DeliveryDate = DateTime.Now}
        }; 

        // GET: Goods
        public ActionResult Index()
        {
            return View(_goods);
        }

        public ActionResult GoodsByCategoryId(int? categoryId)
        {
            var goods = _goods.Where(x => x.CategoryId == categoryId);
            return View("/Views/Goods/Index.cshtml", goods);
        }

        // GET: Goods/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Goods/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Goods/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Goods/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Goods/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Goods/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Goods/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
