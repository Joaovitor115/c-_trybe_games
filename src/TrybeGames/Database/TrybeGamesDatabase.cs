namespace TrybeGames;

public class TrybeGamesDatabase
{
  public List<Game> Games = new List<Game>();

  public List<GameStudio> GameStudios = new List<GameStudio>();

  public List<Player> Players = new List<Player>();

  //4
  public List<Game> GetGamesDevelopedBy(GameStudio gameStudio)
  {
    List<Game> developedGames = Games.Where(game => game.DeveloperStudio.Equals(gameStudio.Id)).ToList();
    return developedGames;
  }


  // 5. Crie a funcionalidade de buscar jogos jogados por uma pessoa jogadora
  public List<Game> GetGamesPlayedBy(Player player)
  {
    var playedGames = Games.Where(game => player.GamesOwned.Contains(game.Id)).ToList();
    return playedGames;
  }

  // 6. Crie a funcionalidade de buscar jogos comprados por uma pessoa jogadora
  public List<Game> GetGamesOwnedBy(Player playerEntry)
  {
    var gamesOwned = Games.Where(game => playerEntry.GamesOwned.Contains(game.Id)).ToList();
    return gamesOwned;
  }


  // 7. Crie a funcionalidade de buscar todos os jogos junto do nome do estúdio desenvolvedor
  public List<GameWithStudio> GetGamesWithStudio()
  {
    var gamesWithStudiosList = from Game in Games
                               join gameStudio in GameStudios
                               on Game.DeveloperStudio equals gameStudio.Id
                               select new GameWithStudio
                               {
                                 GameName = Game.Name,
                                 StudioName = gameStudio.Name,
                                 NumberOfPlayers = Game.Players.Count
                               };

    return gamesWithStudiosList.ToList();

  }

  // 8. Crie a funcionalidade de buscar todos os diferentes Tipos de jogos dentre os jogos cadastrados
  public List<GameType> GetGameTypes()
  {
    // Implementar
    throw new NotImplementedException();
  }

  // 9. Crie a funcionalidade de buscar todos os estúdios de jogos junto dos seus jogos desenvolvidos com suas pessoas jogadoras
  public List<StudioGamesPlayers> GetStudiosWithGamesAndPlayers()
  {
    // Implementar
    throw new NotImplementedException();
  }

}
