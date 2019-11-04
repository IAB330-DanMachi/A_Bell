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
    public partial class Addunit : ContentPage
    {
        private SQLiteConnection connect;
        public Unit unit;
        public Addunit()
        {
            Title = "            Add a new unit List";
            InitializeComponent();
            connect = DependencyService.Get<connection>().GetConnection();
            connect.CreateTable<Unit>();
        }

        private async void AddunitClicked(object sender, EventArgs e)
        {
            unit = new Unit();
            unit.UnitCode = UnitCode.Text;
            unit.TeachingPeriod = TeachingPeriod.Text;
            unit.WorkShopTime = WorkShopTime.Text;
            unit.Campus = Campus.Text;
            unit.RoomNumber = RoomNumber.Text;
            connect.Insert(unit);
            UnitCode.Text = "";
            TeachingPeriod.Text = "";
            WorkShopTime.Text = "";
            Campus.Text = "";
            RoomNumber.Text = "";

            await DisplayAlert("Add unit message", "Add unit successful", "OK");
            await Navigation.PushAsync(new Unitlist());

        }




    }

}