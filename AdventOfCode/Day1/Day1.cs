/*
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Day1
{
  class Day1
  {
    static void Main(string[] args)
    {
      int i = 0;
      string[] stringData = System.IO.File.ReadAllLines("../../Day1/InputData.txt");
      List<int> dataList = new List<int>();
      
      foreach (var line in stringData)
      {
        var numVal = Int32.Parse(line);
        dataList.Add(numVal);
        i++;
      }

      List<int> result = new List<int>();
      for (var p = 0; p < dataList.Count; p++)
      {
        for (var j = 0; j < dataList.Count; j++)
        {
          for (var u = 0; u < dataList.Count; u++)
          {
            var calculation = dataList[p] + dataList[j] + dataList[u];
            if (calculation == 2020)
            {
              result.Add(dataList[p]);
              result.Add(dataList[j]);
              result.Add(dataList[u]);
            }
          }
        }
      }

      List<int> distinct = result.Distinct().ToList();
      int finalVal = distinct[0] * distinct[1] * distinct[2];
      Console.Write(finalVal);

    }
  }
}
*/
