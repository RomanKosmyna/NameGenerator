public class Generator
{
    public void Run()
    {
        Console.WriteLine("Welcome to Name Generator App.");

        var name = NameCollection.GetNameByFirstLetter('o');
        Console.WriteLine(name);
        Console.ReadKey();
    }
}