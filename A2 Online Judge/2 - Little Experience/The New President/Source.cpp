#include <iostream>
#include <string>

using namespace std;

int main() {
	int T;
	cin >> T;
	string strs[T][6];
	for (int i; i < T; i++)
	{
		string str;
		cin >> str;
		cout << T << str;
	}
	return 0;
}