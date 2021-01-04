/*
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode.Day2
{
  class Day2
  {
    static void Main(string[] args)
    {
      string[] stringData = File.ReadAllLines("../../Day2/InputData.txt");
      List<string> result = new List<string>();

      //Part1(stringData, result);
      Part2(stringData, result);
      var final = stringData.Count() - result.Count;
    }

    private static void Part2(string[] stringData, List<string> result)
    {
      foreach (var row in stringData)
      {
        var splitRow = row.Split(':');

        var key = splitRow[0];
        var value = splitRow[1];

        var keySplit = key.Replace(' ', '-').Split('-');
        int firstKeyValue = Int32.Parse(keySplit[0]);
        int secondKeyValue = Int32.Parse(keySplit[1]);

        var charToMatch = keySplit[2];
        int count = 0;
        if (value[firstKeyValue].ToString() == charToMatch)
        {
          count++;
        }
        if (value[secondKeyValue].ToString() == charToMatch)
        {
          count++;
        }

        if (count == 1)
        {
          result.Add(value);
        }
      }
    }

    private static void Part1(string[] stringData, List<string> result)
    {
      foreach (var row in stringData)
      {
        var splitRow = row.Split(':');

        var key = splitRow[0];
        var value = splitRow[1];

        var keySplit = key.Replace(' ', '-').Split('-');
        int firstKeyValue = Int32.Parse(keySplit[0]);
        int secondKeyValue = Int32.Parse(keySplit[1]);

        var charToMatch = keySplit[2];
        int count = 0;
        for (int i = 0; i < value.Length; i++)
        {
          if (value[i].ToString() == charToMatch)
          {
            count++;
          }
        }

        if (count < firstKeyValue || count > secondKeyValue)
        {
          result.Add(splitRow[1]);
        }
      }
    }
  }
}
*/
