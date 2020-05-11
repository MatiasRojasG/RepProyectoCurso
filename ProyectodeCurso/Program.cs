﻿using System;
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
            //Creacion de la cancion
            string nombrecancion;
            string album;
            string generocancion;
            string cantante;
            string compositor;
            float rankings;
            string añodepublicacions;
            string letra;
            int megusta;
            int reproducciones;
            string tipodearchivo;
            string calidaddeaudio;
            string imagenalum;
            string duracions;
            string tamañocancion;
            int descargass;
            bool descargapos;



            string tipo;


            //Admin
            //Console.ReadLine() le damos valores a los atributos
            Songs cancion = new Songs(nombrecancion, album, generocancion, cantante, compositor, rankings, añodepublicacions, letra, megusta, reproducciones, tipodearchivo, calidaddeaudio,
                imagenalum, duracions, tamañocancion, descargass, descargapos);


            //Admin
            //Creacion cantante
            string nombrecantante;
            string apellidocantante;
            string nombreartistico;
            int rankingcantante;
            //Console.ReadLine() le damos valores a los atributos
            Singer cantante1 = new Singer(nombrecantante, apellidocantante, nombreartistico, rankingcantante);


            //Usuario
            //Creacion de la playlist
            string Usuariocreador;
            string nombreplaylistcancion;
            bool privacidadcancion;
            //Console.ReadLine() le damos valores a los atributos
            PlaylistS playlists1 = new PlaylistS(Usuariocreador, nombreplaylistcancion, privacidadcancion, tipo);


            //Usuario
            //Añadir cancion a playlist
            playlists1.AddListS(cancion);



            //Usuario
            //Profile "profile1" sigue a la playlist1 publica
            Profile profile1 = new Profile();
            if (playlists1.PrivacyS1 == false)
            {
                playlists1.AddFollowersPS(profile1);
                profile1.AddPlaylistFollowingS(playlists1);
            }


            //Usuario
            //Buscar una cancion "cancion" en la database
            APP app = new APP();
            app.SearchSong(cancion);



            //Buscar una cancion "cancion" en una playlist "playlist1"
            playlists1.SongSearchinPlaylist(cancion);


            //Buscar una playlist





        }
    }
}

