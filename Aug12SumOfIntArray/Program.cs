int[] numbers = new int[] {
    
};

int sum = 0;
bool success = SumOfArray(numbers, out sum);

if(success) {
    Console.WriteLine($"The sum of array elements: {sum}");
}
else {
    Console.WriteLine("Array does not have elements. Please try again.");
}

bool SumOfArray(int[] numbers, out int sum){
    if(numbers.Length == 0) {
        sum = 0;
        return false;
    }
    else{
        int runningSum = 0;
        for(int i = 0; i < numbers.Length; i++) {
            runningSum += numbers[i];
            Console.WriteLine(runningSum);
        }
        sum = runningSum;
        return true;
    }
}