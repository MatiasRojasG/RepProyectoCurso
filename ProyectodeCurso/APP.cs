using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using ProyectodeCurso;

namespace Proyecto_APP_SpotiNetflix
{
    class App
    {

        private List<Songs> DataBaseSongs = new List<Songs>();
        private List<Movies> DataBaseMovies = new List<Movies>();
        private List<Profile> DataBaseUsers = new List<Profile>();

        private List<Singer> DataBaseSingers = new List<Singer>();
        private List<WorkerMovie> DataBaseWorkersM = new List<WorkerMovie>();

        private List<List<PlaylistM>> DataBasePlaylistM = new List<List<PlaylistM>>();
        private List<List<PlaylistS>> DataBasePlaylistS = new List<List<PlaylistS>>();

        private List<PlaylistS> PlaylistSinDataB = new List<PlaylistS> { };



        protected List<Movies> KeyWordMovies = new List<Movies> { };
        protected List<Songs> KeyWordSongs = new List<Songs> { };

        protected List<Songs> KeyWordRankingigualsongs = new List<Songs> { };//lista para en las cuales son igual la key y el ranking de songs
        protected List<Songs> KeyWordRankingmayorsongs = new List<Songs> { };
        protected List<Songs> KeyWordRankingmenorsongs = new List<Songs> { };
        protected List<Movies> KeyWordRankingigualmovies = new List<Movies> { };
        protected List<Movies> KeyWordRankingmenormovies = new List<Movies> { };
        protected List<Movies> KeyWordRankingmayormovies = new List<Movies> { };
        protected List<Movies> KeyWordCategoria = new List<Movies> { };




        public App()
        {

        }

        public string SearchPlaylistS(string nombreplaylist)
        {
            foreach (PlaylistS playlist in PlaylistSinDataB)
            {
                if (playlist.Name_PlaylistS1 == nombreplaylist)
                {
                    if (playlist.PrivacyS1 == true) //Privada no se puede ver
                    {
                        return "Lo lamentamos, esta Playlist es privada";
                    }
                    if (playlist.PrivacyS1 == false) //Publica se puede ber
                    {
                        return playlist.InfoPlaylistS();
                    }
                    else
                    {
                        return "Esta playlist no existe"; //Si no es ninguna de las dos, la playlist no existe
                    }
                }
            }
            return "";

        }
        public PlaylistS GetPlaylistS(string NamePlaylistS)
        {
            foreach (PlaylistS playlist in PlaylistSinDataB)
            {
                if (playlist.Name_PlaylistS1==NamePlaylistS)
                {
                    return playlist;
                }
            }
            return null;
        }
        public Songs GetSongs(string NameSong)
        {
            foreach (Songs song in DataBaseSongs)
            {
                if(song.Name_Song1==NameSong)
                {
                    return song;
                }
            }
            return null;
        }
    }   
}
