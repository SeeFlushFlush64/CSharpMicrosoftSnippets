string originalMessage = "The quick brown fox jumps over the lazy dog.";
// convert the message into a char array
char[] message = originalMessage.ToCharArray();
// Reverse the chars
Array.Reverse(message);
int letterCount = 0;
// count the o's
foreach (char letter in message) {
    if (letter == 'o') {
        letterCount++;
    }
}
// convert it back to a string
string newMessage = new String(message);
// print it out
Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");