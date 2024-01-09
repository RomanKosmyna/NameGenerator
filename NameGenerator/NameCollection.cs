using static IName;

public class NameCollection
{
    private static List<Name> _names =
        [
            new Name("Anna", SexEnum.Female),
            new Name("Alex", SexEnum.Male),
            new Name("Roki", SexEnum.None),
            new Name("Oleg", SexEnum.Male),
            new Name("Smeevil", SexEnum.Male),
            new Name("John", SexEnum.Male),
            new Name("Olena", SexEnum.Female),
            new Name("Ozder", SexEnum.None),
            new Name("Frogler", SexEnum.None),
            new Name("Naix", SexEnum.None),
            new Name("Skuns", SexEnum.None),
            new Name("Squeaker", SexEnum.None),
            new Name("Zod", SexEnum.Male),
        ];

    public static string? GetNameByFirstLetter(char letter)
    {
        List<Name> sortedNamesByLetter = [];

        foreach (var name in _names)
        {
            if (name.GetName.Length > 0 && char.ToUpper(name.GetName[0]) == char.ToUpper(letter))
            {
                sortedNamesByLetter.Add(name);
            }
        }

        if (sortedNamesByLetter.Count == 0)
        {
            return null;
        }

        int randomNumber = new Random().Next(0, sortedNamesByLetter.Count);

        string randomName = sortedNamesByLetter[randomNumber].GetName;

        return randomName;
    }

    public static string? GetNameBySex(SexEnum sex)
    {
        List<Name> sortedNamesBySex = [];

        foreach (var name in _names)
        {
            if (name.Sex == sex)
            {
                sortedNamesBySex.Add(name);
            }
        }

        if (sortedNamesBySex.Count == 0)
        {
            return null;
        }

        int randomNumber = new Random().Next(0, sortedNamesBySex.Count);

        string randomName = sortedNamesBySex[randomNumber].GetName;

        return randomName;
    }

    public static string? GetNameByLength(int length)
    {
        List<Name> sortedNamesByLength = [];

        foreach (var name in _names)
        {
            if (name.GetName.Length == length)
            {
                sortedNamesByLength.Add(name);
            }
        }

        if (sortedNamesByLength.Count == 0)
        {
            return null;
        }

        int randomNumber = new Random().Next(0, sortedNamesByLength.Count);

        string randomName = sortedNamesByLength[randomNumber].GetName;

        return randomName;
    }
}