using System.Diagnostics;
using System.Security.Cryptography;
using System.Xml;

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
Console.WriteLine("While Alive you believed yourself virtuous and pure");
Console.WriteLine("Unfortunately that isn't as true as you would've hoped");
Console.ReadLine();
Console.Clear();
Console.WriteLine("During the happenings of this game You'll be sent to a new world, this world is in danger and it is your job to save it");
Console.WriteLine("Why? You ask, it's simple this is your redemption, trek through this new world and make up for your sins and once you're done you'll be granted heaven");
Console.ReadLine();
Console.Clear();

// Player chooses a sin and have it recorded
Console.WriteLine("Choose the sing you align with the most");
//Blabla seven sins
Console.WriteLine("");
Console.WriteLine("1. Sloth, The sin of apathy and abondonment of one owns will");
Console.WriteLine("2. Wrath, The sin of unwavering rage and burning hatred");
Console.WriteLine("3. Gluttony, The sin of a ravenous hunger that is never sated");
Console.WriteLine("4. Envy, The sin of want and longing for what others have");
Console.WriteLine("5. Lust, The sin of submission to depravity and pleasure never found");
Console.WriteLine("6. Greed, The sin of taking more & more & more & more & more and MORE");
Console.WriteLine("7. Pride, The lion sin of Superiority");
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
Console.WriteLine("8. Murder, The sin more depraved than any other. Killing another at the cost of oneself");
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
Console.WriteLine("But for now let's continue with your entrance into this world");
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
Console.WriteLine("");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("Guiding Star: Greeting's Sinner, I am your personal guiding star, assigned to your aid in this new world");
Console.WriteLine("My divine purpose is to help you journey across these lands and defeat the vile demon king that lay at the end of your road");
Console.WriteLine("BUT");
Console.WriteLine("Before you can challenge the Demon King, you have to grow stronger, wiser, kinder");
Console.WriteLine("And in order to do all these things, you need to learn how to be kind and amicable!");
Console.WriteLine("That is what I'm here for!");
Console.WriteLine("To show you how to be kind and Amicable by suggesting possible answers whenever you're meet with a decision");
Console.WriteLine("Let's run a test example of what I mean!");
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.ReadLine();
Console.Clear();

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("Corrupted Heart: Pst, hey! Hey! It's me! Your heart! Listen, I'm all corrupted from your sins...");
Console.WriteLine("Corrupted Heart: So let's ignore that guiding star and just do whatever we want, yeah?");
Console.WriteLine("Corrupted Heart: Alright, listen, I'm just a heart so I can't hear anything you say, but to make sure that filthy star doesn't realise I'm here I'm just going to stay hidden");
Console.WriteLine("Corrupted Heart: And I'll just insert our own choices that we can make when talking with people, that way we can pretend to be going along with her plan, but when we start acting however we want we can just blame her");
Console.WriteLine("Corrupted Heart: Anyway I need to leave now before she comes back, but don't worry! I'm always apart of you! I'm your literal heart after all");
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.ReadLine();
Console.Clear();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("Guiding Star: I'm sorry, did you hear something just now? No? Weird, I swore i could hear the annoying screetching of a pesky imp");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Corrupted Heart: Hey! Rude!");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Guiding Star: There it was again! A quiet discord of noise that makes eardrums burst and bleed");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Corrupted Heart: Uhhhhhh, nope, just the wind!");
Console.WriteLine("Corrupted Heart: ... Wind noises~");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Guiding Star: Oh! I guess it was just the wind, odd, there isn't supposed to be any wind in here though");
Console.WriteLine("Guiding Star: Oh well!");
Console.WriteLine("Guiding Star: Now back onto the test example!");
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.DarkGray;
Console.ReadLine();
Console.Clear();

Console.WriteLine("Test Villager A: [GREETINGS SINNER TO MY HUMBLE ABODE. WOULD YOU LIKE A GLASS OF WATER, OR PERHAPS A TEA, OR PERHAPS SOME OTHER TYPE OF REFRESHMENTS.]");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("Guiding Star: Now that you've been provided with a decision, it's time to make a choice, whenever you need to make a choice you can count on me to provide you with the right actions to be kind");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Corrupted Heart: and you can count on me to provide you with choices that do whatever we want, instead of her boring kindness options");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Guiding Star: I swear that's more than just the wind, but whatever. Here are your choices!");
Console.WriteLine("");
Console.ReadLine();

