using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class MainProgram
{
    static void Main(string[] args)
    {
        MainMenu menu = new MainMenu();
        Login Log = new Login();
       
        Log.showlog1();

        bool checker = false;

        if(!checker)
        {
            if(!File.Exists("Account.txt"))
            {
                Log.Terms_0f_Service();
            }
            
        }
      
        Log.ShowLog();
        Console.Clear();
        menu.LogIN();
        menu.ShowAll2();
        


        //yep
        //Player player = new Player();


   
    }

    
}

