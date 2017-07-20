using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class OnlineRadioDatabase
{
    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var songs = new List<Song>();

        for (int i = 0; i < n; i++)
        {
            try
            {
                var input = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (input.Count != 3)
                {
                    Console.WriteLine("Invalid song.");
                }
                else
                {
                    var splitTime = input[2].Split(':');

                    var song = new Song(input[0], input[1], int.Parse(splitTime[0]), int.Parse(splitTime[1]));

                    songs.Add(song);

                    Console.WriteLine("Song added.");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        Console.WriteLine($"Songs added: {songs.Count}");

        int totalDuration = 0;

        foreach (var song in songs)
        {
            totalDuration += song.Minutes * 60 + song.Seconds;
        }

        int totalMinutes = totalDuration / 60;
        int totalSeconds = totalDuration % 60;
        int hours = totalMinutes / 60;
        totalMinutes %= 60;
        Console.WriteLine($"Playlist length: {hours}h {totalMinutes}m {totalSeconds}s");
    }
}
