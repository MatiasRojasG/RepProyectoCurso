using System;
namespace ProyectodeCurso
{
    public class Songs
    {
        //Atributos
        private string name;
        private string album;
        private string songgenre;
        private string singer;
        private string composer;
        private float rankings;
        private string yearpublishs;
        private string lyrics;
        private int likes;
        private int reproductionss;
        private string typefiles;
        private string audioquality;
        private string albumimage;
        private string durations;
        private string songsize;
        private int downloads;
        private bool candownload; //true==Sí / false==No


        //Constructor
        public Songs(string Name, string Album, string SongGenre, string Singer, string Composer, float RankingS, string YearPublishS, string Lyrics, int Likes,
            int ReproductionsS, string TypeFile, string AudioQuality, string AlbumImage, string DurationS, string SongSize, int Downloads, bool CanDownload)
        {
            this.name = Name;
            this.album = Album;
            this.songgenre = SongGenre;
            this.singer = Singer;
            this.composer = Composer;
            this.rankings = RankingS;
            this.yearpublishs = YearPublishS;
            this.lyrics = Lyrics;
            this.likes = Likes;
            this.reproductionss = ReproductionsS;
            this.typefiles1 = TypeFile;
            this.audioquality = AudioQuality;
            this.albumimage = AlbumImage;
            this.durations = DurationS;
            this.songsize = SongSize;
            this.downloads = Downloads;
            this.candownload = CanDownload;
        }
        public string typefiles1 { get => typefiles; set => typefiles = value; }
        public string Name { get => name; set => name = value; }
        public string Album { get => album; set => album = value; }
        public string Songgenre { get => songgenre; set => songgenre = value; }
        public string Singer { get => singer; set => singer = value; }
        public float Rankings { get => rankings; set => rankings = value; }
        public string Yearpublishs { get => yearpublishs; set => yearpublishs = value; }
        public string Lyrics { get => lyrics; set => lyrics = value; }

        public string Composer { get => composer; set => composer = value; }
        public int Likes { get => likes; set => likes = value; }

        public int Reproductionss { get => reproductionss; set => reproductionss = value; }
        public string TypefileS { get => typefiles; set => typefiles = value; }
        public string Audioquality { get => audioquality; set => audioquality = value; }
        public string Albumimage { get => albumimage; set => albumimage = value; }
        public string Durations { get => durations; set => durations = value; }
        public string Songsize { get => songsize; set => songsize = value; }
        public int DownloadS { get => downloads; set => downloads = value; }
        public bool Candownload { get => candownload; set => candownload = value; }











        //Informacion de la Cancion
        public string InfoSong()
        {
            if (candownload == true)
            {
                return "Album: " + Album + " Nombre Canción: " + Name + " Artista: " + Singer + " Compositor: " + Composer + "Ranking: " + Rankings + " Duración: " + Durations + " Likes: " + Likes + " Descargas: " + DownloadS +
                    " Reproducciones: " + reproductionss + " Descarga: Opción No Disponible";
            }
            else
            {
                return "Album: " + Album + " Nombre Canción: " + Name + " Artista: " + Singer + " Compositor: " + Composer + "Ranking: " + Rankings + " Duración: " + Durations + " Likes: " + Likes + " Descargas: " + DownloadS +
                    " Reproducciones: " + reproductionss + " Descarga: Opción No Disponible";
            }
        }



    }
}
