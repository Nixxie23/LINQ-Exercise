namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var gameList = new List<string>() { "Skyrim", "Pokemon Red", "Animal Crossing New Horizons", "The Outer Worlds", "Cult of the Lamb", "Stardew Valley", "Death and Taxes" };
            var gameNameLength = gameList.OrderBy(game => game.Count());
            foreach (var game in gameNameLength)
            {
                Console.WriteLine(game);
            }            
        }
    }
}
//Create a list of video game names...
//Order the list of games by length of the game name.
//Use the lambda expression in this exercise as well.
//use Method Syntax for this exercise