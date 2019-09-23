
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace A_Bell
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StaffProfile : ContentPage
    {
        public StaffProfile()
        {
            InitializeComponent();
            lblClickFucn();
        }
        void lblClickFucn() {
            lblClick.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(()=> {
                    DisplayAlert("Verfication code","XXX XXX","OK");
                })
            });
        }
    }
}