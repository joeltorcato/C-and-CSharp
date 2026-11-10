using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducao_Programacao.November;

class Exercício_3
{

  static int valoresNegativos(int[,] valores, int linhas, int colunas) // Use int[,] valores not int[3,4] valores
  {
    int contador = 0;

    for (int linhasInicial = 0; linhasInicial < linhas; linhasInicial++)
    {
      for (int colunasInicial = 0; colunasInicial < colunas; colunasInicial++)
      {
        if (valores[linhasInicial, colunasInicial] < 0)
        {
          contador++;
        }
      }
    }
    return contador;
  }
  static void Main(string[] args)
  {
    int[,] valores = new int[3, 4];
    int linhas = 3;
    int colunas = 4;

    for (int linhasInicial = 0; linhasInicial < linhas; linhasInicial++)
    {
      for (int colunasInicial = 0; colunasInicial < colunas; colunasInicial++)
      {
        Console.Write("Insira o valor da linha {0} coluna {1}: ", linhasInicial, colunasInicial);
        valores[linhasInicial, colunasInicial] = int.Parse(Console.ReadLine());
      }
    }

    int resultado = valoresNegativos(valores, linhas, colunas);

    Console.Write("\nExistem {0} valores negativos\n\n", resultado);
  }
}