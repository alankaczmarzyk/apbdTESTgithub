﻿using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Album
    {
        public int IdAlbum { get; set; }
        public string AlbumName { get; set; }
        public DateTime PublishDate { get; set; }
        public int IdMusicLabel { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }
        public virtual MusicLabel MusicLabel { get; set; }
    }
}
