using System;

class UltrapassandoV
{
  public static void Run()
  {
    int R = int.Parse(Console.ReadLine());

    int V;
    do
    {
      V = int.Parse(Console.ReadLine());
    } while (V <= R);

    int counter = 1;
    for (int sum = R; sum <= V; sum += R)
    {
      counter++;
      R++;
    }

    Console.WriteLine(counter);
  }
}