﻿public class Generator
{
    public void Run()
    {
        Console.WriteLine("Welcome to Name Generator App.");

        var name = NameCollection.GetNameByFirstLetter('o');
        Console.WriteLine(name);

        var nameBySex = NameCollection.GetNameBySex(IName.SexEnum.None);
        Console.WriteLine(nameBySex);

        var nameByLength = NameCollection.GetNameByLength(5);
        Console.WriteLine(nameByLength);

        Console.ReadKey();
    }
}