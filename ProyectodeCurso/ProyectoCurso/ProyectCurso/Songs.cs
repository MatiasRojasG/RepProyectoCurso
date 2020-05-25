using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectodeCurso;

namespace Proyecto_APP_SpotiNetflix
{
    [Serializable]
    class Songs
    {


        /* Atributos que deben ser sacados cuando se agregan canciones desde el archivo c/r
        
        string AudioQuality;
        
       
        */
        private string Name_Song;
        private string Album;
        private string SongGenre;
        private string Composer;
        private string Singer;
        private float RankingS;
        private string Lyrics;
        private string YearPublishS;

        private string TypeFileS;
        private double SongSize;
        private double DurationS;

        //AlbumImage guarda el nombre del archivo el cual estara en la carpeta bin/Debug de la carpeta contenedora de la aplicacion
        private string AlbumImage;

        private int LikesS;
        private int ReproductionsS;
        private string AudioQuality;
        private bool Candownload;

        private int DownloadsS;
        /*
        Este atributo no es valido dado que los usarios premium pueden solo descargar las canciones, por lo tanto
        de perfiles se define con si es premium o no si lo pueden descargar.
        private bool Candownload;
        */


        public Songs(string Name_Song, string Album, string SongGenre, string Composer, string Singer, string YearPublishS, string Lyrics, string TypeFileS, double SongSize, double DurationS, string AlbumImage, string AudioQuality)
        {
            this.Name_Song = Name_Song;
            this.Album = Album;
            this.SongGenre = SongGenre;
            this.Composer = Composer;
            this.Singer = Singer;
            this.YearPublishS = YearPublishS;
            this.Lyrics = Lyrics;

            this.TypeFileS = TypeFileS;
            this.SongSize = SongSize;
            this.DurationS = DurationS;
            this.AlbumImage = AlbumImage;
            this.AudioQuality = AudioQuality;

        }

        public string Name_Song1 { get => Name_Song; set => Name_Song = value; }
        public string Album1 { get => Album; set => Album = value; }
        public string SongGenre1 { get => SongGenre; set => SongGenre = value; }
        public string Composer1 { get => Composer; set => Composer = value; }
        public string Singer1 { get => Singer; set => Singer = value; }
        public float RankingS1 { get => RankingS; set => RankingS = value; }
        public string Lyrics1 { get => Lyrics; set => Lyrics = value; }
        public string YearPublishS1 { get => YearPublishS; set => YearPublishS = value; }
        public string TypeFileS1 { get => TypeFileS; set => TypeFileS = value; }
        public double SongSize1 { get => SongSize; set => SongSize = value; }
        public double DurationS1 { get => DurationS; set => DurationS = value; }
        public string AlbumImage1 { get => AlbumImage; set => AlbumImage = value; }
        public int LikesS1 { get => LikesS; set => LikesS = value; }
        public int ReproductionsS1 { get => ReproductionsS; set => ReproductionsS = value; }
        public string AudioQuality1 { get => AudioQuality; set => AudioQuality = value; }
        public int Downloads1 { get => DownloadsS; set => DownloadsS = value; }
        public bool Candownload1 { get => Candownload; set => Candownload = value; }





        //Informacion de la Cancion
        public string InfoSong()
        {
            if (Candownload == true)
            {
                return "Album: " + Album + " Nombre Canción: " + Name_Song + " Artista: " + Singer + " Compositor: " + Composer + "Ranking: " + RankingS1 + " Duración: " + DurationS + " Likes: " + LikesS + " Descargas: " + DownloadsS +
                    " Reproducciones: " + ReproductionsS + " Descarga: Opción Disponible";
            }
            else
            {
                return "Album: " + Album + " Nombre Canción: " + Name_Song + " Artista: " + Singer + " Compositor: " + Composer + "Ranking: " + RankingS1 + " Duración: " + DurationS + " Likes: " + LikesS + " Descargas: " + DownloadsS +
                    " Reproducciones: " + ReproductionsS + " Descarga: Opción No Disponible";
            }
        }
    }

}