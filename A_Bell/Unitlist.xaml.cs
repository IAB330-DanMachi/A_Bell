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
    public partial class Unitlist : ContentPage
    {
        public Unitlist()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {

            submit.Text = "Unit Code: " + "\n" +
                         "Unit Name: " + "\n" +
                         "Campus: " + "\n" +
                         "Time: " + "\n" +
                         "Room: " + "\n";
        }
    }
}