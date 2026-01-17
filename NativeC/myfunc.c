#include <stdio.h>

void Greet(char *name) { printf("Hello from shared library %s\n", name); }

int AddTwoNumb(int a, int b) { return a + b; }
