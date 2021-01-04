using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;


namespace AdventOfCode.Day4
{
  class Day4
  {
    private static int validPassports = 0;
    static HashSet<string> mandatoryFields = new HashSet<string> {"byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid"};
    static HashSet<string> validEyeColor = new HashSet<string>{"amb", "blu", "brn", "gry", "grn", "hzl", "oth",};

    static void Main(string[] args)
    {
      var data = ReadData();
      foreach (var item in data)
      {
        CheckIfValid(item);
      }
      Console.Write(validPassports);
    }

    private static Dictionary<string, string>[] ReadData()
    {
      var data = File.ReadAllText("../../Day4/InputData.txt");
      return data
        .Split(new string[] {"\r\n\r\n"}, StringSplitOptions.RemoveEmptyEntries)
        .Select(r => r.Replace("\r\n", " ").Split(' '))
        .Select(r => r.Select(rr => rr.Split(':'))
          .ToDictionary(k => k[0], v => v[1]))
        .ToArray();
    }

    private static void CheckIfValid(Dictionary<string, string> passportItemsDictionary)
    {
      if (mandatoryFields.All(x => passportItemsDictionary.ContainsKey(x)))
      {
        if(CheckBYR(Convert.ToInt32(passportItemsDictionary.FirstOrDefault(x => x.Key == "byr").Value))
        && CheckEYR(Convert.ToInt32(passportItemsDictionary.FirstOrDefault(x => x.Key == "eyr").Value))
        && CheckIYR(Convert.ToInt32(passportItemsDictionary.FirstOrDefault(x => x.Key == "iyr").Value))
        && CheckHCL(passportItemsDictionary.FirstOrDefault(x => x.Key == "hcl").Value)
        && CheckHGT(passportItemsDictionary.FirstOrDefault(x => x.Key == "hgt").Value)
        && CheckPID(passportItemsDictionary.FirstOrDefault(x => x.Key == "pid").Value)
        && CheckECL(passportItemsDictionary.FirstOrDefault(x => x.Key == "ecl").Value))
        {
          validPassports++;
        }
      }
    }

    private static bool CheckBYR(int key)
    {
      return key >= 1920 && key <= 2002;
    }

    private static bool CheckIYR(int key)
    {
      return key >= 2010 && key <= 2020;
    }

    private static bool CheckEYR(int key)
    {
      return key >= 2020 && key <= 2030;
    }

    private static bool CheckHGT(string value)
    {
      var height = Convert.ToInt32(value.Remove(value.Length - 2));
      var type = value.Substring(value.Length - Math.Min(2, value.Length));

      switch (type)
      {
        case "cm" when height >= 150 && height <= 193:
        case "in" when height >= 59 && height <= 76:
          return true;
        default:
          return false;
      }
    }
    private static bool CheckHCL(string hairColor)
    {
      var regex = new Regex("[A-Za-z0-9]{6}");
      var match = regex.IsMatch(hairColor);
      return hairColor[0] == '#' && match;
    }

    private static bool CheckECL(string eyeColor)
    {
      return !string.IsNullOrEmpty(validEyeColor.SingleOrDefault(e => eyeColor.Equals(e)));
    }

    private static bool CheckPID(string pid)
    {
      return pid.Length == 9;
    }
  }

}
