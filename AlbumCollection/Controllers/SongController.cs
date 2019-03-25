using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumCollection.Models;
using AlbumCollection.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AlbumCollection.Controllers
{
    public class SongController : Controller
    {
        ISongRepository songRepo;

        public SongController(ISongRepository songRepo)
        {
            this.songRepo = songRepo;

        }
        public ViewResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Create(int id)
        {
            var song = new Song()
            {
                AlbumId = id
            };
            return View(song);
        }

        [HttpPost]
        public ActionResult Create(Song song)
        {
            songRepo.Create(song);
            return RedirectToAction("../Album/Details/" + song.AlbumId, "Album");
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            var model = songRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Song song)
        {

            songRepo.Delete(song);
            //return RedirectToAction("Index", "Album", new { id = song.AlbumId });
            //return RedirectToAction("../Album/Details" );
            return RedirectToAction("Details/" + song.AlbumId, "Album");


        }

    }
}