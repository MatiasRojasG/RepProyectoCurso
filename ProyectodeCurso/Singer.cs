using System;
namespace ProyectodeCurso
{
    public class Singer
    {
        //Atributos
        private string name;
        private string lastname;
        private string stagename;
        private float rankingsinger;



        //Constructor
        public Singer(string Name, string LastName, string StageName, float RankingSinger)
        {
            this.name = Name;
            this.lastname = LastName;
            this.stagename = StageName;
            this.rankingsinger = RankingSinger;
        }


        //Info del cantante
        public string InfoSinger()
        {
            return "Artista: " + name + " " + lastname + "Nombre Artístico: " + stagename + " " + "Ranking: " + rankingsinger;
        }
    }
}