bool tut = false;
while (tut == false)
{
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("1. Graciously accept the water refreshment");
Console.WriteLine("2. Kindly acquiese for the Cup of Tea");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("3. Throw the glass of water in his face!");
if (Sin == "Murder")
{
Console.WriteLine("4. KILL HIM [Murder]");
}
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Guiding Star: Just press the corresponding number key to select your choice!");
Console.WriteLine("");
Console.BackgroundColor = ConsoleColor.DarkGray;


// if sin = murder och sin ej = murder

ConsoleKeyInfo tutorial = Console.ReadKey();
if(Sin == "Murder")
{
if (tutorial.Key == ConsoleKey.D1)
        {
Console.Clear();
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("1. Graciously accept the water refreshment");
Console.WriteLine("");
Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.DarkGray;
Console.WriteLine("Graciously you pick up the glass filled with cold water and take a sip... it tastes like piss");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("Guiding Star: Oh, uhhh, I probably should've told you to not actually drink that water, considering it isn't water");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.DarkGray;
Console.WriteLine("You panically ask what it was, hoping it wasn't what you think it was");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("Guiding Star: Don't worry, it's just holy water, it's not meant to be drunk but it won't harm you, although it may taste bad considering your a Sinner");
Console.WriteLine("Guiding Star: Anyway, Good job! You did a good thing... well, kind of, accepting the refreshments wasn't neccasarily good, but it was the kind thing to do! Which is good enough!");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Corrupted Heart: ugh, boring");
                Console.ReadLine();
Console.BackgroundColor = ConsoleColor.DarkGray;
tut = true;
        }
else if (tutorial.Key == ConsoleKey.D2)
        {
Console.Clear();
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("2. Kindly acquiese for the Cup of Tea");
Console.WriteLine("");
Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.DarkGray;
Console.WriteLine("You decide to acquiese and pick up the steaming cup of tea in front of you, sitting down in order to have a nice and relaxed conversationg with the person beside you");
Console.WriteLine("");
Console.WriteLine("Test Villager A: [AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!]");
Console.WriteLine("");
Console.WriteLine("The blarring noise erupting out of the Villager nearly deafens you as you hastily cover your ears, trying to dampen the pain thrumming for your head");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("Guiding Star: SORRRY! Sorry! sorry... I probably should've warned you about that");
Console.WriteLine("Guiding Star: Yeah, that actually isn't a real person, shocking I know, but yeah it's a robot ai made by some of the tech's back at Heaven HQ");
Console.WriteLine("Guiding Star: Thing is, when a human person, more specifically sinners, try to talk to it as if it was a person... well it just starts doing that for some reason, not sure why...");
Console.WriteLine("Guiding Star: Anyway, Good job! You did a good thing... well, kind of, accepting the refreshments wasn't neccasarily good, but it was the kind thing to do! Which is good enough!");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Corrupted Heart: ugh, boring");
                Console.ReadLine();
Console.BackgroundColor = ConsoleColor.DarkGray;
tut = true;
        }
else if (tutorial.Key == ConsoleKey.D3)
        {
Console.Clear();
Console.BackgroundColor = ConsoleColor.Black; 
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("3. Throw the glass of water in his face!");
Console.ReadLine();
Console.WriteLine("Corrupted Heart: yesssssss!");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.DarkGray;
Console.WriteLine("You pick up the glass of water before looking at the blank face of the clearly robotic villager in front of you, and you simply thrust your arm forwards a bit causing the water to splash in the face of the Villager");
Console.WriteLine("The Villager sparks as it's body twists and contorts, the circuitry failing and the wires damaged. Smoke starts to steam out of every crevice in it's metallic body and you simply stare at it in silence");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("Guiding Star: Well... that wasn't... exactly how you were supposed to do that... but I guess it's my fault for leaving that option there, for some reason");
Console.WriteLine("Guiding Star: And it kind of was obviously not a real person... euhm...");
Console.WriteLine("Guiding Star: ... Good job? I guess... it wasn't really a good job though, and it was defintely not kind...");
Console.WriteLine("Guiding Star: ... bad job? Whatever let's just move on");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Corrupted Heart: Muhaha, that is exactly what we needed to do >:)");
                Console.ReadLine();
Console.BackgroundColor = ConsoleColor.DarkGray;
tut = true;
        }
else if (tutorial.Key == ConsoleKey.D4)
        {
Console.Clear();
Console.BackgroundColor = ConsoleColor.Black; 
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("4. KILL HIM [Murder]");
Console.ReadLine();
Console.WriteLine("Corrupted Heart: Feck Yeah!! Lessgoooooo!!");
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.DarkGray;
Console.WriteLine("... It's a simple process, a process you're all to familiar with. Your target is clearly not human, but it doesn't matter, as soon as anyone becomes your target, that's all they are");
Console.WriteLine("Nothing more, nothing less");
Console.WriteLine("The prey infront of you is clearly robotic, that's fine practice is always good");
Console.WriteLine("You tentatively pick of the glass of water before harshly thrusting your arm into the face of the Villager, spilling water all over it and breaking the glass in the same motion");
Console.WriteLine("Your hand gets cut on some of shards, but it isn't the first time you've hurt yourself during a kill");
Console.WriteLine("You quickly take one of the shards before it falls to the ground, it cuts your palm open, you don't care");
Console.WriteLine("You slash across one of it's eyes, disabiling it before thrusting glass shard into it's throat, a decisive strike that would end any other prey");
Console.WriteLine("You quickly leap across the room, picking up the tea kettle before bashing the Villager on the back of it's head with the kettle");
Console.WriteLine("The Villager falls forward lifelessly, it's body nothing more than scrap metal");
Console.WriteLine("...");
Console.WriteLine("...");
Console.WriteLine("...");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("Guiding Star: ... What the Fuck, WHY DID YOU DO THAT?! Oh my... I- wha- it-... uhm... let's quickly move on!");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Corrupted Heart: Oh yeah! That's exactly what I needed, let's kill the star next yeah? Muahahaha ahahah");
                Console.ReadLine();
Console.BackgroundColor = ConsoleColor.DarkGray;
tut = true;
PubOpi--;
        }
}
else
    {
if (tutorial.Key == ConsoleKey.D1)
        {
Console.Clear();
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("1. Graciously accept the water refreshment");
Console.WriteLine("");
Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.DarkGray;
Console.WriteLine("Graciously you pick up the glass filled with cold water and take a sip... it tastes like piss");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("Guiding Star: Oh, uhhh, I probably should've told you to not actually drink that water, considering it isn't water");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.DarkGray;
Console.WriteLine("You panically ask what it was, hoping it wasn't what you think it was");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("Guiding Star: Don't worry, it's just holy water, it's not meant to be drunk but it won't harm you, although it may taste bad considering your a Sinner");
Console.WriteLine("Guiding Star: Anyway, Good job! You did a good thing... well, kind of, accepting the refreshments wasn't neccasarily good, but it was the kind thing to do! Which is good enough!");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Corrupted Heart: ugh, boring");
                Console.ReadLine();
Console.BackgroundColor = ConsoleColor.DarkGray;
tut = true;
        }
else if (tutorial.Key == ConsoleKey.D2)
        { 
Console.Clear();
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("2. Kindly acquiese for the Cup of Tea");
Console.WriteLine("");
Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.DarkGray;
Console.WriteLine("You decide to acquiese and pick up the steaming cup of tea in front of you, sitting down in order to have a nice and relaxed conversationg with the person beside you");
Console.WriteLine("");
Console.WriteLine("Test Villager A: [AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!]");
Console.WriteLine("");
Console.WriteLine("The blarring noise erupting out of the Villager nearly deafens you as you hastily cover your ears, trying to dampen the pain thrumming for your head");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("Guiding Star: SORRRY! Sorry! sorry... I probably should've warned you about that");
Console.WriteLine("Guiding Star: Yeah, that actually isn't a real person, shocking I know, but yeah it's a robot ai made by some of the tech's back at Heaven HQ");
Console.WriteLine("Guiding Star: Thing is, when a human person, more specifically sinners, try to talk to it as if it was a person... well it just starts doing that for some reason, not sure why...");
Console.WriteLine("Guiding Star: Anyway, Good job! You did a good thing... well, kind of, accepting the refreshments wasn't neccasarily good, but it was the kind thing to do! Which is good enough!");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Corrupted Heart: ugh, boring");
                Console.ReadLine();
Console.BackgroundColor = ConsoleColor.DarkGray;
tut = true;
        }
else if (tutorial.Key == ConsoleKey.D3)
        {
Console.Clear();
Console.BackgroundColor = ConsoleColor.Black; 
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("3. Throw the glass of water in his face!");
Console.ReadLine();
Console.WriteLine("Corrupted Heart: yesssssss!");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.DarkGray;
Console.WriteLine("You pick up the glass of water before looking at the blank face of the clearly robotic villager in front of you, and you simply thrust your arm forwards a bit causing the water to splash in the face of the Villager");
Console.WriteLine("The Villager sparks as it's body twists and contorts, the circuitry failing and the wires damaged. Smoke starts to steam out of every crevice in it's metallic body and you simply stare at it in silence");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("Guiding Star: Well... that wasn't... exactly how you were supposed to do that... but I guess it's my fault for leaving that option there, for some reason");
Console.WriteLine("Guiding Star: And it kind of was obviously not a real person... euhm...");
Console.WriteLine("Guiding Star: ... Good job? I guess... it wasn't really a good job though, and it was defintely not kind...");
Console.WriteLine("Guiding Star: ... bad job? Whatever let's just move on");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Corrupted Heart: Muhaha, that is exactly what we needed to do >:)");
                Console.ReadLine();
Console.BackgroundColor = ConsoleColor.DarkGray;
tut = true;    
        }   
        Console.Clear();
    }
}

Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("Guiding Star: Alright, I've done all I can to help and I need to leave now. Don't worry I'll still partially be with you and I'll provide you with choice anytime you need to make a decision, but from now on you future is in your own hands.");
Console.WriteLine("Guiding Star: Good bye :)");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Corrupted Heart: Don't worry, I'll still be here for you >:D");
Console.WriteLine("Corrupted Heart: Although I may not be able to always communicate with you considering that star over there is the major contributor for my ability to speak right now");
Console.WriteLine("Corrupted Heart: But do remember, you'll always have a corrupt heart in me. So come around and be evil with me, I'll always give you the option for it");
Console.WriteLine("Corrupted Heart: Bye, bye now >;)");

