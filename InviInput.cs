using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

                                        //sir nag create rakog ani nga c
public class InputInvi
{
    public string Invi()
    {
        string input = "";
        ConsoleKeyInfo key;

        do
        {
            key = Console.ReadKey(true); // true prevents the key from being displayed
            if (key.Key != ConsoleKey.Enter)
            {
                input += key.KeyChar;
            }
        }
        while (key.Key != ConsoleKey.Enter);

        Console.WriteLine(); // Move to the next line after user presses Enter

        return input;

    }
}

