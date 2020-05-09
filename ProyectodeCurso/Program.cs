using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ProyectodeCurso
{
    class MainClass
    { 
        public static void Main(string[] args)
        {
            string Opcion1;
            string nombrePlaylistS;
            string privacyS;
            //Si entra como usuario dueño de playlists
            Console.WriteLine("Elija una opción:");
            Console.WriteLine("1) Crear Playlist de Música");
            Console.WriteLine("2) Ver Playlists de Música");
            Console.WriteLine("3) Crear Playlist de Películas");
            Console.WriteLine("4) Ver Playlists de Peliculas");
            Opcion1 = Console.ReadLine();
            if (Opcion1=="1")
            {
                Console.WriteLine("Ingrese el nombre de la Playlist");
                nombrePlaylistS = Console.ReadLine();
                Console.WriteLine("¿Desea que su Playlist sea privada?");
                privacyS = Console.ReadLine();
                if (privacyS == "Si")
                {
                    PlaylistS playlistSpriv = new PlaylistS("owneruser", nombrePlaylistS, true);

                }
                if (privacyS=="No")
                {
                    PlaylistS playlistSpub = new PlaylistS("owneruser", nombrePlaylistS,false);
                }
                else
                {
                    Console.WriteLine("Error / Favor elija una opción válida");
                }
            }




            //Si es otro usuario




        }
    }
}
