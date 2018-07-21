namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            string output = "";
            foreach (char ch in text)
                if (char.IsLetter(ch))
                {
                    if (char.IsUpper(ch))
                    {
                        output += (char)((((ch + shiftKey) - 'A') % 26) + 'A');
                    }
                    else if (char.IsLower(ch))
                    {
                        output += (char)((((ch + shiftKey) - 'a') % 26) + 'a');
                    }
                }
                 else
                {
                    output += ch;
                }

            return output;
        }
    }
}
