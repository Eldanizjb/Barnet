using Barnet.Data;
using Barnet.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Barnet.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class ServicesController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnviroment;

        public ServicesController(AppDbContext context, IWebHostEnvironment webHostEnviroment)
        {
            _context = context;
            _webHostEnviroment = webHostEnviroment;
        }
        public IActionResult Index()
        {
            return View(_context.Service.Include(s => s.ServicesCategory).ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Category = _context.ServicesCategories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Services model)
        {

            if (ModelState.IsValid)
            {
                if (model.PageFile == null)
                {
                    _context.Service.Add(model);
                    _context.SaveChanges();
                    return RedirectToAction("index");
                }
                else
                {
                    if (model.PageFile.ContentType == "image/jpeg" || model.PageFile.ContentType == "image/png")
                    {
                        if (model.PageFile.Length <= 3000000)
                        {
                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + model.PageFile.FileName;
                            string FilePath = Path.Combine(_webHostEnviroment.WebRootPath, "Uploads", ImageName);

                            using (var stream = new FileStream(FilePath, FileMode.Create))
                            {
                                model.PageFile.CopyTo(stream);
                            }

                            model.Page = ImageName;
                            model.CreateDate = DateTime.Now;


                            _context.Service.Add(model);
                            _context.SaveChanges();
                            //return RedirectToAction("index");
                        }
                        else
                        {
                            ModelState.AddModelError("", "File should be less than 3 mb");
                            ViewBag.Category = _context.ServicesCategories.ToList();
                            return View(model);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Wrong file type");
                        ViewBag.Category = _context.ServicesCategories.ToList();
                        return View(model);
                    }
                }
            }
            else
            {
            }

            ModelState.AddModelError("", "Creating record failed. Please fill in the blanks correctly");
            ViewBag.Category = _context.ServicesCategories.ToList();
            return View(model);
        }

        //public IActionResult Details(int? Id)
        //{

        //    if (ModelState.IsValid)
        //    {
        //        Services model = _context.Service.Include(s => s.ServicesCategory).ToList().Find(T => T.Id == Id);
        //        return View(model);
        //    }
        //    ModelState.AddModelError("", "Dont Hack!");
        //    return RedirectToAction("Index");


        //}

        public IActionResult Update(int? Id)
        {
            if (Id == null)
            {
                TempData["NullUpId"] = "Dont try to hack";
                return RedirectToAction("Index");
            }
            Services model = _context.Service.Include(s => s.ServicesCategory).ToList().Find(T => T.Id == Id);
            if (model == null)
            {
                TempData["NullUpTeac"] = "Dont try to hack";
                return RedirectToAction("Index");
            }
            ViewBag.Category = _context.ServicesCategories.ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Services model)
        {

            if (ModelState.IsValid)
            {
                if (model.PageFile == null)
                {
                    _context.Service.Update(model);

                    _context.SaveChanges();
                    return RedirectToAction("index");
                }
                else
                {
                    if (model.PageFile.ContentType == "image/jpeg" || model.PageFile.ContentType == "image/png")
                    {
                        if (model.PageFile.Length < 3000000)
                        {

                            // Delete old image
                            if (!string.IsNullOrEmpty(model.Page))
                            {
                                string oldPagePath = Path.Combine(_webHostEnviroment.WebRootPath, "img", "services", model.Page);
                                if (System.IO.File.Exists(oldPagePath))
                                {
                                    System.IO.File.Delete(oldPagePath);
                                }
                            }


                            //Create new image
                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("DDMMMMYYYY") + "-" + model.PageFile.FileName;
                            string FilePath = Path.Combine(_webHostEnviroment.WebRootPath, "img", "services", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                model.PageFile.CopyTo(Stream);
                            }

                            model.Page = ImageName;
                            _context.Service.Update(model);
                            _context.SaveChanges();
                            return RedirectToAction("index");
                        }
                        else
                        {
                            ModelState.AddModelError("", "File should be less than 3 mb");
                            ViewBag.Category = _context.ServicesCategories.ToList();
                            return View(model);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Wrong file type");
                        ViewBag.Category = _context.ServicesCategories.ToList();
                        return View(model);

                    }
                }


            }
            else
            {

            }

            ModelState.AddModelError("", "Creating record failed. Please fill in the blanks correctly");
            return View(model);
        }

        public IActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                TempData["NullDelId"] = "NullErrorId";
                return RedirectToAction("Index");
            }
            Services services = _context.Service.Find(Id);
            if (services == null)
            {
                TempData["NullDelTeac"] = "NullErrorId";
                return RedirectToAction("Index");
            }
            _context.Service.Remove(services);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
