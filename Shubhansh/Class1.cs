using System;
public class myMainClass
{
    public static void Main()
    {
        DuplicateFinderLoop obj = new DuplicateFinderLoop();
        Console.WriteLine("Enter a string to find Duplicates: ");
        var inputString = Console.ReadLine();
        obj.findDuplicate(inputString);
        Console.ReadLine();
    }
}