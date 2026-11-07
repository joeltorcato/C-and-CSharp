#include <stdio.h>
#include <string.h>

int main(void)
{
  char texto[20] = "bom dia";

  printf("Array size: %zu\n", sizeof texto);     // 20
  printf("String length: %zu\n", strlen(texto)); // 7
}