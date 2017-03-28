#include <iostream>
#include <vector>
using namespace std;

int main() {
	vector<vector<int>> arr(6, vector<int>(6));
	int maxCount = -63;
	for (int i = 0; i < 6; ++i)
		for (int j = 0; j < 6; ++j)
			cin >> arr[i][j];
	for (int i = 1; i < 5; ++i)
		for (int j = 1; j < 5; ++j)
		{
			int tempCount = arr[i][j];
			tempCount += arr[i - 1][j - 1] + arr[i - 1][j] + arr[i - 1][j + 1];
			tempCount += arr[i + 1][j - 1] + arr[i + 1][j] + arr[i + 1][j + 1];
			if (tempCount > maxCount)
				maxCount = tempCount;
		}
	cout << maxCount;
	cin >> maxCount;
	return 0;
}