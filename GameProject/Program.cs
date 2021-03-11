using System;
using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;
using GameProject.Adapter;
namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player1 = new()
            {
                DateOfBirth = new DateTime(1997, 7, 16),
                FirstName = "Veli",
                LastName = "",
                Id = 11,
                NationalityId = "",
                UserName = "velii"
            };
            Player player2 = new()
            {
                DateOfBirth = new DateTime(1990, 8, 13),
                FirstName = "Ali",
                LastName = "",
                Id = 12,
                NationalityId = "",
                UserName = "alii"
            };
            Game game1 = new()
            {
                Id = 21,
                Name = "Call Of Duty",
                Price = 149.99
            };
            Game game2 = new()
            {
                Id = 22,
                Name = "walheim",
                Price = 39.99
            };
            Campaign campaign1 = new()
            {
                Id = 33,
                Name = "50% Holiday discount",
                Amount = 50
            };
            Campaign campaign2 = new()
            {
                Id = 33,
                Name = "70% First login ",
                Amount = 70
            };

            BasePlayerManager basePlayerManager = new SteamPlayerManager(new MernisServiceAdapter());
            basePlayerManager.Add(player1);

            BasePlayerManager basePlayerManager2 = new EpicgamesPlayerManager();
            basePlayerManager2.Add(player2);
            
            basePlayerManager2.Delete(player2);
            basePlayerManager.Update(player1);

            BaseGameManager baseGame1 = new SteamGameManager();
            baseGame1.GameAdd(game1);
            baseGame1.GameAdd(game2);


            SalesManager sales1 = new();
            sales1.Sall(player1, game1, campaign2);

            SalesManager sales2 = new();
            sales2.Sall(player2, game1);

            SalesManager sales3 = new();
            sales3.Sall(player1, game2, campaign1);
        }
    }
}
