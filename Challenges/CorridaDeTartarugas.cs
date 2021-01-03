using System;

class CorridaDeTartarugas
{
  public static void Run()
  {
    while (true)
    {
      int amount = int.Parse(Console.ReadLine());

      int maximumLevel = 1;
      string[] speeds = Console.ReadLine().Split(" ");
      foreach (string speed in speeds)
      {
        int actualLevel = GetLevel(speed);
        if (maximumLevel < actualLevel)
        {
          maximumLevel = actualLevel;
        }
      }

      Console.WriteLine(maximumLevel);
    }
  }


  private static int GetLevel(string speedText)
  {
    int speed = int.Parse(speedText);
    if (speed < 10)
    {
      return 1;
    }
    else if (speed < 20)
    {
      return 2;
    }
    else
    {
      return 3;
    }
  }
}