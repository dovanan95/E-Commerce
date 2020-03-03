using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.DAO;
using Model.EF;

namespace OnlineShop.Areas.Admin.Controllers
{
    public class ContentController : BaseController
    {
        // GET: Admin/Content
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            SetViewBag();
            return View();
        }
        [HttpGet]
        public ActionResult Edit(long ID)
        {
            var DAO = new ContentDAO();
            var content = DAO.GetById(ID);
            SetViewBag(content.CategoryID);
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Content model)
        {
            if(ModelState.IsValid)
            {

            }
            SetViewBag(model.CategoryID);
            return View();
        }
        [HttpPost]
        public ActionResult Create(Content model)
        {
            if(!ModelState.IsValid)
            {

            }
            SetViewBag(model.CategoryID);
            return View();
        }
        public void SetViewBag(long? SelectedId = null)
        {
            var DAO = new CategoryDAO();
            ViewBag.CategoryID = new SelectList(DAO.ListAll(), "ID", "Name", SelectedId);
        }
    }
}