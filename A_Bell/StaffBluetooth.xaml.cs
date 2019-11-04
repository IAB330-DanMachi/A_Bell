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
    public partial class StaffBluetooth : ContentPage
    {
        private SQLiteConnection connect;
        public User user;
        public StaffBluetooth()
        {
            connect = DependencyService.Get<connection>().GetConnection();
            connect.Table<User>();
            InitializeComponent();
            var data = (from users in connect.Table<User>() select users);
            studentList.ItemsSource = data;
        }
    }
}