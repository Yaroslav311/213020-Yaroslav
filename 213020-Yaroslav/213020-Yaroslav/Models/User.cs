using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _213020_Yaroslav.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public DateTime birthday { get; set; }
        public int PhoneNumber { get; set; }
        public byte[] Photo { get; set; }
    }
}
