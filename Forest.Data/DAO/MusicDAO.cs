using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forest.Data.IDAO;

namespace Forest.Data.DAO
{
    public class MusicDAO : IMusicDAO
    {
        private b7034288Entities _context;
        public MusicDAO()
        {
            _context = new b7034288Entities();
        }
        public IList<Forest.Data.Music_Catergory> GetMusicCategories()
        {
            IQueryable<Music_Catergory> _categories;
            _categories = from category
                 in _context.Music_Catergory
                          select category;

            return _categories.ToList<Music_Catergory>();

        }
        public IList<Forest.Data.Music_Recording> GetMusicRecordings(string Gen)
        {
            IQueryable<Music_Recording> _recordings;
            _recordings = from genre
                 in _context.Music_Recording
                          where genre.Genre == Gen
                          select genre;

            return _recordings.ToList<Music_Recording>();

        }
        public Forest.Data.Music_Recording GetMusicRecording(int id)
        {
            IQueryable<Music_Recording> _recording;
            _recording = from Identity
                 in _context.Music_Recording
                         where Identity.Id == id
                         select Identity;

            return _recording.ToList<Music_Recording>().First();

        }
        public void EditMusicRecording(Music_Recording recording)
        {

            Music_Recording record = GetMusicRecording(recording.Id);
            record.Artist = recording.Artist;
            record.Genre = recording.Genre;
            record.Image_Name = recording.Image_Name;
            record.Num_Tracks = recording.Num_Tracks;
            record.Price = recording.Price;
            record.Released = recording.Released;
            record.Stock_count = recording.Stock_count;
            record.Title = recording.Title;
            _context.SaveChanges();
        }


        


    }
}
