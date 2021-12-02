using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    /// <summary>
    /// Advent of code 1
    /// </summary>
    class DepthScan
    {
        public DepthScan()
        {

        }

        private static List<int> ReadFile(string filePath)
        {
            var readLines = File.ReadAllLines(filePath);

            var inputScanParsed = readLines.Select(l => int.Parse(l)).ToList();
            return readLines.Select(l => int.Parse(l)).ToList();
        }

        public static int CalculateNumberOfDepthIncreases(string filePath)
        {
            var inputScans = ReadFile(filePath);
            var numberOfDepthIncreases = 0;
            int? previousDepth = null;
            foreach (var scanDepth in inputScans)
            {
                if (previousDepth != null && scanDepth > previousDepth)
                {
                    numberOfDepthIncreases++;
                }

                previousDepth = scanDepth;
            }

            return numberOfDepthIncreases;
        }
    }
}
