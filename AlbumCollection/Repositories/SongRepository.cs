using AlbumCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Repositories
{
    public class SongRepository : ISongRepository
    {
        AlbumContext db;

        public SongRepository(AlbumContext db)
        {
            this.db = db;
        }

        public Song GetById(int Id)
        {
            return db.Songs.Single(Song => Song.SongId == Id);
        }

        public IEnumerable<Song> GetAll()
        {
            return db.Songs.ToList();
        }

        public void Create(Song song)
        {

            db.Songs.Add(song);
            db.SaveChanges();
        }

       
    }
}
