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
    }
}
