#include <stdio.h>
#include <string.h>

int main(void)
{
  char texto[] = "sol lua mar";

  char *parte = strtok(texto, " ");
  printf("%s\n", parte);

  parte = strtok(NULL, " ");
  printf("%s\n", parte);

  parte = strtok(NULL, " ");
  printf("%s\n", parte);

  parte = strtok(NULL, " ");
  printf("No more words: %d\n", parte == NULL);

  return 0;
}