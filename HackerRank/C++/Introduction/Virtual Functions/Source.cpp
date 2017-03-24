#include <cmath>
#include <cstdio>
#include <vector>
#include <string>
#include <iostream>
#include <algorithm>
using namespace std;

class Person
{
protected:
	string name;
	int age;
public:
	virtual void getdata() = 0;
	virtual void putdata() = 0;
};

class Professor : public Person
{
	int publications, cur_id;
	static int id;
public:
	Professor()
	{
		cur_id = ++id;
	}
	void getdata()
	{
		cin >> name;
		cin >> age;
		cin >> publications;
	}
	void putdata()
	{
		cout << name << " ";
		cout << age << " ";
		cout << publications << " ";
		cout << cur_id << endl;
	}
};
class Student :public Person
{
	int marks[6], cur_id;
	static int id;
public:
	Student()
	{
		cur_id = ++id;
	}
	void getdata()
	{
		cin >> name;
		cin >> age;
		for (int i = 0; i < 6; i++)
			cin >> marks[i];
	}
	void putdata()
	{
		cout << name << " ";
		cout << age << " ";
		int sum = 0;
		for (int i = 0; i < 6; i++)
			sum += marks[i];
		cout << sum << " ";
		cout << cur_id << endl;
	}
};
int Professor::id = 0;
int Student::id = 0;

int main() {
	int n, val;
	cin >> n; //The number of objects that is going to be created.
	Person *per[n];

	for (int i = 0; i < n; i++) {
		cin >> val;
		if (val == 1) {
			// If val is 1 current object is of type Professor
			per[i] = new Professor;
		}
		else per[i] = new Student; // Else the current object is of type Student

		per[i]->getdata(); // Get the data from the user.
	}

	for (int i = 0; i < n; i++)
		per[i]->putdata(); // Print the required output for each object.
	cin >> n;
	return 0;
}