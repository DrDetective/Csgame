using System.ComponentModel;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
int hunger = 100;
int armor = 0;
int thirst = 100;
int energy = 100;
int PlayerHP = 100;
int EnemyHP;
int playerAttack = 2;
int enemyAttack;
int healAmount = 5;
int mana = 0;
int lvl = 1;
//List<string> inventory = new List<string>();

//List<string> endings = new List<string>();

List<string> itemspyra = new List<string>();
itemspyra.Add("Hay");
itemspyra.Add("Iron bar");
itemspyra.Add("Brozne bar");
itemspyra.Add("Bricks");
Random randNum = new Random();
int aRandomPos = randNum.Next(itemspyra.Count);
string itemspyramid = itemspyra[aRandomPos];

List<string> firstNames = new List<string>();
firstNames.Add("Rocks");
firstNames.Add("Rope");
firstNames.Add("Small chunks of wood");
firstNames.Add("Glass");
firstNames.Add("Cloth");
Random randNum2 = new Random();
int aRandomPos2 = randNum.Next(firstNames.Count);
string Desert = firstNames[aRandomPos];

List<string> firstNames2 = new List<string>();
firstNames2.Add("ENERGYSWORD");
firstNames2.Add("HL");
firstNames2.Add("FSBERSERK");
firstNames2.Add("ZENITH");
firstNames2.Add("BLOODMOON");
firstNames2.Add("PLEB");
firstNames2.Add("TENSAZANGETSU");
firstNames2.Add("kamonevim");
Random randNum3 = new Random();
int aRandomPos3 = randNum3.Next(firstNames2.Count);
string codes = firstNames2[aRandomPos];

List<string> firstNames3 = new List<string>();
firstNames3.Add("Snake");
firstNames3.Add("Scorpion");
Random randNum4 = new Random();
int aRandomPos4 = randNum4.Next(firstNames3.Count);
string desertene = firstNames3[aRandomPos4];

