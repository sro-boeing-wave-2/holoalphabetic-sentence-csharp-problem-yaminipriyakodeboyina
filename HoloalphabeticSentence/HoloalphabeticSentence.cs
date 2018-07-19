using System;
using System.Linq;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            alphabets = alphabets.ToUpper();
            for (int i = 0; i < alphabets.Length; i++)
            {
                if(input.ToUpper().Contains(alphabets[i]) && i==alphabets.Length-1)
                    return true;
                if (input.ToUpper().Contains(alphabets[i]) == false)
                    break;
            }
            return false;
        }
    }
}
