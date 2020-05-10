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
        private int downoalds;
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
            this.typefiles = TypeFile;
            this.audioquality = AudioQuality;
            this.albumimage = AlbumImage;
            this.durations = DurationS;
            this.songsize = SongSize;
            this.downoalds = Downloads;
            this.candownload = CanDownload;
        }


        //Informacion de la Cancion
        public string InfoSong()
        {
            if (candownload == true)
            {
                return "Album: " + album + " Nombre Canción: " + name + " Artista: " + singer + " Compositor: " + composer + "Ranking: " + rankings + " Duración: " + durations + " Likes: " + likes + " Descargas: " + downoalds +
                    " Reproducciones: " + reproductionss + " Descarga: Disponible";
            }
            else
            {
                return "Album: " + album + " Nombre Canción: " + name + " Artista: " + singer + " Compositor: " + composer + "Ranking: " + rankings + " Duración: " + durations + " Likes: " + likes + " Descargas: " + downoalds +
                    " Reproducciones: " + reproductionss + " Descarga: Opción No Disponible";
            }
        }
        public string LyricsSong()
        {
            return lyrics;
        }



    }
}
