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
 public static class Day3
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
          Console.WriteLine(trees);
        }

        if (line.Length <= r)
        {
          r -= line.Length;
        }
      }
    }
  }
}
