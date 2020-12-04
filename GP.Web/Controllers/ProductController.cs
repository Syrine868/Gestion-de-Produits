using GP.Domain;
using GP.Service.TP2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GP.Web.Controllers
{
    public class ProductController : Controller
    {
        ProductService ps = new ProductService();
        CategoryService categoryService = new CategoryService();
        // GET: Product
        public ActionResult Index()
        {
         var  products= ps.GetMany();
            return View(products);
        }
        [HttpPost]
        public ActionResult Index(String critère)
        {

            var list = ps.GetMany();
            if (!String.IsNullOrEmpty(critère))
            {
                list = list.Where(p => p.Name.ToString().Equals(critère)).ToList();
            }
            return View(list);
        }
    
        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View(ps.GetById(id));
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            var categories = categoryService.GetMany();
            ViewBag.CategoryId = new SelectList(categories, "categoryId", "Name");
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product p ,HttpPostedFileBase file)
        {
            p.Image = file.FileName;
            if (file.ContentLength > 0)
            {
                var path = Path.Combine(Server.MapPath("~/Content/Upload/"),
                file.FileName);
                file.SaveAs(path);
            }
            try
            {
                // TODO: Add insert logic here
                ps.Add(p);
                ps.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            
            var categories = categoryService.GetMany();
            ViewBag.CategoryId = new SelectList(categories, "categoryId", "Name");
            return View(ps.GetById(id));
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id,Product p, HttpPostedFileBase file)
        {
            p.Image = file.FileName;
            if (file.ContentLength > 0)
            {
                var path = Path.Combine(Server.MapPath("~/Content/Upload/"),
                file.FileName);
                file.SaveAs(path);
            }
            try
            {
                // TODO: Add update logic here
                if (!ModelState.IsValid)
                    p =ps.GetById(id);
                ps.Update(p);
               
                ps.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            
            return View(ps.GetById(id));
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Product p)
        {
            try
            {
                // TODO: Add delete logic here
                p= ps.GetById(id);
                ps.Delete(p);
                ps.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
