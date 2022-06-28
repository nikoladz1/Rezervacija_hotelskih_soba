using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TVP_projekat1.Models
{   [Serializable()]
    internal class Guest
    {
        public int Guest_Id { get; set; }
        public string Guest_Name { get; set; }
        public string Guest_Surname { get; set; }
        public string Guest_Birthday { get; set; }
        public string Guest_Phone { get; set; }

        public override string ToString()
        {
            return " ID: " + Guest_Id + Environment.NewLine +
                " Ime: " + Guest_Name + Environment.NewLine +
                " Prezime " + Guest_Surname + Environment.NewLine +
                " Rodjendan " + Guest_Birthday + Environment.NewLine +
                " Telefon: " + Guest_Phone + Environment.NewLine;
        }
    }
}
