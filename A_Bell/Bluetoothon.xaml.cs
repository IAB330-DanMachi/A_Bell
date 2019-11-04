using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace A_Bell
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bluetoothon : ContentPage
    {
        private SQLiteConnection connect;
    
        public Bluetoothon()
        {
            InitializeComponent();
            connect = DependencyService.Get<connection>().GetConnection();
            connect.Table<User>();

            var data = (from users in connect.Table<User>() select users);
            studentList.ItemsSource = data;
        }

    }
}