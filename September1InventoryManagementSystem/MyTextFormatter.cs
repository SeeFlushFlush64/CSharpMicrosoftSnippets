using System;
using System.Text;
namespace MyTextFormatter
{
    public static class TextFormatter
    {
        // Wraps the text description based on a specified width
        public static string WrapText(string text, int maxLineLength = 80)
        {
            if (string.IsNullOrWhiteSpace(text)) return text;

            StringBuilder wrappedText = new StringBuilder();
            string[] words = text.Split(' ');

            int currentLineLength = 0;

            foreach (var word in words)
            {
                // Check if adding the next word exceeds the line length
                if (currentLineLength + word.Length + 1 > maxLineLength)
                {
                    wrappedText.AppendLine();
                    currentLineLength = 0;
                }

                // Add a space before the word if not at the start of the line
                if (currentLineLength > 0)
                {
                    wrappedText.Append(' ');
                    currentLineLength++;
                }

                wrappedText.Append(word);
                currentLineLength += word.Length;
            }

            return wrappedText.ToString();
        }
    }

}
