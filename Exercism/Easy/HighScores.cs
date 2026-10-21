public class HighScores
{
    private List<int> _scores;
    public HighScores(List<int> list)
    {
        _scores = list;
    }

    public List<int> Scores()
    {
        return _scores;
    }

    public int Latest()
    {
        return _scores.Last();
    }

    public int PersonalBest()
    {
        return _scores.Max(x => x);
    }

    public List<int> PersonalTopThree()
    {
        return _scores.OrderByDescending(x => x).Take(3).ToList();
    }
}