#include <iostream>
using namespace std;

int factorial(int num)
{
	if (num > 1)
		num *= factorial(num - 1);
	return num;
}

int main() {
	int N;
	cin >> N;
	cout << factorial(N);
	return 0;
}