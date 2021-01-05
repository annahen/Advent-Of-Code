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
      allYeses.Add(FindYeses(data));
      Console.WriteLine(allYeses.Sum());
      Console.ReadLine();
    }

    private static int FindYeses(string[][] data)
    {
      int res = 0;
      foreach (var item in data)
      {
        var s = String.Join("", item);
        int count = s.Distinct().Count();
        res += count;
      }
      return res;
    }

    private static string[][] ParseData()
    {
      var data = File.ReadAllText("../../Day6/InputData.txt");
      return data.Split(new string[] {"\r\n\r\n"}, StringSplitOptions.RemoveEmptyEntries)
        .Select(r => r.Replace("\r\n", " ").Split(' ')).ToArray();
    }
  }
}
