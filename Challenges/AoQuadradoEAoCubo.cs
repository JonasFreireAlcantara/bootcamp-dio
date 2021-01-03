using System;

class AoQuadradoEAoCubo
{
  public static void Run()
  {
    int amount = int.Parse(Console.ReadLine());

    for (int number = 1; number <= amount; number++)
    {
      Console.WriteLine($"{number} {Math.Pow(number, 2)} {Math.Pow(number, 3)}");
    }
  }
}