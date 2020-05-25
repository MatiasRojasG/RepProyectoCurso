using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_APP_SpotiNetflix;
using ProyectodeCurso;

namespace ProyectodeCurso
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            App app = new App();
            Profile profile = new Profile();
            Console.WriteLine("Menú: Elija una opcion numerica");
            Console.WriteLine(" ");
            Console.WriteLine("1) Crear Playlist");
            Console.WriteLine(" ");
            Console.WriteLine("2) Ver Playlist");
            Console.WriteLine(" ");
            Console.WriteLine("3) Añadir Canción a Playlist");
            Console.WriteLine(" ");
            Console.WriteLine("4) Buscar Canción");
            Console.WriteLine(" ");
            Console.WriteLine("5) Buscar Canción dentro de una Playlist");
            Console.WriteLine(" ");
            Console.WriteLine("6) Eliminar una cancion de la playlist");
            Console.WriteLine(" ");
            Console.WriteLine("7) Eliminar una playlist de canciones");
            Console.WriteLine(" ");
            Console.WriteLine("8) Añadir Pelicula a Playlist");
            Console.WriteLine(" ");
            Console.WriteLine("9) Buscar Pelicula");
            Console.WriteLine(" ");
            Console.WriteLine("10) Buscar Pelicula dentro de una Playlist");
            Console.WriteLine(" ");
            Console.WriteLine("11) Elminar una pelicula de la playlist");
            Console.WriteLine(" ");
            Console.WriteLine("12) Eliminar una Playlist de peliculas");
            Console.WriteLine(" ");
            Console.WriteLine("8) Búsqueda general"); //keyword
            Console.WriteLine(" ");
            Console.WriteLine("9) Salir de Spotify");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            string OptionMenuUser = Console.ReadLine();

            if (OptionMenuUser == "1")
            {
                Console.WriteLine("\nIngrese el nombre de la playlist");
                string NamePlaylist = Console.ReadLine();
                Console.WriteLine("\nIngrese el tipo de playlist (Ingrese 1 si es de canciones o 2 si es de peliculas)");
                string tipo = Console.ReadLine();

                while (true)
                {
                    if (tipo != "1" && tipo != "2")
                    {
                        Console.WriteLine("ERROR: Porfavor ingrese un el parameto correcto\n");
                        Console.WriteLine("\nTipo:");
                        tipo = Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                }
                //Listas Canciones
                if (tipo == "1")
                {
                    string FileType;

                    while (true)
                    {
                        Console.WriteLine("Ingrese el tipo de archivo que va a permitir esta playlist (ingrese mp3 o wav)\n");
                        FileType = Console.ReadLine();

                        if (FileType != "mp3" && FileType != "wav")
                        {
                            Console.WriteLine("Error: Porfavor ingrese un tipo valido\n");
                        }
                        else
                        {
                            break;
                        }


                    }
                    PlaylistS playlistS = new PlaylistS(profile.Email1, NamePlaylist, profile.Privacy1, FileType);

                    Console.WriteLine("Playlist creada con exito!\n");

                    profile.AddPlaylistS(playlistS);




                }

                //Listas Peliculas
                else
                {

                }

            }


            else if (OptionMenuUser=="2")
            {
                Console.WriteLine("\nIngrese el nombre de la playlist");
                string NamePlaylist = Console.ReadLine();
                Console.WriteLine("\nIngrese el tipo de playlist (Ingrese 1 si es de canciones o 2 si es de peliculas)");
                string tipo = Console.ReadLine();

                while (true)
                {
                    if (tipo != "1" && tipo != "2")
                    {
                        Console.WriteLine("ERROR: Porfavor ingrese un el parameto correcto\n");
                        Console.WriteLine("\nTipo:");
                        tipo = Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                }

                if(tipo=="1")
                {
                    app.SearchPlaylistS(NamePlaylist);
                }

                else //Peliculas
                {

                }



            }


            else if (OptionMenuUser == "3")
            {
                Console.WriteLine("Ingrese el nombre de la canción a agregar: ");
                string NameSong = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre de su playlist");
                string NamePlaylist = Console.ReadLine();
                try
                {
                    app.GetPlaylistS(NamePlaylist).AddListS(app.GetSongs(NameSong));

                }
                catch
                {
                    Console.WriteLine("ERROR; El nombre de la canción o playlist son incorrectos.");
                }
            }


            else if (OptionMenuUser == "4")
            {

            }


            else if (OptionMenuUser == "5")
            {

            }


            else if (OptionMenuUser == "6")
            {

            }
            else if (OptionMenuUser == "7")
            {

            }
            else if (OptionMenuUser == "8")
            {

            }
            else if (OptionMenuUser == "9")
            {
                LoginOption = "3";

                break;
            }
            else
            {
                Console.WriteLine("ERROR: Escojan una de las opciones del menu\n");
            }







        }

    }



}