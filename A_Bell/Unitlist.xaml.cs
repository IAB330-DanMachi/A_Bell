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

        async void AddUnitClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Addunit());
        }
       
    }
}