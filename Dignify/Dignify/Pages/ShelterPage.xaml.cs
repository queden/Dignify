using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dignify.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShelterPage : ContentPage
    {
        public ShelterPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            LoadCharities();
            base.OnAppearing();
        }
        public void LoadCharities()
        {
            var charities = Helpers.HSPHelpers.GetByCategory(Models.Service.Beds);

            this.BindingContext = charities;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QRPage());
        }
    }
}