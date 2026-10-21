public class Robot
{
    public static List<string> SavedNames = new();
    public static Random random = new Random();
    private string _name;
    public string Name
    {
        get
        {
            if (_name == null)
            {
                while (true)
                {
                    char letter1 = (char)random.Next('A', 'Z' + 1);
                    char letter2 = (char)random.Next('A', 'Z' + 1);
                    int number = random.Next(0, 1000);
                    string a = $"{letter1}{letter2}{number:D3}";

                    if (!SavedNames.Contains(a))
                    {
                        SavedNames.Add(a);
                        _name = a;
                        break;
                    }
                }

            }
            return _name;
        }
    }

    public void Reset()
    {
        _name = null;
    }
}