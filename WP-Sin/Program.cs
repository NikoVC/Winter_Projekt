using System.Security.Cryptography;

int quit = 0;
int played = 0;
string Sin = "sin";
string sinColor = "somethin";
while (quit == 0)
{
    int PubOpi = 0;
    bool win = false;
    bool dead = false;
// Introductions to game, tell player choose a sin
Console.WriteLine("...");
Console.WriteLine("Greetings player and welcome to the game that is driven upon the sins you commit");
Console.WriteLine("");
Console.WriteLine("While Alive you believed yourself virtuous and pure");
Console.WriteLine("Unfortunately that isn't as true as you would've hoped");
Console.ReadLine();
Console.Clear();
Console.WriteLine("During the happenings of this game You'll be sent to a new world, this world is in danger and it is your job to save it");
Console.WriteLine("");
Console.WriteLine("Why? You ask, it's simple this is your redemption, trek through this new world and make up for your sins and once you're done you'll be granted heaven");
Console.ReadLine();
Console.Clear();

// Player chooses a sin and have it recorded
Console.WriteLine("Choose the sing you align with the most");
//Blabla seven sins
Console.WriteLine("");
Console.WriteLine("Sloth, The sin of apathy and abondonment of one owns will");
Console.WriteLine("Wrath, The sin of unwavering rage and burning hatred");
Console.WriteLine("Gluttony, The sin of a ravenous hunger that is never sated");
Console.WriteLine("Envy, The sin of want and longing for what others have");
Console.WriteLine("Lust, The sin of submission to depravity and pleasure never found");
Console.WriteLine("Greed, The sin of taking more & more & more & more & more and MORE");
Console.WriteLine("Pride, The lion sin of Superiority");
int sinW = 0;
if (played == 0)
{
while (sinW == 0)
{
String sinQ = Console.ReadLine().ToLower();
if (sinQ == "1" || sinQ == "sloth")
    {
     Sin = "Sloth";
     sinColor = "Pale Blue";
        sinW++;
    }
else if (sinQ == "2" || sinQ == "wrath")
    {
       Sin = "Wrath";  
     sinColor = "Blood Red";
        sinW++;
    }
else if (sinQ == "3" || sinQ == "gluttony")
    {
        Sin = "Gluttony"; 
     sinColor = "Dark Brown";
        sinW++;
    }
    else if (sinQ == "4" || sinQ == "envy")
    {
        Sin = "Envy";
     sinColor = "Shining Green";
        sinW++;
    }
    else if (sinQ == "5" || sinQ == "lust")
    {
        Sin = "Lust";
     sinColor = "Hot Pink";
        sinW++;
    }
    else if (sinQ == "6" || sinQ == "greed")
    {
        Sin = "Greed";
     sinColor = "Golden Yellow";
        sinW++;
    }
    else if (sinQ == "7" || sinQ == "pride")
    {
        Sin = "Pride";
     sinColor = "Royal Purple";
        sinW++;
    }
    else
    {
        Console.WriteLine("You have to choose one");
    }
}
}
else
{
Console.WriteLine("Murder, The sin more depraved than any other. Killing another at the cost of oneself");
while (sinW == 0)
{
String sinQ = Console.ReadLine().ToLower();
if (sinQ == "1" || sinQ == "sloth")
    {
     Sin = "Sloth";
     sinColor = "Pale Blue";
        sinW++;
    }
else if (sinQ == "2" || sinQ == "wrath")
    {
       Sin = "Wrath";  
     sinColor = "Blood Red";
        sinW++;
    }
else if (sinQ == "3" || sinQ == "gluttony")
    {
        Sin = "Gluttony"; 
     sinColor = "Dark Brown";
        sinW++;
    }
    else if (sinQ == "4" || sinQ == "envy")
    {
        Sin = "Envy";
     sinColor = "Shining Green";
        sinW++;
    }
    else if (sinQ == "5" || sinQ == "lust")
    {
        Sin = "Lust";
     sinColor = "Hot Pink";
        sinW++;
    }
    else if (sinQ == "6" || sinQ == "greed")
    {
        Sin = "Greed";
     sinColor = "Golden Yellow";
        sinW++;
    }
    else if (sinQ == "7" || sinQ == "pride")
    {
        Sin = "Pride";
     sinColor = "Royal Purple";
        sinW++;
    }
        else if (sinQ == "8" || sinQ == "murder")
    {
        Sin = "Murder";
     sinColor = "Void Black";
        sinW++;
    }
    else
    {
        Console.WriteLine("You have to choose one");
    }
}
}
Console.WriteLine($"I see, so that's what you are. You are one who has commited the Sin of {Sin}, so much to the point that you fully embody it");
Console.WriteLine("Beware, the point to which you embody your sin is so large that you'll practically be smelling of it and anyone will easily be able to tell who you are");
Console.WriteLine("But for now let's continue with you entrance into this world");
Console.ReadLine();
Console.Clear();

// Have player distríbute stats points to improve their capabilities
int StatP = 10;
int phys = 1;
int mag = 1;
int tol = 1;
int soc = 1;
Console.WriteLine("In order for you to progress in this world you have to use your capabilities to fight, cast and talk your way to the other side, while also surviving all the way");
Console.WriteLine("Please Distribute these 10 Stat Points to Improve your capabilities");
Console.WriteLine("");
Console.WriteLine("Press 1 to Increase your Physicality");
Console.WriteLine("Press 2 to Increase your Magic");
Console.WriteLine("Press 3 to Increase your Tolerance");
Console.WriteLine("Press 4 to Increase your Sociability");
while (StatP > 0)
    {
Console.WriteLine($"Remaining Stat Points: {StatP}");
Console.WriteLine("");
Console.WriteLine($"Physicality: {phys}");
Console.WriteLine($"Magic: {mag}");
Console.WriteLine($"Tolerance: {tol}");
Console.WriteLine($"Social: {soc}");

// ConsoleKeyInfo info = Console.ReadKey();
// if (info.Key == ConsoleKey.D1) {}
// ^This Code I got help from teach 

ConsoleKeyInfo info = Console.ReadKey();
if (info.Key == ConsoleKey.D1)
        {
            if (phys < 7)
            {   
         phys++;  
         StatP--; 
            }
            else
            {
Console.Clear();
Console.WriteLine("This Stat is already maxxed, try again");
Console.ReadLine();
            }
        }
else if (info.Key == ConsoleKey.D2)
        {
            if (mag < 7)
            {   
            mag++;
         StatP--; 
            }
            else
            {
Console.Clear();
Console.WriteLine("This Stat is already maxxed, try again");
Console.ReadLine();
            }
        }
else if (info.Key == ConsoleKey.D3)
        {
            if (tol < 7)
            {   
           tol++; 
         StatP--; 
            }
            else
            {
Console.Clear();
Console.WriteLine("This Stat is already maxxed, try again");
Console.ReadLine();
            }
        }
else if (info.Key == ConsoleKey.D4)
        {
            if (soc < 7)
            {   
            soc++;
         StatP--; 
            }
            else
            {
Console.Clear();
Console.WriteLine("This Stat is already maxxed, try again");
Console.ReadLine();
            }
        }
Console.Clear();
    }
int hp = tol*2;

// Ask the player if they want to play with the ability to see the difficulty of skill checks or not
bool a = false;
Console.WriteLine("Now, final thing before you'll be sent into this new world.");
Console.WriteLine("Would you like to see to play on easy mode? Yes, or no?");
while (StatP > -1)
    { 
string b = Console.ReadLine().ToLower();
if (b=="yes"||b=="y")
    {
        a = true;
        StatP--;
    }
    else if (b=="no"||b=="n")
    {
        a = false;
        StatP--;
    }
    else
        {
Console.WriteLine("Try again");
        }
    }

//Begin story and do stuff
// Tutorial Guide Summoner, dialouge workings, skill checks, Sin Checks
Console.Clear();
Console.WriteLine("...");
Console.ReadLine();
Console.WriteLine("...");
Console.ReadLine();
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;
Console.Clear();
Console.WriteLine("A bright white light shines through your lidded eyes as you awake in a brightly lit room.");
Console.WriteLine("The room is circular in nature, wood plank floors with cobblestone walls, a few messy shelves stacked up against them");
Console.WriteLine($"Right in front of you stands a woman, golden hair flowing over her shoulder and golden eyes that meet your own {sinColor} eyes");

// Console.ForegroundColor = ConsoleColor.Yellow;
// Console.WriteLine("Guiding Star:");
// Console.ForegroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Guiding Star: Greeting's Sinner, I am your personal guiding star, assigned to your aid in this new world");
Console.ForegroundColor = ConsoleColor.Black;




// Have dialouge and skill checks, with extra sin actions and addons to the dialogue based on your sin


// Multiple endings based on Public Opinion and whether you win or lose at the end, your sin also gives an extra little add on in every ending

// 5-7 endings, public opinion low, public opinion high, public opinion medium, win, lose, death and so on
if (dead == true)
    {
        // End 7
    }
else if (win == true && PubOpi > 15)
    {
        // End 1
    }
else if (win == true && PubOpi < 15 && PubOpi > 0)
    {
        // End 2
    }
else if (win == true && PubOpi < 0)
    {
        // End 3
    }
else if (win == false && PubOpi > 15)
    {
        // End 4
    }
else if (win == false && PubOpi < 15 && PubOpi > 0)
    {
        // End 5
    }
else if (win == false && PubOpi < 0)
    {
        // End 6
    }

// END, restart or quit
int Q = 0;
while (Q == 0)
{
Console.WriteLine("Want to play again?");
String Retry = Console.ReadLine().ToLower();
if (Retry == "y" || Retry == "yes")
    {
    Q++;
       played++;
       Console.Clear();
    }
    else if (Retry == "n" || Retry == "no")
    {
        quit++;
        Q++;
    }
    else
        {
        Console.WriteLine("Not a valid answer. Try Again.");
        }
}
}

Console.WriteLine("Press Anything to Quit!");
Console.ReadLine();