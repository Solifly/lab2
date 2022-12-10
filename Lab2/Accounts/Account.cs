using Lab2.Games;
using Lab2.Main;

namespace Lab2.Accounts;

public abstract class Account
{
    public readonly string Username;
    private int _currentRating;
    private int GamesCount { get; set; }
    private readonly List<GameResults> _history = new ();

    private int CurrentRating
    {
        get => _currentRating;
        set
        {
            if (value < 1) _currentRating = 1;
            else _currentRating = value;
        }
    }

    protected Account(string username, int currentRating)
    {
        Username = username;
        _currentRating = currentRating;
        GamesCount = 0;
    }
    
    public virtual void WinGame(string opponentName, int id, Game gameType)
    {
        var rating = gameType.Rating;
        CurrentRating += rating;
        GamesCount++;
        _history.Add(new GameResults(Username, opponentName, rating, _currentRating, GamesCount, id, gameType.Type, '+'));
    }
    
    public virtual void LoseGame(string opponentName, int id, Game gameType)
    {
        var rating = gameType.Rating;
        CurrentRating -= rating;
        GamesCount++;
        _history.Add(new GameResults(Username, opponentName, rating, _currentRating, GamesCount, id, gameType.Type, '-'));
    }

    public void GetStats()
    {
        foreach (var gameData in _history)
        {
            Console.WriteLine("Game №" + gameData.Id + ". ["
                              + gameData.Username + " vs " + gameData.OpponentName
                              + "] Result of the " + gameData.Type + " game: (" + gameData.Symbol + gameData.RatingPerGame + ")"
                              + ".\tYour rating: " + gameData.CurrentRating 
                              + ". Games you played: " +  gameData.GamesCount);
        }
    }
}