﻿using Forest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest.Services.IService
{
    public interface IMusicService
    {
        IList<Forest.Data.Music_Catergory> GetMusicCategories();
        IList<Forest.Data.Music_Recording> GetMusicRecordings(string gen);
        Forest.Data.Music_Recording GetMusicRecording(int id);
        void EditMusicRecording(Music_Recording recording);

    }
}
