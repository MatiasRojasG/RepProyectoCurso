using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectodeCurso
{
    class APP
    {
        protected List<Songs> DataBaseSongs = new List<Songs>();
        protected List<PlaylistS> DataBasePlaylistS = new List<PlaylistS> { };


        public APP()
        {
        }
        //Buscar cancion
        public string SearchSong(Songs song)
        {
            if (DataBaseSongs.Contains(song))
            {
                return song.InfoSong();
            }
            else //No la contiene
            {
                return "Canción no encontrada";
            }
        }
        //Busca una playlist
        public string SearchPlaylistS(PlaylistS playlist)
        {
            if (playlist.PrivacyS1==true) //Privada no se puede ver
            {
                return "Lo lamentamos, esta Playlist es privada";
            }
            if (playlist.PrivacyS1==false) //Publica se puede ber
            {
                return playlist.InfoPlaylistS();
            }
            else
            {
                return "Esta playlist no existe"; //Si no es ninguna de las dos, la playlist no existe
            }
        }
    }
}
