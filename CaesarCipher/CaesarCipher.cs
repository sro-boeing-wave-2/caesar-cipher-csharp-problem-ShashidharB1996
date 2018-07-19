using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            string output = string.Empty;

            foreach (char ch in text)
                output += Cipher(ch, shiftKey);

            return output;
            throw new NotImplementedException("You need to implement this function.");
        }

        public static char Cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }
            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }
    }
}
