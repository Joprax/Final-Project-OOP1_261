using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Bool
{
    private bool mainmenu = true;  
    private bool back_menu = false;
    private bool back_credits = false;
    private bool back_about = false;
    private bool back_options = false;
    private bool back_sce1 = true;
    private bool askinput = true;
    private bool exit = true;
    private bool back_audio = true;
    private bool back_resolution = true;
    private bool Return = true;
    private bool back_Game = true;
    private bool back_Inventory = true;
    private bool escape = true;
    private bool back_Difficlty = true;
    private bool useItem = true;
    private bool in_exit = true;
    private bool settings = true;
    private bool start = true;
    private bool start2 = true;
    private bool backGameExecuted = true;
    private bool exit2 = true;

    public bool Exit2 { get { return exit2; } set { exit2 = value; } }
    public bool BackGameExecuted { get { return backGameExecuted; } set { backGameExecuted = value; } }

    public bool Start2 { get { return start2; } set { start2 = value; } }
    public bool Start { get { return start; } set { start = value; } }

    public bool Settings { get { return settings; } set { settings = value; } }


    public bool In_exit { get { return in_exit; } set { in_exit = value; } }


    public bool UseItem { get { return useItem; } set { useItem = value; } }

    public bool Back_Difficulty { get { return back_Difficlty; } set { back_Difficlty = value; } }
    public bool Escape { get { return escape; } set { escape = value; } }
    public bool Back_Inventory { get { return back_Inventory; } set { back_Inventory = value; } }
    public bool Back_game { get { return back_Game; } set { back_Game = value; } }

    public bool Mainmenu {  get { return mainmenu; } set {  mainmenu = value; } }
    public bool Back_menu { get { return back_menu; } set { back_menu = value; } }
    public bool Back_credits { get { return back_credits; } set { back_credits = value; } }
    public bool Back_about { get { return back_about; } set { back_about = value; } }
    public bool Back_options { get { return back_options; } set { back_options = value; } }
    public bool Back_sce1 { get { return back_sce1; } set { back_sce1 = value; } }
    public bool Askinput { get { return askinput; } set { askinput = value; } }
    public bool Exit { get { return exit; } set { exit = value; } }
    public bool Back_audio { get { return back_audio; } set { back_audio = value; } }
    public bool Back_resolution { get { return back_resolution; } set { back_resolution = value; } }
    public bool Returnn { get { return Return; } set { Return = value; } }


}