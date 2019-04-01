using System;
using System.Collections.Generic;
using System.Linq;

namespace Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            //string regexCode = @"(?<artist>^[A-Z][a-z]*\s*[a-z]*\'*[a-z]*)\:(?<song>[A-Z]+\s*[A-Z]+\s*[A-Z]+\s*[A-Z]+\s)";

            string name = string.Empty;
            string song = string.Empty;
            int countName = 0;
            int countSong = 0;

            List<string> inputText = Console.ReadLine().Split(':').ToList();
            while (inputText[0] != "end")
            {
                name = inputText[0];
                song = inputText[1];
                for (int i = 0; i < name.Length; i++)
                {
                    if (char.IsUpper(name[i]) && name[i] != ' ' && name[i] != '\'')
                    {
                        countName++;
                    }
                }
                for (int i = 0; i < song.Length; i++)
                {
                    if (char.IsLower(song[i]) && song[i] != ' ' && song[i] != '\'')
                    {
                        countSong++;
                    }
                }
                if (countName == 1 && countSong == 0)
                {
                    Console.WriteLine("Successful encryption:");
                    for (int i = 0; i < name.Length; i++)
                    {
                        Console.Write((char)(name[i] + name.Length));
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
                inputText = Console.ReadLine().Split(':').ToList();
                countName = 0;
                countSong = 0;
            }
        }
    }
}
