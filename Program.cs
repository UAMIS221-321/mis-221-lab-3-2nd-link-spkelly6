// start main
DisplayMenu();
string enjoymentLevel = GetEnjoymentLevel();
string stadium = GetStadiumRecommendation(enjoymentLevel);
string game = GetGameRecommendation(stadium);
DisplayStadiumDetails(stadium, game);

// end main

static void DisplayMenu()
{
    Console.Clear();
    Console.WriteLine("1)Boring \n2)Average \n3)Fun \n4)Epic");
}

static string GetEnjoymentLevel()
{
    Console.WriteLine("Chose your level of enjoyment!");
    return (Console.ReadLine());
}


static string GetStadiumRecommendation(string enjoymentLevel)
{
        switch(enjoymentLevel)
        {
            case "1":
                return "Neyland Stadium";
            case "2":
                return "Jordan-Hare Stadium";
            case "3":
             return "Tiger Stadium";
            case "4":
                return "Saban Field at Bryant-Denny Stadium";
            default:
                return "Invalid option";
        }
    }

static string GetGameRecommendation(string stadium)
{
    switch(stadium)
    {
        case "Neyland Stadium":
            return "vs Kent State";
        case "Jordan-Hare Stadium":
            return "vs Kentucky";
        case "Tiger Stadium":
            return "vs Alabama";
        case "Saban Field at Bryant-Denny Stadium":
            return "vs Auburn";
        default:
            return "Invalid option";
    }
}

static void DisplayStadiumDetails(string stadium, string game)
{
    Console.WriteLine($"You should go to {stadium} to watch the game {game}");
}
