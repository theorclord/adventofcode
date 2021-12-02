using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // Day one
            int numberOfDepthIncreases = DepthScan.CalculateNumberOfDepthIncreases(AppContext.BaseDirectory + @"\Day1\inputScanData.txt");

            Console.WriteLine(numberOfDepthIncreases);


            // Day two
        }
    }
}
