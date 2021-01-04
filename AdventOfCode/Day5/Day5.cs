using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Day5
{
  class Day5
  {
    private static string[] airplaneRows = new string[127];
    private static string[] currentSeatMapRows = new string[] { };
    private static string[] airplaneColumns = new string[7];
    private static string[] currentSeatMapColumns = new string[] { };
    static List<Seat> seats = new List<Seat>();
    static void Main(string[] args)
    {
      var data = ParseData();
      foreach (var boardingPass in data)
      {
        var seat = GetSeat(boardingPass);
        seats.Add(seat);
      }
      seats.Sort();
    }

    private static Seat GetSeat(string boardingPass)
    {
      currentSeatMapRows = airplaneRows;
      currentSeatMapColumns = airplaneColumns;
      foreach (var character in boardingPass)
      {
        switch (character)
        {
          case 'F':
            GetFirstHalfRow();
            break;
          case 'B':
            GetSecondHalfRow();
            break;
          case 'L':
            GetFirstHalfColumn();
            break;
          case 'R':
            GetSecondHalfColumn();
            break;
        }
      }
      return new Seat(Convert.ToInt32(currentSeatMapRows), Convert.ToInt32(currentSeatMapColumns));
    }

    private static void GetSecondHalfColumn()
    {
      currentSeatMapColumns = currentSeatMapColumns.Skip(currentSeatMapColumns.Length / 2).ToArray();
    }

    private static void GetFirstHalfColumn()
    {
      currentSeatMapColumns = currentSeatMapColumns.Take(currentSeatMapColumns.Length / 2).ToArray();
    }

    private static void GetSecondHalfRow()
    {
      currentSeatMapRows = currentSeatMapRows.Skip(currentSeatMapRows.Length / 2).ToArray();
    }

    private static void GetFirstHalfRow()
    {
      currentSeatMapRows = currentSeatMapRows.Take(currentSeatMapRows.Length / 2).ToArray();
    }

    private static string[] ParseData()
    {
      var data = File.ReadAllText("../../Day5/InputData.txt");
      return data.Split(new [] {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);
    }
  }

  class Seat
  {
    private int row;
    private int column;
    public Seat(int row, int column)
    {
      this.row = row;
      this.column = column;
    }
  }
}
