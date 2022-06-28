using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TVP_projekat1.Models
{
    [Serializable()]
    internal class Room
    {
        public int Room_Id { get; set; }

        public string Room_Number { get; set; }

        public string Room_Beds { get; set; }

        public string Room_Type { get; set; }

        public string Room_Price { get; set; }

        public string Room_Price_Off { get; set; }

        public string Room_Min_Days { get; set; }

        public override string ToString()
        {
            return
                " ID: "+Room_Id + Environment.NewLine+
                " Broj sobe:" + Room_Number+ Environment.NewLine+
                " Broj kreveta: " + Room_Beds + Environment.NewLine+
                " Tip: " + Room_Type + Environment.NewLine+
                " Cena: " + Room_Price+ Environment.NewLine +
                " Popust: " + Room_Price_Off+"%" + Environment.NewLine+
                " Minimalno dana: " + Room_Min_Days;
        }
    }
}
