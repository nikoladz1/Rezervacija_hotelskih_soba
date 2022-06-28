using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TVP_projekat1.Models
{
    [Serializable()]
    public class User
    {
        public int User_Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
}
