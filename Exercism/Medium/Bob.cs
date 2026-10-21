public static class Bob
{
    private const string Question = "Sure.";
    private const string ScreamQuestion = "Calm down, I know what I'm doing!";
    private const string Scream = "Whoa, chill out!";
    private const string Silence = "Fine. Be that way!";
    private const string Else = "Whatever.";
    public static string Response(string statement)
    {
        if (statement.IsWhiteSpace() || statement == null)
            return Silence;

        bool question = statement.Trim().EndsWith('?');

        if (statement.Any(n => char.IsLetter(n)))
        {
            bool scream = !statement.Any(n => char.IsLower(n));

            if (question && scream)
                return ScreamQuestion;
            else if (scream)
                return Scream;
        }
        if (question)
            return Question;
        return Else;
    }
}