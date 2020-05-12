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
        protected List<Songs> KeyWordSongs = new List<Songs> { };

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
        public string SearchKeyWord(string Key, string type) //En teoria deberia entregar todas las canciones que tengan la coincidencia
        {
            if (type == "Música")
            {
                foreach (Songs song in DataBaseSongs)
                {
                    if (Key==song.Name || Key == song.Album || Key == song.Songgenre || Key == song.Singer || Key == song.Composer || Key == song.Yearpublishs
                    || Key == song.TypefileS)
                    {
                        KeyWordSongs.Add(song); //Agrega las canciones que cumplan la coincidencia con el keyword
                    }
                }
                foreach (Songs song1 in KeyWordSongs)
                {
                    return song1.InfoSong(); //Retorna la info de las canciones de la lista (las que coinciden)
                }
                KeyWordSongs.Clear(); //Se resetea la lista para una nueva busqueda
            }
            if (type=="Películas") //Lo mismo pero con los métodos de las películas
            {
                return "";
            }
            if (KeyWordSongs.Count==0) //Si la lista no contiene canciones ningun tuvo coincidencia con el keyword
            {
                return "No se encontraron coincidencias";
            }
            else
            {
                return "Error, porfavor ingrese una palabra clave válida";
            }
        }


        //Agregar Cancion
        public void AddSong(Songs song)
        {
            DataBaseSongs.Add(song);
        }

        //MB vi que ya están los métodos para guardar en la memoria y para verificar las canciones, asi que hago el resto de métodos




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
        public void AddPlaylistStoDataBase(PlaylistS playlist)
        {
            DataBasePlaylistS.Add(playlist);
        }
    }
}
