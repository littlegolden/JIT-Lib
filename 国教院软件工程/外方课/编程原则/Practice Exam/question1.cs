/*
 * (a)
 */
public static bool IsLeapYear(int year){
	if(year % 4 == 0 && year % 100 != 0 ||year % 400 == 0 ){
		return true;
	} else {
		return false;
	}
}


/*
 * (b)
 * (i) 1. check if the array elements are in ascending sorted order
 *     2. check if the array elememts are in descending sorted order
 *     3. if the array elements are neither in descending sorted order or in ascending sorted order, the array elements are not sorted
 */

//(ii)
public static bool IsArraySorted(int[] numbers){
	bool isAscending = true;
	bool isDescending = true;
	int lastNumber = numbers[0];

	if(numbers.Length < 3){
		return true;
	}

	for(int i = 1; i < numbers.Length; i++){
		if(lastNumber > numbers[i]){
			isAscending = false;
			break;
		}
		lastNumber = numbers[i];
	}

	lastNumber = numbers[0];
	for(int i = 1; i < numbers.Length; i++){
		if(lastNumber < numbers[i]){
			isDescending = false;
			break;
		}
		lastNumber = numbers[i];
	}

	if(isAscending || isDescending){
		return true;
	} else {
		return false;
	}

}
