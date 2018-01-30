using Forest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Forest.Controllers
{
    public class MusicAdminController : Controller
    {

        private Forest.Services.IService.IMusicService _musicService;

        public MusicAdminController()
        {
            _musicService = new Forest.Services.Service.MusicService();

        }
        // GET: MusicAdminController
        public ActionResult EditMusicRecording(int id)
        {
            return View(_musicService.GetMusicRecording(id));
        }

        // GET: MusicAdminController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MusicAdminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MusicAdminController/Create
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

        // GET: MusicAdminController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MusicAdminController/Edit/5
        [HttpPost]
        public ActionResult EditMusicRecording(int id, Music_Recording recording)
        { 
            try
            {
                 _musicService.EditMusicRecording(recording);

                return RedirectToAction(GetMusicRecordings());
            }
            catch
            {
                return View();
            }
        }

        // GET: MusicAdminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MusicAdminController/Delete/5
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
