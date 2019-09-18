/*
 * (a)
 */
public void Swap(double[] array, int oneIndex, int otherIndex){
	double temp;
	temp = array[oneIndex];
	array[oneIndex] = array[otherIndex];
	array[otherIndex] = temp;
}

public void Reverse(double[] values, int start, int finish){
	while(start < finish){
		Swap(values, start, finish);
		start++;
		finish--;
	}
}


/*
 * (b)
 */
public static double CalculateGPA(int[][] grades) {
	int numberOfGrade = 0;
	double sumOfGrade = 0;
	foreach (int[] semester in grades){
		foreach (int exam in semester) {
			sumOfGrade += exam;
			numberOfGrade++;
		}
	}
	return sumOfGrade / numberOfGrade;
}
