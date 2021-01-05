using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode.Day6
{
  class Day6
  {
    static void Main(string[] args)
    {
      var data = ParseData();
      List<int> allYeses = new List<int>();
      //allYeses.Add(FindYesesPart1(data));
      allYeses.Add(FindYesesPart2(data));
      Console.WriteLine(allYeses.Sum());
      Console.ReadLine();
    }

    private static int FindYesesPart2(string[][] data)
    {
      return data.Select(item => item.Aggregate((a, b) => new string(a.Intersect(b).ToArray()))).Select(intersect => intersect.Length).Sum();
    }

    private static int FindYesesPart1(string[][] data)
    {
      return data.Select(item => String.Join("", item)).Select(s => s.Distinct().Count()).Sum();
    }

    private static string[][] ParseData()
    {
      var data = File.ReadAllText("../../Day6/InputData.txt");
      return data.Split(new string[] {"\r\n\r\n"}, StringSplitOptions.RemoveEmptyEntries)
        .Select(r => r.Replace("\r\n", " ").Split(' ')).ToArray();
    }
  }
}
