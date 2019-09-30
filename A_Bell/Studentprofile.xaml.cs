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
    public partial class StudentProfile : ContentPage
    {
        public StudentProfile()
        {
            InitializeComponent();
            lblClickFucn();
        }
        void lblClickFucn()
        {
            lblClick.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() => {
                    DisplayAlert("Please Enter Verfication code", "__ __ __  __ __ __", "OK");
                })
            });
        }
    }
}