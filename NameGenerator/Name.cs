using static IName;

public class Name : IName
{
    private readonly string _name;

    public SexEnum Sex { get; set; }
    public int NumberOfLetters { get; set; }
    public string GetName { get { return _name; } }

    public Name(string name, SexEnum sex = SexEnum.None)
    {
        _name = name;
        Sex = sex;
    }
}