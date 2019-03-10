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
                SongId = id
            };
            return View(song);
        }

        [HttpPost]
        public ActionResult Create(Song song)
        {
            songRepo.Create(song);
            return RedirectToAction("../Song/Details/" + song.SongId);
        }
    }
}