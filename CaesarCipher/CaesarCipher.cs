using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            string output = "";
            foreach (char ch in text)
                output += CaesarCipherfunction(ch, shiftKey);
            return output;
            throw new NotImplementedException("You need to implement this function.");
        }

        public static char CaesarCipherfunction(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {

                return ch;
            }
            char CheckUpperorLower = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - CheckUpperorLower) % 26) + CheckUpperorLower);
        }
    }
}
