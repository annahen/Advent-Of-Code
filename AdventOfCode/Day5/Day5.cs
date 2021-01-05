using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode.Day5
{
  class Day5
  {
    static void Main(string[] args)
    {
      var data = ParseData();

      List<int> seatIds = data
        .Select(seat => Convert.ToInt32(ConvertToBinary(seat), 2))
        .ToList();

      seatIds.Sort();

      Console.WriteLine(seatIds.Max()); //Part 1
      Console.WriteLine(Enumerable.Range(seatIds.Min(), seatIds.Max()) //Part 2
        .FirstOrDefault(id => !seatIds.Contains(id))
        .ToString());
    }

    private static string ConvertToBinary(string seat)
    {
      return seat
          .Replace('F', '0')
          .Replace('B', '1')
          .Replace('L', '0').Replace('R', '1');
    }

    private static string[] ParseData()
    {
      var data = File.ReadAllText("../../Day5/InputData.txt");
      return data.Split(new [] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);
    }
  }
}
