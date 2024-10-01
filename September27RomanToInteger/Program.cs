using System;
namespace September27RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(RomanToInt("MMDCXLI"));
            
        }
        private static int RomanToInt(string s) {
            char[] romanArray = s.ToCharArray();
            Dictionary<char, int> romanReference = new Dictionary<char, int>();
            romanReference.Add('I', 1);
            romanReference.Add('V', 5);
            romanReference.Add('X', 10);
            romanReference.Add('L', 50);
            romanReference.Add('C', 100);
            romanReference.Add('D', 500);
            romanReference.Add('M', 1000);
            int increments = 1;
            int integerValue = 0;
            //MMDCXLI
            for (int i = 0; i < romanArray.Length; i+= increments)
            {
                if (i == romanArray.Length - 1)
                {
                    integerValue += romanReference[romanArray[i]];
                    break;
                }
                integerValue += romanReference[romanArray[i]] < romanReference[romanArray[i + 1]] ? romanReference[romanArray[i + 1]] - romanReference[romanArray[i]] : romanReference[romanArray[i]] ;
                increments = romanReference[romanArray[i]] < romanReference[romanArray[i + 1]] ? 2 : 1;
            }
            return integerValue;
        }
    }
}