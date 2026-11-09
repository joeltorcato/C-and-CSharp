using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducao_Programacao.November;

int maiorVinte(float numeros, int quantidade)
{

}

class Exercício_2
{
  static void Main(string[] args)
  {
    float[] numeros = new float[5];
    int final = 5;

    for (int inicial = 0; inicial < final; inicial++)
    {
      Console.Write("Insira o {0} valor: ", inicial + 1);
      numeros[inicial] = float.Parse(Console.ReadLine()); //

    }


  }
}