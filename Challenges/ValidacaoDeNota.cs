using System;

class ValidacaoDeNota
{
  public static void Run()
  {
    double average = 0.0;
    int numberOfValidGrades = 0;

    while (numberOfValidGrades < 2)
    {
      double grade = double.Parse(Console.ReadLine());
      if (IsValid(grade))
      {
        average += grade / 2;
        numberOfValidGrades++;
      }
      else
      {
        Console.WriteLine("nota invalida");
      }
    }

    Console.WriteLine($"media = {average.ToString("N2")}");
  }

  private static bool IsValid(double grade)
  {
    return (grade >= 0) && (grade <= 10);
  }
}