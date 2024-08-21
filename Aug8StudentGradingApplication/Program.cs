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

//SHORTER VERSION
// foreach(string student in students) {
//     int[] studentGrades = new int[5];
    // for(int i = 0; i < 5; i++) {
    //     studentGrades[i] = gradeGenerator.Next(1, 101);
    //     Console.WriteLine($"{student}: {studentGrades[i]}");
    // }
//     if(student == "Michael") {
//         int[] michaelGrades = new int[5];
//         michaelGrades = studentGrades;
//     }
//     if(student == "Owen") {
//         int[] owenGrades = new int[5];
//         owenGrades = studentGrades;
//     }
//     if(student == "Daniell") {
//         int[] daniellGrades = new int[5];
//         daniellGrades = studentGrades;
//     }
//     else if(student == "Jimwell") {
//         int[] jimwellGrades = new int[5];
//         jimwellGrades = studentGrades;
//     }
//     Console.WriteLine();
// }

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