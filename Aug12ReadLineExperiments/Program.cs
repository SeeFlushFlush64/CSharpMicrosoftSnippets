int length = ReadDimension("Enter length: ");
int width = ReadDimension("Enter width: ");
Console.WriteLine($"Length: {length}\nWidth: {width}");

int ReadDimension(string message) {
    try{
        Console.Write(message);
        int dimension = Convert.ToInt16(Console.ReadLine());
        return dimension;
    }
    catch (Exception ex){
        Console.WriteLine($"Error: {ex}");
        return 0;
    }
}