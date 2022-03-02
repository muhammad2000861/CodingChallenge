using System;

namespace MusicLibrary {
    class Musictracks{
        List<Musictracks> Music = new List<Musictracks>();
        public GetMusicTracks(Musictracks tracks, string thisGenre, int count) {
            string musicgenre = thisGenre;

            if(tracks.genre == musicgenre && tracks.duration != 0.00) {
                Music.add(new Musictracks(tracks.artist, tracks.title, tracks.genre, tracks.year, tracks.duration));
                Console.WriteLine("name" +tracks.artist);
                Console.WriteLine("name" +tracks.title);
                Console.WriteLine("name" +tracks.genre);
                Console.WriteLine("name" +tracks.year);
                Console.WriteLine("name" +tracks.duration);
            }
            return count;

            Console.WriteLine("which artist/genre you want to listen to?");
            string response = Console.ReadLine();

            if (response == tracks.title) {
                Console.WriteLine(title);
            }

            else if (response == tracks.genre) {
                Console.WriteLine(genre);
            }

            else if (tracks.duration == 0.00){
                return null;
            }


        }

        

    }
  

   
}