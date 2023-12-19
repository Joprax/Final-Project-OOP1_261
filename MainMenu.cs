using Final_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Linq;
using System.Net.Cache;
using System.Net.Configuration;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

public class MainMenu 
{

    static string SaveDirectory = "SavedGames";
    static string accountFileName = "Account.txt";
    public void Return()
    {
        Bool bol = new Bool();


        while(bol.Returnn)
        {
            Console.Clear();
            Console.WriteLine(@"
        ╔───────────────────────────────────────────────────────────────╗  
        │          _....._                                              │                                                                                    
        │         ';-.--';'                                             │                                                                                                            
        │           }===={       _.---.._                               │                 
        │         .'      '.    ';-..--';                               │                
        │        /::        \    `}===={                                │            
        │       |::          :   '      '.        [1]  --   [Inventory] │         
        │       \::.        _.---_        \                             │            
        │        '::_     _`---..-';       |                            │       
        │            `````  }====={        /                            │        
        │            `````  }====={        /                            │       
        │            `````  }====={        /                            │                                                  
        │                 .'       '.   _.'                             │                                               
        │                /::         \ `                                │                                           
        │               |::           |                                 │                                         
        │               \::.          /                                 │                                                     
        │                '::_      _.'                                  │                                                          
        │                    ``````                                     │                                                           
        ╚───────────────────────────────────────────────────────────────╝   
        ╔───────────────────────────────────────────────────╗  
        │                                                   │                               
        │                                                   │
        │         /\____;;___\                              │     
        │        | /         /                              │      
        │        `. ())oo() .                               │       
        │         |\(%()*^^()^\  [2]  --  [Craft Items}     │      
        │        %| |-%-------|                             │     
        │        % \ | %  ))   |                            │    
        │        %  \|%________|                            │    
        │         %%%%                                      │   
        │                                                   │     
        │                                                   │      
        │                                                   │        
        │                                                   │   
        │                                                   │    
        │                                                   │                                       
        │                                                   │                                                                                 
        ╚───────────────────────────────────────────────────╝
        ╔──────────────────────────────────╗  
        │                                  │                                                             
        │                                  │                                                             
        │      (=(   )=)                   │           
        │       `.\ /,'                    │          
        │         `\.                      │        
        │       ,'/ \`.   [3]  --  [Stats] │       
        │      (=(   )=)                   │         
        │       `.\ /,'                    │    
        │         ,/'                      │  
        │       ,'/ \`.                    │    
        │      (=(   )=)                   │     
        │       `.\ /,'                    │      
        │         ,/'                      │      
        │       ,'/ \`.                    │        
        │      (=(   )=)                   │          
        │                                  │                     
        │                                  │               
        ╚──────────────────────────────────╝   
        ╔───────────────────────────────────────────────────╗  
        │                                                   │                               
        │                                                   │
        │                                                   │                              
        │                 [4]  --  [Options]                │               
        │                                                   │             
        │                                                   │           
        │                    %%%%%%%%%                      │ 
        │             %%%%%  %%     %% %%%%%@               │
        │           %%%   %%%%       %%%   %%%%             │
        │          %%%                      %%%             │
        │            %%%       %%%%%       %%%              │
        │        %%%%%%     %%%%   %%%%     %%%%%%          │
        │        %%        %%%       %%%        %%          │ 
        │        %%        %%%       %%%        %%          │
        │        %%%%%%     %%%%   %%%%     %%%%%%          │
        │           %%%        %%%%%       %%%              │ 
        │          %%%                       %%             │
        │           %%%%  %%%%       %%%%  %%%              │
        │              %%%%  %%     %%  %%%%                │
        │                    %%%%%%%%%                      │
        │                                                   │  
        │                                                   │    
        │                                                   │                                       
        │                                                   │                                                                                 
        ╚───────────────────────────────────────────────────╝                  ");
            ConsoleKeyInfo choose = Console.ReadKey(true);
            switch (choose.Key)
            {
                case ConsoleKey.NumPad1:

                    Console.Clear();
                    Console.WriteLine(@"
        ╔───────────────────────────────────────────────────────────────╗  
        │          _....._                                              │                                         
        │         ';-.--';'                                             │                                                 
        │           }===={       _.---.._                               │        
        │         .'      '.    ';-..--';                               │       
        │        /::        \    `}===={                                │       
        │       |::          :   '      '.        [Inventory]           │         
        │       \::.        _.---_        \                             │       
        │        '::_     _`---..-';       |                            │       
        │            `````  }====={        /                            │      
        │            `````  }====={        /                            │       
        │            `````  }====={        /                            │                                           
        │                 .'       '.   _.'                             │                                               
        │                /::         \ `                                │                          
        │               |::           |                                 │
        │               \::.          /                                 │
        │                '::_      _.'                                  │       
        │                    ``````                                     │
        ╚───────────────────────────────────────────────────────────────╝  
        
                                                                                                                     ");

                    bol.Returnn = false;
                    break;

                case ConsoleKey.NumPad2:

                    Console.Clear();
                    Console.WriteLine(@"
        ╔───────────────────────────────────────────────────╗  
        │                                                   │                               
        │                                                   │
        │         /\____;;___\                              │     
        │        | /         /                              │      
        │        `. ())oo() .                               │       
        │         |\(%()*^^()^\    [Craft Items}            │      
        │        %| |-%-------|                             │     
        │        % \ | %  ))   |                            │    
        │        %  \|%________|                            │    
        │         %%%%                                      │   
        │                                                   │     
        │                                                   │      
        │                                                   │        
        │                                                   │   
        │                                                   │    
        │                                                   │                                       
        │                                                   │                                                                                 
        ╚───────────────────────────────────────────────────╝   
                                                                                                                     ");
                    bol.Returnn = false;
                    break;

                case ConsoleKey.NumPad3:

                    break;

                case ConsoleKey.NumPad4:

                    Console.Clear();
                    Console.WriteLine(@"
        ╔───────────────────────────────────────────────────╗  
        │                                                   │                               
        │                                                   │
        │                                                   │                              
        │                   [Options]                       │               
        │                                                   │             
        │                                                   │           
        │                    %%%%%%%%%                      │ 
        │             %%%%%  %%     %% %%%%%@               │
        │           %%%   %%%%       %%%   %%%%             │
        │          %%%                      %%%             │
        │            %%%       %%%%%       %%%              │
        │        %%%%%%     %%%%   %%%%     %%%%%%          │
        │        %%        %%%       %%%        %%          │ 
        │        %%        %%%       %%%        %%          │
        │        %%%%%%     %%%%   %%%%     %%%%%%          │
        │           %%%        %%%%%       %%%              │ 
        │          %%%                       %%             │
        │           %%%%  %%%%       %%%%  %%%              │
        │              %%%%  %%     %%  %%%%                │
        │                    %%%%%%%%%                      │
        │                                                   │  
        │                                                   │    
        │                                                   │                                       
        │                                                   │                                                                                 
        ╚───────────────────────────────────────────────────╝                                
                                         
                                         
       
                                                                                                                     ");
                    bol.Returnn = false;
                    break;
            }


        }

        bol.Returnn = true;


    }



    public void LogIN()
    {
         Adjust adj = new Adjust();
        if (File.Exists(accountFileName))
        {
            Console.WriteLine(@"
                                                           


                                                                                    ░█░█░█▀▀░█░░░█▀▀░█▀█░█▄█░█▀▀
                                                                                    ░█▄█░█▀▀░█░░░█░░░█░█░█░█░█▀▀
                                                                                    ░▀░▀░▀▀▀░▀▀▀░▀▀▀░▀▀▀░▀░▀░▀▀▀   ");

            

            if (Authenticate(Account(Player.Name)))
            {
                Console.WriteLine($@"             
                                                                                              {Player.Name}");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(@"
                                                                 


                                                                          





                                                              ░█░░░█▀█░█▀█░█▀▄░▀█▀░█▀█░█▀▀░░░█▀▀░█▀█░█▀▄░▀█▀░█▀█░█▀▀░░░█▀▀░█▀▀░█▀▀░█▀█░█▀▀░█▀▀
                                                              ░█░░░█░█░█▀█░█░█░░█░░█░█░█░█░░░█▀▀░█░█░█░█░░█░░█░█░█░█░░░▀▀█░█░░░█▀▀░█░█░█▀▀░▀▀█
                                                              ░▀▀▀░▀▀▀░▀░▀░▀▀░░▀▀▀░▀░▀░▀▀▀░░░▀▀▀░▀░▀░▀▀░░▀▀▀░▀░▀░▀▀▀░░░▀▀▀░▀▀▀░▀▀▀░▀░▀░▀▀▀░▀▀▀ 



");

                Loading_bar loadingBar = new Loading_bar();
                int totalSteps = 70; // Adjust the total number of steps
                int delay = 5;

                loadingBar.ShowLoadingBar(totalSteps, delay);
            }
            else
            {
                Console.WriteLine("Automatic login failed. Invalid username or password.");
            }
        }
        else
        {
            Console.WriteLine(@"
                                                             ░█▀█░█▀▀░█░█░░░█▀▀░█▀█░█▄█░█▀▀░▀▀█                    
                                                             ░█░█░█▀▀░█▄█░░░█░█░█▀█░█░█░█▀▀░░▀░                    
                                                             ░▀░▀░▀▀▀░▀░▀░░░▀▀▀░▀░▀░▀░▀░▀▀▀░░▀░   

                                                   ░█▀▀░█▀▄░█▀▀░█▀█░▀█▀░█▀▀░░░█▀█░█▀▀░█▀▀░█▀█░█░█░█▀█░▀█▀
                                                   ░█░░░█▀▄░█▀▀░█▀█░░█░░█▀▀░░░█▀█░█░░░█░░░█░█░█░█░█░█░░█░
                                                   ░▀▀▀░▀░▀░▀▀▀░▀░▀░░▀░░▀▀▀░░░▀░▀░▀▀▀░▀▀▀░▀▀▀░▀▀▀░▀░▀░░▀░ ");
            Console.ReadKey();
            CreateAccount(Player.Name);
            ShowAll2();
        }
    }

    public void ShowAll2()
    {
       

        Bool bol = new Bool();
        //Player player = new Player("Negan", 12);

       
        


        while (bol.Mainmenu)
        {
            Console.Clear();
            Console.WriteLine();
            

            Console.WriteLine(@"
                                                ██████  █    ██  ██▀███   ██▒   █▓ ██▓ ██▒   █▓▓█████              ▄▄▄█████▓ ██░ ██  ██▓  ██████  ▐██▌          
                                              ▒██    ▒  ██  ▓██▒▓██ ▒ ██▒▓██░   █▒▓██▒▓██░   █▒▓█   ▀              ▓  ██▒ ▓▒▓██░ ██▒▓██▒▒██    ▒  ▐██▌  
                                              ░ ▓██▄   ▓██  ▒██░▓██ ░▄█ ▒ ▓██  █▒░▒██▒ ▓██  █▒░▒███                ▒ ▓██░ ▒░▒██▀▀██░▒██▒░ ▓██▄    ▐██▌      
                                                ▒   ██▒▓▓█  ░██░▒██▀▀█▄    ▒██ █░░░██░  ▒██ █░░▒▓█  ▄              ░ ▓██▓ ░ ░▓█ ░██ ░██░  ▒   ██▒ ▓██▒  
                                              ▒██████▒▒▒▒█████▓ ░██▓ ▒██▒   ▒▀█░  ░██░   ▒▀█░  ░▒████▒               ▒██▒ ░ ░▓█▒░██▓░██░▒██████▒▒ ▒▄▄   
                                              ▒ ▒▓▒ ▒ ░░▒▓▒ ▒ ▒ ░ ▒▓ ░▒▓░   ░ ▐░  ░▓     ░ ▐░  ░░ ▒░ ░               ▒ ░░    ▒ ░░▒░▒░▓  ▒ ▒▓▒ ▒ ░ ░▀▀▒    
                                              ░ ░▒  ░ ░░░▒░ ░ ░   ░▒ ░ ▒░   ░ ░░   ▒ ░   ░ ░░   ░ ░  ░                 ░     ▒ ░▒░ ░ ▒ ░░ ░▒  ░ ░ ░  ░     
                                               ░  ░  ░   ░░░ ░ ░   ░░   ░      ░░   ▒ ░     ░░     ░                   ░       ░  ░░ ░ ▒ ░░  ░  ░      ░          
                                              ░     ░        ░           ░   ░        ░     ░  ░                      ░  ░  ░ ░        ░   ░                



                                                                ███╗   ███╗ █████╗ ██╗███╗   ██╗███╗   ███╗███████╗███╗   ██╗██╗   ██╗
                                                                ████╗ ████║██╔══██╗██║████╗  ██║████╗ ████║██╔════╝████╗  ██║██║   ██║
                                                                ██╔████╔██║███████║██║██╔██╗ ██║██╔████╔██║█████╗  ██╔██╗ ██║██║   ██║
                                                                ██║ ╚═╝ ██║██║  ██║██║██║ ╚████║██║ ╚═╝ ██║███████╗██║ ╚████║╚██████╔╝
                                                                ╚═╝     ╚═╝╚═╝  ╚═╝╚═╝╚═╝  ╚═══╝╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝ 



                                                         
                                                                                       ░█▀▀░█▀█░▀█▀░█▀▀░█▀▄
                                                                   [press enter]---    ░█▀▀░█░█░░█░░█▀▀░█▀▄
                                                                                       ░▀▀▀░▀░▀░░▀░░▀▀▀░▀░▀


                                                                               
                                                                                    ░█▀█░█▀█░▀█▀░▀█▀░█▀█░█▀█░█▀▀
                                                                             [O]--- ░█░█░█▀▀░░█░░░█░░█░█░█░█░▀▀█
                                                                                    ░▀▀▀░▀░░░░▀░░▀▀▀░▀▀▀░▀░▀░▀▀▀


                                                                             
                                                                                    ░█▀▀░█▀▄░█▀▀░█▀▄░▀█▀░▀█▀░█▀▀
                                                                            [C]---  ░█░░░█▀▄░█▀▀░█░█░░█░░░█░░▀▀█
                                                                                    ░▀▀▀░▀░▀░▀▀▀░▀▀░░▀▀▀░░▀░░▀▀▀


                                                                      
                                                                                       ░█▀█░█▀▄░█▀█░█░█░▀█▀
                                                                             [A]---    ░█▀█░█▀▄░█░█░█░█░░█░
                                                                                       ░▀░▀░▀▀░░▀▀▀░▀▀▀░░▀░

 
                                                                                    ░█▀▀░█▀█░█▀▄░▀█▀░█▀█░█▀▀░█▀▀
                                                                           [L]---   ░█▀▀░█░█░█░█░░█░░█░█░█░█░▀▀█
                                                                                    ░▀▀▀░▀░▀░▀▀░░▀▀▀░▀░▀░▀▀▀░▀▀▀



                                                                                     ░█▀▄░█▀▀░█░░░█▀▀░▀█▀░█▀▀
                                                                           [D]---    ░█░█░█▀▀░█░░░█▀▀░░█░░█▀▀
                                                                                     ░▀▀░░▀▀▀░▀▀▀░▀▀▀░░▀░░▀▀▀


                                               
                                                                                         ░█▀▀░█░█░▀█▀░▀█▀
                                                                             [X]---      ░█▀▀░▄▀▄░░█░░░█░
                                                                                         ░▀▀▀░▀░▀░▀▀▀░░▀░");
            ConsoleKeyInfo choose = Console.ReadKey(true);
            switch (choose.Key)
            {
                case ConsoleKey.Enter:
                    Console.Clear();



                        while (bol.Mainmenu)
                        {
                            Introduction dia = new Introduction();
                            
                            Console.Clear();
                            Start game = new Start();

                        
                        //dia.intro();
                        game.Start_Game(Player.Name);
                        
                        
                       
                            Console.ReadLine();



                    }
                    
                  
                    

                    break;
                case ConsoleKey.O:

                    bol.Back_options = true;

                   

                    while (bol.Back_options)
                    {
                        Console.Clear();
                        Console.WriteLine(@"                                                                             
                                                                                    ┌────────────────────────────────┐
                                                                                    │  ░█▀█░█▀█░▀█▀░▀█▀░█▀█░█▀█░█▀▀  │
                                                                                    │  ░█░█░█▀▀░░█░░░█░░█░█░█░█░▀▀█  │
                                                                                    │  ░▀▀▀░▀░░░░▀░░▀▀▀░▀▀▀░▀░▀░▀▀▀  │
                                                                                    └────────────────────────────────┘


                                                                     │     │                      │          │                       │          │
                                                             [A]  -  │AUDIO│              [R]  -  │RESOLUTION│                 [D] - │DIFFICULTY│
                                                                     │     │                      │          │                       │          │");

                        
                        


                            choose = Console.ReadKey(true);

                        switch (choose.Key)
                        {
                            case ConsoleKey.A:
                                bool inAudioSettings = true;

                                while (inAudioSettings)
                                {
                                    Console.Clear();

                                    

                                    int masterVolume = 100;
                                    int backgroundMusic = 80;
                                    int voice = 50;
                                    int soundFX = 70;
                                    int ambience = 60;
                                    DrawBars(masterVolume, backgroundMusic, voice, soundFX, ambience);
                                    while (true)
                                    {
                                        ConsoleKeyInfo key = Console.ReadKey();

                                        // Adjust values based on arrow keys
                                        switch (key.Key)
                                        {
                                            case ConsoleKey.UpArrow:
                                                masterVolume = Math.Min(masterVolume + 5, 100);
                                                break;
                                            case ConsoleKey.DownArrow:
                                                masterVolume = Math.Max(masterVolume - 5, 0);
                                                break;
                                            case ConsoleKey.LeftArrow:
                                                backgroundMusic = Math.Max(backgroundMusic - 5, 0);
                                                break;
                                            case ConsoleKey.RightArrow:
                                                backgroundMusic = Math.Min(backgroundMusic + 5, 100);
                                                break;
                                            case ConsoleKey.W:
                                                voice = Math.Min(voice + 5, 100);
                                                break;
                                            case ConsoleKey.S:
                                                voice = Math.Max(voice - 5, 0);
                                                break;
                                            case ConsoleKey.A:
                                                soundFX = Math.Max(soundFX - 5, 0);
                                                break;
                                            case ConsoleKey.D:
                                                soundFX = Math.Min(soundFX + 5, 100);
                                                break;
                                            case ConsoleKey.H:
                                                ambience = Math.Min(ambience + 5, 100);
                                                break;
                                            case ConsoleKey.F:
                                                ambience = Math.Max(ambience - 5, 0);
                                                break;

                                        }

                                        Console.Clear();
                                        DrawBars(masterVolume, backgroundMusic, voice, soundFX, ambience);

                                        if (Console.KeyAvailable)
                                        {
                                            ConsoleKeyInfo choos = Console.ReadKey(true);
                                            if (choos.Key == ConsoleKey.Backspace)
                                            {
                                                inAudioSettings = false;
                                                break; // Exit the inner loop
                                            }

                                        }
                                    }                                  
                                }
                                                                             

                                break;

                            case ConsoleKey.R:
                                while(bol.Back_resolution)
                                {
                                    Console.Clear();
                                    Console.WriteLine(@"
                                                                                    ┌────────────────────────────────┐
                                                                                    │  ░█▀█░█▀█░▀█▀░▀█▀░█▀█░█▀█░█▀▀  │
                                                                                    │  ░█░█░█▀▀░░█░░░█░░█░█░█░█░▀▀█  │
                                                                                    │  ░▀▀▀░▀░░░░▀░░▀▀▀░▀▀▀░▀░▀░▀▀▀  │
                                                                                    └────────────────────────────────┘

                                                                                             │ │          │ │
                                                                                             │ │Resolution│ │
                                                                                             │ │          │ │

                                           
                                                                Resolution                         Name            Aspect Ratio       Pixel Size

                                                                SD (Standard Definition)           480p                4:3            640 x 480

                                                                HD (High Definition)               720p                16:9           1280 x 720

                                                                Full HD (FHD)                      1080p               16:9           1920 x 1080

                                                                2K video (Quad HD)                 2k or 1440          16:9           2560 x 1440

                                                                4K video or Ultra HD (UHD)         4K or 2160p         1:1.9          3840 x 2160

                                                                8K video or Full Ultra HD          8K or 4320p         16∶9           7680 x 4320  ");
                                     
                                    choose = Console.ReadKey(true);

                                    switch (choose.Key)
                                    {
                                        case ConsoleKey.Backspace:

                                            bol.Back_resolution = false;

                                            break;
                                    }
                                }
                                bol.Back_resolution= true;

                                break;
                            case ConsoleKey.D:

                                while (bol.Back_Difficulty)                                   
                                {
                                Console.Clear();
                                Console.WriteLine(@"
                                                                                    ┌────────────────────────────────┐
                                                                                    │  ░█▀█░█▀█░▀█▀░▀█▀░█▀█░█▀█░█▀▀  │
                                                                                    │  ░█░█░█▀▀░░█░░░█░░█░█░█░█░▀▀█  │
                                                                                    │  ░▀▀▀░▀░░░░▀░░▀▀▀░▀▀▀░▀░▀░▀▀▀  │
                                                                                    └────────────────────────────────┘

                                                                                             │ │          │ │
                                                                                             │ │Difficulty│ │
                                                                                             │ │          │ │                                   ");

                                Console.WriteLine(@"
                                                                                         Choose difficulty level:

                                                                     [1] - Easy               [2] - Medium                [3] - Hard                              ");


                                choose = Console.ReadKey(true);



                                    while (bol.Exit)
                                    {


                                        switch (choose.Key)
                                        {
                                            case ConsoleKey.NumPad1:
                                                

                                                Console.WriteLine(@"
                                                                                         Difficulty set to Easy.");
                                                // Add code to handle Easy difficulty
                                                Console.ReadKey();
                                                bol.Exit = false;
                                                break;

                                            case ConsoleKey.NumPad2:
                                               

                                                Console.WriteLine(@"
                                                                                         Difficulty set to Medium.");
                                                Console.ReadKey();
                                                // Add code to handle Medium difficulty
                                                bol.Exit = false;
                                                break;

                                            case ConsoleKey.NumPad3:
                                                

                                                Console.WriteLine(@"
                                                                                         Difficulty set to Hard.");
                                                // Add code to handle Hard difficulty
                                                Console.ReadKey();
                                                bol.Exit = false;
                                                break;

                                            case ConsoleKey.Backspace:

                                                bol.Exit = false;
                                                bol.Back_Difficulty = false;

                                                break;

                                        }
                                    }
                                    bol.Exit = true;
                                }
                                bol.Back_Difficulty = true;



                                break;
                            case ConsoleKey.Backspace:

                                bol.Back_options = false;

                                break;
                        }
                    }

                    bol.Back_options= true;
                    break;

                case ConsoleKey.C:

                    bol.Back_credits = true;

                    while(bol.Back_credits)
                    {
                        Console.Clear();
                        Console.WriteLine(@"                                                                             
                                                                                    ┌────────────────────────────────┐
                                                                                    │  ░█▀▀░█▀▄░█▀▀░█▀▄░▀█▀░▀█▀░█▀▀  │
                                                                                    │  ░█░░░█▀▄░█▀▀░█░█░░█░░░█░░▀▀█  │
                                                                                    │  ░▀▀▀░▀░▀░▀▀▀░▀▀░░▀▀▀░░▀░░▀▀▀  │
                                                                                    └────────────────────────────────┘

                                                                                                Programmer

                                                                                           Jeremiaj Daneol Sapid

                                                                                                 Designer 

                                                                                           Jeremiaj Daneol Sapid

                                                                                                 Music

                                                                                           Jeremiaj Daneol Sapid

                                                                                                Producer 

                                                                                           JDMS Entertainment

                                                                                            Special thanks to~

                                                                                           Jeremiaj Daneol Sapid
                                                                             
               
                                                                                                                              ");
                         choose = Console.ReadKey(true);
                        
                        switch (choose.Key)
                        {
                            case ConsoleKey.Backspace:

                                bol.Back_credits = false;
                                
                                break;
                        }

                    }
                    
                    break;
                case ConsoleKey.A:

                    bol.Back_about = true;
                    bol.Back_credits = true;

                    while (bol.Back_about)
                    {
                        Console.Clear();
                        Console.WriteLine(@"                                                                             
                                                                                    ┌────────────────────────┐
                                                                                    │  ░█▀█░█▀▄░█▀█░█░█░▀█▀  │
                                                                                    │  ░█▀█░█▀▄░█░█░█░█░░█░  │
                                                                                    │  ░▀░▀░▀▀░░▀▀▀░▀▀▀░░▀░  │
                                                                                    └────────────────────────┘ ");

                        Console.ForegroundColor = ConsoleColor.Yellow;

                        Console.WriteLine(@"
                            ""Survive This"" is an immersive text-based survival game set in the modern era, where players find themselves mysteriously stranded in the middle of nowhere. 
                            With no apparent explanation for their predicament, players must navigate a series of challenging scenarios, each presenting unique obstacles and choices. 
                            From resource gathering to crafting and forming alliances with fellow survivors, every decision influences the outcome of your journey. 
                            The game focuses on the core elements of survival in a realistic setting,and make crucial decisions that impact their chances of making it out alive. 
 
                            ""Survive This"" offers a gripping narrative that unfolds based on your choices, creating a dynamic and suspenseful experience 
                            as you strive to survive the challenges of an unfamiliar and unforgiving environment. 
                            Can you make the right decisions and persevere against the odds, or will you succumb to the challenges of the unknown? 
                            Your fate is in your hands.  ");

                        Console.ResetColor();
                                                              
                        choose = Console.ReadKey(true);

                        switch (choose.Key)
                        {
                            case ConsoleKey.Backspace:

                                bol.Back_about = false;

                                break;
                        }

                    }

                    break;

                case ConsoleKey.X:

                    Console.Clear();
                    Console.WriteLine(@"
                                                                                            You sure you want to exit?
                                                                                                     [y/n]             ");
                    while(bol.Exit)
                    {
                        choose = Console.ReadKey(true);
                        switch (choose.Key)
                        {
                            case ConsoleKey.Y:
                                Console.Clear();
                                Console.WriteLine(@"
                                                                                              Exiting the program");
                                Console.ReadKey();
                                Environment.Exit(0);
                                
                                
                                break;

                            case ConsoleKey.N:

                                bol.Exit = false;
                                break;

                        }
                    }
                    bol.Exit = true;
                    break;

                case ConsoleKey.D:
                    Console.Clear();
                    
                    while(bol.Exit)
                    {
                        Console.WriteLine(@"
                                           Do you want to delete your account?
                                                    [type yes]/no");

                        string input = Console.ReadLine().ToLower();
                        switch(input)
                        {
                            case "yes":
                                Console.Clear();

                                DeleteAccount();
                                Console.ReadKey();
                                Environment.Exit(0);
                                break;

                                case "no":
                                bol.Exit = false;
                                break;
                        }
                    }bol.Exit = true;
                   
                    break;

                    case ConsoleKey.L:

                    Console.Clear();
                    while (bol.Start)                    /////////////////////////to add stupid txt, Mossy Way txt, Artful Escape txt , Close One txt, Red Cross txt , I Wonder txt
                    {
                        Console.Clear();
                        Console.WriteLine(@"
                ╔════════════════════╗╔════════════════════╗╔════════════════════╗╔════════════════════╗
                ║ [1] - Im Rich      ║║ [6] - Freedom Way  ║║ [Q] - That's it?   ║║ [null] - Empty     ║
                ║════════════════════║║════════════════════║║════════════════════║║════════════════════║
                ║ [2] - Too Greedy   ║║ [7] - Lazy Ass     ║║ [W] - Stupid       ║║ [null] - Empty     ║
                ║════════════════════║║════════════════════║║════════════════════║║════════════════════║
                ║ [3] - Miner Legacy ║║ [8] - Light's Glow ║║ [E] - Mossy Way    ║║ [y] - Red Cross    ║
                ║════════════════════║║════════════════════║║════════════════════║║════════════════════║                                  
                ║ [4] - ? ? ? ? ? ?  ║║ [9] - Choo-Choo    ║║ [R] - Artful Escape║║ [U] - I Wonder     ║
                ║════════════════════║║════════════════════║║════════════════════║║════════════════════║
                ║ [5] - WTF WAS THAT?║║ [0] - Got obitoed  ║║ [T] - Close One    ║║ [null] - Empty     ║
                ╚════════════════════╝╚════════════════════╝╚════════════════════╝╚════════════════════╝
");
                        while (bol.Exit)
                        {
                            choose = Console.ReadKey(true);
                            switch (choose.Key)
                            {
                                case ConsoleKey.U:
                                    Console.Clear();
                                    DisplayEndingScene_I_Wonder("I Wonder.txt");
                                    Console.ReadKey();

                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.Y:
                                    Console.Clear();
                                    DisplayEndingScene_Red_Cross("Red Cross.txt");
                                    Console.ReadKey();

                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.T:
                                    Console.Clear();
                                    DisplayEndingScene_Close_One("Close One.txt");
                                    Console.ReadKey();

                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.R:
                                    Console.Clear();
                                    DisplayEndingScene_Artful_Escape("Artful Escape.txt");
                                    Console.ReadKey();

                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.E:
                                    Console.Clear();
                                    DisplayEndingScene_Mossy_Way("Mossy Way.txt");
                                    Console.ReadKey();

                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.W:
                                    Console.Clear();
                                    DisplayEndingScene_Stupid("stupid.txt");
                                    Console.ReadKey();

                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.NumPad6:
                                    Console.Clear();
                                    DisplayEndingScene_Freedom("FreedomWay.txt");
                                    Console.ReadKey();

                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.NumPad7:
                                    Console.Clear();
                                    DisplayEndingScene_Lazy_Ass("Lazy_Ass.txt");
                                    Console.ReadKey();
                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.NumPad8:
                                    Console.Clear();
                                    DisplayEndingScene_Lights_Glow("Lights_Glow.txt");
                                    Console.ReadKey();
                                    bol.Exit = false;
                                    break;
                                    case ConsoleKey.NumPad9:
                                    Console.Clear();
                                    DisplayEndingScene_Choo_Choo_Trail("Choo-Choo_Trail.txt");
                                    Console.ReadKey();
                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.NumPad0:
                                    Console.Clear();
                                    DisplayEndingScene_Got_Obitoed("Got_obitoed.txt");
                                    Console.ReadKey();
                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.NumPad1:
                                    Console.Clear();
                                    DisplayEndingScene_Im_Rich("Im_Rich.txt");
                                    Console.ReadKey();
                                    bol.Exit = false;
                                    break;
                                    case ConsoleKey.NumPad2:
                                    Console.Clear();
                                    DisplayEndingScene_Too_Greedy("Too_Greedy.txt");
                                    Console.ReadKey();
                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.NumPad3:
                                    Console.Clear();
                                    DisplayEndingScene_Miners_Legacy("Miners_Legacy.txt");
                                    Console.ReadKey();
                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.NumPad4:
                                    Console.Clear();
                                    DisplayEndingScene_Easter("CIT TOPS AGAIN.txt");
                                    Console.ReadKey();
                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.NumPad5:
                                    Console.Clear();
                                    DisplayEndingScene_WTF("WTF.txt");
                                    Console.ReadKey();
                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.Q:
                                    Console.Clear();
                                    DisplayEndingScene_That_It("Thats_it.txt");
                                    Console.ReadKey();
                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.Backspace:
                                    bol.Exit = false;
                                    bol.Start = false;
                                    break;

                            }
                        }
                        bol.Exit = true;

                    }
                    bol.Start = true;
                    break;


                default:

                    break;
            }


                

        
            }
        }
    public void GameOver()
    {
        Console.WriteLine(@"
            
   █████████                                           ███████                                  
  ███░░░░░███                                        ███░░░░░███                                
 ███     ░░░   ██████   █████████████    ██████     ███     ░░███ █████ █████  ██████  ████████ 
░███          ░░░░░███ ░░███░░███░░███  ███░░███   ░███      ░███░░███ ░░███  ███░░███░░███░░███
░███    █████  ███████  ░███ ░███ ░███ ░███████    ░███      ░███ ░███  ░███ ░███████  ░███ ░░░ 
░░███  ░░███  ███░░███  ░███ ░███ ░███ ░███░░░     ░░███     ███  ░░███ ███  ░███░░░   ░███     
 ░░█████████ ░░████████ █████░███ █████░░██████     ░░░███████░    ░░█████   ░░██████  █████    
  ░░░░░░░░░   ░░░░░░░░ ░░░░░ ░░░ ░░░░░  ░░░░░░        ░░░░░░░       ░░░░░     ░░░░░░  ░░░░░                         ");


        Console.ReadKey();
        Console.Clear();
        Console.WriteLine(@"
            
 ███████████ █████                           █████                                              ██████                                  ████                        ███                     
░█░░░███░░░█░░███                           ░░███                                              ███░░███                                ░░███                       ░░░                      
░   ░███  ░  ░███████    ██████   ████████   ░███ █████    █████ ████  ██████  █████ ████     ░███ ░░░   ██████  ████████     ████████  ░███   ██████   █████ ████ ████  ████████    ███████
    ░███     ░███░░███  ░░░░░███ ░░███░░███  ░███░░███    ░░███ ░███  ███░░███░░███ ░███     ███████    ███░░███░░███░░███   ░░███░░███ ░███  ░░░░░███ ░░███ ░███ ░░███ ░░███░░███  ███░░███
    ░███     ░███ ░███   ███████  ░███ ░███  ░██████░      ░███ ░███ ░███ ░███ ░███ ░███    ░░░███░    ░███ ░███ ░███ ░░░     ░███ ░███ ░███   ███████  ░███ ░███  ░███  ░███ ░███ ░███ ░███
    ░███     ░███ ░███  ███░░███  ░███ ░███  ░███░░███     ░███ ░███ ░███ ░███ ░███ ░███      ░███     ░███ ░███ ░███         ░███ ░███ ░███  ███░░███  ░███ ░███  ░███  ░███ ░███ ░███ ░███
    █████    ████ █████░░████████ ████ █████ ████ █████    ░░███████ ░░██████  ░░████████     █████    ░░██████  █████        ░███████  █████░░████████ ░░███████  █████ ████ █████░░███████
   ░░░░░    ░░░░ ░░░░░  ░░░░░░░░ ░░░░ ░░░░░ ░░░░ ░░░░░      ░░░░░███  ░░░░░░    ░░░░░░░░     ░░░░░      ░░░░░░  ░░░░░         ░███░░░  ░░░░░  ░░░░░░░░   ░░░░░███ ░░░░░ ░░░░ ░░░░░  ░░░░░███
                                                            ███ ░███                                                          ░███                       ███ ░███                   ███ ░███
                                                           ░░██████                                                           █████                     ░░██████                   ░░██████ 
                                                            ░░░░░░                                                           ░░░░░                       ░░░░░░                     ░░░░░░                        ");
        Console.ReadKey();
        Console.Clear();

    }
    public void ShowAll()
    {


        Bool bol = new Bool();
        //Player player = new Player("Negan", 12);





        while (bol.Mainmenu)
        {
            Console.Clear();
            Console.WriteLine();


            Console.WriteLine(@"
                                                ██████  █    ██  ██▀███   ██▒   █▓ ██▓ ██▒   █▓▓█████              ▄▄▄█████▓ ██░ ██  ██▓  ██████  ▐██▌          
                                              ▒██    ▒  ██  ▓██▒▓██ ▒ ██▒▓██░   █▒▓██▒▓██░   █▒▓█   ▀              ▓  ██▒ ▓▒▓██░ ██▒▓██▒▒██    ▒  ▐██▌  
                                              ░ ▓██▄   ▓██  ▒██░▓██ ░▄█ ▒ ▓██  █▒░▒██▒ ▓██  █▒░▒███                ▒ ▓██░ ▒░▒██▀▀██░▒██▒░ ▓██▄    ▐██▌      
                                                ▒   ██▒▓▓█  ░██░▒██▀▀█▄    ▒██ █░░░██░  ▒██ █░░▒▓█  ▄              ░ ▓██▓ ░ ░▓█ ░██ ░██░  ▒   ██▒ ▓██▒  
                                              ▒██████▒▒▒▒█████▓ ░██▓ ▒██▒   ▒▀█░  ░██░   ▒▀█░  ░▒████▒               ▒██▒ ░ ░▓█▒░██▓░██░▒██████▒▒ ▒▄▄   
                                              ▒ ▒▓▒ ▒ ░░▒▓▒ ▒ ▒ ░ ▒▓ ░▒▓░   ░ ▐░  ░▓     ░ ▐░  ░░ ▒░ ░               ▒ ░░    ▒ ░░▒░▒░▓  ▒ ▒▓▒ ▒ ░ ░▀▀▒    
                                              ░ ░▒  ░ ░░░▒░ ░ ░   ░▒ ░ ▒░   ░ ░░   ▒ ░   ░ ░░   ░ ░  ░                 ░     ▒ ░▒░ ░ ▒ ░░ ░▒  ░ ░ ░  ░     
                                               ░  ░  ░   ░░░ ░ ░   ░░   ░      ░░   ▒ ░     ░░     ░                   ░       ░  ░░ ░ ▒ ░░  ░  ░      ░          
                                              ░     ░        ░           ░   ░        ░     ░  ░                      ░  ░  ░ ░        ░   ░                



                                                                ███╗   ███╗ █████╗ ██╗███╗   ██╗███╗   ███╗███████╗███╗   ██╗██╗   ██╗
                                                                ████╗ ████║██╔══██╗██║████╗  ██║████╗ ████║██╔════╝████╗  ██║██║   ██║
                                                                ██╔████╔██║███████║██║██╔██╗ ██║██╔████╔██║█████╗  ██╔██╗ ██║██║   ██║
                                                                ██║ ╚═╝ ██║██║  ██║██║██║ ╚████║██║ ╚═╝ ██║███████╗██║ ╚████║╚██████╔╝
                                                                ╚═╝     ╚═╝╚═╝  ╚═╝╚═╝╚═╝  ╚═══╝╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝ ╚═════╝ 



                                                         
                                                                                       ░█▀▀░█▀█░▀█▀░█▀▀░█▀▄
                                                                   [press enter]---    ░█▀▀░█░█░░█░░█▀▀░█▀▄
                                                                                       ░▀▀▀░▀░▀░░▀░░▀▀▀░▀░▀


                                                                               
                                                                                    ░█▀█░█▀█░▀█▀░▀█▀░█▀█░█▀█░█▀▀
                                                                             [O]--- ░█░█░█▀▀░░█░░░█░░█░█░█░█░▀▀█
                                                                                    ░▀▀▀░▀░░░░▀░░▀▀▀░▀▀▀░▀░▀░▀▀▀


                                                                             
                                                                                    ░█▀▀░█▀▄░█▀▀░█▀▄░▀█▀░▀█▀░█▀▀
                                                                            [C]---  ░█░░░█▀▄░█▀▀░█░█░░█░░░█░░▀▀█
                                                                                    ░▀▀▀░▀░▀░▀▀▀░▀▀░░▀▀▀░░▀░░▀▀▀


                                                                      
                                                                                       ░█▀█░█▀▄░█▀█░█░█░▀█▀
                                                                             [A]---    ░█▀█░█▀▄░█░█░█░█░░█░
                                                                                       ░▀░▀░▀▀░░▀▀▀░▀▀▀░░▀░

 
                                                                                    ░█▀▀░█▀█░█▀▄░▀█▀░█▀█░█▀▀░█▀▀
                                                                           [L]---   ░█▀▀░█░█░█░█░░█░░█░█░█░█░▀▀█
                                                                                    ░▀▀▀░▀░▀░▀▀░░▀▀▀░▀░▀░▀▀▀░▀▀▀



                                                                                     ░█▀▄░█▀▀░█░░░█▀▀░▀█▀░█▀▀
                                                                           [D]---    ░█░█░█▀▀░█░░░█▀▀░░█░░█▀▀
                                                                                     ░▀▀░░▀▀▀░▀▀▀░▀▀▀░░▀░░▀▀▀


                                               
                                                                                         ░█▀▀░█░█░▀█▀░▀█▀
                                                                             [X]---      ░█▀▀░▄▀▄░░█░░░█░
                                                                                         ░▀▀▀░▀░▀░▀▀▀░░▀░");
            ConsoleKeyInfo choose = Console.ReadKey(true);
            switch (choose.Key)
            {
                case ConsoleKey.Enter:
                    Console.Clear();



                    while (bol.Mainmenu)
                    {
                        Introduction dia = new Introduction();

                        Console.Clear();
                        Start game = new Start();


                        //dia.intro();
                        game.Start_Game(Player.Name);



                        Console.ReadLine();



                    }




                    break;
                case ConsoleKey.O:

                    bol.Back_options = true;



                    while (bol.Back_options)
                    {
                        Console.Clear();
                        Console.WriteLine(@"                                                                             
                                                                                    ┌────────────────────────────────┐
                                                                                    │  ░█▀█░█▀█░▀█▀░▀█▀░█▀█░█▀█░█▀▀  │
                                                                                    │  ░█░█░█▀▀░░█░░░█░░█░█░█░█░▀▀█  │
                                                                                    │  ░▀▀▀░▀░░░░▀░░▀▀▀░▀▀▀░▀░▀░▀▀▀  │
                                                                                    └────────────────────────────────┘


                                                                     │     │                      │          │                       │          │
                                                             [A]  -  │AUDIO│              [R]  -  │RESOLUTION│                 [D] - │DIFFICULTY│
                                                                     │     │                      │          │                       │          │");





                        choose = Console.ReadKey(true);

                        switch (choose.Key)
                        {
                            case ConsoleKey.A:
                                bool inAudioSettings = true;

                                while (inAudioSettings)
                                {
                                    Console.Clear();



                                    int masterVolume = 100;
                                    int backgroundMusic = 80;
                                    int voice = 50;
                                    int soundFX = 70;
                                    int ambience = 60;
                                    DrawBars(masterVolume, backgroundMusic, voice, soundFX, ambience);
                                    while (true)
                                    {
                                        ConsoleKeyInfo key = Console.ReadKey();

                                        // Adjust values based on arrow keys
                                        switch (key.Key)
                                        {
                                            case ConsoleKey.UpArrow:
                                                masterVolume = Math.Min(masterVolume + 5, 100);
                                                break;
                                            case ConsoleKey.DownArrow:
                                                masterVolume = Math.Max(masterVolume - 5, 0);
                                                break;
                                            case ConsoleKey.LeftArrow:
                                                backgroundMusic = Math.Max(backgroundMusic - 5, 0);
                                                break;
                                            case ConsoleKey.RightArrow:
                                                backgroundMusic = Math.Min(backgroundMusic + 5, 100);
                                                break;
                                            case ConsoleKey.W:
                                                voice = Math.Min(voice + 5, 100);
                                                break;
                                            case ConsoleKey.S:
                                                voice = Math.Max(voice - 5, 0);
                                                break;
                                            case ConsoleKey.A:
                                                soundFX = Math.Max(soundFX - 5, 0);
                                                break;
                                            case ConsoleKey.D:
                                                soundFX = Math.Min(soundFX + 5, 100);
                                                break;
                                            case ConsoleKey.H:
                                                ambience = Math.Min(ambience + 5, 100);
                                                break;
                                            case ConsoleKey.F:
                                                ambience = Math.Max(ambience - 5, 0);
                                                break;

                                        }

                                        Console.Clear();
                                        DrawBars(masterVolume, backgroundMusic, voice, soundFX, ambience);

                                        if (Console.KeyAvailable)
                                        {
                                            ConsoleKeyInfo choos = Console.ReadKey(true);
                                            if (choos.Key == ConsoleKey.Backspace)
                                            {
                                                inAudioSettings = false;
                                                break; // Exit the inner loop
                                            }

                                        }
                                    }
                                }


                                break;

                            case ConsoleKey.R:
                                while (bol.Back_resolution)
                                {
                                    Console.Clear();
                                    Console.WriteLine(@"
                                                                                    ┌────────────────────────────────┐
                                                                                    │  ░█▀█░█▀█░▀█▀░▀█▀░█▀█░█▀█░█▀▀  │
                                                                                    │  ░█░█░█▀▀░░█░░░█░░█░█░█░█░▀▀█  │
                                                                                    │  ░▀▀▀░▀░░░░▀░░▀▀▀░▀▀▀░▀░▀░▀▀▀  │
                                                                                    └────────────────────────────────┘

                                                                                             │ │          │ │
                                                                                             │ │Resolution│ │
                                                                                             │ │          │ │

                                           
                                                                Resolution                         Name            Aspect Ratio       Pixel Size

                                                                SD (Standard Definition)           480p                4:3            640 x 480

                                                                HD (High Definition)               720p                16:9           1280 x 720

                                                                Full HD (FHD)                      1080p               16:9           1920 x 1080

                                                                2K video (Quad HD)                 2k or 1440          16:9           2560 x 1440

                                                                4K video or Ultra HD (UHD)         4K or 2160p         1:1.9          3840 x 2160

                                                                8K video or Full Ultra HD          8K or 4320p         16∶9           7680 x 4320  ");

                                    choose = Console.ReadKey(true);

                                    switch (choose.Key)
                                    {
                                        case ConsoleKey.Backspace:

                                            bol.Back_resolution = false;

                                            break;
                                    }
                                }
                                bol.Back_resolution = true;

                                break;
                            case ConsoleKey.D:

                                while (bol.Back_Difficulty)
                                {
                                    Console.Clear();
                                    Console.WriteLine(@"
                                                                                    ┌────────────────────────────────┐
                                                                                    │  ░█▀█░█▀█░▀█▀░▀█▀░█▀█░█▀█░█▀▀  │
                                                                                    │  ░█░█░█▀▀░░█░░░█░░█░█░█░█░▀▀█  │
                                                                                    │  ░▀▀▀░▀░░░░▀░░▀▀▀░▀▀▀░▀░▀░▀▀▀  │
                                                                                    └────────────────────────────────┘

                                                                                             │ │          │ │
                                                                                             │ │Difficulty│ │
                                                                                             │ │          │ │                                   ");

                                    Console.WriteLine(@"
                                                                                         Choose difficulty level:

                                                                     [1] - Easy               [2] - Medium                [3] - Hard                              ");


                                    choose = Console.ReadKey(true);



                                    while (bol.Exit)
                                    {


                                        switch (choose.Key)
                                        {
                                            case ConsoleKey.NumPad1:


                                                Console.WriteLine(@"
                                                                                         Difficulty set to Easy.");
                                                // Add code to handle Easy difficulty
                                                Console.ReadKey();
                                                bol.Exit = false;
                                                break;

                                            case ConsoleKey.NumPad2:


                                                Console.WriteLine(@"
                                                                                         Difficulty set to Medium.");
                                                Console.ReadKey();
                                                // Add code to handle Medium difficulty
                                                bol.Exit = false;
                                                break;

                                            case ConsoleKey.NumPad3:


                                                Console.WriteLine(@"
                                                                                         Difficulty set to Hard.");
                                                // Add code to handle Hard difficulty
                                                Console.ReadKey();
                                                bol.Exit = false;
                                                break;

                                            case ConsoleKey.Backspace:

                                                bol.Exit = false;
                                                bol.Back_Difficulty = false;

                                                break;

                                        }
                                    }
                                    bol.Exit = true;
                                }
                                bol.Back_Difficulty = true;



                                break;
                            case ConsoleKey.Backspace:

                                bol.Back_options = false;

                                break;
                        }
                    }

                    bol.Back_options = true;
                    break;

                case ConsoleKey.C:

                    bol.Back_credits = true;

                    while (bol.Back_credits)
                    {
                        Console.Clear();
                        Console.WriteLine(@"                                                                             
                                                                                    ┌────────────────────────────────┐
                                                                                    │  ░█▀▀░█▀▄░█▀▀░█▀▄░▀█▀░▀█▀░█▀▀  │
                                                                                    │  ░█░░░█▀▄░█▀▀░█░█░░█░░░█░░▀▀█  │
                                                                                    │  ░▀▀▀░▀░▀░▀▀▀░▀▀░░▀▀▀░░▀░░▀▀▀  │
                                                                                    └────────────────────────────────┘

                                                                                                Programmer

                                                                                           Jeremiaj Daneol Sapid

                                                                                                 Designer 

                                                                                           Jeremiaj Daneol Sapid

                                                                                                 Music

                                                                                           Jeremiaj Daneol Sapid

                                                                                                Producer 

                                                                                           JDMS Entertainment

                                                                                            Special thanks to~

                                                                                           Jeremiaj Daneol Sapid
                                                                             
               
                                                                                                                              ");
                        choose = Console.ReadKey(true);

                        switch (choose.Key)
                        {
                            case ConsoleKey.Backspace:

                                bol.Back_credits = false;

                                break;
                        }

                    }

                    break;
                case ConsoleKey.A:

                    bol.Back_about = true;
                    bol.Back_credits = true;

                    while (bol.Back_about)
                    {
                        Console.Clear();
                        Console.WriteLine(@"                                                                             
                                                                                    ┌────────────────────────┐
                                                                                    │  ░█▀█░█▀▄░█▀█░█░█░▀█▀  │
                                                                                    │  ░█▀█░█▀▄░█░█░█░█░░█░  │
                                                                                    │  ░▀░▀░▀▀░░▀▀▀░▀▀▀░░▀░  │
                                                                                    └────────────────────────┘


                                                   Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 
                                                 Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.
                                                 Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.
                                                 Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.  
 
                                                   Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 
                                                 Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. 
                                                 Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. 
                                                 Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.

                                                  Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 
                                                 Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. 
                                                 Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. 
                                                 Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.

                                                  Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 
                                                 Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. 
                                                 Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. 
                                                 Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.                ");
                        choose = Console.ReadKey(true);

                        switch (choose.Key)
                        {
                            case ConsoleKey.Backspace:

                                bol.Back_about = false;

                                break;
                        }

                    }

                    break;

                case ConsoleKey.X:

                    Console.Clear();
                    Console.WriteLine(@"
                                                                                            You sure you want to exit?
                                                                                                     [y/n]             ");
                    while (bol.Exit)
                    {
                        choose = Console.ReadKey(true);
                        switch (choose.Key)
                        {
                            case ConsoleKey.Y:
                                Console.Clear();
                                Console.WriteLine(@"
                                                                                              Exiting the program");
                                Console.ReadKey();
                                Environment.Exit(0);


                                break;

                            case ConsoleKey.N:

                                bol.Exit = false;
                                break;

                        }
                    }
                    bol.Exit = true;
                    break;

                case ConsoleKey.D:
                    Console.Clear();

                    while (bol.Exit)
                    {
                        Console.WriteLine(@"
                                           Do you want to delete your account?
                                                    [type yes]/no");

                        string input = Console.ReadLine().ToLower();
                        switch (input)
                        {
                            case "yes":
                                Console.Clear();

                                DeleteAccount();
                                Console.ReadKey();
                                Environment.Exit(0);
                                break;

                            case "no":
                                bol.Exit = false;
                                break;
                        }
                    }
                    bol.Exit = true;

                    break;

                case ConsoleKey.L:

                    Console.Clear();
                    while (bol.Start)                    /////////////////////////to add stupid txt, Mossy Way txt, Artful Escape txt , Close One txt, Red Cross txt , I Wonder txt
                    {
                        Console.Clear();
                        Console.WriteLine(@"
                ╔════════════════════╗╔════════════════════╗╔════════════════════╗╔════════════════════╗
                ║ [1] - Im Rich      ║║ [6] - Freedom Way  ║║ [Q] - That's it?   ║║ [null] - Empty     ║
                ║════════════════════║║════════════════════║║════════════════════║║════════════════════║
                ║ [2] - Too Greedy   ║║ [7] - Lazy Ass     ║║ [W] - Stupid       ║║ [null] - Empty     ║
                ║════════════════════║║════════════════════║║════════════════════║║════════════════════║
                ║ [3] - Miner Legacy ║║ [8] - Light's Glow ║║ [E] - Mossy Way    ║║ [y] - Red Cross    ║
                ║════════════════════║║════════════════════║║════════════════════║║════════════════════║                                  
                ║ [4] - ? ? ? ? ? ?  ║║ [9] - Choo-Choo    ║║ [R] - Artful Escape║║ [U] - I Wonder     ║
                ║════════════════════║║════════════════════║║════════════════════║║════════════════════║
                ║ [5] - WTF WAS THAT?║║ [0] - Got obitoed  ║║ [T] - Close One    ║║ [null] - Empty     ║
                ╚════════════════════╝╚════════════════════╝╚════════════════════╝╚════════════════════╝
");
                        while (bol.Exit)
                        {
                            choose = Console.ReadKey(true);
                            switch (choose.Key)
                            {
                                case ConsoleKey.U:
                                    Console.Clear();
                                    DisplayEndingScene_I_Wonder("I Wonder.txt");
                                    Console.ReadKey();

                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.Y:
                                    Console.Clear();
                                    DisplayEndingScene_Red_Cross("Red Cross.txt");
                                    Console.ReadKey();

                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.T:
                                    Console.Clear();
                                    DisplayEndingScene_Close_One("Close One.txt");
                                    Console.ReadKey();

                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.R:
                                    Console.Clear();
                                    DisplayEndingScene_Artful_Escape("Artful Escape.txt");
                                    Console.ReadKey();

                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.E:
                                    Console.Clear();
                                    DisplayEndingScene_Mossy_Way("Mossy Way.txt");
                                    Console.ReadKey();

                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.W:
                                    Console.Clear();
                                    DisplayEndingScene_Stupid("stupid.txt");
                                    Console.ReadKey();

                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.NumPad6:
                                    Console.Clear();
                                    DisplayEndingScene_Freedom("FreedomWay.txt");
                                    Console.ReadKey();

                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.NumPad7:
                                    Console.Clear();
                                    DisplayEndingScene_Lazy_Ass("Lazy_Ass.txt");
                                    Console.ReadKey();
                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.NumPad8:
                                    Console.Clear();
                                    DisplayEndingScene_Lights_Glow("Lights_Glow.txt");
                                    Console.ReadKey();
                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.NumPad9:
                                    Console.Clear();
                                    DisplayEndingScene_Choo_Choo_Trail("Choo-Choo_Trail.txt");
                                    Console.ReadKey();
                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.NumPad0:
                                    Console.Clear();
                                    DisplayEndingScene_Got_Obitoed("Got_obitoed.txt");
                                    Console.ReadKey();
                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.NumPad1:
                                    Console.Clear();
                                    DisplayEndingScene_Im_Rich("Im_Rich.txt");
                                    Console.ReadKey();
                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.NumPad2:
                                    Console.Clear();
                                    DisplayEndingScene_Too_Greedy("Too_Greedy.txt");
                                    Console.ReadKey();
                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.NumPad3:
                                    Console.Clear();
                                    DisplayEndingScene_Miners_Legacy("Miners_Legacy.txt");
                                    Console.ReadKey();
                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.NumPad4:
                                    Console.Clear();
                                    DisplayEndingScene_Easter("CIT TOPS AGAIN.txt");
                                    Console.ReadKey();
                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.NumPad5:
                                    Console.Clear();
                                    DisplayEndingScene_WTF("WTF.txt");
                                    Console.ReadKey();
                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.Q:
                                    Console.Clear();
                                    DisplayEndingScene_That_It("That's_it.txt");
                                    Console.ReadKey();
                                    bol.Exit = false;
                                    break;
                                case ConsoleKey.Backspace:
                                    bol.Exit = false;
                                    bol.Start = false;
                                    break;

                            }
                        }
                        bol.Exit = true;

                    }
                    bol.Start = true;
                    break;


                default:

                    break;
            }





        }
    }

    static void DisplayEndingScene_Freedom(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                   
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine();

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        Console.WriteLine(line);
                    }

                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
                   
                }
            }
            else
            {
                Console.WriteLine($"Ending is not unlocked, play and find out more");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading ending scene: {ex.Message}");
        }
    }
    static void DisplayEndingScene_Easter(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {

                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine();

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        Console.WriteLine(line);
                    }

                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");

                }
            }
            else
            {
                Console.WriteLine($"Ending is not unlocked, play and find out more");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading ending scene: {ex.Message}");
        }
    }
    static void DisplayEndingScene_Lazy_Ass(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                   
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine();

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        Console.WriteLine(line);
                    }

                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
                    
                }
            }
            else
            {
                Console.WriteLine($"Ending is not unlocked, play and find out more");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading ending scene: {ex.Message}");
        }
    }
    static void DisplayEndingScene_Lights_Glow(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine();

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        Console.WriteLine(line);
                    }

                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
                  
                }
            }
            else
            {
                Console.WriteLine($"Ending is not unlocked, play and find out more");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading ending scene: {ex.Message}");
        }
    }

    static void DisplayEndingScene_Im_Rich(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {

                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine();

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        Console.WriteLine(line);
                    }

                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");

                }
            }
            else
            {
                Console.WriteLine($"Ending is not unlocked, play and find out more");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading ending scene: {ex.Message}");
        }
    }
    static void DisplayEndingScene_WTF(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {

                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine();

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        Console.WriteLine(line);
                    }

                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");

                }
            }
            else
            {
                Console.WriteLine($"Ending is not unlocked, play and find out more");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading ending scene: {ex.Message}");
        }
    }
    static void DisplayEndingScene_That_It(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {

                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine();

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        Console.WriteLine(line);
                    }

                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");

                }
            }
            else
            {
                Console.WriteLine($"Ending is not unlocked, play and find out more");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading ending scene: {ex.Message}");
        }
    }
    static void DisplayEndingScene_Got_Obitoed(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {

                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine();

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        Console.WriteLine(line);
                    }

                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");

                }
            }
            else
            {
                Console.WriteLine($"Ending is not unlocked, play and find out more");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading ending scene: {ex.Message}");
        }
    }
    static void DisplayEndingScene_Choo_Choo_Trail(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {

                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine();

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        Console.WriteLine(line);
                    }

                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");

                }
            }
            else
            {
                Console.WriteLine($"Ending is not unlocked, play and find out more");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading ending scene: {ex.Message}");
        }
    }
    static void DisplayEndingScene_Too_Greedy(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {

                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine();

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        Console.WriteLine(line);
                    }

                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");

                }
            }
            else
            {
                Console.WriteLine($"Ending is not unlocked, play and find out more");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading ending scene: {ex.Message}");
        }
    }
    static void DisplayEndingScene_Miners_Legacy(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {

                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine();

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        Console.WriteLine(line);
                    }

                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");

                }
            }
            else
            {
                Console.WriteLine($"Ending is not unlocked, play and find out more");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading ending scene: {ex.Message}");
        }
    }
    static void DisplayEndingScene_Stupid(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {

                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine();

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        Console.WriteLine(line);
                    }

                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");

                }
            }
            else
            {
                Console.WriteLine($"Ending is not unlocked, play and find out more");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading ending scene: {ex.Message}");
        }
    }
    static void DisplayEndingScene_Mossy_Way(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {

                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine();

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        Console.WriteLine(line);
                    }

                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");

                }
            }
            else
            {
                Console.WriteLine($"Ending is not unlocked, play and find out more");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading ending scene: {ex.Message}");
        }
    }
    static void DisplayEndingScene_Artful_Escape(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {

                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine();

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        Console.WriteLine(line);
                    }

                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");

                }
            }
            else
            {
                Console.WriteLine($"Ending is not unlocked, play and find out more");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading ending scene: {ex.Message}");
        }
    }
    static void DisplayEndingScene_Close_One(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {

                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine();

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        Console.WriteLine(line);
                    }

                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");

                }
            }
            else
            {
                Console.WriteLine($"Ending is not unlocked, play and find out more");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading ending scene: {ex.Message}");
        }
    }
    static void DisplayEndingScene_Red_Cross(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {

                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine();

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        Console.WriteLine(line);
                    }

                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");

                }
            }
            else
            {
                Console.WriteLine($"Ending is not unlocked, play and find out more");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading ending scene: {ex.Message}");
        }
    }
    static void DisplayEndingScene_I_Wonder(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {

                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine();

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        Console.WriteLine(line);
                    }

                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");

                }
            }
            else
            {
                Console.WriteLine($"Ending is not unlocked, play and find out more");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading ending scene: {ex.Message}");
        }
    }


    static void DrawBars(int master, int bgMusic, int voice, int soundFX, int ambience)
    {
        Console.WriteLine($@"
                                                                                    ┌────────────────────────────────┐
                                                                                    │  ░█▀█░█▀█░▀█▀░▀█▀░█▀█░█▀█░█▀▀  │
                                                                                    │  ░█░█░█▀▀░░█░░░█░░█░█░█░█░▀▀█  │
                                                                                    │  ░▀▀▀░▀░░░░▀░░▀▀▀░▀▀▀░▀░▀░▀▀▀  │
                                                                                    └────────────────────────────────┘

                                                                                                │ │     │ │
                                                                                                │ │Audio│ │
                                                                                                │ │     │ │


Master volume:     {DrawBar(master)}      [Up and Down Arrow keys]

Background music:  {DrawBar(bgMusic)}       [Left and Right Arrow keys]

Voice:             {DrawBar(voice)}       [W and S keys]

Sound FX:          {DrawBar(soundFX)}       [A and D keys]

Ambience:          {DrawBar(ambience)}       [F and H keys]                ");
    }

    static string DrawBar(int value)
    {
        int barLength = value / 2;
        string bar = new string('█', barLength) + new string('░', 50 - barLength);
        return $"{bar}  {value}%";
    }
    static void LoadGame2()
    {
        try
        {
            Console.Clear();
            Console.WriteLine("Load Game:");

            string[] savedGames = Directory.GetFiles(SaveDirectory);

            if (savedGames.Length == 0)
            {
                Console.WriteLine("No saved games found.");
                Console.WriteLine("Press 'enter' to continue...");
                Console.ReadLine();
                return;
            }

            for (int i = 0; i < savedGames.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Path.GetFileName(savedGames[i])}");
            }

            Console.WriteLine("Enter the number of the saved game to load or type 'd' to delete a saved game:");
            string choice = Console.ReadLine();

            if (choice.ToLower() == "d")
            {
                DeleteSavedGame();
            }
            else if (int.TryParse(choice, out int selectedGame) && selectedGame > 0 && selectedGame <= savedGames.Length)
            {
                string selectedGamePath = savedGames[selectedGame - 1];
                string savedData = File.ReadAllText(selectedGamePath);
                Console.WriteLine($"Game Loaded from '{Path.GetFileName(selectedGamePath)}':");
                Console.WriteLine(savedData);

                // Continue the game with loaded data
                Console.WriteLine("Continuing the game...");
                PlayLoadedGame(savedData);
            }
            else
            {
                Console.WriteLine("Invalid input. Press 'enter' to continue...");
                Console.ReadLine();
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error loading the game: {ex.Message}");
            Console.WriteLine("Press 'enter' to continue...");
            Console.ReadLine();
        }
    }

    static void SaveGame2()
    {
        try
        {
            // Generate a unique file name based on timestamp
            string fileName = $"SavedGame_{DateTime.Now:yyyyMMddHHmmss}.txt";
            string filePath = Path.Combine(SaveDirectory, fileName);

            // Save the game state to the generated file
            File.WriteAllText(filePath, "Game state saved.");

            Console.WriteLine($"Game saved successfully to '{fileName}'!");
            Console.WriteLine("Press 'enter' to continue...");
            Console.ReadLine();
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error saving the game: {ex.Message}");
            Console.WriteLine("Press 'enter' to continue...");
            Console.ReadLine();
        }
    }

    static void PlayLoadedGame(string loadedData)
    {
        // Implement logic to continue the game with loaded data
        Console.WriteLine($"Loaded game data: {loadedData}");
        Console.WriteLine("Continue the game...");
        Console.WriteLine("Press 'esc' to save and go back to the main menu.");

        string input;
        do
        {
            input = Console.ReadLine();

            if (input.ToLower() == "esc")
            {
                SaveGame();
                return;
            }

            // Continue your game logic here

        } while (true);
    }

    static void DeleteSavedGame()
    {
        Console.Clear();
        Console.WriteLine("Delete Saved Game:");

        string[] savedGames = Directory.GetFiles(SaveDirectory);

        if (savedGames.Length == 0)
        {
            Console.WriteLine("No saved games found.");
            Console.WriteLine("Press 'enter' to continue...");
            Console.ReadLine();
            return;
        }

        Console.WriteLine("Select the saved game to delete:");
        for (int i = 0; i < savedGames.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {Path.GetFileName(savedGames[i])}");
        }

        Console.Write("Enter the number of the saved game to delete: ");
        if (int.TryParse(Console.ReadLine(), out int selectedGame) && selectedGame > 0 && selectedGame <= savedGames.Length)
        {
            string selectedGamePath = savedGames[selectedGame - 1];
            File.Delete(selectedGamePath);
            Console.WriteLine($"Saved game '{Path.GetFileName(selectedGamePath)}' deleted successfully!");
        }
        else
        {
            Console.WriteLine("Invalid input. Press 'enter' to continue...");
            Console.ReadLine();
        }
    }

    public static void SavePlayer(Player player)
    {
        string jsonData = JsonConvert.SerializeObject(player);      
        File.WriteAllText("save_game.json", jsonData);
        Console.WriteLine("Game saved successfully.");
    }

    // Load player data from a file
    public static Player LoadPlayer()
    {
        if (File.Exists("save_game.json"))
        {
            string jsonData = File.ReadAllText("save_game.json");
            return JsonConvert.DeserializeObject<Player>(jsonData);
        }
        else
        {
            Console.WriteLine("No saved game found.");
            return null;
        }
    }

      public static void SaveGame()
    {
        using (StreamWriter writer = new StreamWriter("save.txt"))
        {
            Player player = new Player();
            // Save relevant game state data
            writer.WriteLine(Player.Name);
            writer.WriteLine(player.Lives);

            // Save other game state variables...
        }

        Console.WriteLine("Game saved!");
    }

    public static void LoadGame()
    {
        //Player player = new Player();

        using (StreamReader reader = new StreamReader("save.txt"))
        {
            // Load relevant game state data

            Player.Name = reader.ReadLine();
            //int.TryParse(reader.ReadLine(), out player.Lives);

            // Load other game state variables...
        }

        Console.WriteLine("Game loaded. Welcome back, " + Player.Name + "!");
    }

    static void LoadSavedMethod(string filePath)
    {
        try
        {
            // Load the contents of the file
            string fileContents = File.ReadAllText(filePath);

            // Display the loaded contents
            Console.WriteLine("Loaded Contents:");
            Console.WriteLine(fileContents);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error while loading file: " + ex.Message);
        }
    }

    static void CreateAccount(string Name)
    {
        Bool bol = new Bool();
        //Player player = new Player();

        if (bol.Back_game)
        {
            try
            {
                Player.Name = GetNonBlankInput(@"         
                                                                      ╔────────────────────────────────────────────────────────────────────────────────────────╗
                                                                      │ _____ _   _ _____ _____ ____      _   _ ____  _____ ____  _   _    _    __  __ _____   │
                                                                      │| ____| \ | |_   _| ____|  _ \    | | | / ___|| ____|  _ \| \ | |  / \  |  \/  | ____|_ │ 
                                                                      │|  _| |  \| | | | |  _| | |_) |   | | | \___ \|  _| | |_) |  \| | / _ \ | |\/| |  _| (_)│
                                                                      │| |___| |\  | | | | |___|  _ <    | |_| |___) | |___|  _ <| |\  |/ ___ \| |  | | |___ _ │
                                                                      │|_____|_| \_| |_| |_____|_| \_\    \___/|____/|_____|_| \_\_| \_/_/   \_\_|  |_|_____(_)│
                                                                      ╚────────────────────────────────────────────────────────────────────────────────────────╝  

                                                                                           Aa   Bb   Cc   Dd   Ee   Ff   Gg   Hh   Ii   Jj    

                                                                                           Kk   Ll   Mm   Nn   Oo   Pp   Qq   Rr    Ss   Tt  

                                                                                                     Uu    Vv   Ww   Xx  Yy    Zz 
 
                                                                                                     0  1  2  3  4  5  6  7  8  9  
                                                                                                         
                                                                                                                 ");



                 Name = Player.Name;

               
               


                //Name = Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine($@"
                                                                                                    Error: {ex.Message}");
            }

            bol.Back_game = false;

        }
        Console.Clear();

        //Player.Achievements = new List<string>();

        using (StreamWriter writer = new StreamWriter(accountFileName, true))
        {
            
            //writer.WriteLine("Account");
              writer.WriteLine($"{Player.Name}");
            //writer.WriteLine("Achievements");       
           
        }

      

        Adjust adj = new Adjust();

        adj.Slowprint(@"
                                     Account Logging in...", 50);
        adj.Slowprint(@"
                                     Account Logging in...", 50);
        adj.Slowprint(@"
                                     Account Logging in...", 50);

        if (Authenticate(Player.Name))
        {
            Console.WriteLine($@"WELCOME {Player.Name}");
        }
        else
        {
            Console.WriteLine("DATA IS CORRUPTED. START A NEW ONE.");
        }

        MainMenu mp = new MainMenu();
        mp.ShowAll2();

    }

    static bool Authenticate(string Name)
    {

        using (StreamReader reader = new StreamReader(accountFileName))
        {
            string Account = reader.ReadLine();

           // Name = Player.Name;

            return Player.Name == Account;
        }
        
    }

    static string Account(string name)
    {
        // Read the stored username from the file
        using (StreamReader reader = new StreamReader(accountFileName))
        {
            while(!reader.EndOfStream)
            {
                string Name = Player.Name;
                //string Ach = Player.Achievements;

                Player.Name = reader.ReadLine();
                //Player.Achievements = reader.ReadLine();
                // Skip the password line
                //reader.ReadLine();
                if (Player.Name == name)    
                {
                    return Player.Name;
                }
               

            }                 
        }
        return null;
    }

    static void DeleteAccount()
    {
        if (File.Exists(accountFileName))
        {
            File.Delete(accountFileName);
            Console.WriteLine("Account deleted successfully.");
            File.Delete("FreedomWay.txt");
            File.Delete("Choo-Choo_Trail.txt");
            File.Delete("Got_obitoed.txt");
            File.Delete("Too_Greedy.txt");
            File.Delete("Lights_Glow.txt");
            File.Delete("Im_Rich.txt");
            File.Delete("Too_Greedy.txt");
            File.Delete("Miners_Legacy");
            File.Delete("CIT TOPS AGAIN.txt");
            File.Delete("WTF.txt");
            File.Delete("Thats_it.txt");
            File.Delete("I Wonder.txt");
            File.Delete("Red Cross.txt");
            File.Delete("Close One.txt");
            File.Delete("Artful Escape.txt");
            File.Delete("Mossy Way.txt");
            File.Delete("stupid.txt");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("No account found to delete.");
        }

        Console.Clear();
        Console.WriteLine(@"
                                                             ░█▀█░█▀▀░█░█░░░█▀▀░█▀█░█▄█░█▀▀░▀▀█                    
                                                             ░█░█░█▀▀░█▄█░░░█░█░█▀█░█░█░█▀▀░░▀░                    
                                                             ░▀░▀░▀▀▀░▀░▀░░░▀▀▀░▀░▀░▀░▀░▀▀▀░░▀░   

                                                   ░█▀▀░█▀▄░█▀▀░█▀█░▀█▀░█▀▀░░░█▀█░█▀▀░█▀▀░█▀█░█░█░█▀█░▀█▀
                                                   ░█░░░█▀▄░█▀▀░█▀█░░█░░█▀▀░░░█▀█░█░░░█░░░█░█░█░█░█░█░░█░
                                                   ░▀▀▀░▀░▀░▀▀▀░▀░▀░░▀░░▀▀▀░░░▀░▀░▀▀▀░▀▀▀░▀▀▀░▀▀▀░▀░▀░░▀░ ");
        Console.ReadKey();
        Console.Clear();

        Login logg = new Login();
        logg.Terms_0f_Service();
        Console.ReadKey();
        CreateAccount(Player.Name);
    }

    static string GetNonBlankInput(string prompt)
    {
        string input = "";

        while (true)
        {
            try
            {
                Console.Clear();

                Console.Write(prompt);
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    throw new ArgumentException("Input cannot be blank.");
                }

                break; // Break out of the loop if input is valid
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        return input;
    }

    public void LoadAchievements()
    {
        try
        {
            using (StreamReader reader = new StreamReader(accountFileName))
            {
                string line;
                bool inAchievementsSection = false;

                while ((line = reader.ReadLine()) != null)
                {
                    if (line == "Achievements")
                    {
                        inAchievementsSection = true;
                        continue;
                    }

                    if (inAchievementsSection && !string.IsNullOrWhiteSpace(line))
                    {
                        Player.Achievements.Add(line);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading achievements: {ex.Message}");
        }
    }

    



}  



