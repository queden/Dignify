using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Dignify
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Bed_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.ShelterPage());
        }

        private async void ER_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.EmergencyPage());
        }

        private async void Map_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.MapPage());
        }
        private async void AR_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.ResourcesPage());
        }
        private async void Food_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.FoodPage());
        }
        private async void Acceptance_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.AcceptancePage());
        }
        private void Healthcare_Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("CDC PSA", "Free Flu Shots, 12 minutes away (0.3 mi)", "Route me", "Ignore");
        }
    }
}
