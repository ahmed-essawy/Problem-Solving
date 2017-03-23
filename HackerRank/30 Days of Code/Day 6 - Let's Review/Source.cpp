#include <vector>
#include <iostream>
#include <string>
using namespace std;

int main() {
	int T;
	cin >> T;
	vector<string> strings(T);
	for (int i = 0; i < T; i++)
		cin >> strings[i];
	for (int i = 0; i < T; i++)
	{
		for (int j = 0; j < strings[i].length(); j += 2)
			cout << strings[i][j];
		cout << " ";
		for (int j = 1; j < strings[i].length(); j += 2)
			cout << strings[i][j];
		cout << endl;
	}
	return 0;
}