using System;
using System.Collections.Generic;

namespace ProyectodeCurso
{
    public class PlaylistS
    {
        //Atributos
        private string OwnerUser;
        private string Name_PlaylistS;
        private bool PrivacyS; //Si vale true es privada, distinto publica


        //Listas
        public List<Profile> FollowersPS = new List<Profile> { };
        public List<Songs> ListS = new List<Songs> { };


        public string OwnerUser1 { get => OwnerUser; set => OwnerUser = value; }
        public string Name_PlaylistS1 { get => Name_PlaylistS; set => Name_PlaylistS = value; }
        public bool PrivacyS1 { get => PrivacyS; set => PrivacyS = value; }


        public PlaylistS(string ownerser, string name_playlist, bool privacy)
        {
            this.OwnerUser1 = ownerser;
            this.Name_PlaylistS1 = name_playlist;
            this.PrivacyS1 = privacy;
        }
        //Añadir seguidor
        public void AddFollowersPS(Profile profile)
        {
            FollowersPS.Add(profile);
        }
        //Añadir Cancion
        public void Lists(Songs song)
        {
            ListS.Add(song);
        }
        //Vision si es publica
    }
}
