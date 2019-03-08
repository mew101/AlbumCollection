using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}