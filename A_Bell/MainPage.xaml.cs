using A_Bell.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace A_Bell
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Xamarin.Forms.NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void SigninAccButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Unitlist());
        }
        

        private async void SignupLabel(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Signup());
        }

    }
}
