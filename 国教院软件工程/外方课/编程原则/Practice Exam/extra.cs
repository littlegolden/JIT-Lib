/*
 * (a)
 */

static bool NumberValid(int number){
	int sum = 0;
	int lengthOfNumber = 9;
	for(int i = 1; i <= lengthOfNumber; i++){
		sum += i * (number % 10);
		number /= 10;
	}

	if(sum % 11 == 0){
		return true;
	} else {
		return false;
	}
}
