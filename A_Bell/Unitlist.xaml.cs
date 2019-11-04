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
    public partial class Unitlist : ContentPage
    {

        private SQLiteConnection connect;
        private ListView unitlist;

        public Unitlist()
        {
            connect = DependencyService.Get<connection>().GetConnection();
            connect.Table<Unit>();
            Title = "                   Unit List";
            InitializeComponent();

            var data = (from units in connect.Table<Unit>() select units);
            detailList.ItemsSource = data;


        }


        async void AddUnitClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Addunit());
        }
       
    }
}