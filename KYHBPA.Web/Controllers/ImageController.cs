using KYHBPA.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KYHBPA.Entities;
using KYHBPA.Web.Models;
using KYHBPA.Web.Views.Image;

namespace KYHBPA.Web.Controllers
{
    public class ImageController : Controller
    {
        IGenericRepository<Image> _imageRepo;

        public ImageController(IGenericRepository<Image> imageRepo)
        {
            _imageRepo = imageRepo;
        }

        // GET: Image
        public ActionResult Index()
        {
            var images = _imageRepo.GetAllAsync();
            List<IndexImageViewModel> vmList = new List<IndexImageViewModel>();

            foreach(var image in images)
            {
                vmList.Add(new IndexImageViewModel() {
                    Title = image.Title,
                    Description = image.Description,
                    InImageGallery = image.InImageGallery,
                    Type = image.Type
                });
            }
            return View(vmList);
        }

        // GET: Image/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Image/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Image/Create
        [HttpPost]
        public ActionResult Create(CreateImageViewModel createImageViewModel, HttpPostedFileBase image)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var imageToAdd = new KYHBPA.Entities.Image()
                    {
                        Title = createImageViewModel.Title,
                        Description = createImageViewModel.Description,
                        Content = new byte[image.ContentLength],
                        CreatedBy = Session.SessionID,
                        InImageGallery = false,
                        CreatedOn = DateTime.Now.ToShortDateString(),
                        Type = image.ContentType,
                    };

                    image.InputStream.Read(imageToAdd.Content, 0, image.ContentLength);

                    _imageRepo.AddAsync(imageToAdd);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Image/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Image/Edit/5
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

        // GET: Image/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Image/Delete/5
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

        public FileContentResult GetImage(int imageID)
        {
            var imageToGet = _imageRepo.GetAllAsync()
                .FirstOrDefault(x => x.Id == imageID);

            if (imageToGet != null)
                return File(imageToGet.Content, imageToGet.Type);
            else
                return null;
        }
    }
}
