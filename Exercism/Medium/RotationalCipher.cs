using System.Text;
public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        if (shiftKey == 0 || shiftKey == 26) return text;

        StringBuilder result = new StringBuilder();
        int baseC = 0;
        foreach (char s in text)
        {
            if (!char.IsLetter(s))
            {
                result.Append(s);
                continue;
            }

            if (char.IsLower(s))
            {
                baseC = 'a';
            }
            else
            {
                baseC = 'A';
            }
            result.Append((char)(baseC + ((s - baseC + shiftKey) % 26)));
        }
        return result.ToString();
    }
}