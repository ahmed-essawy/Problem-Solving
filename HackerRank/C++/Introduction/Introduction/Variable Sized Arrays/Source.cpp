#include <vector>
#include <iostream>
using namespace std;

int main() {
	int i, j;
	cin >> i >> j;
	vector<vector<int>> arr(i + j);
	for (int x = 0; x < i; x++)
	{
		int first;
		cin >> first;
		arr[x].resize(first + 1);
		arr[x][0] = first;
		for (int y = 1; y < first + 1; y++)
			cin >> arr[x][y];
	}
	for (int x = i; x < i + j; x++)
	{
		arr[x].resize(2);
		for (int y = 0; y < 2; y++)
			cin >> arr[x][y];
	}
	for (int x = i; x < i + j; x++)
		cout << arr[arr[x][0]][arr[x][1] + 1] << endl;
	return 0;
}