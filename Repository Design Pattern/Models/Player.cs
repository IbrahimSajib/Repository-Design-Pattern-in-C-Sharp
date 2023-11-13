using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Design_Pattern.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int Age { get; set; }
        public Role_Type Role { get; set; }
        public string ClubName { get; set; }
    }
}