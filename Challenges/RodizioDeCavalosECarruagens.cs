using System;
using System.Text.RegularExpressions;

class RodizioDeCavalosECarruagens
{
  public static void Run()
  {
    int number = int.Parse(Console.ReadLine());

    for (int k = 0; k < number; k++)
    {
      string plate = Console.ReadLine();
      if (IsInvalidFormat(plate))
      {
        Console.WriteLine("FALHA");
      }
      else
      {
        Console.WriteLine(GetDay(plate));
      }
    }
  }

  private static bool IsInvalidFormat(string plate)
  {
    return !Regex.IsMatch(plate, "^[A-Z]{3}-[0-9]{4}$");
  }

  private static string GetDay(string plate)
  {
    char lastDigit = plate[plate.Length - 1];
    switch (lastDigit)
    {
      case '1':
      case '2':
        return "SEGUNDA";
      
      case '3':
      case '4':
        return "TERCA";
      
      case '5':
      case '6':
        return "QUARTA";
      
      case '7':
      case '8':
        return "QUINTA";
      
      case '9':
      case '0':
      default:
        return "SEXTA";
    }
  }
}