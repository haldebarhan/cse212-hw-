/*
 * CSE 212 Lesson 6C 
 * 
 * This code will analyze the NBA basketball data and create a table showing
 * the players with the top 10 career points.
 * 
 * Note about columns:
 * - Player ID is in column 0
 * - Points is in column 8
 * 
 * Each row represents the player's stats for a single season with a single team.
 */

using Microsoft.VisualBasic.FileIO;

public class Basketball
{
    static Dictionary<string, int> players = [];
    public static void Run()
    {

        using var reader = new TextFieldParser("basketball.csv");
        reader.TextFieldType = FieldType.Delimited;
        reader.SetDelimiters(",");
        reader.ReadFields(); // ignore header row
        while (!reader.EndOfData)
        {
            var fields = reader.ReadFields()!;
            var playerId = fields[0];
            var points = int.Parse(fields[8]);
            AddPlayer(playerId, points);
        }

        TopPTenPlayers(players.ToArray());
    }

    public static void AddPlayer(string playerId, int points)
    {
        players[playerId] = points;
    }

    public static void TopPTenPlayers(KeyValuePair<string, int>[] topPlayers)
    {
        Array.Sort(topPlayers, (a, b) => b.Value - a.Value);

        for(int index = 0; index < 10; index++) {
            Console.WriteLine($"{topPlayers[index].Key} -- {topPlayers[index].Value}");
        }
    }
}