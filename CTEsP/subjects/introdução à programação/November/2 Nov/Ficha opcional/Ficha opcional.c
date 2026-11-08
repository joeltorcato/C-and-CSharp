#include <stdio.h>
#include <string.h>

#define LIMITE 100 // 100 bytes

int main(void)
{
  char frase[LIMITE];
  char unicas[LIMITE][LIMITE];
  int ordem[LIMITE];
  int quantidadeUnicas = 0;
  int quantidadePalavras = 0;

  printf("Insira uma frase: ");

  if (fgets(frase, sizeof frase, stdin) == NULL)
  {
    return 1;
  }

  /*
  fgets - saves the text and the Enter
  sizeof - the buffer's size in bytes
  fgets - read at 99 characters and add \0, he read the spaces too.
  == NULL (null pointer constant) - checks for failuere
  */

  size_t comprimento = strcspn(frase, "\n"); // strcspn(where should we look, when we find this stop)

  /*
  size_t (a type)- is na unsigned integer type used for sizes and lenghts.
  The correct and safe way to store memory sizes in C (an integer that will never be negative)
  strcspn (String Complementary Span) - It iterates through the "phrase" tring from start to finish
  and counts the characters untir it finds the \n character
  */

  if (frase[comprimento] != '\n')
  {
    printf("Introduza ate 98 bytes e termine com Enter.\n");
    return 1;
  }

  /* 98 tet bytes + 1 newline + 1 terminator */

  frase[comprimento] = '\0'; // Substitute \n (Enter), avoid “123\n” != "123" errors

  /*
  Remove the newline
  \n - newline (character)
  \0 - end of a C string
  */

  for (int i = 0; frase[i] != '\0'; i++)
  {
    if (frase[i] == ' ' &&                                       // Beginning (frase[i] == ' ' && i == 0);
        (i == 0 || frase[i + 1] == ' ' || frase[i + 1] == '\0')) // Followd by another space (frase[i] == ' ' && frase[i + 1] == ' ' )
                                                                 // At the end, immediately before \0 (frase[i] == ' ' && frase[i + 1] == \0)
    {
      printf("Use apenas um espaco entre palavras.\n");
      return 1;
    }
  }

  /*
  The condition rejects a space when it is:
    - At the beginning
    - Follew by another space
    - At the end, immediately before \0
  */

  char *palavra = strtok(frase, " ");

  /*
  char * - declares a pointer to a character
  strtok - separates a string into tokens, pieces separated by specified delimiter
  characters. The delimiter here is a space
  */

  while (palavra != NULL) // continues as long as the pointer identifies a word
  {
    int indice = -1; // It begins searching for the word on the assumption that it will not be found

    for (int i = 0; i < quantidadeUnicas; i++)
    {
      if (strcmp(unicas[i], palavra) == 0) // strcmp (String Compare), if devolves 0, the strings are iquals.
      {
        indice = i; // Save the dictionry index
        break;
      }
    }

    if (indice == -1)
    {
      strcpy(unicas[quantidadeUnicas], palavra); // Copy the text of the current word to the next avaliable position in the unicas list
      indice = quantidadeUnicas;                 // Position that was just saves
      quantidadeUnicas++;
    }

    /*
    strcpy (destination, origin)
    */

    ordem[quantidadePalavras] = indice; // Store the exact position of the word (wheter it's new or a repeat) in an arry called ordem.
    quantidadePalavras++;

    palavra = strtok(NULL, " "); // Makes the program advance word by word (Continue processing the previous string from where you stopped)
  }

  printf("\nPalavras unicas:\n");
  /*
    Palavras unicas:
    0: eu
    1: gosto
    2: de
  */

  for (int i = 0; i < quantidadeUnicas; i++)
  {
    printf("%d: %s\n", i, unicas[i]);
  }

  printf("\nIndices guardados:"); // Indices guardados: 0 1 2 0

  for (int i = 0; i < quantidadePalavras; i++)
  {
    printf(" %d", ordem[i]);
  }

  printf("\n");

  memset(frase, 0, sizeof frase); // fills a specified number of bytes with a value (Clears the "phrase" variable filling it with 0)

  printf("\nString base destruida: \"%s\"\n", frase); // \ Protects the code \

  for (int i = 0; i < quantidadePalavras; i++)
  {
    if (i > 0) // The space is only added starting with the second word
    {
      strcat(frase, " "); // strcat - String Concatenate
    }

    strcat(frase, unicas[ordem[i]]); // strcat (destination, origin)
  }

  printf("\nFrase reconstruida: %s\n", frase);

  return 0;
}