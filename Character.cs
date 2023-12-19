using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Character
{
    // Visual Stats
    public string Name { get; set; }
    public int Level { get; set; }
    public string HairColor { get; set; }
    public string EyeColor { get; set; }

    // Attributes
    public int Strength { get; set; }
    public int Agility { get; set; }


    // Energy
    private int energy;
    public int Energy
    {
        get { return energy; }
        set { energy = Math.Max(0, Math.Min(value, MaxEnergy)); }
    }

    public int MaxEnergy { get; set; }

    // Items
    public List<string> Inventory { get; set; }

    // Constructor
    public Character(string name, int level, string hairColor, string eyeColor, int maxEnergy, int strength, int agility)
    {
        Name = name;
        Level = level;
        HairColor = hairColor;
        EyeColor = eyeColor;
        MaxEnergy = maxEnergy;
        Energy = MaxEnergy; // Start with full energy
        Strength = strength;
        Agility = agility;
        Inventory = new List<string>();
    }

    // Method to display character information
    public void DisplayCharacterInfo()
    {
        SetConsoleColor(ConsoleColor.Cyan);
        Console.WriteLine("===== CHARACTER INFO =====");
        ResetConsoleColor();

        SetConsoleColor(ConsoleColor.Cyan);
        Console.WriteLine($"Name: {Name}");
        ResetConsoleColor();

        SetConsoleColor(ConsoleColor.Yellow);
        Console.WriteLine($"Level: {Level}");
        ResetConsoleColor();

        SetConsoleColor(ConsoleColor.Magenta);
        Console.WriteLine($"Hair Color: {HairColor}");
        ResetConsoleColor();

        SetConsoleColor(ConsoleColor.Blue);
        Console.WriteLine($"Eye Color: {EyeColor}");
        ResetConsoleColor();

        SetConsoleColor(ConsoleColor.Red);
        Console.WriteLine($"Strength: {Strength}");
        ResetConsoleColor();

        SetConsoleColor(ConsoleColor.Green);
        Console.WriteLine($"Agility: {Agility}");
        ResetConsoleColor();

        SetConsoleColor(ConsoleColor.Green);
        Console.WriteLine($"Energy: {Energy}/{MaxEnergy}");
        ResetConsoleColor();

        Console.WriteLine(@"
                                                           
                                                                         {}
                                                                        {{}}
                                                                        {{}}
                                                                         {}
                                                                       .-''-.
                                                                      /  __  \
                                                                     /.-'  '-.\
                                                                     \::.  .::/
                                                                      \'    '/
                                                                 __ ___)    (___ __
                                                               .'   \\        //   `.
                                                              /     | '-.__.-' |     \
                                                              |     |  '::::'  |     |
                                                              |    /    '::'    \    |
                                                              |_.-;\     __     /;-._|
                                                              \.'^`\\    \/    //`^'./
                                                              /   _.-._ _||_ _.-._   \
                                                             `\___\    '-..-'    /___/`
                                                                  /'---.  `\.---'\
                                                                 ||    |`\\\|    ||
                                                                 ||    | || |    ||
                                                                 |;.__.' || '.__.;|
                                                                 |       ||       |
                                                                 {{{{{{{{||}}}}}}}}
                                                                  |      ||      |
                                                                  |.-==-.||.-==-.|
                                                                  <.    .||.    .>
                                                                   \'=='/||\'=='/
                                                                   |   / || \   |
                                                                   |   | || |   |
                                                                   |   | || |   |
                                                                   /^^\| || |/^^\
                                                                  /   .' || '.   \
                                                                 /   /   ||   \   \
                                                                (__.'    \/    '.__)                            ");
        

        

    }

    // Helper method to colorize text
    private string Colorize(string text, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        string coloredText = text;
        Console.ResetColor(); // Reset color to default
        return coloredText;
    }

    private void SetConsoleColor(ConsoleColor color)
    {
        Console.ForegroundColor = color;
    }

    // Helper method to reset console text color to default
    private void ResetConsoleColor()
    {
        Console.ResetColor();
    }
}