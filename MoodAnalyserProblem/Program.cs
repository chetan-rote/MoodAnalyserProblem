﻿using System;

namespace MoodAnalyserProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser...!");
            ///Reads User's Mood.
            Console.WriteLine("How is your Mood Happy or Sad..?");
            string message = Console.ReadLine();
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            Console.WriteLine(moodAnalyser.AnalyseMood());
        }
    }
}
