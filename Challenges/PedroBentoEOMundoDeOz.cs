using System;
using System.Collections.Generic;

class PedroBentoEOMundoDeOz
{
  public static void Run()
  {
    HashSet<string> jewels = new HashSet<string>();

    while (true)
    {
      string jewel = Console.ReadLine();
      if (string.IsNullOrWhiteSpace(jewel))
      {
        break;
      }

      jewels.Add(jewel);
    }

    Console.WriteLine(jewels.Count);
  }
}