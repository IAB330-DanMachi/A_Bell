using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace A_Bell
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public string Occupation { get; set; }

    }
}
