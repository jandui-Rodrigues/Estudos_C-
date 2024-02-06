namespace LinQ;

public class TLinq
{
    public string[] games = { "Fortnite", "Valorant", "Destiny", "Call of Duty", "World of Warcraft" };

    public void Main()
    {
        IEnumerable<string> filteredGames = from game in games
                                            where game.Contains('a')
                                            select game;

        //  var filteredGames = from game in games
        //                     where game.Contains('a')
        //                     select game;
    }

    public static void DoubleList()
    {
        var games = new List<List<string>>
        {
            new() { "Valorant", "CS GO", "Battlefield" },
            new() { "Need For Speed", "The crew" },
            new List<string> { "League of Legends", "Dota" }
        };

        var gamesInLine = from gameLine in games
                          from game in gameLine
                          select game;

        foreach (string game in gamesInLine)
        {
            Console.WriteLine(game);
        }
    }
}