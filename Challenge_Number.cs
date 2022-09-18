using System;
using System.IO;

/// <summary>
/// @author. jaracoder
/// @title. [Title_Challenge]
/// </summary>
/// 
namespace Challenge_Number
{
    public class Challenge_Number
    {
        static int totalCases;

        static string inputFile = "A-small-practice.in";
        static string[] inputLines = null;

        static string outputFile = "solved.in";
        static string[] outputLines = null;


        static void Main()
        {
            try
            {
                inputLines = GetLinesFromFile();
                totalCases = Int32.Parse(inputLines[0]);
                outputLines = new string[totalCases];

                foreach (string inputLine in inputLines)
                {

                }

                //outputLines[0] = "Hey";
                //SaveLinesOnFile(outputLines);
            }
            catch
            {

            }
        }


        /// <summary>
        /// Gets all lines of a text file.
        /// </summary>
        static string[] GetLinesFromFile()
        {
            string[] lines;

            try
            {
                lines = File.ReadAllLines(inputFile);
            }
            catch
            {
                lines = null;
            }

            return lines;
        }


        /// <summary>
        /// Gets all lines of a text file.
        /// </summary>
        static void SaveLinesOnFile(string[] lines)
        {
            try
            {
                File.WriteAllLines(outputFile, lines);
            }
            catch { }
        }
    }
}