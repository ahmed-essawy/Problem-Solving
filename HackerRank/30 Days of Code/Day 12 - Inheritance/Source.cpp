#include <iostream>
#include <vector>
#include <string>

using namespace std;

class Person {
protected:
	string firstName;
	string lastName;
	int id;
public:
	Person(string firstName, string lastName, int identification) {
		this->firstName = firstName;
		this->lastName = lastName;
		this->id = identification;
	}
	void printPerson() {
		cout << "Name: " << lastName << ", " << firstName << "\nID: " << id << "\n";
	}
};
class Student : public Person {
private:
	vector<int> testScores;
public:
	Student(string firstName, string lastName, int identification, vector<int> scores) :Person(firstName, lastName, identification)
	{
		testScores = scores;
	}
	char calculate()
	{
		int sum = 0;
		for (int i = 0; i < testScores.size(); ++i)
			sum += testScores[i];
		double avg = sum / testScores.size();
		char c;
		if (avg < 40)
			c = 'T';
		else if (avg >= 40 && avg < 55)
			c = 'D';
		else if (avg >= 55 && avg < 70)
			c = 'P';
		else if (avg >= 70 && avg < 80)
			c = 'A';
		else if (avg >= 80 && avg < 90)
			c = 'E';
		else if (avg >= 90 && avg <= 100)
			c = 'O';
		return c;
	}
};
int main() {
	string firstName;
	string lastName;
	int id;
	int numScores;
	cin >> firstName >> lastName >> id >> numScores;
	vector<int> scores;
	for (int i = 0; i < numScores; i++) {
		int tmpScore;
		cin >> tmpScore;
		scores.push_back(tmpScore);
	}
	Student* s = new Student(firstName, lastName, id, scores);
	s->printPerson();
	cout << "Grade: " << s->calculate() << "\n";
	return 0;
}