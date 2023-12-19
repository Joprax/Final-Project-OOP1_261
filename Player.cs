using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

interface GameData
{
    string GetName();
}


public class Player
{
    public static string Account = "Name";
    //static string accountFileName = "Account.csv";

    public static string Name {  get; set; }

    private int age;
    private int lives;
    private int money;
    private int hunger;
    private int level;

    public static List<string> Ending_Scenes { get; set; } = new List<string>();
    public static List<string> Achievements { get; set; }   




    public Dictionary<string, int> Stats;

    public List<CraftableItem> CraftableItems { get; set; }
    public List<Item> Inventory { get; set; }

    //public string Name { get { return name; } set { name = value; } }
    public int Age { get { return age; } set { age = value; } }
    public int Lives { get { return lives; } set { lives = value; } }
    public int Money { get { return money; } set { money = value; } }
    public int Hunger { get { return hunger; } set { hunger = value; } }
    public int Level { get { return level; } set { level = value; } }

    public Player(string name, int age)
    {
        //this.name = name;
        this.age = age;
        this.lives = 3;

        Money = 100;
        Hunger = 0;
        Stats = new Dictionary<string, int>
        {
            { "Strength", 0 }, // used when a character's physical strength is tested
            { "Agility", 0 },  //used when a character's physical speed and nimbleness is tested.
            {"Dexterity", 0 },
            {"Stamina", 0 },
            {"Endurance",0 },
            {"Crafting", 0 }
        };
        Inventory = new List<Item>();
        CraftableItems = new List<CraftableItem>();

    }

    
    public Player()
        {

        }
    public void FindItem(Item item) 
        {  
            Inventory.Add(item);
        }

        public void UseItem()
    {
        if (Inventory.Count == 0)
        { Console.WriteLine("Your inventory is empty. Explore further to find items"); return; }

        Console.Write("Current item/s in your inventory");
        for (int i = 0; i < Inventory.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Inventory[i].Name}");
        }
        Console.Write("What item you want to choose?");
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > Inventory.Count)
        { Console.WriteLine("Invalid choice. Please enter a valid item number."); }
        Item usedItem = Inventory[choice - 1];
        Console.WriteLine($"You used {usedItem.Name}!");
        usedItem.Use();
        Inventory.RemoveAt(choice - 1);
    }

    public void UseInventoryItem()
    {
        if (Inventory.Count == 0)
        {
            Console.WriteLine("Your inventory is empty. Find items to use first.");
            return;
        }

        Console.WriteLine("Choose an item to use:");
        for (int i = 0; i < Inventory.Count; i++)                     
        {
            Console.WriteLine($"{i + 1}. {Inventory[i].Name}");
        }

        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > Inventory.Count)
        {
            Console.WriteLine("Invalid choice. Please enter a valid item number.");
        }

        Item usedItem = Inventory[choice - 1];
        Console.WriteLine($"You used {usedItem.Name}!");

        // Implement logic for the specific effect of the used item
        usedItem.Use();

        Inventory.RemoveAt(choice - 1); // Remove the used item from the inventory
    }

    public void CraftItem(CraftableItem item)
    {
        // Check if the player has the required ingredients
        bool hasIngredients = true;
        foreach (var ingredient in item.Ingredients)
        {
            if (!Inventory.Contains(ingredient))
            {
                hasIngredients = false;
                Console.WriteLine($"You don't have the required ingredient: {ingredient.Name}");
                break;
            }
        }

        if (hasIngredients)
        {
            // Remove the consumed ingredients
            foreach (var ingredient in item.Ingredients)
            {
                Inventory.Remove(ingredient);
            }

            // Add the crafted item to the inventory
            Inventory.Add(item);

            Console.WriteLine($"You successfully crafted {item.Name}!");
        }
        else
        {
            Console.WriteLine($"Crafting {item.Name} failed due to missing ingredients.");
        }
    }

}

 