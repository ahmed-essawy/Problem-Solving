#include <iostream>
#include <string>
#include <map>
#include <vector>
using namespace std;

int main() {
	int N;
	cin >> N;
	map<string, long> phoneBook;
	for (int i = 0; i < N; ++i)
	{
		string name;
		cin >> name;
		cin >> phoneBook[name];
	}
	string name;
	while (cin >> name)
		if (phoneBook.count(name))
			cout << name << "=" << phoneBook[name] << endl;
		else
			cout << "Not found" << endl;
	return 0;
}