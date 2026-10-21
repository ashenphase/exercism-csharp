public class GradeSchool
{
    private Dictionary<int, List<string>> _data = new Dictionary<int, List<string>>();
    private List<string> _students = new List<string>();

    public bool Add(string student, int grade)
    {
        if (_students.Contains(student)) return false;

        if (!_data.ContainsKey(grade))
        {
            _data.Add(grade, new List<string>());
        }
        _data[grade].Add(student);
        _students.Add(student);
        return true;
    }

    public IEnumerable<string> Roster()
    {
        List<string> result = new List<string>();

        for (int grade = 1; grade < 12; grade++)
        {
            if (_data.ContainsKey(grade))
            {
                result = result.Concat(_data[grade].OrderBy(n => n)).ToList();
            }
        }
        return result;
    }

    public IEnumerable<string> Grade(int grade)
    {
        if (!_data.ContainsKey(grade)) return new List<string>();
        return _data[grade].OrderBy(n => n);

    }
}