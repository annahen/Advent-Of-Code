using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdventOfCode.Day3
{
  /*class Day3
  {
    static void Main(string[] args)
    {
      string[] data = File.ReadAllLines("../../Day3/InputData.txt");
      int trees = 0;
      int i = 0;
      foreach (var row in data)
      {
        i += 3;
        if (i >= row.Length)
        {
          i = (i - row.Length) * -1;
        }
        else if (row[i] == '#')
        {
          trees++;
        }

        
      }
      Console.WriteLine(trees);
    }
  }*/

/*  public static class Day3
  {
    static int r;
    static int d;
    static string[] input = File.ReadAllLines("../../Day3/InputData.txt");

    static int trees = 0;

    static void Main(string[] args)
    {
      findTrees();
    }

    private static void findTrees()
    {
      while (true)
      {
        var line = input[d];
        if (line.ToCharArray()[r] == '#') trees++;
        r += 1;
        d += 2;
        if (input.Length <= d)
        {
          Console.WriteLine($"Answer: {trees} trees");
          Console.ReadLine();
        }

        if (line.Length <= r)
        {
          r -= line.Length;
        }
      }
    }
  }*/
}
