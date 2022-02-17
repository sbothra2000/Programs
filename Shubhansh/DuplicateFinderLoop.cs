using System;
public class DuplicateFinderLoop
{
    internal void findDuplicate(string rcvdString)
    {
        var str = rcvdString.ToCharArray();
        int count = 0;
        Console.WriteLine("the duplicates in " + rcvdString + " are: ");
        for (int i = 0; i < str.Length; i++)
        {
            count = 0;
            for (int j = i + 1; j < str.Length; j++)
            {
                if (str[i] == str[j] && str[i] != ' ')
                {
                    count++;
                    str[j] = '`';
                }
            }
            if (count > 0 && str[i] != '`')
                Console.Write(str[i] + " ");
        }
    }
}