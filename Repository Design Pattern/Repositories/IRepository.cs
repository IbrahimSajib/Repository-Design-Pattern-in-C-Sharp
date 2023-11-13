using Repository_Design_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Design_Pattern.Repositories
{
    public interface IRepository<T>
    {
        Player SelectPlayer(T data);
        void Insert(Player player);
        void Update(Player player);
        void Delete(T data);
        IEnumerable<Player> GetAllPlayer();
    }
}
