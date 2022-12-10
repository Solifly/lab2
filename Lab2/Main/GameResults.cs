namespace Lab2.Main;

public class GameResults
{
    public enum States
    {
        Win,
        Lose
    }
    
    public readonly string Username;
    public readonly string OpponentName;
    public readonly int RatingPerGame;
    public readonly int CurrentRating;
    public readonly int GamesCount;
    public readonly int Id;
    public readonly char Symbol;
    public readonly string Type;

    public GameResults(string username, string opponentName, int ratingPerGame, int currentRating, int gamesCount, int id, string gameType, char symbol)
    {
        Username = username;
        OpponentName = opponentName;
        RatingPerGame = ratingPerGame;
        CurrentRating = currentRating;
        GamesCount = gamesCount;
        Id = id;
        Symbol = symbol;
        Type = gameType;
    }
}