List<int> scores = [1, 2, 3, 4, 5];
IEnumerable<int> scoreEnumerable = 
    from score in scores
    where score % 2 == 0
    select score;

Console.WriteLine("My Even Scores");
Console.WriteLine();
foreach (int score in scoreEnumerable) 
{
    Console.WriteLine($"{score} ");
}