// Console.ForegroundColor = ConsoleColor.Yellow;
// Console.BackgroundColor = ConsoleColor.Black;
// Console.WriteLine("Guiding Star:");
// Console.ForegroundColor = ConsoleColor.Black;
// Console.BackgroundColor = ConsoleColor.White;

// Console.ForegroundColor = ConsoleColor.DarkRed;
// Console.BackgroundColor = ConsoleColor.Black;
// Console.WriteLine("Corrupted Heart:");
// Console.ForegroundColor = ConsoleColor.Black;
// Console.BackgroundColor = ConsoleColor.White;


Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.Clear();

Console.ForegroundColor = ConsoleColor.Black; 
Console.WriteLine("You awake once more, now laid in a cot inside a small cozy room. The room is small, only large enough to hold the cot you're laying and a small desk that's pressed up against the wall");
Console.WriteLine("On that wall a small oil painting of fruits and vegetables was hung. On the far end of the room was a small window that led to the outside, which wasn't much to talk about, just a few trees and small village buildings");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.DarkGray;
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("???: Ah, seems you're awake sinful one. I found you laying uncounscious in the hills just outside the village, to think I would find someone like you out there");
Console.WriteLine("???: Wait, sorry, I should probably introduce myself");
Console.WriteLine("Eric: My name is Eric, and I'm the village chief. I know that you're not from this world, I know that you've been summoned and I know why you've been summoned");
Console.WriteLine("Eric: So if you please go out and complete your mission, it would be greatly helpful");

