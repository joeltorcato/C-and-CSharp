#include <stdio.h>
#include <string.h>

int main(void)
{
  char primeira[] = "ola\n";
  char segunda[] = "ola";

  printf("With newline: %zu\n", strcspn(primeira, "\n"));   // 3 (conta antes de encontrar)
  printf("Without newline: %zu\n", strcspn(segunda, "\n")); // 3

  printf("With newline: %zu\n", strlen(primeira));   // 4
  printf("Without newline: %zu\n", strlen(segunda)); // 3
}