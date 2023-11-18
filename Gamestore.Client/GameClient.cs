using Gamestore.Client.Models;

namespace Gamestore.Client;

public static class GameClient
{
     private static readonly List<Game> games = new (){
        new Game(){
            Id = 1,
            Name ="Dragon Ball Budokai Tenkaichi 3",
            Genre ="Fighting",
            Price = 19.99m,
            ReleaseDate = new DateTime(1991,2,1)
        },
        new Game(){
            Id = 2,
            Name ="The Helders Skcrolls Skyrim",
            Genre ="Adventure",
            Price = 39.99m,
            ReleaseDate = new DateTime(2010,2,1)
        },
        new Game(){
            Id = 3,
            Name ="NBA 2K18",
            Genre ="Sports",
            Price = 59.99m,
            ReleaseDate = new DateTime(2017,2,1)
        }
    };

    public static Game[] GetGames(){
        return games.ToArray();
    }
}