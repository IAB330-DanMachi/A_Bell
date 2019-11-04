using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace A_Bell
{
    public class Unit
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string UnitCode { get; set; }

        public string TeachingPeriod { get; set; }

        public string WorkShopTime { get; set; }

        public string Campus { get; set; }

        public string RoomNumber { get; set; }
    }
}
