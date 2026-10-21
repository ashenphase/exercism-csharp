public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        if (!sequence.All(n => "ACGT".Contains(n)) || sequence == "")
        {
            throw new ArgumentException("Cal");
        }

        Dictionary<char, int> result = new Dictionary<char, int> { };
        result.Add('A', sequence.Count('A'));
        result.Add('C', sequence.Count('C'));
        result.Add('G', sequence.Count('G'));
        result.Add('T', sequence.Count('T'));

        return result;
    }
}