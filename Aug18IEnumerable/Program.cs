List<int> myArray =  [1, 2, 3, 4, 5];

IEnumerable<int> myArrayEnum = myArray;
Console.WriteLine("My Array Elements");
Console.WriteLine();
foreach(int num in myArray)
{
    Console.Write($"{num} ");
}
myArray[0] = 41;
myArray.Add(60);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("My IEnumerable Elements");
Console.WriteLine();
foreach(int num in myArrayEnum)
{
    Console.Write($"{num} ");
}
Console.WriteLine();
Console.WriteLine($"The length of the IEnumerable: {myArrayEnum.Count()}");
