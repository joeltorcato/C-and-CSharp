using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducao_Programacao.November;

class Exercício_1
{
  static void Main(string[] args)
  {
    int a = 0;
    int e = 0;
    int i = 0;
    int o = 0;
    int u = 0;

    Console.Write("\nInsira uma frase: ");

    string frase = Console.ReadLine();
    int length = frase.Length;

    for (int inicial = 0; inicial < length; inicial++)
    {
      if (frase[inicial] == 'a' || frase[inicial] == 'A')
      {
        a++;
      }
      else if (frase[inicial] == 'e' || frase[inicial] == 'E')
      {
        e++;
      }
      else if (frase[inicial] == 'i' || frase[inicial] == 'I')
      {
        i++;
      }
      else if (frase[inicial] == 'o' || frase[inicial] == 'O')
      {
        o++;
      }
      else if (frase[inicial] == 'u' || frase[inicial] == 'U')
      {
        u++;
      }
    }

    Console.Write($"\nOcorrências da Vogal a: {a}\n");
    Console.Write($"Ocorrências da Vogal e: {e}\n");
    Console.Write($"Ocorrências da Vogal i: {i}\n");
    Console.Write($"Ocorrências da Vogal o: {o}\n");
    Console.Write($"Ocorrências da Vogal u: {u}\n\n");
  }
}