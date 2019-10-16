using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace A_Bell.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Signup : ContentPage
    {
        private SQLiteConnection connect;
        public User user;
        public Signup()
        {
            InitializeComponent();
            connect = DependencyService.Get<connection>().GetConnection();
            connect.CreateTable<User>();
        }

        private void CreateAccButton_Clicked(object sender, EventArgs e)
        {
            user = new User();
            user.Number = Number.Text;
            user.Email = Email.Text;
            user.Occupation = Occupation.Text;
            user.Password = Password.Text;
            connect.Insert(user);
            Number.Text = "";
            Email.Text = "";
            Occupation.Text = "";
            Password.Text = "";
        }

        private void ShowAccButton_Clicked(object sender, EventArgs e)
        {
            var data = (from users in connect.Table<User>() select users);
            Datalist.ItemsSource = data;
        }
    }
}