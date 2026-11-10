using System;

namespace Introducao_Programacao.November;

class Exercício_2
{
  static int maiorVinte(float[] numeros, int quantidade) // I use static because Main use static.
  {
    int contador = 0;

    for (int inicial = 0; inicial < quantidade; inicial++)
    {
      if (numeros[inicial] > 20)
      {
        contador++;
      }
    }
    return contador;
  }
  static void Main(string[] args)
  {
    int final = 5;
    float[] numeros = new float[final];

    for (int inicial = 0; inicial < final; inicial++)
    {
      Console.Write("Insira o {0} valor: ", inicial + 1);
      numeros[inicial] = float.Parse(Console.ReadLine()); // float.Parse - Convers that text into a number
    }

    int resultado = maiorVinte(numeros, final);

    Console.Write("\nExistem {0} maiores de 20\n\n", resultado);
  }
}