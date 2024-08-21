Random gradeGenerator = new Random();
// string student1 = "Michael";
// string student2 = "Owen";
// string student3 = "Daniell";
// string student4 = "Jimwell";
string[] students = {"Michael", "Owen", "Daniell", "Jimwell"};
string[] duplicated = students;

//LONGER VERSION
// foreach(string student in students) {
//     if(student == "Michael") {
//         int[] michaelGrades = new int[5];
//         for(int i = 0; i < 5; i++) {
//             michaelGrades[i] = gradeGenerator.Next(1, 101);

//         }
//         foreach(int grade in michaelGrades) {
//             Console.WriteLine($"Michael: {grade} ");
//         }
//         Console.WriteLine();
//     }
//     else if(student == "Owen") {
//         int[] owenGrades = new int[5];
//         for(int i = 0; i < 5; i++) {
//             owenGrades[i] = gradeGenerator.Next(1, 101);

//         }
//         foreach(int grade in owenGrades) {
//             Console.WriteLine($"Owen: {grade} ");
//         }
//         Console.WriteLine();
//     }
//     else if(student == "Daniell") {
//         int[] daniellGrades = new int[5];
//         for(int i = 0; i < 5; i++) {
//             daniellGrades[i] = gradeGenerator.Next(1, 101);
    
//         }
//         foreach(int grade in daniellGrades) {
//             Console.WriteLine($"Daniell: {grade} ");
//         }
//         Console.WriteLine();
//     }
//     else if(student == "Jimwell") {
//         int[] jimwellGrades = new int[5];
//         for(int i = 0; i < 5; i++) {
//             jimwellGrades[i] = gradeGenerator.Next(1, 101);

//         }
//         foreach(int grade in jimwellGrades) {
//             Console.WriteLine($"Jimwell: {grade} ");
//         }
//         Console.WriteLine();
//     }
// }

// SHORTER VERSION
Console.WriteLine("Student\t\tGrade");
Console.WriteLine();
foreach(string student in students) {
    int[] studentGrades = new int[5];
    int gradeSum = 0;
    decimal gradeAverage = 0m;
    int currentAssignments = 5;
    for(int i = 0; i < 5; i++) {
        studentGrades[i] = gradeGenerator.Next(1, 101);

        gradeSum += studentGrades[i];
        // Console.WriteLine($"{student}: {studentGrades[i]}");
    }
    gradeAverage = (decimal) gradeSum / currentAssignments; // Convert
    
    Console.Write($"{student.PadRight(10, ' ')}\t");
    Console.Write($"{Convert.ToInt16(gradeAverage)}.{Convert.ToInt16((gradeAverage * 10) % 10)}{Convert.ToInt16((gradeAverage * 100) % 10)}\t\t");
    if (gradeAverage >= 97) {
        Console.WriteLine("A+");
    }
    else if (gradeAverage >= 93 && gradeAverage <= 96) {
        Console.WriteLine("A");
    }
    else if (gradeAverage >= 90 && gradeAverage <= 92) {
        Console.WriteLine("A-");
    }
    else if (gradeAverage >= 87 && gradeAverage <= 89) {
        Console.WriteLine("B+");
    }
    else if (gradeAverage >= 83 && gradeAverage <= 86) {
        Console.WriteLine("B");
    }
    else if (gradeAverage >= 80 && gradeAverage <= 82) {
        Console.WriteLine("B-");
    }
    else if (gradeAverage >= 77 && gradeAverage <= 79) {
        Console.WriteLine("C+");
    }
    else if (gradeAverage >= 73 && gradeAverage <= 76) {
        Console.WriteLine("C");
    }
    else if (gradeAverage >= 70 && gradeAverage <= 72) {
        Console.WriteLine("C-");
    }
    else if (gradeAverage >= 67 && gradeAverage <= 69) {
        Console.WriteLine("D+");
    }
    else if (gradeAverage >= 63 && gradeAverage <= 66) {
        Console.WriteLine("D");
    }
    else if (gradeAverage >= 60 && gradeAverage <= 62) {
        Console.WriteLine("D-");
    }
    else if (gradeAverage >= 0 && gradeAverage <= 59) {
        Console.WriteLine("F");
    }
    // Console.WriteLine($"{student.PadRight(10, ' ')} {Convert.ToInt16(gradeAverage)}.{Convert.ToInt16((gradeAverage * 10) % 10)}{Convert.ToInt16((gradeAverage * 100) % 10)}");
    // Console.WriteLine($"{student.PadRight(10, ' ')} {Convert.ToString(gradeAverage).PadRight('0')}");
    if(student == "Michael") {
        int[] michaelGrades = new int[5];
        michaelGrades = studentGrades;
        // int michaelAverage = gradeAverage;
    }
    if(student == "Owen") {
        int[] owenGrades = new int[5];
        owenGrades = studentGrades;
        // int michaelAverage = gradeAverage;
    }
    if(student == "Daniell") {
        int[] daniellGrades = new int[5];
        daniellGrades = studentGrades;
        // int michaelAverage = gradeAverage;
    }
    else if(student == "Jimwell") {
        int[] jimwellGrades = new int[5];
        jimwellGrades = studentGrades;
        // int michaelAverage = gradeAverage;
    }
    
}
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
//SWITCH CASE
// foreach(string student in students) {
//     int[] studentGrades = new int[5];
//     for(int i = 0; i < 5; i++) {
//         studentGrades[i] = gradeGenerator.Next(1, 101);
//         Console.WriteLine($"{student}: {studentGrades[i]}");
//     }
//     switch(student) {
//         case "Michael":
//             int[] michaelGrades = new int[5];
//             michaelGrades = studentGrades;
//             break;
//         case "Owen":
//             int[] owenGrades = new int[5];
//             owenGrades = studentGrades;
//             break;
//         case "Daniell":
//             int[] daniellGrades = new int[5];
//             daniellGrades = studentGrades;
//             break;
//         case "Jimwell":
//             int[] jimwellGrades = new int[5];
//             jimwellGrades = studentGrades;
//             break;
//         default:
//             Console.WriteLine("Dapat ende ako maghello");
//             break;
//     }
//     Console.WriteLine();
// }