#include <stdio.h>

int AddTwoNumb(int a, int b);
void Greet(char *name);

int main(int argsc, char *argv[]) {
  Greet("Suhaib");
  printf("Adding two number %d\n", AddTwoNumb(4, 5));
  return 0;
}
