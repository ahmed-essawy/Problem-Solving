#include <cmath>
#include <iostream>
using namespace std;

int main() {
	double mealCost;
	int tipPercent, taxPercent;
	cin >> mealCost >> tipPercent >> taxPercent;
	cout << "The total meal cost is " << round(mealCost + (mealCost*tipPercent / 100) + (mealCost*taxPercent / 100)) << " dollars.";
	return 0;
}