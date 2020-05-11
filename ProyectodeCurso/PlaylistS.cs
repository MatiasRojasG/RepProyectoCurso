using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectodeCurso
{
    public class PlaylistS
    {
        //Atributos
        private string OwnerUser;
        private string Name_PlaylistS;
        private bool PrivacyS; //true == privada / false == publica
        private string type;


        //Listas
        public List<Profile> FollowersPS = new List<Profile> { }; //Lista de seguidores
        public List<Songs> ListS = new List<Songs> { }; //Lista de canciones


        public string OwnerUser1 { get => OwnerUser; set => OwnerUser = value; }
        public string Name_PlaylistS1 { get => Name_PlaylistS; set => Name_PlaylistS = value; }
        public bool PrivacyS1 { get => PrivacyS; set => PrivacyS = value; }
        public string Type{ get => type; set => type = value; }


        public PlaylistS(string ownerser, string name_playlist, bool privacy, string type)
        {
            this.OwnerUser1 = ownerser;
            this.Name_PlaylistS1 = name_playlist;
            this.PrivacyS1 = privacy;
            this.type = type;
        }


        //Añadir seguidor
        public void AddFollowersPS(Profile profile)
        {
            FollowersPS.Add(profile);
        }


        //Añadir cancion y establecer typefile
        public void AddListS(Songs song)
        {
           if (song.typefiles1 == Type)
            {
                ListS.Add(song);
            }
           else
            {
                Console.WriteLine("Las canciones deben tener el mismo Filetype");
            }
        }



        //Buscar Cancion dentro de la playlist
        public string SongSearchinPlaylist(Songs song)
        {
            if (ListS.Contains(song))
            {
                return song.InfoSong();
            }
            else
            {
                return "Canción no encontrada dentro de la playlist " + Name_PlaylistS1;
            }

        }

        public string InfoPlaylistS()
        {
            Console.WriteLine("Creador :" + OwnerUser1 + " Nombre de la Playlist: " + Name_PlaylistS1);
            Console.WriteLine("Canciones: ");
            foreach (Songs song in ListS)
            {
                return "Nombre: "+song.Name;
            }
            return "...";
        }
    }
}
