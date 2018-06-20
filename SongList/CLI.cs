﻿using System;

namespace SongList
{
    ///Represents helper methods to interact with the CLI
    internal class CLI
    {
        /// Displays the welcome text.
        internal static void DisplayWelcome()
        {
            Console.WriteLine("----------Song List----------");
            Console.WriteLine("A list of your favorite songs");
            Console.WriteLine("-----------------------------");
        }

        /// <summary>
        /// Prompts the user to provide a value.
        /// </summary>
        /// <param name="message">The message to display to the user.</param>
        /// <returns>The response from the user</returns>
        internal static string Prompt(string message)
        {
            Console.Write(message);
            string userInput = Console.ReadLine();
            Console.WriteLine();

            return userInput.Trim();
        }
    }
}