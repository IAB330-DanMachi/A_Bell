using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace A_Bell
{
    public interface connection
    {
        SQLiteConnection GetConnection();
    }
}
