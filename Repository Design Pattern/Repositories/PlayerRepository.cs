using Repository_Design_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Design_Pattern.Repositories
{
    public class PlayerRepository : IRepository<int>
    {
        public Player SelectPlayer(int data)
        {
            Player player = PlayerDB.PlayerList.FirstOrDefault(x => x.PlayerId == data);
            return player;
        }
        
        public void Insert(Player player)
        {
            PlayerDB.PlayerList.Add(player);
        }

        public void Update(Player player)
        {
            Player _player = PlayerDB.PlayerList.FirstOrDefault(x => x.PlayerId == player.PlayerId);
            if (player.PlayerName != null)
            {
                _player.PlayerName = player.PlayerName;
            }
            if (player.Age != 0)
            {
                _player.Age = player.Age;
            }
            if(player.Role != 0)
            {
                _player.Role = player.Role;
            }
            if(player.ClubName != null)
            {
                _player.ClubName = player.ClubName;
            }
        }

        public void Delete(int data)
        {
            Player player = PlayerDB.PlayerList.FirstOrDefault(x => x.PlayerId == data);
            PlayerDB.PlayerList.Remove(player);
        }

        public IEnumerable<Player> GetAllPlayer()
        {
            return PlayerDB.PlayerList;
        }

    }
}