Console.ForegroundColor = ConsoleColor.Red;
string game_name = @"
 __          __             _                          _______    _      
 \ \        / /            | |                        |__   __|  | |     
  \ \  /\  / /_ _ _ __   __| | ___ _ __ ___ _ __ ___     | | __ _| | ___ 
   \ \/  \/ / _` | '_ \ / _` |/ _ \ '__/ _ \ '__/ __|    | |/ _` | |/ _ \
    \  /\  / (_| | | | | (_| |  __/ | |  __/ |  \__ \    | | (_| | |  __/
     \/  \/ \__,_|_| |_|\__,_|\___|_|  \___|_|  |___/    |_|\__,_|_|\___|
                                                                         
                                                                         
";
Console.WriteLine(game_name);
Thread.Sleep(3500);
Console.Clear();
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("You are a wanderer who suddenly woke up in desert and you are guessing it's around 2PM");
Thread.Sleep(3000);
Console.Clear();
Console.WriteLine("Your goal to survive and find resources till you find civilization");
Thread.Sleep(2500);
Console.Clear();
Console.WriteLine("Choose your actions wisely becasuse you have limited stamina to 100 per day\n\rUntil you get out of desert");
Thread.Sleep(4000);
Console.Clear();
title:
ConsoleKeyInfo key;
int option = 1;
bool isSelected = false;
(int left, int top) = Console.GetCursorPosition();
string color = "\u001b[32m";
Console.CursorVisible = false;
while (!isSelected)
{
    Console.SetCursorPosition(left, top);
    Console.WriteLine("|----------------------------------------------------|");
    Console.WriteLine($"{(option == 1 ? color : "")}|                     Start Game                     |\u001b[0m");
    Console.WriteLine("|----------------------------------------------------|");
    Console.WriteLine($"{(option == 2 ? color : "")}|                       Credits                      |\u001b[0m");
    Console.WriteLine("|----------------------------------------------------|");
    Console.WriteLine($"{(option == 3 ? color : "")}|                        Codes                       |\u001b[0m");
    Console.WriteLine("|----------------------------------------------------|");
    Console.WriteLine($"{(option == 4 ? color : "")}|                        Exit                        |\u001b[0m");
    Console.WriteLine("|----------------------------------------------------|");
    key = Console.ReadKey(true);
    switch (key.Key)
    {
        case ConsoleKey.UpArrow:
            option = (option == 1 ? 4 : option - 1);
            break;
        case ConsoleKey.DownArrow:
            option = (option == 4 ? 1 : option + 1);
            break;
        case ConsoleKey.Enter:
            isSelected = true;
            break;
    }
} //MENU
Console.Clear();
if (option == 2)
{
    Console.WriteLine("|------------------------------|\n|       Total coding time      |\n|             040h             |");
    ConsoleKeyInfo key4;
    int option4 = 1;
    bool isSelected4 = false;
    (int left4, int top4) = Console.GetCursorPosition();
    Console.CursorVisible = false;
    while (!isSelected4)
    {
        Console.SetCursorPosition(left4, top4);
        Console.WriteLine("|------------------------------|");
        Console.WriteLine($"{(option4 == 1 ? color : "")}|     Back to title screen     |\u001b[0m");
        Console.WriteLine("|------------------------------|");
        Console.WriteLine($"{(option4 == 2 ? color : "")}|            Endings           |\u001b[0m");
        Console.WriteLine("|------------------------------|");
        key4 = Console.ReadKey(true);
        switch (key4.Key)
        {
            case ConsoleKey.UpArrow:
                option4 = (option4 == 1 ? 2 : option4 - 1);
                break;
            case ConsoleKey.DownArrow:
                option4 = (option4 == 2 ? 1 : option4 + 1);
                break;
            case ConsoleKey.Enter:
                isSelected4 = true;
                break;
        }
    }
    Console.Clear();
    if (option4 == 1) //BACK TO TITLE SCREEN
    {
        goto title;
    }
    else if (option4 == 2) //ENDINGS LIST
    {
        Console.WriteLine(endings);
        goto title;
    }
} //CREDITS
if (option == 3)
{
    Console.WriteLine("Here you can enter codes to make your game easier or harder\nCodes can be found in game\nEnter codes with Capslock on");
    while (true)
    {
        string code = Console.ReadLine();
        if (code == "ENERGYSWORD") //HALO
        {
            Console.WriteLine("Congrats, you gained Energy Sword\n\r|------------------------------|\n\r| Item: Energy Sword           |\n\r|                              |\n\r| Damage: 175                  |\n\r| Critical Damage: 300-505     |\n\r| Speed: Fast                  |\n\r|------------------------------|");
        }
        else if (code == "HL") //HALF-LIFE
        {
            Console.WriteLine("Congrats, you gained Crowbar\n\r|------------------------------|\n\r| Item: Crowbar                |\n\r|                              |\n\r| Damage: 75                   |\n\r| Critical Damage: 80-100      |\n\r| Speed: Average               |\n\r|------------------------------|");
        }
        else if (code == "FSBERSERK") //BERSERK
        {
            Console.WriteLine("Congrats, you gained Berserk armor and Dragon Slayer\n\r|------------------------------|\n\r| Item: Berserk Armor          |\n\r|                              |\n\r| Defence: 300                 |\n\r| Durability: 2000/2000        |\n\r| Skill: Berserk Mode          |\n\r|------------------------------|\n\r|                              |\n\r|------------------------------|\n\r| Item: Dragon Slayer          |\n\r|                              |\n\r| Damage: 300                  |\n\r| Critical Damage: 600-850     |\n\r| Speed: Slow                  |\n\r|------------------------------|");
        }
        else if (code == "ZENITH") //TERARRIA
        {
            Console.WriteLine("Congrats, you gained Zenith\n\r|------------------------------|\n\r| Item: Zenith                 |\n\r|                              |\n\r| Damage: 375                  |\n\r| Critical Damage: 560-739     |\n\r| Speed: Very fast             |\n\r|------------------------------|");
        }
        else if (code == "MASTERKEY") //EVERTHING FROM HERE NAD ALL ENDINGS
        {
            Console.WriteLine("Congrats, you gained everything from codes\n\r|------------------------------|\n\r| Item: Energy Sword           |\n\r|                              |\n\r| Damage: 175                  |\n\r| Critical Damage: 300-505     |\n\r| Speed: Fast                  |\n\r|------------------------------|\n\r|------------------------------|\n\r| Item: Crowbar                |\n\r|                              |\n\r| Damage: 75                   |\n\r| Critical Damage: 80-100      |\n\r| Speed: Average               |\n\r|------------------------------|\n\r|------------------------------|\n\r| Item: Berserk Armor          |\n\r|                              |\n\r| Defence: 300                 |\n\r| Durability: 2000/2000        |\n\r| Skill: Berserk Mode          |\n\r|------------------------------|\n\r|                              |\n\r|------------------------------|\n\r| Item: Dragon Slayer          |\n\r|                              |\n\r| Damage: 300                  |\n\r| Critical Damage: 600-850     |\n\r| Speed: Slow                  |\n\r|------------------------------|\n\r|------------------------------|\n\r| Item: Zenith                 |\n\r|                              |\n\r| Damage: 375                  |\n\r| Critical Damage: 560-739     |\n\r| Speed: Very fast             |\n\r|------------------------------|\n\r|------------------------------|\n\r| Item: Tensa Zangetsu         |\n\r|                              |\n\r| Damage: 250                  |\n\r| Critical Damage: 369-576     |\n\r| Speed: Fast                  |\n\r|                              |\n\r| Skill: Bankai                |\n\r| + 15% Speed Boost            |\n\r| + 50% Damage                 |\n\r|                              |\n\r| Skill 2: Getsuga Tensho      |\n\r|------------------------------|");
        }
        else if (code == "BLOODMOON") //TERARRIA AND 7DTD
        {
            Console.WriteLine("Congrats, you activated Bloodmoon for every night");
        }
        else if (code == "PLEB") //EASIEST DIFFICULTY
        {
            Console.WriteLine("Congrats, you activated easiest difficulty");
        }
        else if (code == "TENSAZANGETSU") //BLEACH ICHIGO ZANPAKUTO
        {
            Console.WriteLine("Congrats, you gained Tensa Zangetsu\n\r|------------------------------|\n\r| Item: Tensa Zangetsu         |\n\r|                              |\n\r| Damage: 250                  |\n\r| Critical Damage: 369-576     |\n\r| Speed: Fast                  |\n\r|                              |\n\r| Skill: Bankai                |\n\r| + 15% Speed Boost            |\n\r| + 50% Damage                 |\n\r|                              |\n\r| Skill 2: Getsuga Tensho      |\n\r|------------------------------|");
        }
        else if (code == "GOBACK") //BACK TO MENU
        {
            Console.Clear();
            goto title;
        }
    }
} //CODES
if (option == 4)
{
    return;
} //EXIT
CH:
ConsoleKeyInfo key1;
int option1 = 1;
bool isSelected1 = false;
(int left1, int top1) = Console.GetCursorPosition();
Console.CursorVisible = false;
if (option == 1)
{
    while (!isSelected1)
    {
        Console.SetCursorPosition(left1, top1);
        Console.WriteLine("|----------------------------------------------------|");
        Console.WriteLine($"{(option1 == 1 ? color : "")}|          Travel futher through desert              |" +
                                                   $"\n\r|             -10 stamina, -5 hunger                 |\u001b[0m");
        Console.WriteLine("|----------------------------------------------------|");
        Console.WriteLine($"{(option1 == 2 ? color : "")}|   Search near your area to find something useful   |" +
                                                   $"\n\r|              -10 stamina, -5 hunger                |\u001b[0m");
        Console.WriteLine("|----------------------------------------------------|");
        Console.WriteLine($"{(option1 == 3 ? color : "")}|                  Open inventory                    |\u001b[0m");
        Console.WriteLine("|----------------------------------------------------|");
        key1 = Console.ReadKey(true);
        switch (key1.Key)
        {
            case ConsoleKey.UpArrow:
                option1 = (option1 == 1 ? 3 : option1 - 1);
                break;
            case ConsoleKey.DownArrow:
                option1 = (option1 == 3 ? 1 : option1 + 1);
                break;
            case ConsoleKey.Enter:
                isSelected1 = true;
                break;
        }
    } //FIRST CHOICES
    Console.Clear();
} //GAME
travelmore:
if (option1 == 1)
{
    Random random = new Random();
    int sanceruin;
    energy -= 10;
    hunger -= 5;
    thirst -= 5;
    sanceruin = random.Next(0, 7);
    if (sanceruin == 0)
    {
        Console.WriteLine("You traveled for hours and found nothing\n\rRemaining stamina: " + energy + "/100\n\rRemaining hunger: " + hunger + "/100");
        Thread.Sleep(2500);
        Console.Clear();
        Console.WriteLine("Want to travel futher?");
        Thread.Sleep(2500);
        Console.Clear();
        ConsoleKeyInfo key2;
        int option2 = 1;
        bool isSelected2 = false;
        (int left2, int top2) = Console.GetCursorPosition();
        Console.CursorVisible = false;
        while (!isSelected2)
        {
            Console.SetCursorPosition(left2, top2);
            Console.WriteLine("|------------------------------|");
            Console.WriteLine($"{(option2 == 1 ? color : "")}|             Yes              |" +
                                                       $"\n\r|         -10 stamina          |\u001b[0m");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine($"{(option2 == 2 ? color : "")}|    No, search are near you   |" +
                                                       $"\n\r|          -10 stamina         |\u001b[0m");
            Console.WriteLine("|------------------------------|");
            key2 = Console.ReadKey(true);
            switch (key2.Key)
            {
                case ConsoleKey.UpArrow:
                    option2 = (option2 == 1 ? 2 : option2 - 1);
                    break;
                case ConsoleKey.DownArrow:
                    option2 = (option2 == 2 ? 1 : option2 + 1);
                    break;
                case ConsoleKey.Enter:
                    isSelected2 = true;
                    break;
            }
        }
        Console.Clear();
        if (option2 == 1)
        {
            goto travelmore;
        }
        else // ADD A WAY TO TRAVEL FROM HERE TO THE OTHER IF
        {
            goto searchnear;
        }
    } //NOTHING FOUND
    else if (sanceruin == 2)
    {
        Console.WriteLine("You found destroyed ruins\n\rRemaining stamina: " + energy + "/100\n\rRemaining hunger: " + hunger + "/100\n\rWant to explore?");
        Thread.Sleep(3000);
        Console.Clear();
        ConsoleKeyInfo key3;
        int option3 = 1;
        bool isSelected3 = false;
        (int left3, int top3) = Console.GetCursorPosition();
        Console.CursorVisible = false;
        while (!isSelected3)
        {
            Console.SetCursorPosition(left3, top3);
            Console.WriteLine("|------------------------------|");
            Console.WriteLine($"{(option3 == 1 ? color : "")}|             Yes              |" +
                                                       $"\n\r|         -5 stamina           |\u001b[0m");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine($"{(option3 == 2 ? color : "")}|     No and travel futher     |" +
                                                       $"\n\r|         -10 stamina          |\u001b[0m");
            Console.WriteLine("|------------------------------|");
            key3 = Console.ReadKey(true);
            switch (key3.Key)
            {
                case ConsoleKey.UpArrow:
                    option3 = (option3 == 1 ? 2 : option3 - 1);
                    break;
                case ConsoleKey.DownArrow:
                    option3 = (option3 == 2 ? 1 : option3 + 1);
                    break;
                case ConsoleKey.Enter:
                    isSelected3 = true;
                    break;
            }
        } //FOUND DESTROYED RUINS
        Console.Clear();
    ruins:
        if (option3 == 1)
        {
            energy -= 5;
            Random randomEXPL = new Random();
            int sanceH3;
            sanceH3 = randomEXPL.Next(0, 2);
            if (sanceH3 == 0)
            {
                endings.Add("Living Hell");
                Console.WriteLine("You found a mysterious portal\n\rAs you go closer you become more curious to know whats in there");
                Thread.Sleep(3750);
                Console.Clear();
                Console.WriteLine("But the closer you got the more hotter you were as if there was a Sun in front of you\n\rOut of nowhere you tripped over something and looked what it was");
                Thread.Sleep(3500);
                Console.Clear();
                Console.WriteLine("It was Super Shotgun and you felt getting angrier\n\rYou looked through the portal and saw demons and you steped in");
                Thread.Sleep(3750);
                Console.Clear();
                Console.WriteLine("Secret ending: Living Hell");
                Thread.Sleep(2000);
                Console.Clear();
                goto title;
            } //LIVING HELL SECRET ENDING
            else if (sanceH3 == 1)
            {
                Console.WriteLine("You found " + Desert);
                Thread.Sleep(2000);
                Console.Clear();
                goto CH;

            } //NORMAL EXPLORE
            else
            {
                goto ruins;
            }
        } //EXPLORING RUINS
    } //RUINS
    else if (sanceruin == 3) //FIX AND DESIGN BETTER COMBAT 
    {
        Console.WriteLine("While traveling you found dead rat and you see a snake coming towards you");
        Thread.Sleep(2000);
        Console.Clear();
        enemyAttack = 3;
        EnemyHP = 20;
        while (PlayerHP > 0 && EnemyHP > 0)
        {
            Console.WriteLine("|           Your Turn          |\n|       Your Hp - " + PlayerHP + "/100      |\n|       " + desertene + " Hp - " + EnemyHP + "/20       |\n|      (A)ttack     (H)eal     |\n|------------------------------|");
            string choise = Console.ReadLine();
            if (choise == "a")
            {
                Console.WriteLine("|------------------------------|");
                EnemyHP -= playerAttack;
                Console.WriteLine("You attacked " + desertene + " and deals " + playerAttack + " damage");
                Console.WriteLine("|------------------------------|");
            }
            else
            {
                Console.WriteLine("|------------------------------|");
                PlayerHP += healAmount;
                Console.WriteLine("You restored " + healAmount + " health points!");
                Console.WriteLine("|------------------------------|");
            }
            if (EnemyHP > 0)
            {
                Console.WriteLine("|         " + desertene + " Turn               |");
                Console.WriteLine("|       Your Hp - " + PlayerHP + "/100      |\n|        " + desertene + " Hp - " + EnemyHP + "          |\n|      (A)ttack     (H)eal    |\n|------------------------------|");
                int enemyChoise = random.Next(0);

                if (enemyChoise == 0)
                {
                    PlayerHP -= enemyAttack;
                    Console.WriteLine(desertene + " attacks and deals " + enemyAttack + " damage");
                    Console.WriteLine("|------------------------------|");
                }
            }
        }
        Console.Clear();
        if (PlayerHP > 0)
        {
            lvl++;
            Console.WriteLine("Congratulations, you have killed a snake\n\rSnake skin will be added to your inventory");
            Thread.Sleep(2250);
            Console.Clear();
            goto CH;
        }
        else
        {
            Console.WriteLine("You really lost to a snake?\n\rEnding: Killed");
            Thread.Sleep(2250);
            Console.Clear();
            goto title;
        }
    } //FOUND FIRST DESERT ENEMY 
    if (sanceruin == 4)
    {
        Console.WriteLine("As You traveled for what felt like years you see a palm tree in distance\nyou feel as if you got your life back and made a run for it\nYou found a ocean");
        Thread.Sleep(3250);
        Console.Clear();


    } //SEEING A PALM TREE   STORY CONTINUES HERE
    if (sanceruin == 5)
    {
        Console.WriteLine("While traveling you found a stone head buried in sand");
        Thread.Sleep(2000);
        Console.Clear();
        Console.WriteLine("Want to dug it out?");
        Thread.Sleep(2000);
        Console.Clear();
        ConsoleKeyInfo key4;
        int option4 = 1;
        bool isSelected4 = false;
        (int left4, int top4) = Console.GetCursorPosition();
        Console.CursorVisible = false;
        while (!isSelected4)
        {
            Console.SetCursorPosition(left4, top4);
            Console.WriteLine("|------------------------------|");
            Console.WriteLine($"{(option4 == 1 ? color : "")}|             Yes              |" +
                                                       $"\n\r|         -5 stamina           |\u001b[0m");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine($"{(option4 == 2 ? color : "")}|     No and travel futher     |" +
                                                       $"\n\r|         -10 stamina          |\u001b[0m");
            Console.WriteLine("|------------------------------|");
            key4 = Console.ReadKey(true);
            switch (key4.Key)
            {
                case ConsoleKey.UpArrow:
                    option4 = (option4 == 1 ? 2 : option4 - 1);
                    break;
                case ConsoleKey.DownArrow:
                    option4 = (option4 == 2 ? 1 : option4 + 1);
                    break;
                case ConsoleKey.Enter:
                    isSelected4 = true;
                    break;
            }
        }
        Console.Clear();
        if (option == 1)
        {
            Console.WriteLine("As you dug it out after 2 hours, when you looked at it, it was a statue");
            Thread.Sleep(2500);
            Console.Clear();
            Console.WriteLine("You felt some kind of strenght going through you");
            Thread.Sleep(2000);
            Console.Clear();
        } //ADD BUFF THAT IS RANDOM
        else if (option == 2)
        {
            goto travelmore;
        }
    } //STATUE + RANDOM BUFF
    if (sanceruin == 6)
    {
        Console.WriteLine("While traveling you found a pyramid");
        Thread.Sleep(2500);
        Console.Clear();
        Console.WriteLine("Want to explore?");
        Thread.Sleep(2500);
        Console.Clear();
        ConsoleKeyInfo key5;
        int option5 = 1;
        bool isSelected5 = false;
        (int left5, int top5) = Console.GetCursorPosition();
        Console.CursorVisible = false;
        while (!isSelected5)
        {
            Console.SetCursorPosition(left5, top5);
            Console.WriteLine("|------------------------------|");
            Console.WriteLine($"{(option5 == 1 ? color : "")}|             Yes              |" +
                                                       $"\n\r|         -5 stamina           |\u001b[0m");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine($"{(option5 == 2 ? color : "")}|     No and travel futher     |" +
                                                       $"\n\r|         -10 stamina          |\u001b[0m");
            Console.WriteLine("|------------------------------|");
            key5 = Console.ReadKey(true);
            switch (key5.Key)
            {
                case ConsoleKey.UpArrow:
                    option5 = (option5 == 1 ? 2 : option5 - 1);
                    break;
                case ConsoleKey.DownArrow:
                    option5 = (option5 == 2 ? 1 : option5 + 1);
                    break;
                case ConsoleKey.Enter:
                    isSelected5 = true;
                    break;
            }
        }
        Console.Clear();
        if (option5 == 1)
        {
            Console.WriteLine("You went to explore and found " + itemspyramid);
        }
        else if (option5 == 2)
        {
            goto travelmore;
        }
    } //FINDING PYRAMID
    else
    {
        goto CH;
    } //POJISTKA ZATÍM
} //TRAVELING FUTHER
searchnear:
if (option1 == 2)
{
    if (energy == 0)
    {
        Console.WriteLine("As you traveled suddenly you lost consciousness beacause you were out of stamina");
        Thread.Sleep(2500);
        Console.Clear();
        Console.WriteLine("Next day you woke up when the Sun was rising");
        Thread.Sleep(2500);
        Console.Clear();
        energy += 100;
        goto CH;
    } //OUT OF STAMINA
    Random random = new Random();
    int sancesearch;
    energy -= 10;
    hunger -= 5;
    sancesearch = random.Next(0, 2);
    if (sancesearch == 0)
    {
        Console.WriteLine("You searched for few hours and found " + Desert + "\n\rRemaining stamina: " + energy + "/100\n\rRemaining hunger: " + hunger + "/100");
        Thread.Sleep(2500);
        Console.Clear();
        ConsoleKeyInfo key6;
        int option6 = 1;
        bool isSelected6 = false;
        (int left6, int top6) = Console.GetCursorPosition();
        Console.CursorVisible = false;
        while (!isSelected6)
        {
            Console.SetCursorPosition(left6, top6);
            Console.WriteLine("|------------------------------|\n\r|     Want to explore more?    |\n\r|------------------------------|");
            Console.WriteLine($"{(option6 == 1 ? color : "")}|             Yes              |" +
                                                       $"\n\r|          -10 stamina         |\u001b[0m");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine($"{(option6 == 2 ? color : "")}|       No, travel futher      |" +
                                                       $"\n\r|          -10 stamina         |\u001b[0m");
            Console.WriteLine("|------------------------------|");
            key6 = Console.ReadKey(true);
            switch (key6.Key)
            {
                case ConsoleKey.UpArrow:
                    option6 = (option6 == 1 ? 2 : option6 - 1);
                    break;
                case ConsoleKey.DownArrow:
                    option6 = (option6 == 2 ? 1 : option6 + 1);
                    break;
                case ConsoleKey.Enter:
                    isSelected6 = true;
                    break;
            }
        }
        Console.Clear();
        if (option6 == 1)
        {
            goto searchnear;
        }
        else if (option6 == 2)
        {
            goto travelmore;
        }
    }
    else if (sancesearch == 2)
    {
        Console.WriteLine("You found a piece of paper\n\rIt says: " + codes + "\n\rYou don't know what it means");
        Thread.Sleep(2500);
        Console.Clear();
        ConsoleKeyInfo key7;
        int option7 = 1;
        bool isSelected7 = false;
        (int left7, int top7) = Console.GetCursorPosition();
        Console.CursorVisible = false;
        while (!isSelected7)
        {
            Console.SetCursorPosition(left7, top7);
            Console.WriteLine("|------------------------------|\n\r|     Want to explore more?    |\n\r|------------------------------|");
            Console.WriteLine($"{(option7 == 1 ? color : "")}|             Yes              |" +
                                                       $"\n\r|          -10 stamina         |\u001b[0m");
            Console.WriteLine("|------------------------------|");
            Console.WriteLine($"{(option7 == 2 ? color : "")}|       No, travel futher      |" +
                                                       $"\n\r|          -10 stamina         |\u001b[0m");
            Console.WriteLine("|------------------------------|");
            key7 = Console.ReadKey(true);
            switch (key7.Key)
            {
                case ConsoleKey.UpArrow:
                    option7 = (option7 == 1 ? 2 : option7 - 1);
                    break;
                case ConsoleKey.DownArrow:
                    option7 = (option7 == 2 ? 1 : option7 + 1);
                    break;
                case ConsoleKey.Enter:
                    isSelected7 = true;
                    break;
            }
        }
        if (option7 == 1)
        {
            goto searchnear;
        }
        else
        {
            goto travelmore;
        }
    } //FINDING CODES
    else
    {
        goto searchnear;
    }
} //SEARCH NEAR YOUR AREA
if (option1 == 3)
{
    string inv = ("|------------------------------|\n\r| Level: " + lvl + "                     |\n\r| Health: " + PlayerHP + "                  |\n\r| Hunger: " + hunger + "                  |\n\r| Thirst: " + thirst + "                  |\n\r| Stamina: " + energy + "                 |\n\r| Damage: " + playerAttack + "                    |\n\r| Armor: " + armor + "                     |\n\r| Mana: " + mana + "                      |\n\r|------------------------------|\n\r| Items:                       |\n\r|------------------------------|");
    Console.WriteLine(inv);
    ConsoleKeyInfo key5;
    int option5 = 1;
    bool isSelected5 = false;
    (int left5, int top5) = Console.GetCursorPosition();
    Console.CursorVisible = false;
    while (!isSelected5)
    {
        Console.SetCursorPosition(left5, top5);
        Console.WriteLine($"{(option5 == 1 ? color : "")}|     Back to title screen     |\u001b[0m");
        Console.WriteLine("|------------------------------|");
        key5 = Console.ReadKey(true);
        switch (key5.Key)
        {
            case ConsoleKey.Enter:
                isSelected5 = true;
                break;
        }
    }
    Console.Clear();
    goto CH;
} //INVENTORY
if (energy == 0)
{
    Console.WriteLine("As you traveled suddenly you lost consciousness beacause you were out of stamina");
    Thread.Sleep(2500);
    Console.Clear();
    Console.WriteLine("Next day you woke up when the Sun was rising");
    Thread.Sleep(2500);
    Console.Clear();
    energy += 100;
    goto CH;
} //OUT OF STAMINA

//PASSWORD ENDINGS
//Console.WriteLine("Password: ");
//string pass = Console.ReadLine();
//Console.Clear();
//if (pass == "kamonevim")
//{                                                                                                                                                                                                                                                                                      
//    Console.WriteLine("|------------------------------|\n\r| Endings:                     |\n\r| Living Hell                  |\n\r| Civilization                 |\n\r| Killed                       |\n\r| Collector                    |\n\r| End?                         |\n\r| 100%                         |\n\r|------------------------------|");
//    Thread.Sleep(4000);
//    Console.Clear();
//    goto title;
//}
//else
//{
//    Console.WriteLine("Don't ask me for the code");
//    Thread.Sleep(2000);
//    Console.Clear();
//    goto title;
//}

//static void PrintLinesInCenter(params string[] lines)
//{
//    int verticalStart = (Console.WindowHeight - lines.Length) / 2; // work out where to start printing the lines
//    int verticalPosition = verticalStart;
//    foreach (var line in lines)
//    {
//        // work out where to start printing the line text horizontally
//        int horizontalStart = (Console.WindowWidth - line.Length) / 2;
//        // set the start position for this line of text
//        Console.SetCursorPosition(horizontalStart, verticalPosition);
//        // write the text
//        Console.Write(line);
//        // move to the next line
//        ++verticalPosition;
//    }
//}
//PrintLinesInCenter("hello", "this is a test", "of centered text");

//Console.WriteLine("|------------------------------|");
//Console.WriteLine("| Item: Zenith                 |");
//Console.WriteLine("|                              |");
//Console.WriteLine("| Damage: 375                  |");
//Console.WriteLine("| Critical Damage: 560-739     |");
//Console.WriteLine("| Speed: Very fast             |");
//Console.WriteLine("|------------------------------|");

//"|------------------------------|"
//"| Item: "+item+"               |"
//"|                              |"
//"| Damage: "+weapondamage+"     |"
//"| Critical Damage: "+critwdamage+"   |"
//"| Speed: "+weaponspeed+"       |"          ?????????????????
//"| -----------------------------|"

//Console.WriteLine("|------------------------------|");
//Console.WriteLine("| Health: " + PlayerHP + "                  |"); 
//Console.WriteLine("| Damage: " + playerAttack + "                    |"); 
//Console.WriteLine("| Hunger: " + hunger + "                  |");
//Console.WriteLine("| Thirst: " + thirst + "                  |"); 
//Console.WriteLine("| Level: " + lvl + "                     |"); 
//Console.WriteLine("| Mana: " + mana + "                      |");
//Console.WriteLine("|------------------------------|");
//Console.WriteLine("| Items:                       |");
//Console.WriteLine("|------------------------------|");

//int PlayerHP = 50;
//int EnemyHP = 40;
//int playerAttack = 7;
//int enemyAttack = 8;
//int healAmount = 5;
//while (PlayerHP > 0 && EnemyHP > 0)
//{
//    Console.WriteLine("---- Player Turn ----");
//    Console.WriteLine("Player Hp - " + PlayerHP + ". Enemy Hp - " + EnemyHP);
//    Console.WriteLine("|  (A)ttack   (H)eal |");
//    string choise = Console.ReadLine();
//    if (choise == "a")
//    {
//        Console.WriteLine("-------------------");
//        EnemyHP -= playerAttack;
//        Console.WriteLine("Player attacked enemy and deals " + playerAttack + " damage");
//        Console.WriteLine("-------------------");
//    }
//    else
//    {
//        Console.WriteLine("-------------------");
//        PlayerHP += healAmount;
//        Console.WriteLine("Player restores " + healAmount + " health points!");
//        Console.WriteLine("-------------------");
//    }
//    if (EnemyHP > 0)
//    {
//        Console.WriteLine("---- Enemy Turn ----");
//        Console.WriteLine("Player Hp - " + PlayerHP + ". Enemy Hp - " + EnemyHP);
//        int enemyChoise = random.Next(0, 2);
//        if (enemyChoise == 0)
//        {
//            Console.WriteLine("-------------------");
//            PlayerHP -= enemyAttack;
//            Console.WriteLine("Enemy attacks and deals " + enemyAttack + " damage");
//            Console.WriteLine("-------------------");
//        }
//        else
//        {
//            Console.WriteLine("-------------------");
//            EnemyHP += healAmount;
//            Console.WriteLine("Enemy restores " + healAmount + " health points!");
//            Console.WriteLine("-------------------");
//        }
//    }
//}
//if (PlayerHP > 0)
//{
//    Console.WriteLine("Congratulations, you have won!");
//}
//else
//{
//    Console.WriteLine("You Lose!");
//}