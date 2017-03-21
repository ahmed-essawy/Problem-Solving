#include <stdio.h>
using namespace std;

int main() {
	int v_int;
	long v_long;
	long long v_long_long;
	char v_char;
	float v_float;
	double v_double;
	scanf("%d %ld %lld %c %f %lf", &v_int, &v_long, &v_long_long, &v_char, &v_float, &v_double);
	printf("%d\n%ld\n%lld\n%c\n%f\n%lf", v_int, v_long, v_long_long, v_char, v_float, v_double);
	return 0;
}