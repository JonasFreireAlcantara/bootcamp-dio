using System;

class IdadeEmDias
{
  public static void Run() {
    var idadeEmDias = int.Parse(Console.ReadLine());
    
    var anos = idadeEmDias / 365; // Implemente aqui o calculo dos anos
    idadeEmDias = idadeEmDias % 365;

    var meses = idadeEmDias / 30; // Implemente aqui o calculo dos meses
    idadeEmDias = idadeEmDias % 30;

    var dias =  idadeEmDias; // Implemente aqui o calculo dos dias

    Console.WriteLine($"{anos} ano(s)\n{meses} mes(es)\n{dias} dia(s)");
  }
}