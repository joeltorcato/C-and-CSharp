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
    Console.Write("\n\nIntroduza uma frase: ");

    string? frase = Console.ReadLine(); // Reads text; null means no input is available.

    if (frase == null || frase == "") // Error
    {
      Console.WriteLine("Introduza apenas uma frase.\n\n");
      return; // Ends Main, stopping the program.
    }

    // Separates the sentence at spaces, keeping empty pieces.
    string[] palavras = frase.Split(' ', StringSplitOptions.None);

    /* 
    string[] palavras - Create an array.
    frase.Split() - Break it into smaller pieces, always that have a space ' '.
    StringSplitOption.None - Default behavior
    */

    for (int inicial = 0; inicial < palavras.Length; inicial++)
    {
      if (palavras[inicial] == "") // "" - Indicates a invalid space
      {
        Console.Write("Insira apenas um espaço entre palavras\n\n");
        return;
      }
    }

    // new string[palavras.Lenght] - Reserves enough positions even if every word is different. 
    string[] unicas = new string[palavras.Length];

    int[] ordem = new int[palavras.Length];

    int questidadeUnicas = 0; // Counter

    for (int inicial = 0; inicial < palavras.Length; inicial++) // Steps through in palavras array one by one.
    {
      int indice = -1; // -1 means "not found"; valid indexes start at 0.

      for (int j = 0; j < questidadeUnicas; j++) // Checks the unicas array.
      {
        if (unicas[j] == palavras[inicial]) // Compares the words' text.
        {
          indice = j; // Remebers the existing word's index
          break;
        }
      }

      if (indice == -1) // Runs only if the inner loop did not find the word.
      {
        unicas[questidadeUnicas] = palavras[inicial]; // Stores the new word
        indice = questidadeUnicas;
        questidadeUnicas++;
      }

      ordem[inicial] = indice; // Enocdes the word at original position i.
    }

    // Replaces the array with one containing only its populated entries (removing all the leftover empty null slots at the end).
    Array.Resize(ref unicas, questidadeUnicas); // Array Resize(ref array, newSize)

    // Removes all references from the tomporary original-order word array.
    Array.Clear(palavras, 0, palavras.Length); // Array.Clear(array, index, lenght);

    frase = "";

    Console.WriteLine("\nPalavras unicas: ");

    for (int inicial = 0; inicial < unicas.Length; inicial++)
    {
      Console.WriteLine("{0}: {1}", inicial, unicas[inicial]);
    }

    Console.WriteLine("\nIndices guardados: ");

    for (int inicial = 0; inicial < ordem.Length; inicial++)
    {
      Console.Write(" {0}", ordem[inicial]);
    }

    Console.WriteLine(); // Ends the output line.

    for (int inicial = 0; inicial < ordem.Length; inicial++)
    {
      if (inicial > 0) // Every word except the first needs a preceding space
      {
        frase = frase + " ";
      }

      frase = frase + unicas[ordem[inicial]];
    }
    Console.WriteLine("\nFrase reconstruida: {0}\n\n", frase);
  }
}