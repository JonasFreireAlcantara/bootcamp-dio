using System;

class CardapioAereo {
  public static void Run()
  {
    string[] line = Console.ReadLine().Split(" ");
    int availablePizza = int.Parse(line[0]);
    int availableSalad = int.Parse(line[1]);
    int availablePasta = int.Parse(line[2]);

    line = Console.ReadLine().Split(" ");
    int desiredPizza = int.Parse(line[0]);
    int desiredSalad = int.Parse(line[1]);
    int desiredPasta = int.Parse(line[2]);

    int withoutPizza = (desiredPizza > availablePizza) ? desiredPizza - availablePizza : 0;
    int withoutSalad = (desiredSalad > availableSalad) ? desiredSalad - availableSalad : 0;
    int withoutPasta = (desiredPasta > availablePasta) ? desiredPasta - availablePasta : 0;

    int total = withoutPizza + withoutSalad + withoutPasta;

    Console.WriteLine(total);
  }
}