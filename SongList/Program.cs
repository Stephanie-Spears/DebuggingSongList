using System;
using System.Collections.Generic;

namespace SongList
{
    internal class Program
    {
        private static List<Song> _songs = new List<Song>();

        /// <summary>
        /// Application entry point
        /// </summary>
        /// <param name="args">The arguments.</param>
        private static void Main(string[] args)
        {
            CLI.DisplayWelcome();

            int option = 0;
            while ((option = Menu.Prompt()) != 3)
            {
                switch (option)
                {
                    case 1:
                        AddSong();
                        break;

                    case 2:
                        DisplaySongList();
                        break;
                }
            }
        }

        /// <summary>
        /// Displays the list of favorite songs.
        /// </summary>
        private static void DisplaySongList()
        {
            Console.WriteLine("Songs");
            Console.WriteLine("----------");
            _songs.ForEach((song) => Console.WriteLine(song));
            Console.WriteLine();
        }

        /// <summary>
        /// Prompts user for song name and artist and adds a new Song.
        /// </summary>
        private static void AddSong()
        {
            bool done = false;
            do
            {
                string songName = CLI.Prompt("What's the name of the song? ");
                string artist = CLI.Prompt("Who's the artist? ");

                _songs.Add(new Song { Name = songName, Artist = artist });
                done = CLI.Prompt("Add another song? (y/n) ").ToLower() != "y";
            } while (!done);
        }
    }
}