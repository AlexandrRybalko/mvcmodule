﻿using MVCmodule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCmodule.Controllers
{
    public class CategoryController : Controller
    {
        private readonly List<CategoryModel> _categories = new List<CategoryModel> {
                new CategoryModel { Id = 1, Title = "Food" },
                new CategoryModel { Id = 2, Title = "Drinks" },
                new CategoryModel { Id = 3, Title = "Presents"} };

        // GET: Category
        public ActionResult Index()
        {
            return View(_categories);
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {          
            return View();
        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
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

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Category/Edit/5
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

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            _categories.RemoveAt(id - 1);

            return View();
        }

        // POST: Category/Delete/5
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
