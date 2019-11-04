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
            Xamarin.Forms.NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void CreateAccButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Number.Text) || (string.IsNullOrEmpty(Number.Text)))
            {
                await DisplayAlert("Enter Data", "Number is a required field!", "OK");
            }

            else if (string.IsNullOrWhiteSpace(Email.Text) || (string.IsNullOrEmpty(Email.Text)))
            {
                await DisplayAlert("Enter Data", "Email is a required field!", "OK");

            }

            else if (string.IsNullOrWhiteSpace(Occupation.Text) || (string.IsNullOrEmpty(Occupation.Text)))
            {
                await DisplayAlert("Enter Data", "Occupation is a required field!", "OK");
            }

            else if (string.IsNullOrWhiteSpace(Password.Text) || (string.IsNullOrEmpty(Password.Text)))
            {
                await DisplayAlert("Enter Data", "Password is a required field!", "OK");
            }

            else if (!string.Equals(Password.Text, ConfirmPassword.Text))
            {

                warningLabel.Text = "Enter Same Password";
                Password.Text = string.Empty;
                ConfirmPassword.Text = string.Empty;
                warningLabel.TextColor = Color.IndianRed;
                warningLabel.IsVisible = true;
            }

            if (Occupation.Text == "Staff" || Occupation.Text == "Student")
            {

            }
            else if (Occupation.Text != "Staff" || Occupation.Text != "Student")
            {
                await DisplayAlert("Enter Data", "Please entry value detail: Student / Staff", "OK");
            }

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

            DisplayAlert("Registration message", "Rigistration successful", "OK");
            await Navigation.PushAsync(new MainPage());

        }

        private void ShowAccButton_Clicked(object sender, EventArgs e)
        {
            var data = (from users in connect.Table<User>() select users);
            Datalist.ItemsSource = data;
        }

        private async void SigninLabel(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
       
    }
}