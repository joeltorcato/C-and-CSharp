#include <stdio.h>

int main(void)
{
  char nomes[2][8] = {"Eva", "Rui"};
  // [2] - Rows (Nomes), [8] - Máximo de Caracteres

  printf("First name: %s\n", nomes[0]); // %s - String completa (sequência de texto)
  printf("Second name: %s\n", nomes[1]);
  printf("One character: %c\n", nomes[0][2]); // %c - Um único caractre
}