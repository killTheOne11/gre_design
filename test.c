#include<stdio.h>
#include<windows.h>

int update(int a)
{
	int b = a + 10;
	return b;
}

int add(int a, int b)
{
	int c = a + b;
	int d = update(c);
	return d;
}

int main()
{
	int a = 10;
	int b = 20;
	int c = add(a,b);
	printf("Function C is %d",c );
	return 0;
}