using System;

class HoraDaCorrida {
  public static void Run()
  {
    string[] line = Console.ReadLine().Split(" ");

    int numberOfLaps = int.Parse(line[0]);
    int numberOfPlates = int.Parse(line[1]);

    int for10 = ComputeMinimumNumberOfPlates(0.1 * numberOfLaps, numberOfPlates);
    int for20 = ComputeMinimumNumberOfPlates(0.2 * numberOfLaps, numberOfPlates);
    int for30 = ComputeMinimumNumberOfPlates(0.3 * numberOfLaps, numberOfPlates);
    int for40 = ComputeMinimumNumberOfPlates(0.4 * numberOfLaps, numberOfPlates);
    int for50 = ComputeMinimumNumberOfPlates(0.5 * numberOfLaps, numberOfPlates);
    int for60 = ComputeMinimumNumberOfPlates(0.6 * numberOfLaps, numberOfPlates);
    int for70 = ComputeMinimumNumberOfPlates(0.7 * numberOfLaps, numberOfPlates);
    int for80 = ComputeMinimumNumberOfPlates(0.8 * numberOfLaps, numberOfPlates);
    int for90 = ComputeMinimumNumberOfPlates(0.9 * numberOfLaps, numberOfPlates);

    Console.Write($"{for10} {for20} {for30} {for40} {for50} {for60} {for70} {for80} {for90}");
  }

  static int ComputeMinimumNumberOfPlates(double laps, int plates)
  {
    return (int) Math.Ceiling(laps * plates);
  }
}