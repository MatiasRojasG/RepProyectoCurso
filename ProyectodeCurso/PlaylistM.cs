using System;
using System.Collections.Generic;

namespace ProyectodeCurso
{
    public class PlaylistM
    {
        //Atributos
        private string OwnerUser;
        private string Name_PlaylistM;
        private bool PrivacyM; //Si vale true es privada, distinto publica


        //Listas
        public List<Profile> FollowersPM = new List<Profile> { };
        public List<Movies> ListM = new List<Movies> { };



        public string OwnerUser1 { get => OwnerUser; set => OwnerUser = value; }
        public string Name_PlaylistM1 { get => Name_PlaylistM; set => Name_PlaylistM = value; }
        public bool PrivacyM1 { get => PrivacyM; set => PrivacyM = value; }


        //Constructor
        public PlaylistM(string ownerser, string name_playlist, bool privacy)
        {
            this.OwnerUser1 = ownerser;
            this.Name_PlaylistM1 = name_playlist;
            this.PrivacyM1 = privacy;
        }


        //Añadir seguidor
        public void AddFollowersPM(Profile profile)
        {
            FollowersPM.Add(profile);
        }
        //Añadir Cancion
        public void Lists(Movies movie)
        {
            ListM.Add(movie);
        }

    }
}
