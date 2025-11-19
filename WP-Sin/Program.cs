int quit = 0;
int played = 0;
while (quit == 0)
{
// Introductions to game, tell player choose a sin
Console.WriteLine("...");
Console.WriteLine("Greetings player and welcome to the game that is droven upon the sins you commit");
Console.WriteLine("");
Console.WriteLine("While Alive you believed yourself virtuous and pure");
Console.WriteLine("Unfortunately that isn't as trua as you would've hoped");
Console.ReadLine();
Console.Clear();
Console.WriteLine("During the happenings of this game You'll be sent to a new ");
Console.WriteLine("");

// Player chooses a sin and have it recorded
Console.WriteLine("Choose the sing you align yourself with the most");
//Blabla seven sins
int sinW = 0;
while (sinW == 0)
{
String sinQ = Console.ReadLine().ToLower();
if (sinQ == "1" || sinQ == "sloth")
    {
       string Sin = "Sloth";
        sinW++;
    }
else if (sinQ == "2" || sinQ == "wrath")
    {
        string Sin = "Wrath";  
        sinW++;
    }
else if (sinQ == "3" || sinQ == "gluttony")
    {
       string Sin = "Gluttony"; 
        sinW++;
    }
    else if (sinQ == "4" || sinQ == "envy")
    {
        string Sin = "Envy";
        sinW++;
    }
    else if (sinQ == "5" || sinQ == "lust")
    {
        string Sin = "Lust";
        sinW++;
    }
    else if (sinQ == "6" || sinQ == "greed")
    {
        string Sin = "Greed";
        sinW++;
    }
    else if (sinQ == "7" || sinQ == "pride")
    {
        string Sin = "Pride";
        sinW++;
    }
        else if (sinQ == "8" || sinQ == "murder")
    {
        string Sin = "Killer";
        sinW++;
    }
    else
    {
        Console.WriteLine("You have to choose one");
    }
}

Console.WriteLine($"I see, so you're a sinner who has commited the sin of {Sin}");
// Have player distríbute stats points to improve their capabilities

// Ask the player if they want to play with the ability to see the difficulty of skill checks or not

//Begin story and do stuff

// Have dialouge and skill checks, with extra sin actions and addons to the dialogue based on your sin

// Multiple endings based on Public Opinion and whether you win or lose at the end, your sin also gives an extra little add on in every ending

// 5-7 endings, public opinion low, public opinion high, public opinion medium, win, lose, death and so on
int Q = 0;
while (Q == 0)
{
Console.WriteLine("Want to play again?");
String Retry = Console.ReadLine();
if (Retry == "Yes" || Retry == "yes")
    {
    Q++;
       played++;
       Console.Clear();
    }
    else if (Retry == "No" || Retry == "no")
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