using System;

class TempoDoDobby
{
  public static void Run()
  {
    int availableTime = int.Parse(Console.ReadLine());

    string[] line = Console.ReadLine().Split(" ");
    int timeFirstGift = int.Parse(line[0]);
    int timeSecondGift = int.Parse(line[1]);

    if (availableTime < (timeFirstGift + timeSecondGift))
    {
      Console.WriteLine("Deixa para amanha!");
    }
    else
    {
      Console.WriteLine("Farei Hoje!");
    }
  }
}