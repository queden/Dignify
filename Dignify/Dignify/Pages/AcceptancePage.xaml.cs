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
    public partial class AcceptancePage : ContentPage
    {
        public AcceptancePage()
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
            var charities = Helpers.HSPHelpers.GetByCategory(Models.Service.MentalHealth);

            this.BindingContext = charities;
        }
    }
}