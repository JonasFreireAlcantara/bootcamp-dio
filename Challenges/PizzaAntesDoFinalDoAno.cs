using System;

class PizzaAntesDoFinalDoAno
{
  public static void Run()
  {
    string[] line = Console.ReadLine().Split(" ");
    int numberOfPersons = int.Parse(line[0]);
    int numberOfDates = int.Parse(line[1]);

    for (int k = 0; k < numberOfDates; k++)
    {
      string input = Console.ReadLine();
      if (input.Contains(" 0"))
      {
        Console.WriteLine("contains zero");
        continue;
      }
      Console.WriteLine(input.Split(" ")[0]);
      return;
    }

    Console.WriteLine("Pizza antes de FdA");
  }

}