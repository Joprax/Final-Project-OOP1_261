using System;
using System.Collections.Generic;
using System.Security;
using System.Xml.Linq;

public class Item
{
    private string name;
    private int price;
 
        
    public string Name { get { return name; } set { name = value; } }
    public int Price { get { return price; } set { price = value; } }
    public Item(string name) { Name = name; }
    public Item(string name, int price) {  Name = name; Price = price; }
    public virtual void Use() { Console.WriteLine($"Using {Name} doesn't have a specific effect in the current version of the game."); }
}


public class Flashlight : Item
{
    public Flashlight() : base("Flashlight") { }
    public override void Use() { Console.WriteLine("Using the flashlight brightens your path. Scenarios in dark areas are now less risky."); }
}
public class Fish : Item
{
    public Fish() : base("Fish") { }
    public override void Use() { Console.WriteLine("You use the fish, I mean, what would it do? you just use the fish?"); }
}
public class Boat : Item
{
    public Boat() : base("Boat") { }
    public override void Use() { Console.WriteLine("You use the boat to help you navigate the river. Crossing sea-related scenarios are now easier to survive. "); }
}

public class ClimbingGear : Item
{
    public ClimbingGear() : base("ClimbingGear") { }
    public override void Use() { Console.WriteLine("Using the climbing gear makes mountain climbing more manageable. Mountain related scenarios are now less risky"); }
}

public class Grapplinghook : Item
{
    public Grapplinghook() : base("Grapplinghook") { }
    public override void Use() { Console.WriteLine("Using the grappling hook makes climbing more manageable. Mountain related scenarios are now less risky"); }
}

public class Stick : Item
{
    public Stick() : base("Stick") { }
    public override void Use() { Console.WriteLine("You throw the stick, nothing happened"); }
}

public class BatWings : Item
{
    public BatWings() : base("BatWings") { }
    public override void Use() { Console.WriteLine("You used the batwings, It does not do anything"); }
}

public class Gems : Item
{
    public Gems() : base("Gems") { }
    public override void Use() { Console.WriteLine("You used the gems, you just stared at it's beauty "); }
}

public class FoodCans : Item
{
    public FoodCans() : base("Food Cans") { }
    public override void Use() { Console.WriteLine("You used the Food cans, you eat it joyfully "); }
}

public class Scraps : Item
{
    public Scraps() : base("Scraps") { }
    public override void Use() { Console.WriteLine("You used the scraps, nothing happened"); }
}

public class Secret_Item : Item
{
    public Secret_Item() : base("Secret_Item") { }
    public override void Use() { Console.WriteLine("YOU FOUND AN EASTER EGG!!!, CIT TOPS AGAIN!! "); }
}
public class Herbals : Item
{
    public Herbals() : base("Herbals") { }
    public override void Use() 
    {
       Player player = new Player();
        if(TryReplenishLives())
        {
            player.Lives++;

            Console.WriteLine("You used a herbal medicine, you gained a life");
        }
    }

    static bool TryReplenishLives()
    {
        Random random = new Random();
        int outcome = random.Next(1, 101); // Generate a random number between 1 and 100

        return outcome <= 100; // 100% chance of repleneshing life
    }
}

public class Glowing_Water : Item
{
    public Glowing_Water() : base("Gowing Water") { }
    public override void Use()
    {
        Player player = new Player();
        if (TryReplenishLives())
        {
            player.Lives++;

            Console.WriteLine("You tried to drink the water, it unexpectedly gained you a life");
        }
    }

    static bool TryReplenishLives()
    {
        Random random = new Random();
        int outcome = random.Next(1, 101); // Generate a random number between 1 and 100

        return outcome <= 100; // 100% chance of repleneshing life
    }
}

public class Water : Item
{
    public Water() : base("Water") { }
    public override void Use()
    {
        Player player = new Player();
        if (TryReplenishLives())
        {
            player.Lives++;

            Console.WriteLine("You tried to drink the water, You feel refreshed");
        }
    }

    static bool TryReplenishLives()
    {
        Random random = new Random();
        int outcome = random.Next(1, 101); // Generate a random number between 1 and 100

        return outcome <= 100; // 100% chance of repleneshing life
    }
}
public class luminescent_mushrooms: Item
{
    public luminescent_mushrooms() : base("Luminescent Mushrooms") { }
    public override void Use()
    {
        Player player = new Player();
        if (TryReplenishLives())
        {
            player.Lives++;

            Console.WriteLine("You tried to eat the luminescent mushrooms, You glow temporarily");
        }
    }

    static bool TryReplenishLives()
    {
        Random random = new Random();
        int outcome = random.Next(1, 101); // Generate a random number between 1 and 100

        return outcome <= 100; // 100% chance of repleneshing life
    }
}


public class Journal : Item
{
    public Journal() : base("Journal") { }
    public override void Use() { Console.WriteLine(@"You read the the tattered journal, it says here 
                                                           'becareful on what ahead'
                                                           'a cave whose beauty is mesmerizing'
                                                           'but something awaits'
                                                           'we are unsure of'
 
                                                         some parts are unreadable"); }
}

public class Crystals : Item
{
    public Crystals() : base("Crystals") { }
    public override void Use() { Console.WriteLine(@"You took the the crystals in your pocket, it does not do anything, rather it you just appreciate it's beauty 
                                                          "); }
}



public class CraftableItem : Item
{
    public List<Item> Ingredients { get; set; }

    public CraftableItem(string name, int price, List<Item> ingredients) : base(name, price)
    {
        Ingredients = ingredients;
    }

    public override void Use()
    {
        Console.WriteLine($"Using {Name} doesn't have a specific effect in the current version of the game.");
    }
}



public class Food : Item
{
    public int HungerRestore { get; set; }

    public Food(string name, int price, int hungerRestore) : base(name, price)
    {
        HungerRestore = hungerRestore;
    }

    public override void Use()
    {
        Console.WriteLine($"Eating {Name} restores {HungerRestore} hunger.");
    }
}

