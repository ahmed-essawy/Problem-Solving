#include <iostream>
#include <string>

using namespace std;

string tobinary(int num)
{
	string binary;
	if (num)
		binary += tobinary(num / 2) + to_string(num % 2);
	return binary;
}

int main() {
	int n, counter = 0, maxCount = 0;
	cin >> n;
	string binary = tobinary(n);
	for (int i = 0; i < binary.length(); ++i)
	{
		if (binary[i] == '1')
		{
			++counter;
			if (counter > maxCount)
				maxCount = counter;
		}
		else
			counter = 0;
	}
	cout << maxCount;
	return 0;
}