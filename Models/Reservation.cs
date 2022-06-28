using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TVP_projekat1.Models
{
    [Serializable]
    internal class Reservation
    {
        public int Res_Id { get; set; }
        public int Room_Id { get; set; }
        public int Guest_Id { get; set; }
        public string Res_Start { get; set; }
        public string Res_End { get; set; }
        public string Res_Total_Price { get; set; }
        public string Res_Type { get; set; }


    }
}