if (Sin == "Lust")
    {
Console.WriteLine("Eric: So long as you stay away from my wife and my daughter do whatever you want");     
    }
if (Sin == "Sloth")
    {
Console.WriteLine("Eric: ");     
    }
if (Sin == "Wrath")
    {
Console.WriteLine("Eric: ");     
    }
if (Sin == "Gluttony")
    {
Console.WriteLine("Eric: ");     
    }
if (Sin == "Envy")
    {
Console.WriteLine("Eric: ");     
    }
if (Sin == "Greed")
    {
Console.WriteLine("Eric: ");     
    }
if (Sin == "Pride")
    {
Console.WriteLine("Eric: ");     
    }
if (Sin == "Murder")
    {
Console.WriteLine("Eric: ");     
    }
// Unique dialouge for ever sin


// Console.ForegroundColor = ConsoleColor.Yellow;
// Console.BackgroundColor = ConsoleColor.Black;
// Console.WriteLine("1. BlaBlaBla");
// Console.WriteLine("2. Skill check");
// Console.WriteLine("3. somethin somethin");



// Have dialouge and skill checks, with extra sin actions and addons to the dialogue based on your sin


// Multiple endings based on Public Opinion and whether you win or lose at the end, your sin also gives an extra little add on in every ending

// 5-7 endings, public opinion low, public opinion high, public opinion medium, win, lose, death and so on
if (dead == true)
    {
Console.WriteLine("You're dead. Sucks to suck, try again");
Console.WriteLine("Ending dead: DEAD!");
Console.ReadLine();
Environment.Exit(0);
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