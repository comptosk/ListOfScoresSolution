using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;

namespace ListOfScores
{
    class Program
    {

        static void Main(string[] args)
        {
            RunBowling();  
        }

        static void RunBowling()
        {
            Random rnd = new Random();
            var frames = new List<int>(10);
            for (var idx = 0; idx < 10; idx++)
            {
                var score = rnd.Next(20, 31);
                frames.Add(score);
            }

            var total = 0;
            foreach (var frame in frames)
            {
                total += frame;
            }
            Console.WriteLine($"Score is {total}");
        }
    }

}