using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forest.Data;
using Forest.Data.IDAO;
using Forest.Data.DAO;

namespace Forest.Services.Service
{
    public class MusicService : Forest.Services.IService.IMusicService
    {
        private IMusicDAO _musicDAO;
        public MusicService()
        {
            _musicDAO = new MusicDAO();


        }
        public IList<Forest.Data.Music_Catergory> GetMusicCategories()
        {
            return _musicDAO.GetMusicCategories();
        }
        public IList<Forest.Data.Music_Recording> GetMusicRecordings(string gen)
        {
            return _musicDAO.GetMusicRecordings(gen);
        }
        public Forest.Data.Music_Recording GetMusicRecording(int id)
        {
            return _musicDAO.GetMusicRecording(id);
        }
        public void EditMusicRecording(Music_Recording recording)
        {
            _musicDAO.EditMusicRecording(recording);
        }

    }
}

