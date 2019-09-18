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
    public partial class Studentprofile : ContentPage
    {
        public Studentprofile()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            submit.Text = "Teacher verification code: " + "\n";
            submit2.Text = "New IMEI number: " + "\n";
        }
    }
}