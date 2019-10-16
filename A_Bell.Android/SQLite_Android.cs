using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using A_Bell.Droid;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using Xamarin.Forms;

[assembly:Dependency(typeof(SQLite_Android))]
namespace A_Bell.Droid
{ 
    public class SQLite_Android : connection
    {
        public SQLiteConnection GetConnection()
        {
            var dbName = "myDatabase.sqlite";
            var dbPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            var path = Path.Combine(dbPath, dbName);
            var connect = new SQLiteConnection(path);
            return connect;
        }
    }
}