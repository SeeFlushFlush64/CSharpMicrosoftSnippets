try
{
    Console.Write("Enter a number: ");
    int num = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine(num);
}
catch (FormatException)
{
    Console.WriteLine("Please enter a number");
}
catch (OverflowException) 
{
    Console.WriteLine("Please enter a number less than 32767");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}