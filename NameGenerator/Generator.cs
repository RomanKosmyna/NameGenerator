using static System.Console;

public class Generator
{
    public static void Run()
    {
        WriteLine("Welcome to Name Generator App.");

        int userOption = GetUserInput();

        RenderOption(userOption);

        ReadKey();
    }

    public static int GetUserInput()
    {
        Write("\n");
        WriteLine("If you want to generate a name with a starting letter of your choice, press 1.");
        WriteLine("If you want to generate a name with a specific sex, press 2.");
        WriteLine("If you want to generate a name with a specific length, press 3.");

        try
        {
            int parsedUserInput = int.Parse(ReadLine());

            return parsedUserInput;
        }
        catch (FormatException ex)
        {
            WriteLine(ex.Message);
        }

        return 0;
    }

    public static void Result(string name)
    {
        if (name == null || name.Length == 0)
        {
            Write("\n");
            WriteLine("Generation failed :(");
            return;
        }

        Write("\n");
        WriteLine($"Generated name - {name}.");
    }

    public static void RenderOption(int option)
    {
        switch (option)
        {
            case 1:
                {
                    Write("Put your desired letter: ");
                    char input = char.Parse(ReadLine());
                    var name = NameCollection.GetNameByFirstLetter(input);
                    Result(name);
                    break;
                }
            case 2:
                {
                    Write("\n");
                    WriteLine("Available sex: Male, Female, None");
                    string input = ReadLine();

                    string name = "";

                    if (input == "Male")
                    {
                        name = NameCollection.GetNameBySex(IName.SexEnum.Male);
                    }
                    else if (input == "Female")
                    {
                        name = NameCollection.GetNameBySex(IName.SexEnum.Female);
                    }
                    else if (input == "None")
                    {
                        name = NameCollection.GetNameBySex(IName.SexEnum.None);
                    }

                    Result(name);
                    break;
                }
            case 3:
                {
                    Write("Put your desired length: ");
                    int input = int.Parse(ReadLine());
                    var name = NameCollection.GetNameByLength(input);
                    Result(name);
                    break;
                }
        }
    }
}