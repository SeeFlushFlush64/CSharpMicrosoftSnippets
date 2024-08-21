// string[] studentNames = {"Michael"};
// int[] michaelScores = {1, 2, 3, 4, 5};
// int numberOfAssignments = michaelScores.Length;
// foreach(string student in studentNames){
//    int[] assignmentScores = new int[numberOfAssignments];
//    int sumOfScores = 0;
//    float gradeAverage = 0f;
//    if(student == "Michael"){
//        assignmentScores = michaelScores;
//    }
//    foreach(int score in assignmentScores){
//        sumOfScores += score;
//    }
//    gradeAverage = (float) sumOfScores / numberOfAssignments;
//    Console.WriteLine($"{student.PadRight(10, ' ')} {gradeAverage}");
// }

int[] numbers = {
    1, 2, 3, 4, 5, 6
};

// Array.Clear(numbers, 2, 2);


// foreach(var number in numbers) {
//     Console.Write($"{number} ");
// }

// Console.Write("Enter number to search: ");
// int searchNumber = Convert.ToInt16(Console.ReadLine());
// int searchIndex = Array.IndexOf(numbers, searchNumber);
// Console.Write($"The number {searchNumber} is at {searchIndex}");

// Console.Write("Press 1 to proceed: ");
// int key = Console.Read();
// Console.WriteLine((char)key);
// if (key == 1) {
//     Console.WriteLine("*Proceeds");
// }
// else{
//     Console.WriteLine("Incorrect key press");
// }

// List<int> myNumbers = new List<int>();
// myNumbers.Add(2);
// myNumbers.Add(3);
// myNumbers.Add(4);
// foreach(int number in myNumbers) {
//     Console.Write($"{number} ");
// }
// myNumbers.Remove(3);
// Console.WriteLine();
// foreach(int number in myNumbers) {
//     Console.Write($"{number} ");
// }

// Create a new dictionary of strings, with string keys.
//
// List<int> myNumbersList = new List<int>() {1, 2, 3, 4, 5, 6};
// List<int> oddList = new List<int>();
// List<int> evenList = new List<int>();
// foreach (int myNumber in myNumbersList) {
//     // myNumber % 2 == 0 ? evenList.Add(myNumber) : oddList.Add(myNumber);
//     if(myNumber % 2 == 0) {
//         evenList.Add(myNumber);
//     }
//     else{
//         oddList.Add(myNumber);
//     }
// }
// Console.Write("Odd Numbers: ");
// foreach(int oddNum in oddList) {
//     Console.Write($"{oddNum} ");
// }
// Console.WriteLine();
// Console.Write("Even Numbers: ");
// foreach(int evenNum in evenList) {
//     Console.Write($"{evenNum} ");
// }

// string myString = "a";
// int myNum = 0;
// int.TryParse(myString, out myNum);
// Console.WriteLine(myNum);

// void HelloWorldDisplay() {
//     Console.WriteLine("Hello World");
// }
// string ReturnAString() {
//     return "Returned string";
// }
// void UnorderedArguments(string name, int age, string profession) {
//     Console.Write($"Name: {name}\nAge: {age}\nProfession: {profession}");
// }
// UnorderedArguments(profession: "Developer", name: "Michael", age: 22);

// HelloWorldDisplay();
// Console.WriteLine(ReturnAString());

int result;
bool success = TryMultiply(denominator: 40, numerator: 10, result: out result);
if(success){
    Console.WriteLine($"Product: {result}");
}
else{
    Console.WriteLine("Unsuccessful multiplication :(");
}
bool TryMultiply(int numerator, int denominator, out int result){
    if(denominator == 0) {
        result = 0;
        return false;
    }
    result = numerator * denominator;
    return true;
}