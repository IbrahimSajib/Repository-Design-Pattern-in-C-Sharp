using Repository_Design_Pattern.Models;
using Repository_Design_Pattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Design_Pattern
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("===================================================================================================");
            Console.WriteLine("Make Your Favourite Squad For Bangladesh national cricket team.\nBy using the typical CRUD (Create, Read, Update, and Delete) operations.");
            Console.WriteLine("===================================================================================================");
            Console.WriteLine("Let's Make It.....!");
            DisplayOption();

            Console.ReadKey();
        }


        public static void DisplayOption()
        {
            Console.WriteLine("1. Show All Player");
            Console.WriteLine("2. Insert Player");
            Console.WriteLine("3. Update Player");
            Console.WriteLine("4. Delete Player");

            var index = int.Parse(Console.ReadLine());
            Show(index);
        }


        public static void Show(int index)
        {
            PlayerRepository playerRepository = new PlayerRepository();
            //Index 1 for show all Player
            if (index == 1)
            {
                var playerList = playerRepository.GetAllPlayer();
                if (playerList.Count() == 0)
                {
                    Console.WriteLine("===============================");
                    Console.WriteLine("No player found in the list!!!");
                    Console.WriteLine("===============================");
                }
                else
                {
                    Console.WriteLine("=========================================== Player List ===========================================");
                    foreach (var item in playerRepository.GetAllPlayer())
                    {
                        Console.WriteLine($"Player Id : {item.PlayerId} | Name : {item.PlayerName} | Age : {item.Age} | Role : {item.Role} | Club : {item.ClubName}");

                    }
                    Console.WriteLine("=========================================== End of List ===========================================\n");
                    DisplayOption();
                }
            }

            //index 2 for insert new Player
            else if (index == 2)
            {
                Console.WriteLine("========================================= Add New Player ==========================================");
                Console.Write("Player Name : ");
                string name = Console.ReadLine();
                Console.Write("Player Age  : ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Player Role[1=Batter / 2=Wicket_Keeper / 3=All_Rounder / 4=Bowler] : ");
                Role_Type role = (Role_Type)int.Parse(Console.ReadLine());
                Console.Write("Club Name : ");
                string club = Console.ReadLine();

                int maxId = playerRepository.GetAllPlayer().Any() ? playerRepository.GetAllPlayer().Max(x => x.PlayerId) : 0;

                Player player = new Player
                {
                    PlayerId = maxId + 1,
                    PlayerName = name,
                    Age = age,
                    Role = role,
                    ClubName = club
                };
                playerRepository.Insert(player);
                Console.WriteLine("New Player data inserted successfully!!");
                Console.WriteLine("===================================================================================================\n");
                DisplayOption();
            }
            //index 3 for update Player info
            else if (index == 3)
            {
                Console.WriteLine("===================================================================================================");
                Console.Write("Enter PlayerId to Update   : ");
                int id = Convert.ToInt32(Console.ReadLine());
                var _player = playerRepository.SelectPlayer(id);
                if (_player == null)
                {
                    Console.WriteLine("==========================");
                    Console.WriteLine("Player id is invalid!!!");
                    Console.WriteLine("==========================");
                    return;
                }
                else
                {
                    
                    Console.WriteLine($"============ Update Info for PlayerId ~> {id} ===========");
                    Console.Write("Player Name : ");
                    string name = Console.ReadLine();
                    Console.Write("Player Age  : ");
                    int age = int.Parse(Console.ReadLine());
                    Console.Write("Player Role [1=Batter / 2=Wicket_Keeper / 3=All_Rounder / 4=Bowler] : ");
                    Role_Type role = (Role_Type)int.Parse(Console.ReadLine());
                    Console.Write("Club Name : ");
                    string club = Console.ReadLine();

                    Player player = new Player
                    {
                        PlayerId = id,
                        PlayerName = name,
                        Age = age,
                        Role= role,
                        ClubName = club
                    };
                    playerRepository.Update(player);
                    Console.WriteLine("Player data updated successfully!!");
                    Console.WriteLine("===================================================================================================\n");
                    DisplayOption();
                }
            }
            //index 4 for delete Player data
            else if (index == 4)
            {
                Console.WriteLine("=========================================== Remove Player ===========================================");
                Console.Write("Enter PlayerId to delete : ");

                int id = Convert.ToInt32(Console.ReadLine());
                var _player = playerRepository.SelectPlayer(id);

                if (_player == null)
                {
                    Console.WriteLine("==========================");
                    Console.WriteLine("Player id is invalid!!!");
                    Console.WriteLine("==========================");
                    return;
                }
                else
                {
                    playerRepository.Delete(id);
                    Console.WriteLine("Player data deleted successfully!!!");
                    Console.WriteLine("=====================================================================================================\n");
                    DisplayOption();
                }
            }

        }
    }
}
